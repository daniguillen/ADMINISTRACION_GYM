<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaPrincipalEntrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaPrincipalEntrenador" %>
<asp:Content ID="NavbarEntrenador" ContentPlaceHolderID="NavbarEntrenador" runat="server">


        <nav class="navbar navbar-expand-lg bg-body-tertiary navbar-dark bg-dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">NOMBREGYM</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="nav-link active" aria-current="page" href="VistaPerfilEntrenador.aspx">Mi perfil</a>
                    <a class="nav-link active" href="VistaEntrenador-Usuarios.aspx">Usuarios</a>
                    <a class="nav-link active" href="VistaEntrenador-EntrenamientosABM.aspx">Entrenamientos</a>
                    <a class="nav-link active" href="VistaEntrenador-Clases.aspx">Clases</a>
                    <a class="btn btn-danger" href="Login.aspx">Cerrar Sesion</a>
                </div>
            </div>
        </div>
    </nav>


</asp:Content>
