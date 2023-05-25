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
        int i = -1;
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
            else if (i == -1)
            {
                using (SqlConnection conn = DataBase.conn)
                {
                    conn.Open();

                    Client client = new Client(0, textBox1.Text.ToString(), textBox2.Text.ToString());
                    conn.Execute("INSERT INTO [Client]([Login],[Name],[CTours]) VALUES(@Login, @Name,@CTours)", new { client.Login, client.Name});

                }
                MessageBox.Show("Client is created");
                this.Close();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    Client client = new Client(0, textBox1.Text.ToString(), textBox2.Text.ToString(), " ");
                    conn.Execute("update [Client] set Login = @login, Name=@name where Id = @id", new { client.Login, client.Name, id = i });

                }
                MessageBox.Show("Client is updated");
                this.Close();
            }
        }
    }
}
