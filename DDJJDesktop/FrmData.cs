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
    public partial class FrmData : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FrmData()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
        }

        private void FrmData_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex++;
            
                       
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex++;
           
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex--;
            
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex--;            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterprise_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseModal_Click(object sender, EventArgs e)
        {
            cardModalGR.Visible = false;
            cardVaccine.Visible = true;
        }

        private void btnRiskGroup_Click(object sender, EventArgs e)
        {
            cardVaccine.Visible = false;
            cardModalGR.Visible = true;            
        }
    }
}
