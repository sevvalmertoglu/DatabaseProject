using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veriT
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        void UrunGetir()
        {
            baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=veriT;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM URUN", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            UrunGetir();
         
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txturunıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtwvano.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtoemno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtkullanılanarac.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtstokno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtfirmaıd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtkategoriıd.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO URUN (Urun_ID,WVA_NO,OEM_NO,Kullanılan_arac,Stok_No,Firma_ID,Fiyat,Kategori_ID) VALUES (@Urun_ID,@WVA_NO,@OEM_NO,@Kullanılan_arac,@Stok_No,@Firma_ID,@Fiyat,@Kategori_ID) ";
            komut.Parameters.AddWithValue("@Urun_ID", txturunıd.Text);
            komut.Parameters.AddWithValue("@WVA_NO", txtwvano.Text);
            komut.Parameters.AddWithValue("@OEM_NO", txtoemno.Text);
            komut.Parameters.AddWithValue("@Kullanılan_arac", txtkullanılanarac.Text);
            komut.Parameters.AddWithValue("@Stok_No", txtstokno.Text);
            komut.Parameters.AddWithValue("@Firma_ID", txtfirmaıd.Text);
            komut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@Kategori_ID", txtkategoriıd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM URUN WHERE Urun_ID=@Urun_ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Urun_ID", Convert.ToInt32(txturunıd.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UrunGetir();
        }
    }
}
