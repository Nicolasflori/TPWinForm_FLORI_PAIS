<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="ArticulosWeb.CarritoDeCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />

    <div class="jumbotron mb-3 ">
        <div class="text-white">
            <h1>Carrito de Compras</h1>
        </div>
    </div>

  <asp:Repeater runat="server" ID="Repetidor"> 

        <ItemTemplate> 
            <tr> 
                    <td><%#Eval("Articulos")%></td> 

                    <td> 
                       <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="buttonEliminar_Click" CommandArgument='<%#Eval("Articulos.ID")%>' runat="server" /> 

                    </td> 

                </tr> 

        </ItemTemplate> 

    </asp:Repeater> 

    <button class="btn btn-primary"><i class="fas fa-shopping-cart mr-1"></i> Comprar</button>
    <a href="Atras.aspx?id=atras" class="btn btn-secondary">Agregar más artículos</a>

</asp:Content>
