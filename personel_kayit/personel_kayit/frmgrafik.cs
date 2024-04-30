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
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source = DESKTOP-IEPBU31\\SQLEXPRESS; Initial Catalog = personelveritabanı; Integrated Security = True");

        private void chart1_Click(object sender, EventArgs e)
        {
            baglantı.Open();


            SqlCommand komutg1 = new SqlCommand("select perad,count(*) from dbo.Table_1 group by perad", baglantı);

            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read()) { chart1.Series["isim"].Points.AddXY(dr1[0], dr1[1]); }










            baglantı.Close();
        }
    }
}
