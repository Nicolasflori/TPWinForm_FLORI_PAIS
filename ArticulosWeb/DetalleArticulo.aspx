<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="ArticulosWeb.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Articulo Seleccionado</h1>
    <asp:Image ID="ImageUrl" class="card-img-top embed-responsive-item" runat="server" Style="max-width: 500px" />

    <div class="card-body">
        <h5><asp:Label ID="lblNombre" runat="server" Text="Label" Font-Size="30px"></asp:Label></h5>
        <p>Descripción: <asp:Label ID="LblDescripcion" runat="server" Text="Label" Font-Size="20px"></asp:Label></p>
        <h6 class="mb-2">Precio: $<span><asp:Label ID="LblPrecio" runat="server" Text="Label" Font-Size="15px"></asp:Label></span></h6>
        <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
    </div>

</asp:Content>
