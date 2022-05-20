using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace Tienda
{
    public partial class producto_crear : System.Web.UI.Page
    {
        string strConexion = "Server=Meryjean18; Database=Tienda; Integrated Security=true;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDatos();
            }            
        }

        void cargarDatos()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                using (var command = new SqlCommand("Select * From Categoria", conexion))
                {
                    var reader = command.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        ListItem categoria;
                        while (reader.Read())
                        {
                            categoria = new ListItem();
                            categoria.Value = reader["IdCategoria"].ToString();
                            categoria.Text = reader["Nombre"].ToString();
                            ddlCategoria.Items.Add(categoria);
                        }
                    }
                }
            }
        }

        protected void registrar(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string marca = txtMarca.Text;
            string categoria = ddlCategoria.SelectedValue;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string observacion = txtObservacion.Text;
            string foto = "/assets/img/productos/generico.png";
            string imgFile = Path.GetFileName(fuFoto.PostedFile.FileName);
            if (!string.IsNullOrEmpty(imgFile))
            {
                fuFoto.SaveAs(Server.MapPath("~/assets/img/productos/") + imgFile);
                foto = "/assets/img/productos/" + imgFile;
            }

            using (var conexion = new SqlConnection(strConexion))
            {
                var sql = "INSERT INTO Producto(Nombre, Marca, Precio, Stock, " +
                    "Observacion, Foto, IdCategoria) " +
                    "Values (@nombre, @marca, @precio, @stock, @observacion, " +
                    "@foto, @categoria)";
                using (var command = new SqlCommand(sql, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@observacion", observacion);
                    command.Parameters.AddWithValue("@foto", foto);
                    command.Parameters.AddWithValue("@categoria", categoria);
                    conexion.Open();
                    int filas = command.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        var script = "alert('Producto registrado'); " +
                            "window.location='productos.aspx';";
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "mensaje", script, true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),
                            "mensaje", "alert('No se ha podido completar la operación')", true);
                    }
                }
            }

        }
    }
}