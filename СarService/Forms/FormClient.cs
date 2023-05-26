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
    public partial class FormClient : Form
    {
        List<Client> clients = new List<Client>();
        List<Car> cars = new List<Car>();
        List<Master> masters = new List<Master>();
        List<Part> parts = new List<Part>();
        List<Service> services = new List<Service>();
        Client CurrentClient = new Client();
        int i;
        public FormClient()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        public FormClient(Client client):this()
        {
            CurrentClient = client;
            int i = 1;
            string str = "";
            foreach (Car car in client.cars)
            {
                str += i + " - " + car.Model.ToString();
                i++;
            }
             label2.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToInt32(textBox1.Text.ToString());
                i--;
                if (i >-1)
                {
                    button2.Enabled = true;

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            if (CurrentClient.cars.Count < i  || i > -1)
            {
                
                Car currenCar = new Car();
                currenCar = CurrentClient.cars[i];
                using (SqlConnection conn = new SqlConnection(DataBase.strConn))
                {
                    conn.Open();
                    parts = conn.Query<Part>("SELECT * FROM [Part];").ToList();

                }
                List<Part> clParts = new List<Part>();
                foreach (Part part in parts)
                {
                    if (part.Model.ToString().Contains(currenCar.Model.ToString()))
                    {
                        clParts.Add(part);
                    }
                }
                

                int y = 0;
                for (int i = 0; i < clParts.Count; i++)
                {
                    var item = new UserControlPart(clParts[i]);
                    item.Location = new Point(0, y);
                    this.panel1.Controls.Add(item);
                    y += item.Height;
                }
            }
        
            else
            {
                return;
            }

        }
    }
}
