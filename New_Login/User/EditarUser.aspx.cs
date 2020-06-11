using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.User
{
    public partial class EditarUser : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (CapturaID())
                {
                    DadosConsulta();
                }
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
            var idFunc = ObterIDCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from usuario
                                    where id = @id";

                cmd.Parameters.AddWithValue("@id", idFunc);
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
                    lblResultado.CssClass = "text-danger";
                    lblResultado.Text = "Login Ja Cadastrado";
                }
                else
                {

                    cmd.CommandText = @"update usuario
                                    set nome = @nome,
                                    login = @login,
                                    email = @email,
                                    nivel = @nivel                                   
                                    where id = @id_User;";

                    cmd.Parameters.AddWithValue("id_User", txtID.Text);
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("nivel", txtNivel.Text);



                    cmd.ExecuteNonQuery();

                    Response.Redirect("listaUser.aspx");

                }

            }
            catch (Exception ex)
            {
                lblResultado.CssClass = "text-danger";
                lblResultado.Text = "Falha: " + ex.Message;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

    }
}
