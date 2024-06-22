﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaModificarRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaModificarRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <h3>MODIFICAR CAMPOS RUTINA</h3>
            <div class="col-md-6">
                <div class="mb-3">
                    <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
                    <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                    <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="8"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="mb-3">
                    <label for="lblHorario" class="form-label">HORARIO:</label>
                    <asp:DropDownList ID="ddlHorario" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                    <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
                </div>
                <div class="mb-3 mt-xl-5" >
                    <asp:CheckBox runat="server" type="radio" Text=" Ver detalles"
                        ID="chkAFiltroAvanzado" AutoPostBack="true"
                        OnCheckedChanged="chkAFiltroAvanzado_CheckedChanged" />
                </div>
            </div>
        </div>
        <% if (chkAFiltroAvanzado.Checked)
            { %>
        <div class="row">
            <div class="col-12">
                <h3>MODIFICAR EJERCICIOS DENTRO DE LA RUTINA</h3>
                <div class="table-responsive">
                    <table class="table table-striped table-bordered table-dark" id="tablaRutina">
                        <thead class="header-class">
                            <tr class="row-class">
                                <td>EJERCICIOS - REPETICIONES</td>
                                <td>ACCIONES</td>
                            </tr>
                        </thead>
                        <tbody>
                            <% 
                                int rutinaID = int.Parse(Request.QueryString["id"]);
                                var ejercicios = ListaTablaRuti.Where(x => x.ID_Rutina == rutinaID).ToList();
                                foreach (var ejercicio in ejercicios)
                                {
                        %>
                            <tr>
                                <td>
                                    <span><%= ejercicio.NombreEjercicio %></span> -
                               
                                    <span><%= ejercicio.Repeticiones %></span>
                                </td>
                                <td>
                                    <asp:Button ID="btnOpenModal" runat="server" Text="Ver detalles" CssClass="btn btn-primary m-2" OnClick="btnOpenModal_Click" />
                                </td>
                            </tr>
                            <% } %>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <% } %>
        <div class="row">
            <div class="col-12">
                <asp:Button ID="btnModificarRutina" Text="Guardar Cambios" runat="server" CssClass="btn btn-primary m-2" OnClick="btnModificarRutina_Click" />
                <asp:Button ID="btnVolver" runat="server" Text="Cancelar" CssClass="btn btn-secondary m-2" OnClick="btnVolver_Click" />
            </div>
        </div>
    </div>


    <div class="modal" id="nuevoModal" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">MODIFICAR EJERCICIO.</h3>
                    <asp:Button type="button" ID="btnSalirX1" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnSalirX1_Click" />
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="mb-3">
                            <asp:Label ID="lblFiltroMuscular" runat="server" Text="Filtrar por Grupo muscular" class="form-label"></asp:Label>
                            <asp:DropDownList ID="ddlGrupoMuscular" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <asp:Label ID="lblEjercicios" runat="server" Text="Seleccion Ejercicio:" class="form-label"></asp:Label>
                            <asp:DropDownList ID="ddlEjercicios" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="lblRepeticiones" class="form-label">Repeticiones:</label>
                            <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button type="button" CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Guardar Cambios" />
                </div>
            </div>
        </div>
    </div>










    <asp:HiddenField ID="hfRutinaID" runat="server" />

    <script>        
        function openModal() {
            console.log("entro al modal");
            var modal = document.getElementById('nuevoModal');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModal() {
            var modal = document.getElementById('nuevoModal');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }

    </script>


</asp:Content>
