<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">


    <div id="noticias" class="d-flex justify-content-center align-items-center mb-5">

        <div class="row">
            <div class="col-2">
                <div class="card" style="width: 18rem;">
                    <img src="/Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                    <div class="card-body">
                        <h5 class="card-title"><% =Perfil.Nombre+" "+Perfil.Apellido %> </h5>
                        <p class="card-text"><%=Plan.Tipo_Plan  %></p>
                        <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-primary">Ver Perdil</a>
                    </div>
                </div>
            </div>

            <div class="col-8">

                <asp:Label ID="LblInformacion" runat="server" Font-Size="Large" BorderStyle="Double" BorderColor="#009933" Text="En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante En este Text van a recibir las noticias con respecto al gimnasio, sea hoarios de feriados, o algun informacion relevante"></asp:Label>
            </div>



        </div>

        <div class="col-2">
            <div class="card" style="width: 18rem;">
                <img src="/Assets/usuario.png" class="card-img-top" alt="Assets/usuario.png">
                <div class="card-body">
                    <h5 class="card-title">Entrenador</h5>
                    <p class="card-text">datos</p>
                    <a href="VistaPerfilEntrenador.aspx" class="btn btn-primary">Ver Perfil</a>
                </div>
            </div>
        </div>

    </div>

    <div class="row">

        <div class="card-body">
     <table id="datatablesSimple" class="table table-striped table-bordered bg-light">
         <thead>
 
             <tr>
                 <th></th>
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
            <tr>
                         <td>7:00 A 8:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>8:00 A 9:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>9:00 A 10:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>11:00 A 12:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>12:00 A 13:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>13:00 A 14:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>14:00 A 15:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td>Elongacion</td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>15:00 A 16:00</td>
                         <td>Spinning</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>16:00 A 17:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td>Crossfit</td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>17:00 A 18:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>18:00 A 19:00</td>
                         <td>Full body</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>19:00 A 20:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
                     <tr>
                         <td>21:00 A 22:00</td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                         <td></td>
                     </tr>
         </tbody>
     </table>
 </div>


    </div>


</asp:Content>

