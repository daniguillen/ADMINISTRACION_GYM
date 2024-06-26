<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PantallaPrincipalEntrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.PantallaPrincipal" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row mt-4">
            <div class="col-4 offset-4">
                <div class="form-group">

                    <div style="text-align: center">

                        <asp:Label ID="lblBienvenida" runat="server" Text="Label"></asp:Label>
                        <h2>Menu:</h2>
                     <asp:DropDownList ID="ddlAltas" runat="server" CssClass="form-select m-1">
                            <asp:ListItem Text="Altas" Value=""></asp:ListItem>
                            <asp:ListItem Text="Nuevo Ejercicio" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Nueva Rutina" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Agregar Ejercicio a Rutina" Value="3"></asp:ListItem>

                        </asp:DropDownList>

                    </div>



                </div>
                <div class="form-group">



                    <asp:DropDownList ID="ddlModificar" runat="server" CssClass="form-select m-1">
                        <asp:ListItem Text="Modificar" Value=""></asp:ListItem>
                        <asp:ListItem Text="Modificar Ejercicio" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Modificar Rutina" Value="2"></asp:ListItem>
                    </asp:DropDownList>



                </div>



                <div class="form-group">



                    <asp:DropDownList ID="ddlListar" runat="server" CssClass="form-select m-1">
                        <asp:ListItem Text="Listar" Value=""></asp:ListItem>
                        <asp:ListItem Text="Listar Ejercicio" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Listar Rutina" Value="2"></asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>
        </div>
    </div>





</asp:Content>
