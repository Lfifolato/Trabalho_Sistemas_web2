using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Fornecedor
{
    public partial class AdicionarForn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();

           

            try
            {
                string Cnpj = txtCnpj.Text;

                cmd.Connection = Conexao.Connection;

                cmd.CommandText = @"select cnpj
                                    from fornecedor
                                    where cnpj=@cnpj_forn";

                cmd.Parameters.AddWithValue("cnpj_forn", Cnpj);

                Conexao.Conectar();

                string Cnpj_Forn = Convert.ToString(cmd.ExecuteScalar());

                if (Cnpj == Cnpj_Forn)
                {

                    lblResultado.Text = "CNPJ Ja cadastrado ";
                }
                else
                {
                    cmd.CommandText = @"insert into fornecedor(
                                  razao, cnpj, cen_custo, respon, telefone, cep, status)
                                  values
                                  (@razao, @cnpj, @cen_custo, @respon, @telefone, @cep, @status)";

                    cmd.Parameters.AddWithValue("razao", txtRazao.Text);
                    cmd.Parameters.AddWithValue("cnpj", txtCnpj.Text);
                    cmd.Parameters.AddWithValue("cen_custo",ddCusto.Text);
                    cmd.Parameters.AddWithValue("status", ddStatus.Text);
                    cmd.Parameters.AddWithValue("respon", txtRespon.Text);
                    cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("cep", txtCep.Text);


                    cmd.ExecuteNonQuery();
                    Response.Redirect("Listaforn.aspx");
                }


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