using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_Login
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string nivel = Session["Perfil"].ToString();
            if (nivel == "O")
            {
                btnAdm.Visible = false;
            }



        }

        
    }
}