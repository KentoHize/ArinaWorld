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
using System.Text.RegularExpressions;

namespace ArinaWorldTPF
{
    public partial class NewMapForm : Form
    {
        public string MapName { get; set; }
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }

        public NewMapForm()
        {
            InitializeComponent();
            PatchLanguageText();
            txtWidth.Text = Setting.DefaultMapWidth.ToString();
            txtHeight.Text = Setting.DefaultMapHeight.ToString();
            txtWidth_TextChanged(txtWidth, EventArgs.Empty);
            txtHeight_TextChanged(txtHeight, EventArgs.Empty);
            txtMapName_TextChanged(txtMapName, EventArgs.Empty);

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
            txtMapName.Text = RabbitCouriers.GetMessage("AWE_TXT_DEFAULT_MAP_NAME");
        }

        private void RefreshControlState()
        {
            btnOK.Enabled = !(errWidth.HasErrors || errHeight.HasErrors || errMapName.HasErrors);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (errWidth.HasErrors)
                return;
            MapName = txtMapName.Text;
            MapHeight = int.Parse(txtHeight.Text);
            MapWidth = int.Parse(txtWidth.Text);
            Setting.DefaultMapHeight = MapHeight;
            Setting.DefaultMapWidth = MapWidth;
            DialogResult = DialogResult.OK;
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtWidth.Text, out int i))
            {
                if (i < Const.MinimumMapWidth)
                    errWidth.SetError(txtWidth, RabbitCouriers.GetMessage("AWE_VAL_MAP_WIDTH_LESS_THEN_MINIMUM", Const.MinimumMapWidth));
                else if (i > Const.MaximumMapWidth)
                    errWidth.SetError(txtWidth, RabbitCouriers.GetMessage("AWE_VAL_MAP_WIDTH_GREATER_THEN_MAXIMUM", Const.MaximumMapWidth));
                else
                    errWidth.Clear();
            }
            else
                errWidth.SetError(txtWidth, RabbitCouriers.GetMessage("AWE_VAL_NOT_AN_INTEGER"));
            RefreshControlState();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtHeight.Text, out int i))
            {
                if (i < Const.MinimumMapHeight)
                    errHeight.SetError(txtHeight, RabbitCouriers.GetMessage("AWE_VAL_MAP_HEIGHT_LESS_THEN_MINIMUM", Const.MinimumMapHeight));
                else if (i > Const.MaximumMapHeight)
                    errHeight.SetError(txtHeight, RabbitCouriers.GetMessage("AWE_VAL_MAP_HEIGHT_GREATER_THEN_MAXIMUM", Const.MaximumMapHeight));
                else
                    errHeight.Clear();
            }
            else
                errHeight.SetError(txtHeight, RabbitCouriers.GetMessage("AWE_VAL_NOT_AN_INTEGER"));
            RefreshControlState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtMapName_TextChanged(object sender, EventArgs e)
        {
            if (txtMapName.Text == "")
                errMapName.SetError(txtMapName, RabbitCouriers.GetMessage("AWE_VAL_IS_EMPTY"));
            else
                errMapName.Clear();
            //超過多少字
            RefreshControlState();
        }
    }
}
