<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="producto_crear.aspx.cs" Inherits="Tienda.producto_crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h2>Nuevo Producto</h2>
    <a class="boton" href="productos.aspx" title="Regresar">
        <i class="fa-solid fa-circle-left"></i>
        Regresar
    </a>
    <fieldset>
        <legend>Datos del Producto</legend>

        <label for="txtNombre">Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

        <label for="txtMarca">Marca:</label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>

        <label for="ddlCategoria">Categoría:</label>
        <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>

        <label for="txtPrecio">Precio:</label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

        <label for="txtStock">Stock</label>
        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>

        <label for="fuFoto">Foto:</label>
        <asp:FileUpload ID="fuFoto" runat="server" />

        <label for="txtObservacion">Observación:</label>
        <asp:TextBox ID="txtObservacion" TextMode="MultiLine" runat="server"></asp:TextBox>
    </fieldset>
    <asp:Button CssClass="boton" ID="btnRegistrar" 
        runat="server" Text="Registrar" OnClick="registrar" />
</asp:Content>
