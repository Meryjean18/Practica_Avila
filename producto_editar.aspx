<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="producto_editar.aspx.cs" Inherits="Tienda.producto_editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h2>Editar Producto</h2>

    <a class="boton" href="productos.aspx" title="Regresar">
        <i class="fa-solid fa-circle-left"></i>
        Regresar
    </a>
    
    <fieldset>
        <legend>Datos del producto</legend>

        <label for="txtNombre">Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

        <label for="txtMarca">Marca:</label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>

        <label for="txtPrecio">Precio:</label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

        <label for="txtObservacion">Observación:</label>
        <asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine"></asp:TextBox>

    </fieldset>
    <asp:Button ID="btnAtualizar" CssClass="boton" runat="server" OnClick="actualizar" Text="Actualizar" />
</asp:Content>
