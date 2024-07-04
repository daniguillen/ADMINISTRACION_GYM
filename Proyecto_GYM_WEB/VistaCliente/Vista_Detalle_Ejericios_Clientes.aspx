<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vista_Detalle_Ejericios_Clientes.aspx.cs" Inherits="Proyecto_GYM_WEB.Vista_Detalle_Ejericios_Clientes" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <main style="background-color: black">

        <div class="d-flex justify-content-center mt-4">

            <h1>Rutina <%=dia_rutina.dia %></h1>
        </div>
        <div class="container mt-0">
              <asp:Button ID="btnvolver" runat="server" Text="🢀" OnClick="btnvolver_Click" />
          <% foreach (var rutinaEjercicio in rutina_usuario.rutina_Ejercicios.Where(e => e.dia.id == dia_rutina.id)) { %>
                    <% foreach (var ejercicio in rutinaEjercicio.ejercicio) { %>
            <div class="row d-flex justify-content-center">

                <div class="col-7 justify-content-center mt-4">
                         <h2><%=ejercicio.Nombre %></h2>
                </div>

                <div class="col-6">

                    <div class="fluid-width-video-wrapper ">

                        <iframe width="560" height="315" src="<%=ejercicio.Video %>" title="<%=ejercicio.Nombre %>" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
                        <p>Su navegador no soporta vídeos HTML5.</p>

                    </div>
                </div>

                <div class="col-4 ">
                    <div class="align-items-center">
                                     <h4>Nombre: <%=ejercicio.Nombre %></h4>
                                    <h4>Tipo: <%=ejercicio.Tipo_Ejercicio.Descripcion %></h4>
                                    <h4>Dificultad: <%=ejercicio.Tipo_Dificultad.Descripcion %></h4>
                                    <h4>Grupo Muscular: <%=ejercicio.Grupo_Muscular.Descripcion %></h4>
                                    <h4>Repeticiones: <%=ejercicio.Repeticiones %></h4>
                    </div>
                </div>
            </div>
            <%} %>
              <% } %>
             
        </div>
        <div class="container2">
            <div class="row mb-4">
                <div class="col-md-3 offset-md-3">
                    <a href=" /VistaCliente/VistaUsuarioCliente.aspx" type="button" class="btn btn-success">Solicitar Nueva Rutina</a>
                </div>
                <div class="col-md-3 offset-md-3">
                    <a href=" /VistaCliente/VistaUsuarioCliente.aspx" type="button" class="btn btn-success">Volver</a>
                </div>
            </div>


        </div>









    </main>
</asp:Content>



