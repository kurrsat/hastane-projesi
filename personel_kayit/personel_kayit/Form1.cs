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
namespace personel_kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelveritabanıDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'personelveritabanıDataSet1.Table_1' table. You can move, or remove it, as needed
            this.table_1TableAdapter.Fill(this.personelveritabanıDataSet1.Table_1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelveritabanıDataSet1.Table_1);
        }

        SqlConnection baglantı = new SqlConnection("Data Source = DESKTOP-IEPBU31\\SQLEXPRESS; Initial Catalog = personelveritabanı; Integrated Security = True");



        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            baglantı.Open();


            SqlCommand komut = new SqlCommand("insert into dbo.Table_1 (perad , persoyad , perMaaş) values (@p1 , @p2 , @p3)" , baglantı);
        


            komut.Parameters.AddWithValue("@p1" ,txtperad.Text);
            komut.Parameters.AddWithValue("@p2 ",txtpersoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskmaaş.Text);       
                
            komut.ExecuteNonQuery();


        baglantı.Close();
           



        }

        private void txtperad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelveritabanıDataSet1.Table_1);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            





        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtperad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtpersoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskmaaş.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand kommutsil =  new SqlCommand("Delete From dbo.Table_1 where perad=@k1", baglantı);

            kommutsil.Parameters.AddWithValue("@k1",txtperad.Text);
            kommutsil.ExecuteNonQuery(); 

            baglantı.Close();

            MessageBox.Show("silindi");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komutgüncerle = new SqlCommand("Update dbo.Table_1 set perad=@a2 ,persoyad=@a3  where  perid=@a4", baglantı);

            komutgüncerle.Parameters.AddWithValue("@a2", txtperad.Text);

            komutgüncerle.Parameters.AddWithValue("@a3", txtpersoyad.Text);

            komutgüncerle.Parameters.AddWithValue("@a4", txtperid.Text);



            komutgüncerle.ExecuteNonQuery();

            MessageBox.Show("personel güncerlendi");








            baglantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            istatistik fr = new istatistik();

            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmgrafik gr = new frmgrafik();

            gr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmgiriş gir = new frmgiriş();
            gir.Show();
        }
    }
}
