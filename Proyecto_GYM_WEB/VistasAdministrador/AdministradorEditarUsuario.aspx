<%@ Page Title="" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AdministradorEditarUsuario.aspx.cs"
    Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorEditarUsuario" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
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


  <div class="container panel mt-5">
    <h2 class="text-center mb-4 text-white">Historial de Usuario</h2>
    
    <div class="row mb-3 text-white">
        <div class="col-md-3">
            <strong>Nombre:</strong>
        </div>
        <div class="col-md-9">
            Juan Pérez
        </div>
    </div>
    
    <div class="row mb-3 text-white">
        <div class="col-md-3">
            <strong>Edad:</strong>
        </div>
        <div class="col-md-9">
            30 años
        </div>
    </div>
    
    <div class="row mb-3 text-white">
        <div class="col-md-3">
            <strong>Fecha de inicio:</strong>
        </div>
        <div class="col-md-9">
            01/01/2023
        </div>
    </div>
    
    <div class="row mb-3 text-white">
        <div class="col-md-3">
            <strong>Entrenador:</strong>
        </div>
        <div class="col-md-9">
            Diego Martínez
        </div>
    </div>
    
    <div class="row mb-3 text-white panel">
        <div class="col-md-12">
            <h4>Historial de Sesiones</h4>
            <table class="table text-white">
                <thead class="text-white">
                    <tr>
                        <th>#</th>
                        <th>Fecha</th>
                        <th>Descripción</th>
                        <th>Duración</th>
                    </tr>
                </thead>
                <tbody class="text-white">
                    <tr>
                        <td class="text-white">1</td>
                        <td class="text-white">05/01/2023</td>
                        <td class="text-white">Entrenamiento de fuerza</td>
                        <td class="text-white">1 hora</td>
                    </tr>
                    <tr>
                        <td class="text-white">2</td>
                        <td class="text-white">08/01/2023</td>
                        <td class="text-white">Cardio</td>
                        <td class="text-white">45 minutos</td>
                    </tr>
                    <tr>
                        <td class="text-white">3</td>
                        <td class="text-white">12/01/2023</td>
                        <td class="text-white">Flexibilidad</td>
                        <td class="text-white">30 minutos</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-12 text-white">
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Volver" />
        </div>
    </div>
    
</div>







</asp:Content>
