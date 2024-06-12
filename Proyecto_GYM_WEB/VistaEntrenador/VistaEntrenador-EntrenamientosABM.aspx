<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>GRILLA DE EJERCICIOS POR GRUPO MUSCULAR</h1>
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around">
                <div class="d-flex justify-content-between">
                    <asp:Button ID="btnOpenModal" runat="server" CssClass="btn btn-primary m-2" Text="AGREGAR EJERCICIO" OnClick="btnOpenModal_Click" />
                    <asp:Button ID="btnOpenModal2" runat="server" CssClass="btn btn-primary m-2" Text="AGREGAR RUTINA" OnClick="btnOpenModal2_Click" />
                    <asp:Button ID="btnOpenModal3" runat="server" CssClass="btn btn-primary m-2" Text="AGREGAR EJERCICIO A RUTINA" OnClick="btnOpenModal3_Click" />
                    <asp:Button ID="btnlistar" runat="server" Text="LISTAR RUTINAS" CssClass="btn btn-success m-2" OnClick="btnlistar_Click"/>
                </div>

            </li>
        </ul>

        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>




        <div class="modal" id="nuevoModal" tabindex="-1">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3 class="modal-title ">FORMULARIO ALTA EJERCICIO.</h3>
                        <asp:Button type="button" ID="btnSalirX1" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnSalirX1_Click" />

                    </div>
                    <div class="modal-body">
                        <%--        AGREGAR EJERCICIO --%>
                        <div class="container">
                            <div class="mb-3 uP">
                                <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                                <asp:TextBox ID="txtDescripcionEj" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="lblNombre" class="form-label">NOMBRE:</label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="lblIDDificultad" class="form-label">DIFICULTAD:</label>
                                <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="mb-3">
                                <label for="lblVideo" class="form-label">INGRESE URL DEL VIDEO:</label>
                                <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="lblIdTipo" class="form-label">TIPO:</label>
                                <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                            <div class="mb-3">
                                <label for="lblIdGrupoMusc" class="form-label">GRUPO MUSCULAR:</label>
                                <asp:DropDownList ID="ddlGrupoMuscu" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">Volver</a>
                        <asp:Button type="button" CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Guardar Cambios" OnClick="btnAgregar_Click" />
                    </div>
                </div>
            </div>
        </div>

        <%--  MODAL 2: CREAR RUTINA--%>
        <div class="modal" id="nuevoModal2" tabindex="-1">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3 class="modal-title ">FORMULARIO ALTA RUTINA.</h3>
                        <asp:Button type="button" ID="btnSalirX2" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnSalirX2_Click" />
                    </div>
                    <div class="modal-body">
                        <%--        AGREGAR RUTINA --%>
                        <div class="container">
                            <div class="mb-3 uP">
                                <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
                                <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                                <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                        <asp:Button ID="btnAgregarRutina" runat="server" type="button" CssClass="btn btn-primary" Text="GUARDAR" OnClick="btnAgregarRutina_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%--  MODAL 2: ASIGNAR EJERCICIO A RUTINA--%>
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
                        <div class="mb-3 uP">
                            <label for="IDRutina" class="form-label">RUTINA:</label>
                            <asp:DropDownList ID="ddlIDRutina" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="lblEjercicios" class="form-label">SELECCIONE EJERCICIOS:</label>
                            <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                            <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="lblHorario" class="form-label">HORARIO:</label>
                            <asp:TextBox ID="txtHora" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                        <asp:Button ID="btnAgregarEjercicioARutina" runat="server" type="button" CssClass="btn btn-primary" Text="GUARDAR" OnClick="btnAgregarEjercicioARutina_Click" />
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

        </script>
</asp:Content>

