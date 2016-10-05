using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMenu : Form
    {
        private Logic.LogicUser _logicUser = new Logic.LogicUser();

        private string _cellId;
        private string _cellUser;
        private bool _emptyRow;
        private string _messageInfo;

        #region "Prop Object"
        public object DaGrViUsuariosProp { get { return DaGrViUsuarios.DataSource; } set { DaGrViUsuarios.DataSource = value; } }

        public bool BtnActualizarEnabledProp { get { return BtnActualizar.Enabled; } set { BtnActualizar.Enabled = value; } }

        public bool BtnEliminarEnabledProp { get { return BtnEliminar.Enabled; } set { BtnEliminar.Enabled = value; } }
        #endregion

        public FrmMenu()
        {
            InitializeComponent();
        }

        public void SyncDaGrViUsuarios()
        {
            DaGrViUsuariosProp = _logicUser.LogicGetUsers(ref _emptyRow);
            if (_emptyRow == true)
            {
                MessageBox.Show("No hay Usuarios para Mostrar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnActualizarEnabledProp = false;
                BtnEliminarEnabledProp = false;
            }
            else
            {
                BtnActualizarEnabledProp = true;
                BtnEliminarEnabledProp = true;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            SyncDaGrViUsuarios();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var _frmUser = new FrmUser(this, _cellId);
            _frmUser.BtnActualizarEnabledProp = false;
            _frmUser.ShowDialog();
        }

        private void DaGrViUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _cellId = DaGrViUsuarios.CurrentRow.Cells[0].Value.ToString();
                _cellUser = DaGrViUsuarios.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (_cellId == null)
            {
                MessageBox.Show("Seleccione el Usuario que Desea Eliminar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var confirm = MessageBox.Show("Esta Seguro de Eliminar el Usuario"+" "+_cellUser, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    if (_logicUser.LogicDeleteUser(_cellId, ref _messageInfo) == true)
                    {
                        MessageBox.Show(_messageInfo, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SyncDaGrViUsuarios();
                        _cellId = null;
                    }
                    else
                    {
                        MessageBox.Show(_messageInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _cellId = null;
                }
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            SyncDaGrViUsuarios();
        }

        private void DaGrViUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var _frmUser = new FrmUser(this, _cellId);
                _frmUser.TextNamesProp = DaGrViUsuarios.CurrentRow.Cells[1].Value.ToString();
                _frmUser.TextPasswdProp = DaGrViUsuarios.CurrentRow.Cells[2].Value.ToString();
                _frmUser.TextEmailProp = DaGrViUsuarios.CurrentRow.Cells[3].Value.ToString();
                _frmUser.ComboPerfilProp = DaGrViUsuarios.CurrentRow.Cells[4].Value.ToString();
                _frmUser.BtnEnviarEnabledProp = false;
                _frmUser.BtnLimpiarEnabledProp = false;
                _frmUser.ShowDialog();
                _cellId = null;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (_cellId == null)
            {
                MessageBox.Show("Seleccione el Usuario que Desea Actualizar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var _frmUser = new FrmUser(this, _cellId);
                _frmUser.TextNamesProp = DaGrViUsuarios.CurrentRow.Cells[1].Value.ToString();
                _frmUser.TextPasswdProp = DaGrViUsuarios.CurrentRow.Cells[2].Value.ToString();
                _frmUser.TextEmailProp = DaGrViUsuarios.CurrentRow.Cells[3].Value.ToString();
                _frmUser.ComboPerfilProp = DaGrViUsuarios.CurrentRow.Cells[4].Value.ToString();
                _frmUser.BtnEnviarEnabledProp = false;
                _frmUser.BtnLimpiarEnabledProp = false;
                _frmUser.ShowDialog();
                _cellId = null;
            }
        }
    }
}