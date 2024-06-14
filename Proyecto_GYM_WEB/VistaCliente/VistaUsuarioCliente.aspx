<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background-color: black;
        }
    </style>

    <div id="Vista-Usuario" class="Vista-Usuario justify-content-center ms-5">

        <div id="noticias" class="d-flex justify-content-center align-items-center mb-5 mt-5">

            <div class="d-flex justify-content-center justify-content-center me-5 ms-5">
                <div class="col-2 d-flex me-2 ms-2">
                    <div class="card" style="width: 18rem;">
                        <img src="/Assets/usuario1.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title"><% =Perfil.Nombre+" "+Perfil.Apellido %> </h4>
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
                    <div class="card" style="width: 18rem;">
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
                            <td>
                                <button type="button" onclick="evento('1')">Click me</button>
                            </td>
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
    </div>
    <script>
        function evento(a) {
            window.location.href = "https://localhost:44386/VistaCliente/VistaUsuarioCliente?id=" + a;
            console.log(a);
        }
    </script>
</asp:Content>
