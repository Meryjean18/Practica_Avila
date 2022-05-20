<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Tienda._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">    
    <h2>Consulta</h2> 
    <div class="consulta">
        <div>
            <label for="ddlCategoria">Categoria:</label>
            <asp:DropDownList ID="ddlCategoria" runat="server"
                AutoPostBack="true"
                OnSelectedIndexChanged="seleccionarCategoria">
                <asp:ListItem Text="Seleccione" Value="">
                </asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <label for="ddlMarca">Marca:</label>
            <asp:DropDownList ID="ddlMarca" runat="server"
                AutoPostBack="true"
                OnSelectedIndexChanged="seleccionarMarca">
                <asp:ListItem Text="Seleccione" Value="">
                </asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="productos">
        <asp:Repeater ID="rpDatos" runat="server">
            <ItemTemplate>
                <div class="producto">
                    <div class="producto-categoria">
                        <h3><%#Eval("Categoria") %></h3>
                    </div>

                    <div class="producto-detalle">
                        <div class="producto-texto">
                            <h3><%#Eval("Nombre") %></h3>
                            <p><%#Eval("Marca") %></p>
                            <p><%#Eval("Categoria") %></p>
                            <div class="producto-info">
                                <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-receipt-2" width="20" height="20" viewBox="0 0 24 24" stroke-width="1.5" stroke="#2c3e50" fill="none" stroke-linecap="round" stroke-linejoin="round">
                                    <path stroke="none" d="M0 0h24v24H0z" fill="none" />
                                    <path d="M5 21v-16a2 2 0 0 1 2 -2h10a2 2 0 0 1 2 2v16l-3 -2l-2 2l-2 -2l-2 2l-2 -2l-3 2" />
                                    <path d="M14 8h-2.5a1.5 1.5 0 0 0 0 3h1a1.5 1.5 0 0 1 0 3h-2.5m2 0v1.5m0 -9v1.5" />
                                </svg>
                                <p><%#Eval("Precio") %></p>
                            </div>                        
                        </div>
                        <div class="producto-figure">
                            <img src="<%#Eval("Foto") %>" title="<%#Eval("Nombre") %>" class="producto-foto" />
                        </div>
                    </div>
                    
                    <div class="producto-acciones">
                        <a href="#">Detalle</a>
                    </div>                    
                </div>     
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
