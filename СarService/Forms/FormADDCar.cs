using Dapper;
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
using СarService.Clases;

namespace СarService.Forms
{
    public partial class FormADDCar : Form
    {
        int y;
        public FormADDCar(int i)
        {
            InitializeComponent();
            y = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.strConn))
            {
                conn.Open();
                Car car = new Car(0, textBox1.Text.ToString(), y , Convert.ToInt32(textBox2.Text.ToString()));
                conn.Execute("INSERT INTO [Car]([Model],[ClientId],[Year]) VALUES(@Model,@ClientId, @Year)", new { car.Model, car.ClientId, car.Year });
            }
            MessageBox.Show("Cars is added");
            this.Close();
        }
    }
}
