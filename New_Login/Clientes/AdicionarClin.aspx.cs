using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Clientes
{
    public partial class AdicionarClin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();



            try
            {
                string cpf = txtCpf.Text;

                cmd.Connection = Conexao.Connection;

                cmd.CommandText = @"select cpf
                                    from clientes
                                    where cpf=@cpf_cli";

                cmd.Parameters.AddWithValue("cpf_cli", cpf);

                Conexao.Conectar();

                string Cnpj_Forn = Convert.ToString(cmd.ExecuteScalar());

                if (cpf == Cnpj_Forn)
                {

                    lblResultado.Text = "CPF Ja cadastrado ";
                }
                else
                {
                    cmd.CommandText = @"insert into clientes(
                                  nome, cpf, ddd, celular, telefone, curva, email, status)
                                  values
                                  (@nome, @cpf, @ddd, @celular, @telefone, @curva, @email, @status)";

                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("ddd", txtDdd.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("curva", ddlCurva.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("status", ddStatus.Text);


                    cmd.ExecuteNonQuery();
                    Response.Redirect("Listaclin.aspx");
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