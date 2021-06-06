<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="ArticulosWeb.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Articulo Seleccionado</h1>


    <div class="card mb-3"> 
         
                <div class="embed-responsive embed-responsive-21by9">     
        <asp:Image ID="ImageUrl"  class="card-img-top embed-responsive-item" runat="server" />
  </div>
  <div class="card-body">
    <h5 class="card-title"><asp:Label ID="lblNombre" runat="server" Text="Label"  Font-Size=30px></asp:Label></h5>
    <p class="card-text"> 
    
    <asp:Label ID="LblDescripcion" runat="server" Text="Label" Font-Size=20px></asp:Label>
    <asp:Label ID="LblPrecio" runat="server" Text="Label" Font-Bold="true" Font-Size=25px></asp:Label></p>
    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
  </div>
</div>
   
   
</asp:Content>
