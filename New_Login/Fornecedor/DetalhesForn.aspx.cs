using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Fornecedor
{
    public partial class DetalhesForn : System.Web.UI.Page
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

                cmd.CommandText = @"select * from fornecedor
                                    where id =@id";

                cmd.Parameters.AddWithValue("@id", idUser);
                Conexao.Conectar();

                var render = cmd.ExecuteReader();

                while (render.Read())
                {
                    txtId.Text = render["id"].ToString();
                    txtRazao.Text = render["razao"].ToString();
                    txtCnpj.Text = render["cnpj"].ToString();
                    txtCusto.Text = render["cen_custo"].ToString();
                    txtRespon.Text = render["respon"].ToString();
                    txtTelefone.Text = render["telefone"].ToString();
                    txtCep.Text = render["cep"].ToString();
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
    }
}