using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Services;
using EntitiesModel;

namespace DDJJDesktop
{
    public partial class FrmAdmin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SecurityServices securityServices = new SecurityServices();
        private List<string> lstIds = new List<string>();
        
        public FrmAdmin()
        {           

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            getDeclarations();
            fillStatus();
            fillIds();

        }

        private void getDeclarations() {
            List<DeclarationAdmin> declarations = securityServices.getDeclarations();
            foreach (DeclarationAdmin declaracion in declarations)
            {
                fillDataGrid(declaracion);
                lstIds.Add(declaracion.idDeclaration.ToString());
            }
        }

        private void fillDataGrid(DeclarationAdmin declaracion) {

            tableDeclarations.Rows.Clear();            

            int rowIndex = tableDeclarations.Rows.Add();

            tableDeclarations.Rows[rowIndex].Cells[0].Value = declaracion.idDeclaration;
            tableDeclarations.Rows[rowIndex].Cells[1].Value = declaracion.created_at.ToShortDateString();
            tableDeclarations.Rows[rowIndex].Cells[2].Value = declaracion.dni;
            tableDeclarations.Rows[rowIndex].Cells[3].Value = declaracion.firstName;
            tableDeclarations.Rows[rowIndex].Cells[4].Value = declaracion.surName;
            tableDeclarations.Rows[rowIndex].Cells[5].Value = declaracion.telephone;
            tableDeclarations.Rows[rowIndex].Cells[6].Value = declaracion.closeContact ? "SI" : "NO";
            tableDeclarations.Rows[rowIndex].Cells[7].Value = declaracion.hasSymptom ? "SI" : "NO";
            tableDeclarations.Rows[rowIndex].Cells[8].Value = declaracion.isVaccinated ? "SI" : "NO";
            tableDeclarations.Rows[rowIndex].Cells[9].Value = declaracion.isRiskGroup ? "SI" : "NO";
            tableDeclarations.Rows[rowIndex].Cells[10].Value = declaracion.isTraveler ? "SI" : "NO";
            tableDeclarations.Rows[rowIndex].Cells[11].Value = declaracion.nameDepartament;
            tableDeclarations.Rows[rowIndex].Cells[12].Value = declaracion.visitDate.ToShortDateString();
            tableDeclarations.Rows[rowIndex].Cells[13].Value = declaracion.nameStatus;
            
        }
        private void fillStatus()
        {
            List<Status> lstStatus = securityServices.getStatus();
            sltStatus.DisplayMember = "nameStatus";
            sltStatus.ValueMember = "idStatus";
            sltStatus.DataSource = lstStatus;
        }
        private void fillIds() {
            sltIdDeclaration.DataSource = lstIds;
        }
        private void declarationsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void btnStatus_Click(object sender, EventArgs e)
        {
            
            int idStatus = int.Parse(sltStatus.SelectedValue.ToString());
            int idDeclaration = int.Parse(sltIdDeclaration.SelectedValue.ToString());

            int result = securityServices.editDeclarationStatus(idDeclaration, idStatus);
            if (result >= 1) {
                getDeclarations();
                MaterialMessageBox.Show($"Se actualizó con exito el estado de la declaracion ID: {idDeclaration.ToString()}");
            }
            else {
                MaterialMessageBox.Show($"Ocurrió un error cambiando el estado de la declaracion ID: {idDeclaration.ToString()}");
            }  
            
        }
        private void backTologin()
        {
            this.Close();
            new FrmLogin().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            backTologin();
        }
    }
}
