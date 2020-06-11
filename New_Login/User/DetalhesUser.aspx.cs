using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.User
{
    public partial class DetalhesUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (CapturaID()) 
            {
                DadosConsulta();
            }
            

        }

        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }

        private void DadosConsulta()
        {
            var idUser = ObterIdUser();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;

                cmd.CommandText = @"select * from usuario
                                    where id =@id";

                cmd.Parameters.AddWithValue("@id", idUser);
                Conexao.Conectar();

                var render = cmd.ExecuteReader();

                while (render.Read())
                {
                    txtID.Text = render["id"].ToString();
                    txtNome.Text = render["nome"].ToString();
                    txtLogin.Text = render["login"].ToString();
                    txtEmail.Text = render["email"].ToString();
                    txtNivel.Text = render["nivel"].ToString();
                }

            }
            catch (Exception ex)
            {

                string erro = ex.Message;

            }
            finally
            {
                Conexao.Desconectar();
            }

        }

        private int ObterIdUser()
        {
            var id = 0;
            var idURL = Request.QueryString["id"];
            if (!int.TryParse(idURL, out id)) 
            {
                throw new Exception("ID Invalido");
            }
            if(id <= 0)
            {

                throw new Exception("ID Invalido");

            }
            return id;
        }
    }
}