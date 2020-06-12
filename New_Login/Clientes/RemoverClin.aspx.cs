using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Clientes
{
    public partial class RemoverClin : System.Web.UI.Page
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

                cmd.CommandText = @"select * from clientes
                                    where id =@id";

                cmd.Parameters.AddWithValue("@id", idUser);
                Conexao.Conectar();

                var render = cmd.ExecuteReader();

                while (render.Read())
                {
                    txtId.Text = render["id"].ToString();
                    txtNome.Text = render["nome"].ToString();
                    txtCpf.Text = render["cpf"].ToString();
                    txtDdd.Text = render["ddd"].ToString();
                    txtCelular.Text = render["celular"].ToString();
                    txtTelefone.Text = render["telefone"].ToString();
                    txtCurva.Text = render["curva"].ToString();
                    txtEmail.Text = render["email"].ToString();
                    txtStatus.Text = render["status"].ToString();

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
            if (id <= 0)
            {

                throw new Exception("ID Invalido");

            }
            return id;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            var idCliente = ObterIdUser();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"delete from clientes
                                    where id = @id";
                cmd.Parameters.AddWithValue("@id", idCliente);
                Conexao.Conectar();
                cmd.ExecuteNonQuery();

                Response.Redirect("listaclin.aspx");
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