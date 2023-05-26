using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СarService
{
    public partial class UserControlClient : UserControl
    {
        public UserControlClient()
        {
            InitializeComponent();
        }
        public UserControlClient(Client client) : this()
        {
            labelId.Text = client.Id.ToString();
            labelLogin.Text = client.Login.ToString();
            labelName.Text = client.Name.ToString();
            foreach (Car car in client.cars)
            {
                string str = " " + car.Model.ToString() + " " + car.Year.ToString() + "; ";
                labelCars.Text += str;
            }      
        }


    }
}
