using EntitiesModel;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDJJDesktop
{
    public partial class FrmData : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private string url;
        public FrmData()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
        }

        private async void FrmData_Load(object sender, EventArgs e)
        {
            string countrys = await getCountrys();
            List<Country> lstCountries = JsonConvert.DeserializeObject<List<Country>>(countrys);
            foreach (Country country in lstCountries) {
                sltNationality.Items.Add(country.name.common);
                sltResidence.Items.Add(country.name.common);
                sltCodArea.Items.Add(country.name.common + ": " + (country.idd.root != null ? country.idd.root : "-") + (country.idd.suffixes != null ? country.idd.suffixes[0] : "-") );
            }

        }

        private async Task<string> getCountrys() {
            url = "https://restcountries.com/v3.1/all";
            WebRequest webRequest = WebRequest.Create(url);
            WebResponse response = webRequest.GetResponse();
            StreamReader sreader = new StreamReader(response.GetResponseStream());
            
            return await sreader.ReadToEndAsync();
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

        private void btnSy_Click(object sender, EventArgs e)
        {
            cardSy.Visible = false;
            ModalSy.Visible = true;
        }

        private void btnCloseSy_Click(object sender, EventArgs e)
        {            
            ModalSy.Visible = false;
            cardSy.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "../../../img/success.png");
            imgResult.Image = Image.FromFile(imagePath);
            imgResult.Location = new System.Drawing.Point(195, 60);
            materialCard4.Visible = false;
            materialCard5.Visible = false;
            materialCard6.Visible = false;
            cardSy.Visible = false;
            btnConfirm.Visible = false;
            btnBack3.Visible = false;
            TabSelector.Visible = false;
        }
    }
}
