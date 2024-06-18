﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaListarRutinas.aspx.cs" Inherits="Proyecto_GYM_WEB.vistaListarRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>RUTINA STANDART</h1>
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
                        <td>DIA</td>
                        <td>RUTINA</td>
                        <td>DESCRIPCION</td>
                        <td>EJERCICIOS</td>
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
                        <td><%= ListaTablaRuti[i].DiaNombre %></td>
                        <td><%= ListaTablaRuti[i].NombreRutina %></td>
                        <td><%= ListaTablaRuti[i].DescripcionRutina %></td>
                        <td>
                            <span><%= ListaTablaRuti[i].NombreEjercicio %></span> -
                            <span><%= ListaTablaRuti[i].Repeticiones %></span>
                        </td>
                        <td>
                            <a href="vistaModificarRutina.aspx?id=<%= ListaTablaRuti[i].ID_Rutina %>" class="btn btn-secondary">Editar</a>
                        </td>
                    </tr>
                    <%
                        }
                        else
                        {
                    %>
                    <tr>
                        <td hidden><%= ListaTablaRuti[i].ID_Rutina %></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>
                            <div>
                                <span><%= ListaTablaRuti[i].NombreEjercicio %></span> - 
                               
                                <span><%= ListaTablaRuti[i].Repeticiones %> reps</span>
                            </div>
                        </td>
                        <td></td>
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

