using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Tienda
{
    public partial class producto_editar : System.Web.UI.Page
    {
        string idProducto = string.Empty;
        string strConexion = "Server=Meryjean18; Database=Tienda; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            idProducto = Request.QueryString["id"];
            if (string.IsNullOrEmpty(idProducto))
            {
                Response.Redirect("productos.aspx");
            }

            if (!Page.IsPostBack)
            {
                cargarDatosProducto();
            }
        }

        void cargarDatosProducto()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                var sql = "Select * From Producto Where IdProducto=@id";
                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@id", idProducto);
                    var reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtMarca.Text = reader["Marca"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtObservacion.Text = reader["Observacion"].ToString();
                    }
                }
            }
        }

        protected void actualizar(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var marca = txtMarca.Text;
            var precio = txtPrecio.Text;
            var observacion = txtObservacion.Text;

            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                var sql = "Update Producto Set Nombre=@nombre, Marca=@marca, " +
                    "Precio=@precio, Observacion=@observacion " +
                    "Where IdProducto=@id";
                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@observacion", observacion);
                    command.Parameters.AddWithValue("@id", idProducto);
                    int filas = command.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        var script = "alert('Datos actualizados'); ";
                        script += "window.location='productos.aspx';";
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "mensaje", script, true);
                    }
                }
            }
        }
    }
}