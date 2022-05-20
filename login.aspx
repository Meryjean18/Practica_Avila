<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tienda.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="form-login">
        <h2>Iniciar Sesión</h2>
        <asp:ValidationSummary ID="vsErrores" runat="server" CssClass="errores" />

        <label for="txtUsuario">Usuario:</label>
        <div class="validacion-control">
            <input type="text" id="txtUsuario" runat="server" />
            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server"
                ErrorMessage="El nombre de usuario es requerido."
                ControlToValidate="txtUsuario"
                CssClass="span-error">*</asp:RequiredFieldValidator>
        </div>

        <label for="txtPassword">Contraseña:</label>
        <div class="validacion-control">
            <input type="password" id="txtPassword" runat="server" />
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                ErrorMessage="La contraseña es requerida."
                ControlToValidate="txtPassword"
                CssClass="span-error">*</asp:RequiredFieldValidator>
        </div>

        <button type="button" class="boton" runat="server" onserverclick="iniciarSesion">Iniciar</button>
    </div>

</asp:Content>
