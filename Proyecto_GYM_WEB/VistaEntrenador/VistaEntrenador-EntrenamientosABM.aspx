﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>LISTA DE EJERCICIOS POR GRUPO MUSCULAR</h1>
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around">
                <div class="d-flex justify-content-between">
                    <asp:Button ID="btnOpenModal3" runat="server" CssClass="btn btn-primary m-2" Text="AGREGAR EJERCICIO A RUTINA" OnClick="btnOpenModal3_Click" />
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-success m-2" OnClick="btnVolver_Click" />
                </div>

            </li>
        </ul>

        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>      

    <%--  MODAL 3: ASIGNAR EJERCICIO A RUTINA--%>
    <div class="modal" id="nuevoModal3" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">ASIGNAR EJERCICIO A RUTINA.</h3>
                    <asp:Button type="button" ID="btnbtnSalirX3" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnbtnSalirX3_Click" />
                </div>
                <div class="modal-body">
                    <%--        AGREGAR EJERCICIO A RUTINA --%>
                    <div class="container">
                        <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
                            <ContentTemplate>

                                <div class="row">

                                <div class="col-md-6 mb-3 ">
                                    <label for="IDRutina" class="form-label">RUTINA:</label>
                                    <asp:DropDownList ID="ddlIDRutina" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlIDRutina_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <asp:DropDownList runat="server" ID="ddlGrupoMuscular" CssClass="form-control" AutoPostback="true" OnSelectedIndexChanged="ddlGrupoMuscular_SelectedIndexChanged">
                                   
                                </asp:DropDownList>
                                <div class="mb-3">
                                    <label for="lblEjercicios" class="form-label">SELECCIONE EJERCICIOS:</label>
                                    <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:ListBox>
                                </div>
                                </div>
                                <div class="row">

                                <div class="col-md-6 mb-3">
                                    <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                                    <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
                                </div>
                                <div class="mb-3">
                                    <label for="lblHorario" class="form-label">HORARIO:</label>
                                    <asp:DropDownList runat="server" ID="ddlHorario" CssClass="form-control" ></asp:DropDownList>
                                </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                    <asp:Button ID="btnAgregarEjercicioARutina" runat="server" type="button" CssClass="btn btn-primary" Text="GUARDAR" OnClick="btnAgregarEjercicioARutina_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="modal" id="nuevoModal4" tabindex="-1">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h3 class="modal-title ">FORMULARIO ALTA EJERCICIO.</h3>
                <asp:Button type="button" ID="btnOpenModalModificarEjercicio" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" />

            </div>
            <div class="modal-body">
                <%--        AGREGAR EJERCICIO --%>
                <div class="container">

                    <div class="mb-3 uP">
                        <label for="lblNombre" class="form-label">NOMBRE:</label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3 ">
                        <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="lblIDDificultad" class="form-label">DIFICULTAD:</label>
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="lblVideo" class="form-label">INGRESE URL DEL VIDEO:</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="lblIdTipo" class="form-label">TIPO:</label>
                        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="lblIdGrupoMusc" class="form-label">GRUPO MUSCULAR:</label>
                        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">Volver</a>
                <asp:Button type="button" CssClass="btn btn-primary" ID="btnModificarCambiosEjercicio" runat="server" Text="Guardar Cambios"/>
            </div>
        </div>
    </div>
</div>
    <script>        
        function openModal3() {
            console.log("entro al modal");
            var modal = document.getElementById('nuevoModal3');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModal3() {
            var modal = document.getElementById('nuevoModal3');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }
        function openModal4() {
            console.log("entro al modal");
            var modal = document.getElementById('nuevoModal4');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModal4() {
            var modal = document.getElementById('nuevoModal4');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }

    </script>
</asp:Content>

