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
        public static string staticDia;
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

        private void UserControlDias_Click(object sender, EventArgs e)
        {
            frmEvento frm = new frmEvento();
            staticDia = lblDia.Text;
            frm.ShowDialog();
        }
    }
}
