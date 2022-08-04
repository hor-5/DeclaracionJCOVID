namespace DDJJDesktop
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.declarationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDeclarations = new System.Windows.Forms.DataGridView();
            this.idDeclaracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasSymptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVaccinated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRiskGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTraveler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatus = new MaterialSkin.Controls.MaterialButton();
            this.sltIdDeclaration = new MaterialSkin.Controls.MaterialComboBox();
            this.sltStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtEditar = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogout = new MaterialSkin.Controls.MaterialFloatingActionButton();
            ((System.ComponentModel.ISupportInitialize)(this.declarationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDeclarations)).BeginInit();
            this.SuspendLayout();
            // 
            // declarationsBindingSource
            // 
            this.declarationsBindingSource.DataSource = typeof(EntitiesModel.Declarations);
            this.declarationsBindingSource.CurrentChanged += new System.EventHandler(this.declarationsBindingSource_CurrentChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(EntitiesModel.Person);
            // 
            // tableDeclarations
            // 
            this.tableDeclarations.AllowUserToAddRows = false;
            this.tableDeclarations.AllowUserToDeleteRows = false;
            this.tableDeclarations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDeclarations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeclaracion,
            this.created_at,
            this.dni,
            this.firstName,
            this.surName,
            this.telephone,
            this.closeContact,
            this.hasSymptom,
            this.isVaccinated,
            this.isRiskGroup,
            this.isTraveler,
            this.nameDepartament,
            this.visitDate,
            this.nameStatus});
            this.tableDeclarations.Location = new System.Drawing.Point(3, 108);
            this.tableDeclarations.Name = "tableDeclarations";
            this.tableDeclarations.ReadOnly = true;
            this.tableDeclarations.RowTemplate.Height = 25;
            this.tableDeclarations.Size = new System.Drawing.Size(991, 461);
            this.tableDeclarations.TabIndex = 0;
            // 
            // idDeclaracion
            // 
            this.idDeclaracion.HeaderText = "ID";
            this.idDeclaracion.Name = "idDeclaracion";
            this.idDeclaracion.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Fecha de creación";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.created_at.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Nombre";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // surName
            // 
            this.surName.HeaderText = "Apellido";
            this.surName.Name = "surName";
            this.surName.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telefono";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // closeContact
            // 
            this.closeContact.HeaderText = "¿Es contacto estrecho?";
            this.closeContact.Name = "closeContact";
            this.closeContact.ReadOnly = true;
            // 
            // hasSymptom
            // 
            this.hasSymptom.HeaderText = "¿Tiene sintomas?";
            this.hasSymptom.Name = "hasSymptom";
            this.hasSymptom.ReadOnly = true;
            // 
            // isVaccinated
            // 
            this.isVaccinated.HeaderText = "¿Está vacunadx?";
            this.isVaccinated.Name = "isVaccinated";
            this.isVaccinated.ReadOnly = true;
            // 
            // isRiskGroup
            // 
            this.isRiskGroup.HeaderText = "¿Grupo de riesgo?";
            this.isRiskGroup.Name = "isRiskGroup";
            this.isRiskGroup.ReadOnly = true;
            // 
            // isTraveler
            // 
            this.isTraveler.HeaderText = "¿Viajó recientemente?";
            this.isTraveler.Name = "isTraveler";
            this.isTraveler.ReadOnly = true;
            // 
            // nameDepartament
            // 
            this.nameDepartament.HeaderText = "Departamento";
            this.nameDepartament.Name = "nameDepartament";
            this.nameDepartament.ReadOnly = true;
            // 
            // visitDate
            // 
            this.visitDate.HeaderText = "Fecha de visita";
            this.visitDate.Name = "visitDate";
            this.visitDate.ReadOnly = true;
            // 
            // nameStatus
            // 
            this.nameStatus.HeaderText = "Estado";
            this.nameStatus.Name = "nameStatus";
            this.nameStatus.ReadOnly = true;
            this.nameStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnStatus
            // 
            this.btnStatus.AutoSize = false;
            this.btnStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnStatus.Depth = 0;
            this.btnStatus.HighEmphasis = true;
            this.btnStatus.Icon = null;
            this.btnStatus.Location = new System.Drawing.Point(849, 606);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStatus.Size = new System.Drawing.Size(130, 35);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Cambiar Estado";
            this.btnStatus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnStatus.UseAccentColor = true;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // sltIdDeclaration
            // 
            this.sltIdDeclaration.AutoResize = true;
            this.sltIdDeclaration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltIdDeclaration.Depth = 0;
            this.sltIdDeclaration.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltIdDeclaration.DropDownHeight = 118;
            this.sltIdDeclaration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltIdDeclaration.DropDownWidth = 121;
            this.sltIdDeclaration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltIdDeclaration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltIdDeclaration.Hint = "ID";
            this.sltIdDeclaration.IntegralHeight = false;
            this.sltIdDeclaration.ItemHeight = 29;
            this.sltIdDeclaration.Location = new System.Drawing.Point(509, 606);
            this.sltIdDeclaration.MaxDropDownItems = 4;
            this.sltIdDeclaration.MouseState = MaterialSkin.MouseState.OUT;
            this.sltIdDeclaration.Name = "sltIdDeclaration";
            this.sltIdDeclaration.Size = new System.Drawing.Size(121, 35);
            this.sltIdDeclaration.StartIndex = 0;
            this.sltIdDeclaration.TabIndex = 2;
            this.sltIdDeclaration.UseTallSize = false;
            // 
            // sltStatus
            // 
            this.sltStatus.AutoResize = false;
            this.sltStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltStatus.Depth = 0;
            this.sltStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltStatus.DropDownHeight = 118;
            this.sltStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltStatus.DropDownWidth = 121;
            this.sltStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltStatus.FormattingEnabled = true;
            this.sltStatus.Hint = "Estado";
            this.sltStatus.IntegralHeight = false;
            this.sltStatus.ItemHeight = 29;
            this.sltStatus.Location = new System.Drawing.Point(672, 606);
            this.sltStatus.MaxDropDownItems = 4;
            this.sltStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.sltStatus.Name = "sltStatus";
            this.sltStatus.Size = new System.Drawing.Size(151, 35);
            this.sltStatus.StartIndex = 0;
            this.sltStatus.TabIndex = 3;
            this.sltStatus.UseTallSize = false;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Depth = 0;
            this.txtTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.txtTitle.Location = new System.Drawing.Point(6, 78);
            this.txtTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(157, 24);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "DECLARACIONES";
            // 
            // txtEditar
            // 
            this.txtEditar.AutoSize = true;
            this.txtEditar.Depth = 0;
            this.txtEditar.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditar.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.txtEditar.Location = new System.Drawing.Point(509, 580);
            this.txtEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(210, 17);
            this.txtEditar.TabIndex = 5;
            this.txtEditar.Text = "Editar estado de una declaración";
            // 
            // btnLogout
            // 
            this.btnLogout.Depth = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Icon = ((System.Drawing.Image)(resources.GetObject("btnLogout.Icon")));
            this.btnLogout.Location = new System.Drawing.Point(954, 67);
            this.btnLogout.Mini = true;
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.sltStatus);
            this.Controls.Add(this.sltIdDeclaration);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.tableDeclarations);
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de administrador";
            ((System.ComponentModel.ISupportInitialize)(this.declarationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDeclarations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource declarationsBindingSource;
        private BindingSource personBindingSource;
        private DataGridView tableDeclarations;
        private MaterialSkin.Controls.MaterialButton btnStatus;
        private DataGridViewTextBoxColumn idDeclaracion;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn closeContact;
        private DataGridViewTextBoxColumn hasSymptom;
        private DataGridViewTextBoxColumn isVaccinated;
        private DataGridViewTextBoxColumn isRiskGroup;
        private DataGridViewTextBoxColumn isTraveler;
        private DataGridViewTextBoxColumn nameDepartament;
        private DataGridViewTextBoxColumn visitDate;
        private DataGridViewTextBoxColumn nameStatus;
        private MaterialSkin.Controls.MaterialComboBox sltIdDeclaration;
        private MaterialSkin.Controls.MaterialComboBox sltStatus;
        private MaterialSkin.Controls.MaterialLabel txtTitle;
        private MaterialSkin.Controls.MaterialLabel txtEditar;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnLogout;
    }
}