﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArticulosWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Style.css" rel="stylesheet" type="text/css" />

    <div class="jumbotron mb-3">
        <div class="text-white">
            <h1>Artículos</h1>
        </div>
    </div>

    <div class="row">
        <% foreach (Dominio.Articulos item in lista)
            {%>
        <div class="card col-sm-3 border-dark mb-3 ml-3" style="max-width: 18rem;">
            <img src="<%=item.ImagenURl%>" class="card-img-top embed-responsive-item" alt="..">
            <div class="card-body">
                <h5 class="card-title"><%= item.Nombre%></h5>
                <p class="card-text"><%=item.Descripcion %></p>
                <p class="card-text"><small class="text-muted"><%=item.Marca + " " +  item.Categoria %></small></p>
                <h6 class="mb-2"><span>$<%=item.Precio %></span></h6>
                <div class="btn-group btn-group-sm">
                    <a href="CarritoDeCompras.aspx?id=<% = item.ID %>" class="btn btn-primary btn-sm mr-1 my-1"><i class="fas fa-shopping-cart mr-1"></i>Comprar</a>
                    <a href="DetalleArticulo.aspx?id=<% = item.ID %>" class="btn btn-secondary btn-sm mr-1 my-1"><i class="fas fa-info-circle ml-1"></i>Ver Detalle</a>
                </div>
            </div>
        </div>
        <%} %>
    </div>

    <div class="input-group">
        <input type="search" class="form-control rounded" placeholder="Ingrese Nombre del artículo y presione el botón Buscar" aria-label="search" name="search" id="search" aria-describedby="search-addon" />
        <button type="button" class="btn btn-outline-primary" runat="server" id="button1" onserverclick="Unnamed_ServerClick">Buscar</button>
    </div>

</asp:Content>
