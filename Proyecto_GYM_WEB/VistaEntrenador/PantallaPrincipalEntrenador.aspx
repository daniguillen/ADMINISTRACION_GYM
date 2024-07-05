<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PantallaPrincipalEntrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.PantallaPrincipal" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh;
        }

        .panel {
            background: rgba(0, 0, 0, 0.7);
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 20px;
        }

            .panel h5, .panel p, .panel input {
                color: white;
            }

        .btn-primary {
            border-color: #2C6D00;
            background: linear-gradient(to left, #74EB1E, #2C6D00);
        }

        .text-dark {
            color: white !important;
        }

        .font-weight-bold {
            font-weight: bold;
        }
    </style>
    <div class="container mt-5">
        <h2 class="text-center mb-4 text-white">Panel del Entrenador</h2>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Nueva Rutina</h5>
                    <p class="text-dark font-weight-bold">Dar de alta nueva rutina</p>
                    <asp:Button ID="btnRutinaAlta" runat="server" Text="Alta rutina" CssClass="btn btn-primary" OnClick="btnRutinaAlta_Click" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Administrar Rutina</h5>
                    <p class="text-dark font-weight-bold">Modificar, Listado, Ver detalles</p>
                    <asp:Button ID="btnRutina" runat="server" Text="Administrar Rutina" CssClass="btn btn-primary" OnClick="btnRutina_Click" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Administrar Ejercicios</h5>
                    <p class="text-dark font-weight-bold">Modificar, Listado, Agregar ejercicio a rutina</p>
                    <asp:Button ID="btnListadoEjercicio" runat="server" Text="Administrar ejercicio" CssClass="btn btn-primary" OnClick="btnListadoEjercicio_Click" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Nuevo Ejercicio</h5>
                    <p class="text-dark font-weight-bold">Dar de alta nueva ejercicio</p>
                    <asp:Button ID="btnAltaEjercicio" runat="server" Text="Alta ejercicio" CssClass="btn btn-primary" OnClick="btnAltaEjercicio_Click" />
                </div>
            </div>        
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Mi Perfil</h5>
                    <p class="text-dark font-weight-bold">Modificar Perfil</p>
                    <asp:Button ID="btnPerfil" runat="server" Text="Ver Perfil" CssClass="btn btn-primary" OnClick="btnPerfil_Click" />
                </div>
            </div>
        </div>
    </div>

    <!--*****************************************************************-->
    <%--        AGREGAR EJERCICIO --%>
    <div class="modal" id="nuevoModal" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">ALTA EJERCICIO.</h3>
                    <asp:Button type="button" ID="btnSalirX1" runat="server" CssClass="btn-close" data-bs-dismiss="modal" aria-label="Close" OnClick="btnSalirX1_Click" />
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-6  mb-3 ">
                                <label for="lblNombre" class="form-label">NOMBRE:</label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 mb-3 ">
                                <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                                <asp:TextBox ID="txtDescripcionEj" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 mb-3">
                                <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 mb-3">
                                <label for="lblIDDificultad" class="form-label">DIFICULTAD:</label>
                                <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 mb-3">
                                <label for="lblVideo" class="form-label">INGRESE URL DEL VIDEO:</label>
                                <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 mb-3">
                                <label for="lblIdTipo" class="form-label">TIPO:</label>
                                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 mb-3">
                                <label for="lblIdGrupoMusc" class="form-label">GRUPO MUSCULAR:</label>
                                <asp:DropDownList ID="ddlGrupoMuscu" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="PantallaPrincipalEntrenador.aspx" type="button" class="btn btn-secondary">Volver</a>
                    <asp:Button type="button" CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar Ejercicio" OnClick="btnAgregar_Click" />
                </div>
            </div>
        </div>
    </div>

    <!--*****************************************************************-->
    <%--  MODAL 2: CREAR RUTINA--%>
    <div class="modal" id="nuevoModal2" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">FORMULARIO ALTA RUTINA.</h3>
                    <asp:Button type="button" ID="btnSalirX2" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnSalirX2_Click1" />
                </div>
                <div class="modal-body">
                    <%--        AGREGAR RUTINA --%>
                    <div class="container">
                        <div class="mb-3 uP">
                            <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
                            <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
                            <div class="mb-3">
                                <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                                <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="PantallaPrincipalEntrenador.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                        <asp:Button ID="btnAgregarRutina" runat="server" type="button" CssClass="btn btn-primary" Text="GUARDAR" OnClick="btnAgregarRutina_Click1" />
                    </div>
                </div>
            </div>
        </div>
    </div>

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
        function openModal2() {
            console.log("entro al modal");
            var modal = document.getElementById('nuevoModal2');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModal2() {
            var modal = document.getElementById('nuevoModal2');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }

    </script>

</asp:Content>
