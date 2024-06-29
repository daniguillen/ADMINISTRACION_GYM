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


    <div id="Vista-Usuario" class="Vista-Usuario justify-content-center">

        <div id="noticias" class="d-flex justify-content-center align-items-center mb-5 mt-5">

            <div class ="row w-100" >
                <div class="col-4 d-flex justify-content-center" >
                    <div class="card" style="width:18em;  background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">

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

                <div class="col-4 d-flex justify-content-center">
<!-- se saco el mensaje  aca en la propiedad Text-->
                    <asp:Label ID="LblInformacion" runat="server" Class="w-100" Font-Size="X-Large" 
                        ForeColor="White" BorderStyle="Double" BorderColor="#009933" 
                        ></asp:Label>

                </div>

                <div class="col-4 d-flex justify-content-center ">
                    <div class="card" style="width:18em;  background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">
                        <img src="/Assets/Lionel_Scaloni_-_2022.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title">Lionel Scaloni </h4>
                            <h5 class="card-text">Entrenador</h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx?id=2" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center mt-2 ms">Solicitar Rutina</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>


    </div>
        <div class="row me-5 ms-5 row">

            <div class="card-body">
                <table id="datatablesSimple"
                    class="table table-striped table-bordered table table-dark table-hover">
                    <thead>
                        <tr>
                            <th>Hora</th>
                            <asp:Repeater ID="RepeaterUsuario" runat="server">
                                <ItemTemplate>
                                    <th data-dia="<%# Eval("dia") %>" onclick="evento(this)">
                                        <%# Eval("dia") %>
                                    </th>
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
    <script>
        function evento(element) {
            var dia = element.dataset.dia;
            window.location.href = "https://localhost:44386/VistaCliente/Vista_Detalle_Ejericios_Clientes.aspx?id=" + dia;
            console.log(dia);
        }
    </script>
</asp:Content>
