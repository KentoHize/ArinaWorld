using ArinaWorld;
using System.Security.Cryptography.X509Certificates;

namespace ArinaWorldTPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Province p1 = new Province();
            p1.Name = "��1";
            puc1.Province = p1;

            Province p2 = new Province();
            p2.Name = "��2";
            p2.ID = "aaa";
        }

        private void tsmRun1_Click(object sender, EventArgs e)
        {

        }
    }
}