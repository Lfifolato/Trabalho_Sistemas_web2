using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace New_Login
{
    public partial class Lista : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
        #endregion

        #region CarregarUsuarios
        private void CarregarUsuarios()
        {
            string query = @"select id, nome, nivel from usuario";
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, Conexao.Connection);
                da.Fill(dt);

                //Popular Repeater
                rptUsuarios.DataSource = dt;
                rptUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Falha " + ex.Message;
            }

        }
        #endregion

        #region btnAdicionar_Click
        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionarUser.aspx");
        }
        #endregion
    }
}