using MaterialSkin.Controls;
using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using System;

namespace StartClinica.View
{
    public partial class frmEvento : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmEvento()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Orange200, MaterialSkin.TextShade.WHITE);
        }
        
    }
}
