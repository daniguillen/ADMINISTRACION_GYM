<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>GRILLA DE EJERCICIOS POR GRUPO MUSCULAR</h2>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <div class="container">
<<<<<<< Updated upstream:Proyecto_GYM_WEB/VistaEntrenador/VistaEntrenador-EntrenamientosABM.aspx
        <asp:Button ID="btnOpenModal" runat="server" CssClass="btn btn-primary" Text="AGREGAR REGISTRO DE EJERCICIO" OnClick="btnOpenModal_Click" />
        <asp:Button ID="btnOpenModal2" runat="server" CssClass="btn btn-primary" Text="AGREGAR REGISTRO DE RUTINA" OnClick="btnOpenModal2_Click" />
        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>
=======
        <asp:Button ID="btnOpenModal" runat="server" CssClass="btn btn-primary" Text="Agregar Nuevo Registro" OnClick="btnOpenModal_Click" />

        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>

>>>>>>> Stashed changes:Proyecto_GYM_WEB/VistaEntrenador-EntrenamientosABM.aspx
    </div>




    <div class="modal" id="nuevoModal" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title ">FORMULARIO ALTA EJERCICIO.</h5>
                    <asp:Button type="button" ID="Button2" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" />

                </div>
                <div class="modal-body">
                    <%--        AGREGAR EJERCICIO --%>
                    <div class="container">
                        <div class="mb-3">
                            <label for="lblDescripcion" class="form-label">Descripcion ejercicio nuevo:</label>
                            <asp:TextBox ID="txtDescripcionEj" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblNombre" class="form-label">Nombre ejercicio:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblRepeticiones" class="form-label">Repeticiones:</label>
                            <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblIDDificultad" class="form-label">Dificultad ID:</label>
                            <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="lblVideo" class="form-label">Video:</label>
                            <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblIdTipo" class="form-label">Tipo ID:</label>
                            <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="mb-3">
                            <label for="lblIdGrupoMusc" class="form-label">IdGrupoMuscu:</label>
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
                    <h5 class="modal-title ">FORMULARIO ALTA RUTINA.</h5>
                    <%--                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>--%>
                    <asp:Button type="button" ID="btnSalirX2" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" />
                </div>
                <div class="modal-body">
                    <%--        AGREGAR RUTINA --%>
                    <div class="container">
                        <div class="mb-3">
                            <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
                            <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblDescripcion" class="form-label">Descripcion:</label>
                            <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>                      
                        <div class="mb-3">
                            <label for="lblEjercicios" class="form-label">Seleccione ejercicios:</label>
                          <!---  <asp:DropDownList ID="ddlEjercicios" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:DropDownList>      -->              
                            <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:ListBox>
                        </div>
                        <div class="mb-3">
                            <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                            <asp:TextBox ID="txtDia" runat="server" CssClass="form-control btn-secondary" Type="date"></asp:TextBox>
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

