using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.User
{
    public partial class RemoverUser : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CapturaID())
            {
                DadosConsulta();
            }
        }
        #endregion

        #region CapturaID
        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }
        #endregion

        #region DadosConsulta
        private void DadosConsulta()
        {
            var idCliente = ObterIDCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from usuario
                                    where id = @id";

                cmd.Parameters.AddWithValue("@id", idCliente);
                Conexao.Conectar();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txtNome.Text = reader["nome"].ToString();
                    txtLogin.Text = reader["login"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtNivel.Text = reader["nivel"].ToString();
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
        #endregion

        #region ObterIDCliente
        public int ObterIDCliente()
        {
            var id = 0;
            var idURL = Request.QueryString["id"];
            if (!int.TryParse(idURL, out id))
            {
                throw new Exception("ID inválido");
            }
            if (id <= 0)
            {
                throw new Exception("ID inválido");
            }
            return id;
        }


        #endregion

        protected void btnRemover_Click(object sender, EventArgs e)
        {

            var idCliente = ObterIDCliente();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"delete from usuario
                                    where id = @id";
                cmd.Parameters.AddWithValue("@id", idCliente);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();

                Response.Redirect("listaUser.aspx");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }

        }
    }
}