<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }
    </style>


    <div id="Vista-Usuario" class="Vista-Usuario justify-content-center">

        <div id="noticias" class="d-flex justify-content-center align-items-center mb-5 mt-5">

            <div class="row w-100">
                <div class="col-4 d-flex justify-content-center">
                    <div class="card" style="width: 18em; background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">

                        <img src="<%=Perfil.Foto %>" class="card-img-top" alt="....">
                        <div class="card-body">
                            <h4 class="card-title"><% =Perfil.Nombre + " " + Perfil.Apellido %> </h4>
                            <h5 class="card-text">Plan: <%=Perfil.plan.Tipo_Plan  %></h5>
                            <h5 class="card-text">Dni: <%=Perfil.DNI  %></h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx"
                                class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                        </div>
                    </div>

                </div>

                <div class="col-4 d-flex justify-content-center panel">
                    <!-- se saco el mensaje  aca en la propiedad Text-->
                    <asp:Label ID="LblInformacion" runat="server" Class="w-100" Font-Size="X-Large"
                        ForeColor="White" BorderStyle="Double" BorderColor="#009933"></asp:Label>

                </div>

                <div class="col-4 d-flex justify-content-center ">
                    <div class="card" style="width: 18em; background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">
                        <img src="/Assets/Lionel_Scaloni_-_2022.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title">Lionel Scaloni </h4>
                            <h5 class="card-text">Entrenador</h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx?id=2" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center mt-2 ms">Solicitar Nueva Rutina</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class=" mb-5 d-flex justify-content-center">

            <asp:DropDownList ID="DdlrutinaCLiente" runat="server" CssClass="form-control" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="DdlrutinaCLiente_SelectedIndexChanged">
                <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                <asp:ListItem Text="Rutina Básica" Value="1"></asp:ListItem>
                <asp:ListItem Text="Rutina Estándar" Value="2"></asp:ListItem>
                <asp:ListItem Text="Rutina Premium" Value="3"></asp:ListItem>
                <asp:ListItem Text="Rutina Personalizada" Value="4"></asp:ListItem>
            </asp:DropDownList>

        </div>
        <div class="row me-5 ms-5 row">
            <div class="card-body">
                <table id="datatablesSimple"
                    class="table table-striped table-bordered table table-dark table-hover">
                    <thead>
                        <tr>
                            <th>Hora</th>
                            <th>LUNES</th>
                            <th>MARTES</th>
                            <th>MIERCOLES</th>
                            <th>JUEVES</th>
                            <th>VIERNES</th>
                            <th>SABADO</th>
                            <th>DOMINGO</th>
                        </tr>
                    </thead>
                    <tbody>
                        <% for (int x = 8; x <= 22; x++)
                            { %>
                        <!-- Bucle para las horas -->
                        <tr>
                            <td><%= x %></td>
                            <!-- Mostrar la hora -->

                            <!-- LUNES -->
                            <td>
                                <% 
                                    var ejerciciosLunes = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 5 && e.hora == x);
                                    if (ejerciciosLunes.Any())
                                    {
                                        foreach (var ejercicioLunes in ejerciciosLunes)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioLunes.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                    }
                                } %>
                            </td>

                            <!-- MARTES -->
                            <td>
                                <% 
                                    var ejerciciosMartes = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 5 && e.hora == x);
                                    if (ejerciciosMartes.Any())
                                    {
                                        foreach (var ejercicioMartes in ejerciciosMartes)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioMartes.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>

                            <!-- MIÉRCOLES -->
                            <td>
                                <% 
                                    var ejerciciosMiercoles = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 5 && e.hora == x);
                                    if (ejerciciosMiercoles.Any())
                                    {
                                        foreach (var ejercicioMiercoles in ejerciciosMiercoles)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioMiercoles.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>

                            <!-- JUEVES -->
                            <td>
                                <% 
                                    var ejerciciosJueves = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 5 && e.hora == x);
                                    if (ejerciciosJueves.Any())
                                    {
                                        foreach (var ejercicioJueves in ejerciciosJueves)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioJueves.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>

                            <!-- VIERNES -->
                            <td>
                                <% 
                                    var ejerciciosViernes = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 6 && e.hora == x);
                                    if (ejerciciosViernes.Any())
                                    {
                                        foreach (var ejercicioViernes in ejerciciosViernes)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioViernes.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>

                            <!-- SÁBADO -->
                            <td>
                                <% 
                                    var ejerciciosSabado = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 6 && e.hora == x);
                                    if (ejerciciosSabado.Any())
                                    {
                                        foreach (var ejercicioSabado in ejerciciosSabado)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioSabado.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>
                            <!-- DOMINGO -->
                            <td>
                                <% 
                                    var ejerciciosDomingo = rutinas_usuario.rutina_Ejercicios
                                        .Where(e => e.dia.id == 7 && e.hora == x);
                                    if (ejerciciosDomingo.Any())
                                    {
                                        foreach (var ejercicioDomingo in ejerciciosDomingo)
                                        { // Itera sobre cada Rutina_ejercicio
                                            foreach (var ejercicio in ejercicioDomingo.ejercicio)
                                            { // Itera sobre la lista de ejercicios%>
                                <%= ejercicio.Nombre %><br />
                                <%     }
                                        }
                                    } %>
                            </td>
                        </tr>
                        <% } %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <script>
        function evento(element) {
            var dia = element.dataset.dia;
            window.location.href = "https://localhost:44386/VistaCliente/Vista_Detalle_Ejericios_Clientes.aspx?id=" + dia;
            console.log(dia);
        }
    </script>
</asp:Content>
