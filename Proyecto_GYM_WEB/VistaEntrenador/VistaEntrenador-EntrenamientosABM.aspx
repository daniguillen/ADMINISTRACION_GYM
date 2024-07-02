<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }

        .btn-primary {
            border-color: #2C6D00;
            background: linear-gradient(to left, #74EB1E, #2C6D00);
        }
    </style>

    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4">
        <h1>LISTA DE EJERCICIOS POR GRUPO MUSCULAR</h1>
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-between w-100">
                <div>
                    <asp:Button ID="btnOpenModal3" runat="server" CssClass="btn btn-primary m-2" Text="AGREGAR EJERCICIO A RUTINA" OnClick="btnOpenModal3_Click" />
                </div>

                <div class="ms-auto">

                    <asp:Button ID="btnVolver" runat="server" Text="🢀" OnClick="btnVolver_Click" />
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
                        <div class="container">
                            <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
                                <ContentTemplate>

                                    <div class="row mb-3">
                                        <div class="col-md-12 modal-dialog-centered">
                                            <label for="IDRutina" class="form-label">RUTINA:</label>
                                            <asp:DropDownList ID="ddlIDRutina" runat="server" CssClass="form-control mx-lg-4" AutoPostBack="true"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row mb-3">

                                        <div class="col-md-6 ">
                                            <asp:Label Text="FILTRAR POR GRUPO MUSCULAR" runat="server" />
                                            <asp:DropDownList runat="server" ID="ddlGrupoMuscular" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlGrupoMuscular_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Label Text="FILTRAR POR NOMBRE:" runat="server" AssociatedControlID="TxtBusqueda" />
                                            <asp:TextBox runat="server" ID="TxtBusqueda" CssClass="form-control mt-4" AutoPostBack="true" OnTextChanged="TxtBusqueda_TextChanged" />
                                        </div>
                                    </div>
                                    <div class="row mb-3">
                                        <label for="lblEjercicios" class="form-label">SELECCIONE EJERCICIOS:</label>
                                        <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple" AutoPostBack="true"></asp:ListBox>
                                    </div>

                                    <div class="row mb-3">
                                        <div class="col-md-6">
                                            <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                                            <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="lblHorario" class="form-label">HORARIO:</label>
                                            <asp:DropDownList runat="server" ID="ddlHorario" CssClass="form-control"></asp:DropDownList>
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
    </div>

    <%--        MODIFICAR EJERCICIO --%>
    <div class="modal" id="nuevoModal4" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">MODIFICAR EJERCICIO.</h3>
                    <asp:Button Text="" runat="server" type="button" ID="btnClose" CssClass="btn-close" data-bs-dismiss="modal" aria-label="Close" OnClick="btnClose_Click" />
                </div>
                <div class="modal-body">
                    <div class="container">
                        <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
                            <ContentTemplate>
                                <div class="row mb-3">
                                    <div class="col-md-12 modal-dialog-centered">
                                        <label for="txtNombreEjercicio" class="form-label">NOMBRE:</label>
                                        <asp:TextBox runat="server" ID="txtNombreEjercicio" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="row mb-3">
                                    <label for="lblEjercicios" class="form-label">DESCRIPCIÓN:</label>
                                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" Rows="5" />
                                </div>
                                <div class="row mb-3">
                                    <div class="col-md-6">
                                        <label for="lblVideo" class="form-label">INGRESE URL DEL VIDEO:</label>
                                        <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-md-6">
                                        <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                                        <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="row mb-3">
                                        <div class="col-md-6 ">
                                            <label for="lblIdGrupoMusc" class="form-label">GRUPO MUSCULAR:</label>
                                            <asp:DropDownList ID="ddlGrupoMuscu" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="lblIdTipo" class="form-label">TIPO:</label>
                                            <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </div>
                                        <div class="col-md-6">
                                            <label for="lblIDDificultad" class="form-label">DIFICULTAD:</label>
                                            <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                    <asp:Button runat="server" ID="btnModificarEjercicio" type="button" CssClass="btn btn-primary" Text="GUARDAR CAMBIOS" OnClick="btnModificarEjercicio_Click" />
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
        function openModalModificarEjercicio(ejercicioId) {

            var modal = document.getElementById('nuevoModal4');
            modal.style.display = 'block';
            modal.classList.add('show');
            console.log('ID del ejercicio:', ejercicioId);

        document.addEventListener('DOMContentLoaded', function () {
            var links = document.querySelectorAll('.custom-link');
            links.forEach(function (link) {
                link.addEventListener('click', function (event) {
                    event.preventDefault();
                    var ejercicioId = this.getAttribute('data-id');
                    openModalModificarEjercicio(ejercicioId);
                });
            });
        });

        function closeModalModificarEjercicio() {
            var modal = document.getElementById('nuevoModal4');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }


    </script>
</asp:Content>

