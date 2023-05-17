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
            MapForm mp = new MapForm();
            mp.MdiParent = this;
            mp.WindowState = FormWindowState.Maximized;
            mp.Show();
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingShop.SaveIniFile(typeof(Setting));
        }

        private void tsmQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmProducePangea_Click(object sender, EventArgs e)
        {
            Var.Map = new Map();
            Var.Map.Height = 500;
            Var.Map.Width = 300;
            Setting.AmplificationFactor = 2;
            Geography.ProducePangeaGeography(Var.Map, 450, 250, 1, 
                CompassDirection.North, 2, 28, TwoWayCompassDirection.EastWest, 20);
            Invalidate();
        }
    }
}
