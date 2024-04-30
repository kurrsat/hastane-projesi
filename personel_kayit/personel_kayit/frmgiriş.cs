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
    public partial class frmgiriş : Form
    {
        public frmgiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source = DESKTOP-IEPBU31\\SQLEXPRESS; Initial Catalog = personelveritabanı; Integrated Security = True");
        private void frmgiriş_Load(object sender, EventArgs e)
        {

        }

        private void girişyap_Click(object sender, EventArgs e)
        {
            
        }
    }
}
