using ArinaWorld;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ArinaWorldTPF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Province p1 = new Province();
            //p1.Name = "��1";
            //puc1.Province = p1;

            //Province p2 = new Province();
            //p2.Name = "��2";
            //p2.ID = "aaa";
        }

        private void tsmRun1_Click(object sender, EventArgs e)
        {

        }

        private void puc1_Load(object sender, EventArgs e)
        {

        }

        private void tsmLoadData_Click(object sender, EventArgs e)
        {
            string buffer;

            //�Map
            using (FileStream fs = new FileStream(Path.Combine(Const.GameDataPath, "Map.json"), FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    buffer = sr.ReadToEnd();
                    Var.Map = JsonSerializer.Deserialize<Map[]>(buffer)[0];
                }
            }

            //�Province
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