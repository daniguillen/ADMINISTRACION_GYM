<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AdministradorGeneral.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorGeneral" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




  <div class="mt-3">
    <a href="/RegistroPersona.aspx" class="btn btn-primary">Ir a Registro de Persona</a>
</div>
      <div class="mt-3">
    <a href="/RegistroPersona.aspx" class="btn btn-primary">Modificar</a>
</div>


    <asp:Button ID="Button4" runat="server" Text="Button" CssClass="btn btn-secondary btn-icon-split" />

    <div class="container-fluid  px-4 bg-custom-dark">
        <h1 class="mt-4">Tables</h1>
        <ul class="breadcrumb mb-4">
            <li class="breadcrumb-item">Entrenadores</li>
            <li class="breadcrumb-item active">Usuarios</li>
        </ul>
        <div class="card mb-4 ">
            <span class="card-body">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the

            </span>
        </div>
        <div class="card mb-4 ">
            <div class="card-header   ">
                <i class="fas fa-table me-1 "></i>
                DataTable Example
            </div>
            <div class="card-body ">
                <table id="datatablesSimple" class="table table-striped table-bordered bg-light    ">
                    <thead>
                        <tr>
                            <th>Dni</th>
                            <th>Nombre Completo</th>
                            <th>Plan</th>
                            <th>Celular</th>
                            <th>Tel Emergencia</th>
                            <th>Email</th>
                            <th>Password</th>
                            <th>Edad</th>
                            <th>Sexo</th>
                            <th>Fecha Ingreso</th>
                            <th>Estado</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>

                    <tbody>
                        <% foreach (var usuario in ListaUsuarios)
                            { %>
                        <tr>
                            <th><%= usuario.DNI %></th>
                            <th><%= usuario.Nombre + " " + usuario.Apellido %></th>
                            <th><%= usuario.ID_Plan %></th>
                            <th><%= usuario.Cel %></th>
                            <th><%= usuario.Tel_Emergencia %></th>
                            <th><%= usuario.Mail %></th>
                            <th><%= usuario.Password %></th>
                            <th><%= DateTime.Now.Year - usuario.Fecha_Nacimiento.Year - (usuario.Fecha_Nacimiento.Date > DateTime.Now.Date ? 1 : 0) %></th>
                            <th><%= usuario.Sexo %></th>
                            <th><%= usuario.Fecha_ingreso.Day + " / "+usuario.Fecha_ingreso.Month + " / " +usuario.Fecha_ingreso.Year %></th>
                            <th><%= usuario.Estado.ToString()=="True"?"Activo":"Inactivo" %></th>
                            <th><a href="AdministradorEditarUsuario.aspx?id=<%=usuario.ID %>" class="btn btn-secondary btn-icon-split">
                                <span class="icon text-white-50">
                                    <i class="fas fa-arrow-right"></i>
                                </span>
                                <span class="bottom-0">Editar</span>
                            </a></th>

                        </tr>
                        <% } %>
                    </tbody>

                </table>
            </div>
        </div>
    </div>






</asp:Content>
