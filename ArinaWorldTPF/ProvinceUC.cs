using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArinaWorld;

namespace ArinaWorldTPF
{
    public partial class ProvinceUC : UserControl
    {
        private Province _Province;
        public Province Province {
            get => _Province;
            set
            {
                _Province = value;
                lblName.Text = _Province.Name;
            }
        }
        public ProvinceUC()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {          
            base.OnCreateControl();
        }
    }
}
