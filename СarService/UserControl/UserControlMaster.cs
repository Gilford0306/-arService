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
    public partial class UserControlMaster : UserControl
    {
        public UserControlMaster()
        {
            InitializeComponent();
        }
        public UserControlMaster(Master master): this ()
        {
            labelId.Text = master.Id.ToString();
            labelName.Text = master.Name.ToString();
            labelProf.Text=master.Professional.ToString();
            labelLevel.Text = master.Level.ToString(); 
        }


    }
}
