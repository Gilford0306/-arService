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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using СarService.Clases;
using Dapper;

namespace СarService
{
    public partial class FormADDMaster : Form
    {
        int i;
        public FormADDMaster()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || comboBox1.TabIndex==0)
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(DataBase.strConn))
                {
                    conn.Open();
                    //Master master = new Master(0, textBox1.Text.ToString(), comboBox1.Text.ToString(), Convert.ToInt32(trackBar1.Value.ToString()));
                    Master master = new Master(0, textBox1.Text.ToString(), comboBox1.Text.ToString(), Convert.ToInt32(trackBar1.Value.ToString()), i);
                    conn.Execute("INSERT INTO [Master]([Name], [Professional], [Level], [ServiceId]) VALUES( @Name, @Professional, @Level,  @ServiceId)", new { master.Name, master.Professional, master.Level, master.ServiceId});


                }
                MessageBox.Show("Master is created");
                this.Close();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = comboBox1.SelectedIndex+1;
            
        }
    }
}
