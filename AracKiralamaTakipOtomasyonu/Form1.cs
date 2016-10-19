using AdoNetHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = @"Server={*};Database=AracKiralamaOtoDB;User Id={*}; Password={*}";

        private void musMusteri_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void musArac_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void musCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void GetAracListesi()
        {
            Database db = new Database(baglantiCumlesi);
            DataTable sonucTablo1 = db.GetTable("select * from Araclar", null);
            foreach (DataRow row in sonucTablo1.Rows)
            {
                Araclar arac = new Araclar();
                arac.Id = (int)row["Id"];
                arac.Marka = row["Marka"].ToString();
                arac.Model = row["Model"].ToString();
                arac.Plaka = row["Plaka"].ToString();
                arac.Gunluk = (int)row["Gunluk"];
                arac.Haftalik = (int)row["Haftalik"];
                arac.Aylik = (int)row["Aylik"];
                cmbArabalar.Items.Add(arac);
            }
        }
        private void GetMusteriListesi()
        {
            Database db = new Database(baglantiCumlesi);

            DataTable sonucTablo = db.GetTable("select * from Musteriler", null);
            foreach (DataRow row in sonucTablo.Rows)
            {
                Musteriler musteri = new Musteriler();

                musteri.Id = (int)row["Id"];
                musteri.TcNo = row["TcNo"].ToString();
                musteri.Ad = row["Ad"].ToString();
                musteri.Soyad = row["Soyad"].ToString();
                musteri.EPosta = row["EPosta"].ToString();
                musteri.Telefon = row["Telefon"].ToString();
                musteri.Adres = row["Adres"].ToString();

                cmbMusteriler.Items.Add(musteri);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAracListesi();
            GetMusteriListesi();

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (cmbArabalar.SelectedIndex > -1 && cmbMusteriler.SelectedIndex > -1)
            {

                Database db = new Database(baglantiCumlesi);
                string q = "insert into MusteriAracKiralama(BaslamaTarihi,BitisTarihi,MusteriId,KiralamaSekli,ToplamGun,ToplamFiyat,AracId) values(@BaslamaTarihi,@BitisTarihi,@MusteriId,@KiralamaSekli,@ToplamGun,@ToplamFiyat,@AracId)";
                List<SqlParameter> par = new List<SqlParameter>();

                Musteriler seciliMusteri = cmbMusteriler.SelectedItem as Musteriler;
                Araclar seciliArac = cmbArabalar.SelectedItem as Araclar;

                DateTime baslangic = dtpBaslamaTarihi.Value;
                DateTime bitis = dtpBitisTarihi.Value;
                TimeSpan sonuc = bitis - baslangic;
                lblGunSayisi.Text = sonuc.Days.ToString();
                int days = (int)sonuc.Days;

                par.Add(new SqlParameter("@BaslamaTarihi", dtpBaslamaTarihi.Value));
                par.Add(new SqlParameter("@BitisTarihi", dtpBitisTarihi.Value));
                par.Add(new SqlParameter("@MusteriId", seciliMusteri.Id));

                if (rdbGunluk.Checked)
                {
                    int gunluk = seciliArac.Gunluk;
                    int fiyat = gunluk * days;
                    lblToplamFiyat.Text = fiyat.ToString();
                    par.Add(new SqlParameter("@KiralamaSekli", rdbGunluk.Text));
                    par.Add(new SqlParameter("@ToplamGun", days));
                    par.Add(new SqlParameter("@ToplamFiyat", fiyat));
                }
                else if (rdbHaftalik.Checked)
                {
                    lblToplamFiyat.Text = seciliArac.Haftalik.ToString();
                    par.Add(new SqlParameter("@KiralamaSekli", rdbHaftalik.Text));
                    par.Add(new SqlParameter("@ToplamGun", days));
                    par.Add(new SqlParameter("@ToplamFiyat", seciliArac.Haftalik));
                }
                else
                {
                    lblToplamFiyat.Text = seciliArac.Aylik.ToString();
                    par.Add(new SqlParameter("@KiralamaSekli", rdbAylik.Text));
                    par.Add(new SqlParameter("@ToplamGun", days));
                    par.Add(new SqlParameter("@ToplamFiyat", seciliArac.Aylik));
                }
                par.Add(new SqlParameter("@AracId", seciliArac.Id));

                db.RunQuery(q, par);

               
            }
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedIndex > -1)
            {
                Musteriler seciliMusteri = cmbMusteriler.SelectedItem as Musteriler;
                Database db = new Database(baglantiCumlesi);

                List<SqlParameter> par = new List<SqlParameter>();
                par.Add(new SqlParameter("@MusteriId", seciliMusteri.Id));
                DataTable sonucTablo = db.GetTable
                    ("select MusteriAracKiralama.Id, Araclar.Marka, Araclar.Model from MusteriAracKiralama,Araclar where MusteriAracKiralama.AracId=Araclar.Id and MusteriAracKiralama.MusteriId=@MusteriId", par);

                dgwMusteriAraclari.DataSource = sonucTablo;
                dgwMusteriAraclari.Columns[0].Visible = false;

            }
        }

        

        private void dgwMusteriAraclari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            Database db = new Database(baglantiCumlesi);
            List<SqlParameter> par = new List<SqlParameter>();
            int index = dgwMusteriAraclari.CurrentRow.Index;
            int seciliArac = (int)dgwMusteriAraclari.Rows[index].Cells[0].Value;
            par.Add(new SqlParameter("@Id", seciliArac));
            DataTable sonucTablo = db.GetTable("select MusteriAracKiralama.BaslamaTarihi,MusteriAracKiralama.BitisTarihi,MusteriAracKiralama.KiralamaSekli,MusteriAracKiralama.ToplamFiyat,MusteriAracKiralama.ToplamGun from MusteriAracKiralama, Araclar where MusteriAracKiralama.AracId=Araclar.Id and MusteriAracKiralama.Id=@Id", par);

            foreach (DataRow item in sonucTablo.Rows)
            {
                dtpBaslamaTarihi.Value = (DateTime)item["BaslamaTarihi"];
                dtpBitisTarihi.Value = (DateTime)item["BitisTarihi"];
                lblGunSayisi.Text = item["ToplamGun"].ToString();
                lblToplamFiyat.Text = item["ToplamFiyat"].ToString();
                string metin = item["KiralamaSekli"].ToString();
                if (metin == "Günlük")
                {
                    rdbGunluk.Checked = true;
                }
                else if (metin == "Haftalık")
                {
                    rdbHaftalik.Checked = true;
                }
                else
                {
                    rdbAylik.Checked = true;
                }

            }
        }

        private void btnMusteriAraclariSil_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "delete from MusteriAracKiralama where Id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();

            int index = dgwMusteriAraclari.CurrentRow.Index;
            int seciliArac = (int)dgwMusteriAraclari.Rows[index].Cells[0].Value;
            par.Add(new SqlParameter("@Id", seciliArac));
            db.RunQuery(q, par);
            
        }

        private void cmbArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



