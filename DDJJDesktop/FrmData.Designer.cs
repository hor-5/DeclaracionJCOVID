namespace DDJJDesktop
{
    partial class FrmData
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
            this.tbForm = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSurname = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDni = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBack2 = new MaterialSkin.Controls.MaterialButton();
            this.btnNext2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBack3 = new MaterialSkin.Controls.MaterialButton();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tabPage1);
            this.tbForm.Controls.Add(this.tabPage2);
            this.tbForm.Controls.Add(this.tabPage3);
            this.tbForm.Depth = 0;
            this.tbForm.Location = new System.Drawing.Point(5, 83);
            this.tbForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbForm.Multiline = true;
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(795, 376);
            this.tbForm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(787, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.AnimateReadOnly = false;
            this.txtSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSurname.Depth = 0;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSurname.HideSelection = true;
            this.txtSurname.LeadingIcon = null;
            this.txtSurname.Location = new System.Drawing.Point(516, 24);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PrefixSuffixText = null;
            this.txtSurname.ReadOnly = false;
            this.txtSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(194, 36);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TabStop = false;
            this.txtSurname.Text = "Apellido";
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSurname.TrailingIcon = null;
            this.txtSurname.UseSystemPasswordChar = false;
            this.txtSurname.UseTallSize = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(272, 24);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(194, 36);
            this.txtName.TabIndex = 3;
            this.txtName.TabStop = false;
            this.txtName.Text = "Nombre";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.UseTallSize = false;
            // 
            // txtDni
            // 
            this.txtDni.AnimateReadOnly = false;
            this.txtDni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDni.Depth = 0;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDni.HideSelection = true;
            this.txtDni.LeadingIcon = null;
            this.txtDni.Location = new System.Drawing.Point(49, 24);
            this.txtDni.MaxLength = 32767;
            this.txtDni.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PrefixSuffixText = null;
            this.txtDni.ReadOnly = false;
            this.txtDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDni.SelectedText = "";
            this.txtDni.SelectionLength = 0;
            this.txtDni.SelectionStart = 0;
            this.txtDni.ShortcutsEnabled = true;
            this.txtDni.Size = new System.Drawing.Size(194, 36);
            this.txtDni.TabIndex = 2;
            this.txtDni.TabStop = false;
            this.txtDni.Text = "Ingrese DNI";
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDni.TrailingIcon = null;
            this.txtDni.UseSystemPasswordChar = false;
            this.txtDni.UseTallSize = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(678, 303);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(95, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBack2);
            this.tabPage2.Controls.Add(this.btnNext2);
            this.tabPage2.Controls.Add(this.materialTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(780, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack2.Depth = 0;
            this.btnBack2.HighEmphasis = true;
            this.btnBack2.Icon = null;
            this.btnBack2.Location = new System.Drawing.Point(7, 303);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack2.Size = new System.Drawing.Size(67, 36);
            this.btnBack2.TabIndex = 2;
            this.btnBack2.Text = "Atrás";
            this.btnBack2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBack2.UseAccentColor = true;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext2.Depth = 0;
            this.btnNext2.HighEmphasis = true;
            this.btnNext2.Icon = null;
            this.btnNext2.Location = new System.Drawing.Point(678, 303);
            this.btnNext2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext2.Size = new System.Drawing.Size(95, 36);
            this.btnNext2.TabIndex = 1;
            this.btnNext2.Text = "Siguiente";
            this.btnNext2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext2.UseAccentColor = false;
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(51, 48);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(182, 36);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBack3);
            this.tabPage3.Controls.Add(this.btnConfirm);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBack3
            // 
            this.btnBack3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack3.Depth = 0;
            this.btnBack3.HighEmphasis = true;
            this.btnBack3.Icon = null;
            this.btnBack3.Location = new System.Drawing.Point(7, 303);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack3.Size = new System.Drawing.Size(67, 36);
            this.btnBack3.TabIndex = 2;
            this.btnBack3.Text = "Atrás";
            this.btnBack3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBack3.UseAccentColor = true;
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(678, 303);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(105, 36);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = false;
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(62, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Probando";
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.tbForm;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(294, 62);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(507, 24);
            this.TabSelector.TabIndex = 2;
            this.TabSelector.TabIndicatorHeight = 4;
            this.TabSelector.Text = "none";
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.tbForm);
            this.Name = "FrmData";
            this.Text = "Declaración jurada personal";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.tbForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbSelector;
        private MaterialSkin.Controls.MaterialTabControl tbForm;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSurname;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtDni;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton btnBack2;
        private MaterialSkin.Controls.MaterialButton btnNext2;
        private MaterialSkin.Controls.MaterialButton btnBack3;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
    }
}