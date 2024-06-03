<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div id="noticias" class="d-flex justify-content-center align-items-center mb-5">



        <div class="row">
            <div class="col-2">
                <div class="card" style="width: 18rem;">
                    <img src="Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                    <div class="card-body">
                        <h5 class="card-title"><% =Perfil.Nombre+" "+Perfil.Apellido %> </h5>
                        <p class="card-text"><%=Plan.Tipo_Plan  %></p>
                        <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-primary">Ver Perdil</a>
                    </div>
                </div>
            </div>

            <div class="col-8">

                <asp:Label ID="LblInformacion" runat="server" Font-Size="Large" BorderStyle="Double" BorderColor="#009933" Text="En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante"></asp:Label>
            </div>



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
    <div class="container">
        <table class="table">
          <thead >   
            <tr>
                <th></th>
                <th>Lunes</th>
                <th>Martes</th>
                <th>Miercoles</th>
                <th>Jueves</th>
                <th>Viernes</th>
                <th>Sabado</th>
                <th>Domingo</th>
            </tr>
            <tr>
                <td>1:00</td>
                <td>Peter</td>
                <td>Griffin</td>
                <td>$ejercicio

 

                    <br />
                    Hora: $horario

                </td>
                <td>$100</td>
                <td>$100</td>
                <td>$100</td>
                <td>$100</td>
            </tr>
              </thead>
        </table>


    </div>







</asp:Content>
