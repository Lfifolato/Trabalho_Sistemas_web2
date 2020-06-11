using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login
{
    public partial class Adicionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            var senhacrip = BCrypt.Net.BCrypt.HashPassword(txtSenha.Text);

            MySqlCommand cmd = new MySqlCommand();


            try
            {
                string login = txtLogin.Text;

                cmd.Connection = Conexao.Connection;

                cmd.CommandText = @"select login
                                    from usuario
                                    where login=@login_User";

                cmd.Parameters.AddWithValue("login_User", login);

                Conexao.Conectar();

                string loginDB = Convert.ToString(cmd.ExecuteScalar());

                if (login == loginDB)
                {

                    lblResultado.Text = "Login Ja Cadastrado";
                }
                else
                {
                    cmd.CommandText = @"insert into usuario(
                                  nome, login, email, senha, nivel)
                                  values
                                  (@nome, @login, @email, @senha, @nivel)";

                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("nivel", ddlNivel.Text);
                    cmd.Parameters.AddWithValue("senha", senhacrip);


                    cmd.ExecuteNonQuery();
                    Response.Redirect("ListaUser.aspx");
                }

                               
            }
            catch ( Exception ex )
            {
                lblResultado.Text = "Falha:" + ex.Message;
            }
            finally
            {

                Conexao.Desconectar();

            }

        }
    }
}