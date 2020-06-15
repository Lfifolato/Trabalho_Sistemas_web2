﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login.Clientes
{
    public partial class ListaClin : System.Web.UI.Page
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
            string query = @"select id, nome, status, telefone from clientes";
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

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdicionarClin.aspx");
        }

        protected void rptUsuarios_ItemCommand(object source, RepeaterCommandEventArgs e)
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