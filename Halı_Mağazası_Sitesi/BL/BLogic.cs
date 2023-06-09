using Halı_Mağazası_Sitesi.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halı_Mağazası_Sitesi.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Müşterigetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Müşterigetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool MüşteriSil(string id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        public static bool UrunEkle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Urungetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Urungetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunGüncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }


        internal static bool SatisEkle(Satis s)
        {
            try
            {
                int res = DataLayer.SatisEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                DataSet ds = DataLayer.SatisDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool SatisGüncelle(Satis s)
        {
            try
            {
                int res = DataLayer.SatisGüncelle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SatisSil(string id)
        {
            try
            {
                int res = DataLayer.SatisSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeEkle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeEkle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool OdemeGüncelle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeGüncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = DataLayer.OdemeSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
