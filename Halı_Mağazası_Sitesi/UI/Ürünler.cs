using Halı_Mağazası_Sitesi.BL;
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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            frmUrun frm = new frmUrun()
            {
                Text = "Ürün Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };
        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Urun);
                if (b)
                {
                    DataSet ds = BLogic.Urungetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
                else
                    goto tekrar;


            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            frmUrun frm = new frmUrun()
            {
                Text = "Ürün Güncelle",
                Güncelleme = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    Stok = double.Parse(row.Cells[4].Value.ToString()),
                    Birim = row.Cells[5].Value.ToString(),
                    Detay = row.Cells[6].Value.ToString(),
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGüncelle(frm.Urun);
                if (b)
                {
                    row.Cells[1].Value = frm.Urun.Ad;
                    row.Cells[2].Value = frm.Urun.Kategori;
                    row.Cells[3].Value = frm.Urun.Fiyat;
                    row.Cells[4].Value = frm.Urun.Stok;
                    row.Cells[5].Value = frm.Urun.Birim;
                    row.Cells[5].Value = frm.Urun.Detay;

                }


            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();



            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.Urungetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }


            }
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.Urungetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }
      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

      
        public Urun Urun { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Urun = new Urun()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Kategori = row.Cells[2].Value.ToString(),
                Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                Stok = double.Parse(row.Cells[4].Value.ToString()),
                Birim = row.Cells[5].Value.ToString(),
                Detay = row.Cells[6].Value.ToString(),
            };
            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.Urungetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

        }
    }
}
