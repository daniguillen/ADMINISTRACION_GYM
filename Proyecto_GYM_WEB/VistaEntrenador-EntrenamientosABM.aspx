<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaEntrenador-EntrenamientosABM.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador_EntrenamientosABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>GRILLA DE EJERCICIOS POR GRUPO MUSCULAR</h2>

    <div class="container">
        <asp:Button ID="btnOpenModal" runat="server" CssClass="btn btn-primary" Text="Agregar Nuevo Registro" OnClick="btnOpenModal_Click" />

        <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>
    </div>




    <div class="modal" id="nuevoModal" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title ">FORMULARIO ALTA EJERCICIO.</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <%--        AGREGAR GRUPO MUSCULAR--%>


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

