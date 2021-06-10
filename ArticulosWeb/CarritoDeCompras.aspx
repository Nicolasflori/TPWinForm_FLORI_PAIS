<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoDeCompras.aspx.cs" Inherits="ArticulosWeb.CarritoDeCompras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

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
                        <td>

                            <asp:TextBox TextMode="Number" ID="Cantidad" runat="server" AutoPostBack="true" min="1" MaxLength="20" placeholder="1"></asp:TextBox></td>
                        <td>
                            <asp:Button Text="Eliminar" CssClass="btn btn-primary" ID="btnEliminar" OnClick="buttonEliminar_Click" CommandArgument='<%#Eval("Articulos.ID")%>' runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>

    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal"><i class="fas fa-shopping-cart mr-1"></i>Comprar</button>
    <button class="btn btn-secondary" runat="server" onserverclick="Unnamed_ServerClick">Agregar más artículos</button>

    <div class="modal" id="myModal">
        <div class="modal-dialog">
            <div class="modal-content">

                <div class="modal-header">
                    <h4 class="modal-title">Comprar</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <div class="modal-body">
                    Función en desarrollo, disculpe las molestias.
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
