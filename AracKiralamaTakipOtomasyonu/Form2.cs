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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = @"Server=HAKAN\HAKAN;Database=AracKiralamaOtoDB;User Id=sa; Password=2005203036";
        private void GetDataAraclar()
        {
            Database db = new Database(baglantiCumlesi);

            DataTable sonucTablo = db.GetTable("select * from Araclar", null);
            dgwAraclar.DataSource = sonucTablo;
            dgwAraclar.Columns[0].Visible = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "insert into Araclar(Marka, Model, Plaka, Gunluk, Haftalik, Aylik) values(@Marka,@Model,@Plaka,@Gunluk,@Haftalik,@Aylik)";
            List<SqlParameter> par = new List<SqlParameter>();
           

            par.Add(new SqlParameter("@Marka", txtMarka.Text));
            par.Add(new SqlParameter("@Model", txtModel.Text));
            par.Add(new SqlParameter("@Plaka", txtPlaka.Text.Trim().ToUpper()));
            par.Add(new SqlParameter("@Gunluk", nudGunluk.Value));
            par.Add(new SqlParameter("@Haftalik", nudHaftalik.Value));
            par.Add(new SqlParameter("@Aylik", nudAylik.Value));

            db.RunQuery(q, par);
            GetDataAraclar();
            MessageBox.Show("Araç Kaydedildi...");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetDataAraclar();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "update Araclar set Marka=@Marka,Model=@Model,Plaka=@Plaka,Gunluk=@Gunluk,Haftalik=@Haftalik,Aylik=@Aylik where Id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();
            int index = dgwAraclar.CurrentRow.Index;
            int secliKisi = (int)dgwAraclar.Rows[index].Cells[0].Value;


            par.Add(new SqlParameter("@Id", secliKisi));
            par.Add(new SqlParameter("@Marka",txtMarka.Text));
            par.Add(new SqlParameter("@Model", txtModel.Text));
            par.Add(new SqlParameter("@Plaka", txtPlaka.Text));
            par.Add(new SqlParameter("@Gunluk", nudGunluk.Value));
            par.Add(new SqlParameter("@Haftalik", nudHaftalik.Value));
            par.Add(new SqlParameter("@Aylik", nudAylik.Value));
            db.RunQuery(q, par);
            GetDataAraclar();
        }

        private void dgwAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwAraclar.CurrentRow.Index > -1)
            {
                int index = dgwAraclar.CurrentRow.Index;
                int secliKisi = (int)dgwAraclar.Rows[index].Cells[0].Value;

                txtMarka.Text = dgwAraclar.Rows[index].Cells[1].Value.ToString();
                txtModel.Text = dgwAraclar.Rows[index].Cells[2].Value.ToString();
                txtPlaka.Text = dgwAraclar.Rows[index].Cells[3].Value.ToString();
                nudGunluk.Value = (int)dgwAraclar.Rows[index].Cells[4].Value;
                nudHaftalik.Value = (int)dgwAraclar.Rows[index].Cells[5].Value;
                nudAylik.Value = (int)dgwAraclar.Rows[index].Cells[6].Value;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            Database db = new Database(baglantiCumlesi);
            string q = "delete from Araclar where Id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();

            int index = dgwAraclar.CurrentRow.Index;
            int seciliArac = (int)dgwAraclar.Rows[index].Cells[0].Value;
            par.Add(new SqlParameter("@Id", seciliArac));
            db.RunQuery(q, par);
            GetDataAraclar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Aratxt = txtAracPlaka.Text.Trim().ToUpper();

            int j = -1;

            for (int i = 0; i <= dgwAraclar.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dgwAraclar.Rows)
                {
                    foreach (DataGridViewCell cell in dgwAraclar.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == Aratxt)
                            {
                                int index = cell.RowIndex;
                                int secliKisi = (int)dgwAraclar.Rows[index].Cells[0].Value;

                                txtMarka.Text = dgwAraclar.Rows[index].Cells[1].Value.ToString();
                                txtModel.Text = dgwAraclar.Rows[index].Cells[2].Value.ToString();
                                txtPlaka.Text = dgwAraclar.Rows[index].Cells[3].Value.ToString();
                                nudGunluk.Value = (int)dgwAraclar.Rows[index].Cells[4].Value;
                                nudHaftalik.Value = (int)dgwAraclar.Rows[index].Cells[5].Value;
                                nudAylik.Value = (int)dgwAraclar.Rows[index].Cells[6].Value;
                                j = 0;
                                break;
                            }

                        }
                    }
                }
            }
            if (j == -1)
            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
        }
    }
}
