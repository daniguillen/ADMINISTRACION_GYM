<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vista_Detalle_Ejericios_Clientes.aspx.cs" Inherits="Proyecto_GYM_WEB.Vista_Detalle_Ejericios_Clientes" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <main  style="background-color:black">

        <div class="d-flex justify-content-center mt-4">

        <h1>Rutina Lunes</h1>
        </div>
       <div class="container mt-0">
            <%for (int x = 0; x < 5; x++)
                {  %>
        <div class="row d-flex justify-content-center" >

             <div class="col-7 justify-content-center mt-4" >
                 <h2>Titulo Ejercicio</h2>
             </div>
                
             <div class="col-6">

                  <div class="fluid-width-video-wrapper " >

                    <iframe width="560" height="315" src="https://www.youtube.com/embed/hLQl3WQQoQ0?si=VNvU0wU1E9y-Ms2k" title="Nombre del Ejercicio" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
                    <p>Su navegador no soporta vídeos HTML5.</p>

                  </div>
            </div>

             <div class="col-4 ">
                 <div class="align-items-center">

                <h4>Tipo Ejercicio</h4>
                 <h4>dificultad</h4>
                 <h4>Grupo Muscular</h4>
                  <h4>Repeticiones</h4>
                 </div>
             </div>
        </div>
           <%} %>
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



