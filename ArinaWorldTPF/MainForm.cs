using ArinaWorld;
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
            Province p1 = new Province();
            p1.Name = "è»1";
            puc1.Province = p1;

            Province p2 = new Province();
            p2.Name = "è»2";
            p2.ID = "aaa";
        }

        private void tsmRun1_Click(object sender, EventArgs e)
        {

        }

        private void puc1_Load(object sender, EventArgs e)
        {

        }

        private void tsmLoadData_Click(object sender, EventArgs e)
        {

        }
    }
}