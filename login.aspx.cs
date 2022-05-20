using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarSesion(object sender, EventArgs e)
        {
            string user = txtUsuario.Value;
            string password = txtPassword.Value;

            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "mensaje", "alert('Debe completar los datos')", true);
            }

            var strConexion = "Server=Meryjean18; Database=Tienda; Integrated Security = true;";
            //var strConexion = "Server=LIMGND02; Database=Tienda; User=sa; Password=6789";
            using(var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                
            }

            if (user == "Admin" && password == "123456")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "mensaje", "alert('Usuario logueado')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "mensaje", "alert('Usuario o Password incorrecto')", true);
            }
        }
    }
}