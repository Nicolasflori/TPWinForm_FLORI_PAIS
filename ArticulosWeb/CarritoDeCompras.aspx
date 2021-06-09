<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="ArticulosWeb.CarritoDeCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />

    <div class="jumbotron mb-3 ">
        <div class="text-white">
            <h1>Carrito de Compras</h1>
        </div>
    </div>
<table class="table">
      <thead>
    <tr>
      <th scope="col">Modelo</th>
      <th scope="col">Marca</th>
      <th scope="col">Precio</th>
      <th scope="col">Cantidad</th>
      <th scope="col">Eliminar del Carrito</th>
    </tr>
  </thead>
      <tbody>
  <asp:Repeater runat="server" ID="Repetidor"> 

        <ItemTemplate> 
            <tr> 
                <td><%#Eval("Articulos.Nombre")%></td> 
                <td><%#Eval("Articulos.Marca")%></td> 
                <td>$<%#Eval("Articulos.Precio")%></td> 
                <td><asp:TextBox TextMode="Number" ID="Cantidad" runat ="server" AutoPostBack="true" placeholder="1" ></asp:TextBox></td>            
                    <td> 
                       <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="buttonEliminar_Click" CommandArgument='<%#Eval("Articulos.ID")%>' runat="server" /> 
                    </td> 
                </tr>  
        </ItemTemplate> 
    </asp:Repeater> 
          
            </tbody>
        </table>
    <button class="btn btn-primary"><i class="fas fa-shopping-cart mr-1"></i> Comprar</button>
    <button class="btn btn-secondary" runat="server" onserverclick="Unnamed_ServerClick"> Agregar más artículos</button>

</asp:Content>
