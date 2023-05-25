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

namespace СarService
{
    public partial class FormADDClient : Form
    {

        public FormADDClient()
        {
            InitializeComponent();
        }
        public FormADDClient(Client client) : this()
        { 
              
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Fill in the fields");
            }

            {
                using (SqlConnection conn = new SqlConnection(DataBase.strConn))
                {
                    conn.Open();
                    Client client = new Client(0, textBox1.Text.ToString(), textBox2.Text.ToString());
                    conn.Execute("INSERT INTO [Client]([Login],[Name]) VALUES(@Login, @Name)", new { client.Login, client.Name });

                }
                MessageBox.Show("Client is created");
                this.Close();
            }

        }
    }
}
