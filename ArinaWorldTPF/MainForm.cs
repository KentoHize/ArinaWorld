using ArinaWorld;
using System.Text.Json;

namespace ArinaWorldTPF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmLoadData_Click(object sender, EventArgs e)
        {
            string buffer;

            //æ¤Map
            using (FileStream fs = new FileStream(Path.Combine(Const.GameDataPath, "Map.json"), FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    buffer = sr.ReadToEnd();
                    Var.Map = JsonSerializer.Deserialize<Map[]>(buffer)[0];
                }
            }


            //æ¤Province
            using (FileStream fs = new FileStream(Path.Combine(Const.GameDataPath, "Provinces.json"), FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    buffer = sr.ReadToEnd();
                    Var.Map.Provinces.AddRange(JsonSerializer.Deserialize<Province[]>(buffer));
                }
            }

            RefreshAreaMap();
        }

        public void RefreshAreaMap()
        {
            ProvinceUC puc;
            //pnlAreaMap.Height = (int)Var.Map.Height;
            pnlAreaMap.Width = (int)Var.Map.Width + 100;
            pnlAreaMap.Controls.Clear();

            for (int i = 0; i < Var.Map.Provinces.Count; i++)
            {
                puc = new ProvinceUC();
                puc.Province = Var.Map.Provinces[i];
                puc.Top = (int)Var.Map.Height - (int)puc.Province.Y;
                puc.Left = (int)puc.Province.X;
                pnlAreaMap.Controls.Add(puc);
            }
        }

    }
}