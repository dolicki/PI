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
        private int odabir;
        public PočetnoSučelje()
        {
            InitializeComponent();
        }

        private void Skladišta_Click(object sender, EventArgs e)
        {
            UpravljanjeSkladistima fromaSkladista = new UpravljanjeSkladistima();
            fromaSkladista.ShowDialog();
        }

        private void kupci_Click(object sender, EventArgs e)
        {
            UpravljanjeKupcima formaKupci = new UpravljanjeKupcima();
            formaKupci.ShowDialog();
        }

        private void artikli_Click(object sender, EventArgs e)
        {
            odabir = 0;
        }

        private void medjuskladisnice_Click(object sender, EventArgs e)
        {
            odabir = 4;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (odabir == 4)
            {
                Meduskladisnica formaMeduskladisnica = new Meduskladisnica();
                formaMeduskladisnica.ShowDialog();
            }
        }

        private void otpremnice_Click(object sender, EventArgs e)
        {
            s formaOtpremnica = new s();
            formaOtpremnica.ShowDialog();
        }
    }
}
