using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class PočetnoSučelje : Form
    {
        public PočetnoSučelje()
        {
            InitializeComponent();
        }

        private void Skladišta_Click(object sender, EventArgs e)
        {
            UpravljanjeSkladistima fromaSkladista = new UpravljanjeSkladistima();
            fromaSkladista.ShowDialog();
        }

        private void otpremnice_Click(object sender, EventArgs e)
        {
            Otpremnica formaOtpremnica = new Otpremnica();
            formaOtpremnica.ShowDialog();
        }

        private void PočetnoSučelje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
