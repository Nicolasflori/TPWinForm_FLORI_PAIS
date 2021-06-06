<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="ArticulosWeb.CarritoDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row" >
            <% foreach (Dominio.ItemCarrito item in carrito)
                {
            %>
            <div class="card" >
                <div class="embed-responsive embed-responsive-4by3">
                <img src="<%=item.Articulos.ImagenURl%>" class="card-img-top embed-responsive-item" alt="..." >
                    </div>
                <div class="card-body">
                    <h5 class="card-title"><%= item.Articulos.Nombre%></h5>
                    <p class="card-text"><%=item.Articulos.Descripcion %></p>
                    <p class="card-text"><small class="text-muted"><%=item.Articulos.Marca + " " +  item.Articulos.Categoria %></small></p>
                    <p class="card-text"><%=item.Cantidad %></p>
                     <a href="CarritoDeCompras.aspx?id=<% = item.Articulos.ID %>>&e=f">Eliminar</a>
                    
                     
                    
                </div>
            </div>
            <%} %>
        </div>
    </div>
</asp:Content>
