<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto_GYM_WEB.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div>
            <asp:TextBox ID="txtMail" runat="server" placeholder="Mail" />
        </div>
        <div>
            <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" />
        </div>
        <div>
            <asp:Button ID="btnIngresoSesion" Text="Iniciar Sesión" runat="server" CssClass="btn btn-primary" />
        </div>
        <div>
            <a href="RegistroPersona.aspx">Registrarse</a>
        </div>
    </div>
</asp:Content>
