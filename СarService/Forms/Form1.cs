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
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();
            using (SqlConnection conn = DataBase.conn)
            {
                conn.Open();
                clients = conn.Query<Client>("SELECT * FROM [Client];").ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "admin")
                {
                    FormAdmin newForm = new FormAdmin();
                    newForm.Show();
                }
                else
                {
                    bool flag = false;
                    foreach (Client client in clients)
                    {
                        string str = client.Login;
                        str = str.Replace(" ", string.Empty);
                        if (textBox1.Text == str)
                        {
                            FormClient newForm = new FormClient(client);
                            newForm.Show();
                            flag = true;
                        }

                    }
                    if (flag == false && textBox1.Text != string.Empty)
                        MessageBox.Show("Login isn`t exist");
                }


            }
        }
    }
}
//Написать приложение для сто. Возможности, добавления клиента (у клиента может быть множество машин, на КОНКРЕТНУЮ машину может записывать одно или несколько услуг к конкретному мастеру.) 
//и мастера(мастер имеет специальность одну или несколько (к примеру, кузовной ремонт и покраска) , а так же уровень мастера) . Мастеров добавляет владелец бизнеса ( один такой), так же как и клиентов. 
//Реализовать возможность записи клиента на конкретную дату и услугу, так же мастера кто будет выполнять ремонт и запчасти. И ремонт и запчасть должны иметь цену записанную. 
//Реализовать архитектуру MVC, использовать пользовательские компоненты GUI и Базу Данных для хранения данных. Метод работы с Бд - любой