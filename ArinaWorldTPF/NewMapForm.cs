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
            lblWidth.Text = RabbitCouriers.GetMessage("AWE_LBL_WIDTH");
            lblHeight.Text = RabbitCouriers.GetMessage("AWE_LBL_HEIGHT");
            lblMapName.Text = RabbitCouriers.GetMessage("AWE_LBL_MAP_NAME");
            btnOK.Text = RabbitCouriers.GetMessage("AWE_BTN_OK");
            btnCancel.Text = RabbitCouriers.GetMessage("AWE_BTN_CANCEL");
            //tmiHelp.Text = $"{RabbitCouriers.GetMessage("AWE_TMI_HELP")}(&H)";
        }
    }
}
