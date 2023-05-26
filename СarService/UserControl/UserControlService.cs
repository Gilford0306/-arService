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
    public partial class UserControlService : UserControl
    {
        public UserControlService()
        {
            InitializeComponent();
        }

        public UserControlService(Service service):this()
        {
            string str = string.Empty;
            labelId.Text=service.Id.ToString();
            labelDesription.Text=service.Description.ToString();    
            labelPrice.Text=service.Price.ToString();
            foreach (Master master in service.masters)
            {
                 
                str += " - " + master.Name.ToString();
            }
            labelmaster.Text = str;
        }

    }
}
