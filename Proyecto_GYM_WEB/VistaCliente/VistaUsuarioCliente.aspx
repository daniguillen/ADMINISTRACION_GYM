<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">


    <div id="noticias" class="d-flex justify-content-center align-items-center mb-5">

        <div class="row">
            <div class="col-2">
                <div class="card" style="width: 18rem;">
                    <img src="/Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
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
                <img src="/Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                <div class="card-body">
                    <h5 class="card-title">Entrenador</h5>
                    <p class="card-text">datos</p>
                    <a href="VistaPerfilEntrenador.aspx" class="btn btn-primary">Ver Perfil</a>
                </div>
            </div>
        </div>

    </div>

    <div class="row">

        <div class="row">
            <% for (int x = 0; x < 7; x++)
                {
                    DayOfWeek dia = (DayOfWeek)x; // Obtén el día de la semana
                    var ejerciciosDelDia = RutinaCliente.ejercicio.Where(e => e.Dia == dia.ToString()).ToList();
                    // Filtra la lista de ejercicios para el día actual

                    if (ejerciciosDelDia.Count > 0)
                    { // Solo muestra la tarjeta si hay ejercicios para el día
            %>
            <div class="card" style="width: 18rem;">
                <h3><%=dia.ToString() %></h3>
                <div class="card-body">
                    <h5 class="card-title">Ejercicios</h5>
                    <ul>
                        <% foreach (var ejercicio in ejerciciosDelDia)
                            { %>
                        <li><%=ejercicio.Nombre %></li>
                        <% } %>
                    </ul>
                    <a href="/VistaCliente/Vista_Detalle_Ejericios_Clientes" class="btn btn-primary">Ver Ejercicios</a>
                </div>
            </div>
            <% } // Cierra el if 
                } %>
        </div>


    </div>


</asp:Content>

