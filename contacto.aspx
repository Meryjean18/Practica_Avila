<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="Tienda.contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h2>Contáctenos</h2>
    <fieldset>
        <legend>Información Personal
        </legend>

        <label for="nombre">Nombre:</label>
        <input type="text" placeholder="Ingrese el nombre" id="nombre" />

        <label for="email">Email:</label>
        <input type="email" placeholder="Ingrese el email" id="email" />

        <label for="telefono">Teléfono:</label>
        <input type="tel" placeholder="Ingrese el teléfono" id="telefono" />

        <label for="mensaje">Mensaje:</label>
        <textarea id="mensaje"></textarea>
    </fieldset>

    <input class="boton" type="submit" value="Enviar" />
</asp:Content>
