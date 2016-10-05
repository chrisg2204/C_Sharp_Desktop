namespace View
{
    partial class FrmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextNombres = new System.Windows.Forms.TextBox();
            this.TextPasswd = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.ComboPerfil = new System.Windows.Forms.ComboBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perfil:";
            // 
            // TextNombres
            // 
            this.TextNombres.Location = new System.Drawing.Point(72, 21);
            this.TextNombres.Name = "TextNombres";
            this.TextNombres.Size = new System.Drawing.Size(174, 20);
            this.TextNombres.TabIndex = 4;
            // 
            // TextPasswd
            // 
            this.TextPasswd.Location = new System.Drawing.Point(72, 69);
            this.TextPasswd.Name = "TextPasswd";
            this.TextPasswd.PasswordChar = '*';
            this.TextPasswd.Size = new System.Drawing.Size(174, 20);
            this.TextPasswd.TabIndex = 5;
            // 
            // TextEmail
            // 
            this.TextEmail.Location = new System.Drawing.Point(72, 118);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(174, 20);
            this.TextEmail.TabIndex = 6;
            // 
            // ComboPerfil
            // 
            this.ComboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPerfil.FormattingEnabled = true;
            this.ComboPerfil.Items.AddRange(new object[] {
            "Seleccione...",
            "Usuario",
            "Administrador"});
            this.ComboPerfil.Location = new System.Drawing.Point(72, 170);
            this.ComboPerfil.Name = "ComboPerfil";
            this.ComboPerfil.Size = new System.Drawing.Size(174, 21);
            this.ComboPerfil.TabIndex = 7;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(25, 226);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 8;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnSendFormUsuario_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(187, 226);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiarFormUsuario_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(106, 226);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.ComboPerfil);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextPasswd);
            this.Controls.Add(this.TextNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextNombres;
        private System.Windows.Forms.TextBox TextPasswd;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.ComboBox ComboPerfil;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}

