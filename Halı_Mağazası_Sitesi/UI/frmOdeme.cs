using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Mağazası_Sitesi.UI
{
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }
        
        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen tutar giriniz!");
                nmTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");

            }

            if (cbTur.SelectedItem == null)
            {
                errorProvider1.SetError(cbTur, "Ödeme türü seçiniz");
                cbTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbTur, "");
            }

            if (txtAçıklama.Text == "")
            {
                errorProvider1.SetError(txtAçıklama, "Eksik veya Hatalı bilgi");
                txtAçıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAçıklama, "");
            }

            Odeme.MusteriID = Guid.Parse(txtMusteri.Text);
            Odeme.Tur = cbTur.SelectedItem.ToString();
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Açıklama = txtAçıklama.Text;
            Odeme.Tarih = dtTarih.Value;
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Odeme.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Odeme.MusteriID.ToString();
                nmTutar.Value = (decimal)Odeme.Tutar;
                dtTarih.Value = Odeme.Tarih;
                cbTur.SelectedItem = Odeme.Tur;
                txtAçıklama.Text = Odeme.Açıklama.ToString();

            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();

            }
        }
    }
}
