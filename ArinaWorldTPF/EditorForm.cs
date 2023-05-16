﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritiafel.Locations;


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
    }
}
