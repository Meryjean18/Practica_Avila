using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Tienda
{
    public partial class _default : System.Web.UI.Page
    {

        string strConexion = "Server=Meryjean18; Database=Tienda; Integrated Security=true;";
        //string strConexion = "Server=(local); Database=Tienda; UserId = SA; password=123456";
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCategorias();
        }

        void cargarDatos()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                string sql = "SELECT IdProducto, A.Nombre, Marca, Foto, Precio, B.Nombre AS Categoria " +
                    "FROM Producto A Inner Join Categoria B ON A.IdCategoria = B.IdCategoria";

                using (var command = new SqlCommand(sql, conexion))
                {
                    var ds = new DataSet();
                    var da = new SqlDataAdapter(command);
                    da.Fill(ds);
                    

                    rpDatos.DataSource = ds;
                    rpDatos.DataBind();
                }
            }
        }

        void cargarCategorias()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                using (var command = new SqlCommand("select IdProducto, P.Nombre, Marca, Precio, Stock, P.Observacion, foto, C.Nombre as 'Categoria' from Producto P inner join Categoria C on P.IdCategoria = C.IdCategoria", conexion))
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

        protected void seleccionarCategoria(object sender, EventArgs e)
        {
            Response.Write(ddlCategoria.SelectedIndex);
        }

        void cargarMarcas()
        {
            using (var conexion = new SqlConnection(strConexion))
            {
                conexion.Open();
                using (var command = new SqlCommand("Select * From Marcas", conexion))
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

        protected void seleccionarMarca(object sender, EventArgs e)
        {
            Response.Write(ddlMarca.SelectedIndex);
        }

    }
}