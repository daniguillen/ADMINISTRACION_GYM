<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div id="noticias" class="d-flex justify-content-center align-items-center mb-5"  >

    <asp:Label ID="LblInformacion" runat="server" Font-Size="Large" BorderStyle="Double" BorderColor="#009933"  Text="En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante"></asp:Label>
    </div>

    <div class="row">
        <div class="col-2">
            <div class="card" style="width: 18rem;">
                <img src="Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                <div class="card-body">
                    <h5 class="card-title">Usuario</h5>
                    <p class="card-text">datos</p>
                    <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-primary">Ver Perdil</a>
                </div>
            </div>
        </div>

        <div class="col-8">
        </div>
        <div class="col-2">
            <div class="card" style="width: 18rem;">
                <img src="Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                <div class="card-body">
                    <h5 class="card-title">Entrenador</h5>
                    <p class="card-text">datos</p>
                    <a href="VistaPerfilEntrenador.aspx" class="btn btn-primary">Ver Perfil</a>
                </div>
            </div>
        </div>

    </div>



</asp:Content>
