<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <%--   <div class="row m-5">

        <%foreach (Dominio.GrupoMuscular grupoMusc in ListagrupoMusculares)
            {
        %>

        <div class="col-4">
            <div class="card m-auto mb-5" style="width: 18rem;">
                <img src="Assets/brazo2.png" class="card-img-top" alt="Assets/brazo2.png">
                <div class="card-body">
                    <h5 class="card-title"><%= grupoMusc.Descripcion %></h5>
                    <p class="card-text">Este es el grupo</p>
                    <a href="VistaEntrenador-DetalleABM.aspx?id=<%=grupoMusc.ID%>">Ver Detalles</a>
                </div>
            </div>
        </div>
        <%   } %>
    </div>--%>
    <h2>GRILLA DE EJERCICIOS POR GRUPO MUSCULAR</h2>
    <div class="container">
        <table class="table">
            <thead>
                <tr>

                    <%foreach (Dominio.GrupoMuscular grupoMusc in ListagrupoMusculares)
                        {
                    %>

                    <th><%=grupoMusc.Descripcion %></th>

                    <%   } %>
                </tr>
            </thead>
            <tr>
                <%foreach (Dominio.Ejercicio ejerci in ListaEjercicios)
                    {
                %>

                <th><%=ejerci.Nombre %></th>

                <%   } %>
            </tr>

        </table>
    </div>
</asp:Content>

