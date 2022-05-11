using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartClinica.View
{
    public partial class UserControlDias : UserControl
    {
        public UserControlDias()
        {
            InitializeComponent();
        }

        private void UserControlDias_Load(object sender, EventArgs e)
        {

        }
        public void Dias(int dia)
        {
            lblDia.Text = dia + "";
        }
    }
}
