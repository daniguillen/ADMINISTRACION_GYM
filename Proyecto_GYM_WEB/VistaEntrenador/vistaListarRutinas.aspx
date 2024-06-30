<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaListarRutinas.aspx.cs" Inherits="Proyecto_GYM_WEB.vistaListarRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>RUTINA STANDART</h1>
        <div class="text-end">

        <asp:Button ID="btnvolver" runat="server" Text="🢀" OnClick="btnvolver_Click"/>
        </div>
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around">
                <div class="d-flex justify-content-between">
                </div>

            </li>
        </ul>
        <div class="table-responsive">
            <table class="table table-striped table-bordered table-dark" id="tablaRutina">
                <thead class="header-class">
                    <tr class="row-class">
                        <td>DIA - HORARIO</td>
                        <td>RUTINA</td>
                        <td>DESCRIPCION</td>                      
                        <td>ACCIONES</td>
                    </tr>
                </thead>
                <tbody>
                    <% 
                        int rutinaID = -1;
                        for (int i = 0; i < ListaTablaRuti.Count(); i++)
                        {
                            bool nuevaRuti = rutinaID != ListaTablaRuti[i].ID_Rutina;
                            if (nuevaRuti)
                            {
                                rutinaID = ListaTablaRuti[i].ID_Rutina;
                            %>
                    <tr>
                        <td hidden><%= ListaTablaRuti[i].ID_Rutina %></td>
                        <td>
                            <span><%= ListaTablaRuti[i].DiaNombre %></span> -
                            <span><%= ListaTablaRuti[i].Horario %></span> Hs
                        </td>
                        <td><%= ListaTablaRuti[i].NombreRutina %></td>
                        <td><%= ListaTablaRuti[i].DescripcionRutina %></td>                        
                        <td>
                            <a href="vistaModificarRutina.aspx?id=<%= ListaTablaRuti[i].ID_Rutina %>"  > ✍ </a>
                        </td>
                    </tr>          
                    <%
                            }
                        }
                    %>
                </tbody>
            </table>
        </div>
    </div>
    
    <script>        

      
    </script>
</asp:Content>

