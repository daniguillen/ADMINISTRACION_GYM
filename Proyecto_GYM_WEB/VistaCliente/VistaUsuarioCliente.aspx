<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        body {
            background-image: url(../Assets/fondo.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }
    </style>


    <div id="Vista-Usuario" class="Vista-Usuario justify-content-center ms-5">

        <div id="noticias" class="d-flex justify-content-center align-items-center mb-5 mt-5">

            <div class="d-flex justify-content-center justify-content-center me-5 ms-5">
                <div class="col-2 d-flex me-2 ms-2">
                    <div class="card" style="width: 18rem;">
                        <img src="/Assets/usuario1.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title"><% =Perfil.Nombre + " " + Perfil.Apellido %> </h4>
                            <h5 class="card-text">Plan: <%=Plan.Tipo_Plan  %></h5>
                            <h5 class="card-text">Dni: <%=Perfil.DNI  %></h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                        </div>
                    </div>
                </div>

                <div class="col-8 d-flex justify-content-center m-5">

                    <asp:Label ID="LblInformacion" runat="server" Font-Size="X-Large" ForeColor="White" BorderStyle="Double" BorderColor="#009933" Text="En este Text van a recibir las noticias con respecto al gimnasio, sea horarios de feriados, o algun informacion relevante"></asp:Label>

                </div>


                <div class="col-2 d-flex me-5">
                    <div class="card" style="width: 18rem; background-image: url('/Assets/fondo_card.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">
                        <img src="/Assets/Lionel_Scaloni_-_2022.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title">Lionel Scaloni </h4>
                            <h5 class="card-text">Entrenador</h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center mt-2 ms">Solicitar Rutina</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>


        <div class="row me-5">

            <div class="card-body">
                <table id="datatablesSimple" class="table table-striped table-bordered bg-light">
                    <thead>
                        <tr>
                            <th>Hora</th>
                            <asp:Repeater ID="RepeaterUsuario" runat="server">
                                <ItemTemplate>
                                    <th><%# Eval("dia") %></th>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tr>
                    </thead>
                    <tbody>
                        <% for (int x = 8; x <= 22; x++)
                            { %>
                        <tr>
                            <td><%=x %></td>
                            <% 
                                // Recorrer cada día
                                foreach (var dia in rutinas_usuario.rutina_Ejercicios.GroupBy(e => e.dia.id))
                                {
                                    // Obtener los ejercicios para este día y hora
                                    var ejerciciosParaDiaYHora = dia.Where(e => e.hora == x);

                                    // Verificar si hay ejercicios para este día y hora
                                    if (ejerciciosParaDiaYHora.Any())
                                    { %>
                            <td>
                                <% 
                                    foreach (var ejercicio in ejerciciosParaDiaYHora)
                                    {
                                        // Iterar sobre la lista de ejercicios dentro de rutina_ejercicio
                                        foreach (var ejercicioIndividual in ejercicio.ejercicio)
                                        { %>
                                <%=ejercicioIndividual.Nombre %><br />
                                <% }
                                    }
                                %>
                            </td>
                            <% }
                                else
                                { %>
                            <td></td>
                            <% }
                                }
                            %>
                        </tr>
                        <% } %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script>
        function evento(a) {
            window.location.href = "https://localhost:44386/VistaCliente/VistaUsuarioCliente?id=" + a;
            console.log(a);
        }
    </script>
</asp:Content>
