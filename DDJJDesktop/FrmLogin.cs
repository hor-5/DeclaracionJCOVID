using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDJJDesktop
{
    public partial class FrmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FrmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400,MaterialSkin.TextShade.WHITE);
        }


        private void btnWUser_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            grpWelcome.Visible = false;            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = false;
            grpWelcome.Visible = true;            
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.Show();
            this.Hide();
        }
    }
}
