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
    public partial class FrmUser : Form
    {
        private Model.User _modelUser = new Model.User();
        private Logic.LogicUser _logicUser = new Logic.LogicUser();
        private FrmMenu _frmMenu = new FrmMenu();

        private string _cellId;
        private string _messageInfo;

        #region "Prop Object"
        public string TextNamesProp { get { return TextNombres.Text; } set { TextNombres.Text = value; } }

        public string TextPasswdProp { get { return TextPasswd.Text; } set { TextPasswd.Text = value; } }

        public string TextEmailProp { get { return TextEmail.Text; } set { TextEmail.Text = value; } }

        public string ComboPerfilProp { get { return ComboPerfil.Text; } set { ComboPerfil.Text = value; } }

        public bool BtnEnviarEnabledProp { get { return BtnEnviar.Enabled; } set { BtnEnviar.Enabled = value; } }

        public bool BtnLimpiarEnabledProp { get { return BtnLimpiar.Enabled; } set { BtnLimpiar.Enabled = value; } }

        public bool BtnActualizarEnabledProp { get { return BtnActualizar.Enabled; } set { BtnActualizar.Enabled = value; } }
        #endregion

        public FrmUser(FrmMenu FrmMenu, string cellId)
        {
            InitializeComponent();
            ComboPerfil.SelectedIndex = 0;
            _frmMenu = FrmMenu;
            _cellId = cellId;
        }

        public void SyncModel()
        {
            _modelUser.Name = TextNamesProp;
            _modelUser.Passwd = TextPasswdProp;
            _modelUser.Email = TextEmailProp;
            _modelUser.Profile = ComboPerfilProp;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiarFormUsuario_Click(object sender, EventArgs e)
        {
            TextNamesProp = "";
            TextPasswdProp = "";
            TextEmailProp = "";
            ComboPerfilProp = "Seleccione...";
        }

        private void BtnSendFormUsuario_Click(object sender, EventArgs e)
        {
            SyncModel();
            if (_logicUser.Validation(_modelUser, ref _messageInfo))
            {
                if (_logicUser.LogicAddUser(_modelUser.Name, _modelUser.Passwd, _modelUser.Email, _modelUser.Profile, ref _messageInfo) == true)
                {
                    MessageBox.Show(_messageInfo, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    _frmMenu.SyncDaGrViUsuarios();
                }
                else
                {
                    MessageBox.Show(_messageInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(_messageInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SyncModel();
            if (_logicUser.Validation(_modelUser, ref _messageInfo))
            {
                if (_logicUser.LogicUpdateUser(_cellId, _modelUser.Name, _modelUser.Passwd, _modelUser.Email, _modelUser.Profile, ref _messageInfo) == true)
                {
                    MessageBox.Show(_messageInfo, "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    _frmMenu.SyncDaGrViUsuarios();
                    _cellId = null;
                }
                else
                {
                    MessageBox.Show(_messageInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(_messageInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
