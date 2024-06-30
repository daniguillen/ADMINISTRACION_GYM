<%@ Page Title="" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AdministradorEditarUsuario.aspx.cs"
    Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorEditarUsuario" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2 class="text-center mb-4">Historial de Usuario</h2>
        
        <div class="row mb-3">
            <div class="col-md-3">
                <strong>Nombre:</strong>
            </div>
            <div class="col-md-9">
                Juan Pérez
            </div>
        </div>
        
        <div class="row mb-3">
            <div class="col-md-3">
                <strong>Edad:</strong>
            </div>
            <div class="col-md-9">
                30 años
            </div>
        </div>
        
        <div class="row mb-3">
            <div class="col-md-3">
                <strong>Fecha de inicio:</strong>
            </div>
            <div class="col-md-9">
                01/01/2023
            </div>
        </div>
        
        <div class="row mb-3">
            <div class="col-md-3">
                <strong>Entrenador:</strong>
            </div>
            <div class="col-md-9">
                Diego Martínez
            </div>
        </div>
        
        <div class="row mb-3">
            <div class="col-md-12">
                <h4>Historial de Sesiones</h4>
                <table class="table">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Fecha</th>
                            <th>Descripción</th>
                            <th>Duración</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>05/01/2023</td>
                            <td>Entrenamiento de fuerza</td>
                            <td>1 hora</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>08/01/2023</td>
                            <td>Cardio</td>
                            <td>45 minutos</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>12/01/2023</td>
                            <td>Flexibilidad</td>
                            <td>30 minutos</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Volver" />
            </div>
        </div>
        
    </div>







</asp:Content>
