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
using СarService.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СarService
{
    public partial class FormAdmin : Form
    {
        List<Client> clients = new List<Client>();
        List<Car> cars = new List<Car>();
        List<Master>masters = new List<Master>();
        List<Part> parts = new List<Part>();
        List<Service> services = new List<Service>();
        int i;
        public FormAdmin()
        {
            InitializeComponent();
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormADDClient newForm = new FormADDClient();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormADDMaster newForm = new FormADDMaster();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(DataBase.strConn))
            {
                clients.Clear();
                conn.Open();
                clients = conn.Query<Client>("SELECT * FROM [Client];").ToList();
                cars = conn.Query<Car>("SELECT * FROM [Car];").ToList();
            }

            foreach (Client client in clients)
            {
                foreach (Car car in cars)
                {
                    if (client.Id == car.ClientId)
                    {
                        client.cars.Add(car);
                    }
                }

            }
            int y = 0;
            for (int i = 0; i < clients.Count; i++)
            {
                var item = new UserControlClient(clients[i]);
                item.Location = new Point(0, y);
                this.panel1.Controls.Add(item);
                y += item.Height;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();   
            using (SqlConnection conn = new SqlConnection(DataBase.strConn))
            {
                masters.Clear();
                conn.Open();
                masters = conn.Query<Master>("SELECT * FROM [Master];").ToList();
                
            }

            int y = 0;
            for (int i = 0; i < masters.Count; i++)
            {
                var item = new UserControlMaster(masters[i]);
                item.Location = new Point(0, y);
                this.panel1.Controls.Add(item);
                y += item.Height;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Client client in clients)
            {
                if (i == client.Id)
                {
                    FormADDCar newForm = new FormADDCar(i);
                    newForm.Show();
                }
            }            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { 
                i = Convert.ToInt32(textBox1.Text.ToString());
                if (i>0)
                {
                    button5.Enabled = true;

                }

            }
            catch
            {
                if (textBox1.Text != string.Empty)
                {
                    MessageBox.Show("Only number");
                    textBox1.Text = null;
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(DataBase.strConn))
            {
                parts.Clear();
                conn.Open();
                parts = conn.Query<Part>("SELECT * FROM [Part];").ToList();

            }

            int y = 0;
            for (int i = 0; i < parts.Count; i++)
            {
                var item = new UserControlPart(parts[i]);
                item.Location = new Point(0, y);
                this.panel1.Controls.Add(item);
                y += item.Height;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            using (SqlConnection conn = new SqlConnection(DataBase.strConn))
            {
                services.Clear();
                conn.Open();
                services = conn.Query<Service>("SELECT * FROM [Service];").ToList();
                masters = conn.Query<Master>("SELECT * FROM [Master];").ToList();

            }
            foreach (Service service in services)
            {
                foreach (Master master in masters)
                {
                        if (service.Id == master.ServiceId)
                        {
                            service.masters.Add(master);
                        }
                }

            }
            int y = 0;
            for (int i = 0; i < services.Count; i++)
            {
                var item = new UserControlService(services[i]);
                item.Location = new Point(0, y);
                this.panel1.Controls.Add(item);

                
                y += item.Height;
            }
            
        }
    }
}
