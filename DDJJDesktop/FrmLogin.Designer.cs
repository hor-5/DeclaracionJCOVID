namespace DDJJDesktop
{
    partial class FrmLogin
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWUser = new System.Windows.Forms.Button();
            this.btnNoUser = new System.Windows.Forms.Button();
            this.grpWelcome = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.grpWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.btnVolver);
            this.grpLogin.Controls.Add(this.btnIngresar);
            this.grpLogin.Controls.Add(this.textBox2);
            this.grpLogin.Controls.Add(this.textBox1);
            this.grpLogin.Location = new System.Drawing.Point(230, 71);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(300, 234);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            this.grpLogin.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(198, 196);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 30);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(49, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(49, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnWUser
            // 
            this.btnWUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWUser.Location = new System.Drawing.Point(94, 150);
            this.btnWUser.Name = "btnWUser";
            this.btnWUser.Size = new System.Drawing.Size(270, 70);
            this.btnWUser.TabIndex = 1;
            this.btnWUser.Text = "Ingresar con usuario";
            this.btnWUser.UseVisualStyleBackColor = false;
            this.btnWUser.Click += new System.EventHandler(this.btnWUser_Click);
            // 
            // btnNoUser
            // 
            this.btnNoUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNoUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNoUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNoUser.Location = new System.Drawing.Point(94, 215);
            this.btnNoUser.Name = "btnNoUser";
            this.btnNoUser.Size = new System.Drawing.Size(270, 70);
            this.btnNoUser.TabIndex = 2;
            this.btnNoUser.Text = "Ingresar sin usuario";
            this.btnNoUser.UseVisualStyleBackColor = false;
            this.btnNoUser.Click += new System.EventHandler(this.btnNoUser_Click);
            // 
            // grpWelcome
            // 
            this.grpWelcome.Controls.Add(this.btnWUser);
            this.grpWelcome.Controls.Add(this.btnNoUser);
            this.grpWelcome.Location = new System.Drawing.Point(171, 12);
            this.grpWelcome.Name = "grpWelcome";
            this.grpWelcome.Size = new System.Drawing.Size(476, 399);
            this.grpWelcome.TabIndex = 3;
            this.grpWelcome.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 31);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(40, 30);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "<";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpWelcome);
            this.Controls.Add(this.grpLogin);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpLogin;
        private Button btnIngresar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnWUser;
        private Button btnNoUser;
        private GroupBox grpWelcome;
        private Button btnVolver;
    }
}