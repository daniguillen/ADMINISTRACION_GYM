<%@ Page Title="" Language="C#" 
    MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="AdministradorEditarUsuario.aspx.cs" 
    Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorEditarUsuario" %>



<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label ID="Label1" runat="server" Text="Label">hla</asp:Label>






        <div class="container-fluid px-4 bg-custom-dark">
        <h1 class="mt-4">Tables</h1>
        <ul class="breadcrumb mb-4">
            <li class="breadcrumb-item">Entrenadores</li>
            <li class="breadcrumb-item active">Usuarios</li>
        </ul>
        <div class="card mb-4">
            <span class="card-body">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the</span>
        </div>
        <div class="card mb-4">
            <div class="card-header">
                <i class="fas fa-table me-1"></i>
                DataTable Example
            </div>
            <div class="card-body">
                <table id="datatablesSimple" class="table table-striped table-bordered bg-light">
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
                        <tr>
                            <td><%= elUsuarioEditar.DNI %></td>
                            <td><%= elUsuarioEditar.Nombre + " " + elUsuarioEditar.Apellido %></td>
                            <td><%= elUsuarioEditar.ID_Plan %></td>
                            <td><%= elUsuarioEditar.Cel %></td>
                            <td><%= elUsuarioEditar.Tel_Emergencia %></td>
                            <td><%= elUsuarioEditar.Mail %></td>
                            <td><%= elUsuarioEditar.Password %></td>
                            <td><%= DateTime.Now.Year - elUsuarioEditar.Fecha_Nacimiento.Year - (elUsuarioEditar.Fecha_Nacimiento.Date > DateTime.Now.Date ? 1 : 0) %></td>
                            <td><%= elUsuarioEditar.Sexo %></td>
                            <td><%= elUsuarioEditar.Fecha_ingreso.Day + " / " + elUsuarioEditar.Fecha_ingreso.Month + " / " + elUsuarioEditar.Fecha_ingreso.Year %></td>
                            <td><%= elUsuarioEditar.Estado ? "Activo" : "Inactivo" %></td>
                            <td>
                                <a href="#" class="btn btn-secondary btn-icon-split">
                                    <span class="icon text-white-50">
                                        <i class="fas fa-arrow-right"></i>
                                    </span>
                                    <span class="bottom-0">Guardar</span>
                                </a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>