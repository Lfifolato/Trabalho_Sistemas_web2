using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

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
            string query = @"select id, nome, nivel  from usuario";
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

        protected void rptUsuarios_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            
            string nivel = Session["Perfil"].ToString();
            var lnkEditar = (LinkButton)e.Item.FindControl("lnkEditar");
            var lnkRemover = (LinkButton)e.Item.FindControl("lnkRemover");

            if (lnkEditar != null && lnkRemover != null && nivel == "O")
            {
                lnkEditar.Visible = false;
                lnkRemover.Visible = false;
            }
        }
    }
}