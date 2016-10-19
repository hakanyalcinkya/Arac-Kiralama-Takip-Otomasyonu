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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = @"Server=HAKAN\HAKAN;Database=AracKiralamaOtoDB;User Id=sa; Password=2005203036";

        private void GetDataMusteri()
        {
            Database db = new Database(baglantiCumlesi);
            
            DataTable sonucTablo = db.GetTable("select * from Musteriler", null);
            dataGridView1.DataSource = sonucTablo;
            dataGridView1.Columns[0].Visible = false;
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "insert into Musteriler(TcNo, Ad, Soyad, EPosta, Telefon, Adres) values(@TcNo,@Ad,@Soyad,@EPosta,@Telefon,@Adres)";
            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@TcNo",txtTcNo.Text.Trim()));
            par.Add(new SqlParameter("@Ad",txtAd.Text));
            par.Add(new SqlParameter("@Soyad",txtSoyad.Text));
            par.Add(new SqlParameter("@EPosta",txtEMail.Text));
            par.Add(new SqlParameter("@Telefon", txtTelefon.Text));
            par.Add(new SqlParameter("@Adres",txtAdres.Text));

            db.RunQuery(q, par);
            GetDataMusteri();
            MessageBox.Show("Müsteri Kaydedildi...");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetDataMusteri();
        }

        private void btnMusterSil_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "delete from Musteriler where Id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();

            int index = dataGridView1.CurrentRow.Index;
            int seciliMusteri = (int)dataGridView1.Rows[index].Cells[0].Value;
            par.Add(new SqlParameter("@Id", seciliMusteri));
            db.RunQuery(q, par);
            GetDataMusteri();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index>-1)
            {
                int index = dataGridView1.CurrentRow.Index;
                int secliKisi = (int)dataGridView1.Rows[index].Cells[0].Value;

                txtTcNo.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtAd.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtEMail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txtTelefon.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txtAdres.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void MusteriDuzenle_Click(object sender, EventArgs e)
        {
            Database db = new Database(baglantiCumlesi);
            string q = "update Musteriler set TcNo=@TcNo,Ad=@Ad,Soyad=@Soyad,EPosta=@EPosta,Telefon=@Telefon,Adres=@Adres where Id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();
            int index = dataGridView1.CurrentRow.Index;
            int secliKisi =(int) dataGridView1.Rows[index].Cells[0].Value;

            
            par.Add(new SqlParameter("@Id",secliKisi));
            par.Add(new SqlParameter("@TcNo",txtTcNo.Text.Trim()));
            par.Add(new SqlParameter("@Ad",txtAd.Text));
            par.Add(new SqlParameter("@Soyad",txtSoyad.Text));
            par.Add(new SqlParameter("@EPosta",txtEMail.Text));
            par.Add(new SqlParameter("@Telefon",txtTelefon.Text));
            par.Add(new SqlParameter("@Adres",txtAdres.Text));
            db.RunQuery(q, par);
            GetDataMusteri();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            string Aratxt = txtMusteriTcNo.Text.Trim();

            int j = -1;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString() == Aratxt)
                            {
                                int index = cell.RowIndex;

                                txtTcNo.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                                txtAd.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                                txtSoyad.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                                txtEMail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                                txtTelefon.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                                txtAdres.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
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
