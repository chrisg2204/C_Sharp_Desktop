namespace View
{
    partial class FrmMenu
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
            this.DaGrViUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DaGrViUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DaGrViUsuarios
            // 
            this.DaGrViUsuarios.AllowUserToAddRows = false;
            this.DaGrViUsuarios.AllowUserToDeleteRows = false;
            this.DaGrViUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaGrViUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.passwd,
            this.email,
            this.profile,
            this.created_at,
            this.updated_at});
            this.DaGrViUsuarios.Location = new System.Drawing.Point(12, 12);
            this.DaGrViUsuarios.Name = "DaGrViUsuarios";
            this.DaGrViUsuarios.ReadOnly = true;
            this.DaGrViUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DaGrViUsuarios.Size = new System.Drawing.Size(636, 165);
            this.DaGrViUsuarios.TabIndex = 0;
            this.DaGrViUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaGrViUsuarios_CellClick);
            this.DaGrViUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaGrViUsuarios_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NOMBRES";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // passwd
            // 
            this.passwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwd.DataPropertyName = "passwd";
            this.passwd.HeaderText = "PASSWD";
            this.passwd.Name = "passwd";
            this.passwd.ReadOnly = true;
            this.passwd.Visible = false;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // profile
            // 
            this.profile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profile.DataPropertyName = "profile";
            this.profile.HeaderText = "PERFIL";
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "CREADO";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // updated_at
            // 
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "ACTUALIZADO";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 193);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(147, 56);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar Usuario";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(501, 193);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(147, 56);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar Usuario";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Location = new System.Drawing.Point(165, 193);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(147, 56);
            this.BtnRefrescar.TabIndex = 3;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(348, 193);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(147, 56);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.Text = "Modificar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 261);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DaGrViUsuarios);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaGrViUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DaGrViUsuarios;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
    }
}