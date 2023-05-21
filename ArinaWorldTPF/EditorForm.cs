using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritiafel.Locations;
using Aritiafel.Organizations.ArinaOrganization;
using ArinaWorld;
using Aritiafel.Organizations;
using System.Security.Policy;

namespace ArinaWorldTPF
{
    public partial class EditorForm : Form
    {
        private int childFormNumber = 0;

        public EditorForm()
        {
            InitializeComponent();
        }

        public void PatchLanguageText()
        {
            RabbitCouriers.RegisterLaguageFolderAndCI(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language"), Setting.CultureInfo);
            tmiHelp.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_HELP")}(&H)";
            tmiAbout.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_ABOUT_AWE")}(&A)";
            tmiTool.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_TOOL")}(&T)";
            tmiEN_US.Text = RabbitCouriers.GetMessage("AWE_TMI_EN_US");
            tmiZH_TW.Text = RabbitCouriers.GetMessage("AWE_TMI_ZH_TW");
            tmiFile.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_FILE")}(&F)";
            tmiTest.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_TEST")}(&R)";
            tmiQuit.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_QUIT")}(&X)";
            tmiNewMap.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_NEW_MAP")}(&N)";
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            SettingShop.LoadIniFile(typeof(Setting));
            Text = $"Arina World Editor - {Const.VersionString}";
            //Temp
            Geography.LoadRelatedData();

            //讀取語言檔            
            PatchLanguageText();
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingShop.SaveIniFile(typeof(Setting));
        }

        private void tmiAbout_Click(object sender, EventArgs e)
        {
            RabbitCouriers.SentInformation($"Arina World Editor, {Const.VersionString}\n\n" +
                $"{Const.AuthorString}\n\n" + $"Email:{Const.AuthorEmail}");
        }

        private void tmiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiZH_TW_Click(object sender, EventArgs e)
        {
            Setting.CultureInfo = new System.Globalization.CultureInfo("zh-TW");
            PatchLanguageText();
        }

        private void tmiEN_US_Click(object sender, EventArgs e)
        {
            Setting.CultureInfo = new System.Globalization.CultureInfo("en-US");
            PatchLanguageText();
        }

        private void tmiProducePangea_Click(object sender, EventArgs e)
        {
            Var.Map = new Map();
            Var.Map.Height = 200;
            Var.Map.Width = 200;
            Setting.AmplificationFactor = 50;
            Geography.ProducePangeaGeography(Var.Map, 100, 100, 1,
                CompassDirection.North, 2, 28, TwoWayCompassDirection.EastWest, 1000);
            if (ActiveMdiChild != null)
                ActiveMdiChild.Invalidate();
        }

        private void tmiNewMap_Click(object sender, EventArgs e)
        {
            //new NewMapForm();

            if (Var.MapForm != null)
                return;
            Var.MapForm = new MapForm();
            Var.MapForm.MdiParent = this;
            Var.MapForm.WindowState = FormWindowState.Maximized;
            Var.SelectedBlock = new Point(0, 0);
            Var.MapForm.Show();
        }
    }
}
