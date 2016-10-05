using System;
using System.Text.RegularExpressions;
using System.Data;

namespace Logic
{
    public class LogicUser
    {
        private AccessData.AccessDataUser _accessDataUSer = new AccessData.AccessDataUser();

        #region "Validaciones"
        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        public bool IsEmail(string input)
        {
            var RegExEmail = @"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            return !Regex.IsMatch(input, RegExEmail);
        }

        public bool Validation(Model.User _userModel, ref string messageInfo)
        {
            var success = true;
            try
            {
                if (_userModel.Name == null || _userModel.Name == string.Empty)
                {
                    success = false;
                    messageInfo = "Campo Nombre Vacio";
                }
                if (IsNumeric(_userModel.Name))
                {
                    success = false;
                    messageInfo = "Campos Nombres no Permite Números";
                }
                if (_userModel.Passwd == null || _userModel.Passwd == string.Empty)
                {
                    success = false;
                    messageInfo = "Campo Password Vacio";
                }
                if (_userModel.Email == null || _userModel.Email == string.Empty)
                {
                    success = false;
                    messageInfo = "Campo Email Vacio";
                }
                if (IsEmail(_userModel.Email))
                {
                    success = false;
                    messageInfo = "Formato Email Invalido";
                }
                if (_userModel.Profile == "Seleccione...")
                {
                    success = false;
                    messageInfo = "Seleccione un Perfil para Continuar";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return success;
        }
        #endregion

        public bool LogicAddUser(string name, string passwd, string email, string profile, ref string messageInfo)
        {
            return _accessDataUSer.AddUser(name,passwd,email,profile, ref messageInfo);
        }

        public DataTable LogicGetUsers(ref bool emptyRow)
        {
            return _accessDataUSer.GetUsers(ref emptyRow);
        }

        public bool LogicDeleteUser(string id, ref string messageInfo)
        {
            return _accessDataUSer.DeleteUser(id, ref messageInfo);
        }

        public bool LogicUpdateUser(string id, string name, string passwd, string email, string profile, ref string messageInfo)
        {
            return _accessDataUSer.UpdateUser(id,name,passwd,email,profile, ref messageInfo);
        }
    }
}