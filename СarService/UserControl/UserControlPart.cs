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
    public partial class UserControlPart : UserControl
    {
        public UserControlPart()
        {
            InitializeComponent();
        }
        public UserControlPart(Part part):this() 
        {
            labelId.Text= part.Id.ToString();
            labelName.Text= part.Name.ToString();
            labelmodel.Text= part.Model.ToString();
            labelPrice.Text= part.Price.ToString();

        }
    }
}
