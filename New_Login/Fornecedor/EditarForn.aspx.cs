using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Fornecedor
{
    public partial class EditarForn : System.Web.UI.Page
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
                cmd.CommandText = @"select * from fornecedor
                                    where id = @id";

                cmd.Parameters.AddWithValue("@id", idFunc);
                Conexao.Conectar();
                var reder = cmd.ExecuteReader();

                while (reder.Read())
                {
                    txtId.Text = reder["id"].ToString();
                    txtRazao.Text = reder["razao"].ToString();
                    txtCnpj.Text = reder["cnpj"].ToString();
                    ddCusto.Text = reder["cen_custo"].ToString();
                    txtRespon.Text = reder["respon"].ToString();
                    txtTelefone.Text = reder["telefone"].ToString();
                    txtCep.Text = reder["cep"].ToString();
                    ddStatus.Text = reder["status"].ToString();
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

        protected void btnEditar_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Conexao.Connection;


            try
            {

                cmd.CommandText = @"update fornecedor
                                    set razao = @razao,
                                    cnpj = @cnpj,
                                    cen_custo = @cen_custo,
                                    status = @status,                                   
                                    respon = @respon,                                   
                                    telefone = @telefone,                               
                                    cep = @cep                                 
                                    where id = @id_Forn;";

                cmd.Parameters.AddWithValue("id_Forn", txtId.Text);
                cmd.Parameters.AddWithValue("razao", txtRazao.Text);
                cmd.Parameters.AddWithValue("cnpj", txtCnpj.Text);
                cmd.Parameters.AddWithValue("cen_custo", ddCusto.Text);
                cmd.Parameters.AddWithValue("status", ddStatus.Text);
                cmd.Parameters.AddWithValue("respon", txtRespon.Text);
                cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("cep", txtCep.Text);

                Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Response.Redirect("Listaforn.aspx");


            }
            catch (Exception ex)
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