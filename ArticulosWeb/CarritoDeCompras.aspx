<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="ArticulosWeb.CarritoDeCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />

    <div class="jumbotron mb-3 ">
        <div class="text-white">
            <h1>Carrito de Compras</h1>
        </div>
    </div>

    <div class="row">
        <% foreach (Dominio.ItemCarrito item in carrito)
            {
        %>
        <div class="card border-dark mb-3 ml-3" style="max-width: 18rem;">
            <img src="<%=item.Articulos.ImagenURl%>" class="card-img-top embed-responsive-item" alt="...">

            <div class="card-body">
                <h5 class="card-title"><%= item.Articulos.Nombre%></h5>
                <p class="card-text"><%=item.Articulos.Descripcion %></p>
                <p class="card-text"><small class="text-muted"><%=item.Articulos.Marca + " " +  item.Articulos.Categoria %></small></p>
                <p class="card-text"><%=item.Cantidad %></p>
                <asp:Button ID="buttonEliminar" runat="server" Text="Eliminar" OnClick="buttonEliminar_Click" CommandArgument='<% #Eval("Id") %>' />
            </div>
        </div>
        <%} %>
    </div>

    <button class="btn btn-primary"><i class="fas fa-shopping-cart mr-1"></i> Comprar</button>
    <a href="Atras.aspx?id=atras" class="btn btn-secondary">Agregar más artículos</a>

</asp:Content>
