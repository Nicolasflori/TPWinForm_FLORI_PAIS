<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArticulosWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Articulos</h1>
    </div>
    <div class="container">
        <div class="row" >
            <% foreach (Dominio.Articulos item in lista)
                {
            %>
            <div class="card" >
                <div class="embed-responsive embed-responsive-4by3">
                <img src="<%=item.ImagenURl%>" class="card-img-top embed-responsive-item" alt="..." >
                    </div>
                <div class="card-body">
                    <h5 class="card-title"><%= item.Nombre%></h5>
                    <p class="card-text"><%=item.Descripcion %></p>
                    <p class="card-text"><small class="text-muted"><%=item.Marca + " " +  item.Categoria %></small></p>
                    <p class="card-text"><%=item.Precio %></></p>
                    <a href="DetalleArticulo.aspx?id=<% = item.ID %>" class="btn btn-primary">Ver Detalle</a>
                    <a href="CarritoDeCompras.aspx?id=<% = item.ID %>&e=t"><i class="fas fa-shopping-basket"></i></a>
                     
                    
                </div>
            </div>
            <%} %>
        </div>
    </div>

</asp:Content>
