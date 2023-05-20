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


namespace ArinaWorldTPF
{
    public partial class EditorForm : Form
    {
        private int childFormNumber = 0;

        public EditorForm()
        {
            InitializeComponent();
        }
        private void EditorForm_Load(object sender, EventArgs e)
        {
            SettingShop.LoadIniFile(typeof(Setting));

            //Temp
            Geography.LoadRelatedData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Var.MapForm != null)
                return;
            Var.MapForm = new MapForm();
            Var.MapForm.MdiParent = this;
            Var.MapForm.WindowState = FormWindowState.Maximized;
            Var.SelectedBlock = new Point(0, 0);
            Var.MapForm.Show();

        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingShop.SaveIniFile(typeof(Setting));
        }
      
        private void tsmProducePangea_Click(object sender, EventArgs e)
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

        private void tmiAbout_Click(object sender, EventArgs e)
        {

        }

        private void tmiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
