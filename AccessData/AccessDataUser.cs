using System;
using System.Data;
using System.Data.SqlClient;

namespace AccessData
{
    public class AccessDataUser
    {
        private string strConnect = @"Database=admin;Server=DESKTOP-SMIDFR1\SQLEXPRESS;Integrated Security=SSPI";

        public bool AddUser(string name, string passwd, string email, string profile, ref string messageInfo)
        {
            var success = true;
            try
            {
                using (SqlConnection _sqlConnect = new SqlConnection(strConnect))
                {
                    var _sqlCommand = new SqlCommand();
                    _sqlConnect.Open();
                    var sqlInsert = "INSERT INTO [dbo].[users] ([name],[passwd],[email],[profile],[created_at],[updated_at]) VALUES (@NAME,@PASSWD,@EMAIL,@PROFILE,GETDATE(),GETDATE())";
                    _sqlCommand = new SqlCommand(sqlInsert, _sqlConnect);
                    _sqlCommand.Parameters.Add(new SqlParameter("@NAME", name));
                    _sqlCommand.Parameters.Add(new SqlParameter("@PASSWD", passwd));
                    _sqlCommand.Parameters.Add(new SqlParameter("@EMAIL", email));
                    _sqlCommand.Parameters.Add(new SqlParameter("@PROFILE", profile));
                    _sqlCommand.CommandType = CommandType.Text;
                    var execInsert = _sqlCommand.ExecuteNonQuery();
                    _sqlConnect.Close();
                    if (execInsert == 0)
                    {
                        success = false;
                        messageInfo = "Error al Agregar Usuario";
                    } else
                    {
                        success = true;
                        messageInfo = "Usuario Agregado Exitosamente!";
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return success;
        }

        public DataTable GetUsers(ref bool emptyRow)
        {
            var _dtUsers = new DataTable();
            try
            {
                var _dsUsers = new DataSet();
                using (SqlConnection _sqlConnect = new SqlConnection(strConnect))
                {
                    var _sqlCommand = new SqlCommand();
                    var _sqlDataAdapter = new SqlDataAdapter();
                    _sqlConnect.Open();
                    var sqlSelect = "SELECT [id],[name],[passwd],[email],[profile],[created_at],[updated_at] FROM[dbo].[users]";
                    _sqlCommand = new SqlCommand(sqlSelect, _sqlConnect);
                    _sqlCommand.CommandType = CommandType.Text;
                    _sqlDataAdapter.SelectCommand = _sqlCommand;
                    _sqlDataAdapter.Fill(_dsUsers,"dsUser");
                    _sqlConnect.Close();
                    if (_dsUsers.Tables[0].Rows.Count > 0)
                    {
                        _dtUsers = _dsUsers.Tables[0];
                        emptyRow = false;
                    } else
                    {
                        _dtUsers = _dsUsers.Tables[0];
                        emptyRow = true;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return _dtUsers;
        }

        public bool DeleteUser(string id, ref string messageInfo)
        {
            var success = true;
            try
            {
                using (SqlConnection _sqlConnect = new SqlConnection(strConnect))
                {
                    var _sqlCommand = new SqlCommand();
                    _sqlConnect.Open();
                    var sqlDelete = "DELETE FROM [dbo].[users] WHERE id = @ID";
                    _sqlCommand = new SqlCommand(sqlDelete, _sqlConnect);
                    _sqlCommand.Parameters.Add(new SqlParameter ("@ID", id));
                    _sqlCommand.CommandType = CommandType.Text;
                    var exec = _sqlCommand.ExecuteNonQuery();
                    _sqlConnect.Close();
                    if (exec == 0)
                    {
                        success = false;
                        messageInfo = "Error al Eliminar Usuario :(";
                    } else
                    {
                        success = true;
                        messageInfo = "Usuario Eliminado Exitosamente!";
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return success;
        }

        public bool UpdateUser(string id, string name, string passwd, string email, string profile, ref string messageInfo)
        {
            var success = true;
            try
            {
                using (SqlConnection _sqlConnect = new SqlConnection(strConnect))
                {
                    var _sqlCommand = new SqlCommand();
                    _sqlConnect.Open();
                    var _sqlUpdate = "UPDATE [dbo].[users] SET [name] = @NAME, [passwd] = @PASSWD, [email] = @EMAIL, [profile] = @PROFILE, [updated_at] = GETDATE() WHERE id = @ID";
                    _sqlCommand = new SqlCommand(_sqlUpdate, _sqlConnect);
                    _sqlCommand.Parameters.Add(new SqlParameter("@ID", id));
                    _sqlCommand.Parameters.Add(new SqlParameter("@NAME", name));
                    _sqlCommand.Parameters.Add(new SqlParameter("@PASSWD", passwd));
                    _sqlCommand.Parameters.Add(new SqlParameter("@EMAIL", email));
                    _sqlCommand.Parameters.Add(new SqlParameter("@PROFILE", profile));
                    _sqlCommand.CommandType = CommandType.Text;
                    var execUpdate = _sqlCommand.ExecuteNonQuery();
                    _sqlConnect.Close();
                    if (execUpdate == 0)
                    {
                        success = false;
                        messageInfo = "Error al Actualizar Usuario :(";
                    }
                    else
                    {
                        success = true;
                        messageInfo = "Usuario Actualizado Exitosamente!";
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return success;
        }
    }
}
