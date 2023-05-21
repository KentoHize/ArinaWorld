using Aritiafel.Organizations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArinaWorldTPF
{
    public partial class NewMapForm : Form
    {
        public NewMapForm()
        {
            InitializeComponent();


        }

        public void PatchLanguageText()
        {
            RabbitCouriers.RegisterLaguageFolderAndCI(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Language"), Setting.CultureInfo);
            Text = RabbitCouriers.GetMessage("AWE_TMI_NEW_MAP");

            //tmiHelp.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_HELP")}(&H)";
        }
    }
}
