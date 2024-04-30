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





    public partial class istatistik : Form
    {

        SqlConnection baglantı = new SqlConnection("Data Source = DESKTOP-IEPBU31\\SQLEXPRESS; Initial Catalog = personelveritabanı; Integrated Security = True");


        public istatistik()
        {
            InitializeComponent();
        }

        private void istatistik_Load(object sender, EventArgs e)
        {
            baglantı.Open();




            SqlCommand komut1 = new SqlCommand("select count(*)  from dbo.Table_1 ", baglantı);

            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) { lbltoplam.Text = dr1[0].ToString(); }





            baglantı.Close();



            baglantı.Open();

            SqlCommand komut2 = new SqlCommand("select count(*)  from dbo.Table_1 where perdurum = 1", baglantı);

            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read()) { lblevli.Text = dr2[0].ToString(); }









            baglantı.Close();

            baglantı.Open();

            SqlCommand komut3 = new SqlCommand("select sum(permaaş) from dbo.Table_1", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read()) { lblmaaş.Text = dr3[0].ToString(); }

            baglantı.Close();




            baglantı.Open();

            SqlCommand komut4 = new SqlCommand("select avg(permaaş) from dbo.Table_1", baglantı

            );


            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read()) { lblortalama.Text = dr4[0].ToString(); }



            





            baglantı.Close();






























           







        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
