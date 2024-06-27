<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PantallaPrincipalEntrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.PantallaPrincipal" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row mt-4">
            <div class="col-4">
                <div class="col-12 ">
                    <asp:Label ID="lblBienvenida" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="row mt-2">
                    <div class="col-12 text-center">
                        <h2>Menu:</h2>
                    </div>
                </div>

                <div class="row justify-content-center mt-2">
                     <div class="col-12 text-center">
                        <asp:DropDownList ID="ddlAltas" runat="server" CssClass="form-select m-1" AutoPostBack="true" OnSelectedIndexChanged="ddlAltas_SelectedIndexChanged">
                            <asp:ListItem Text="Altas" Value=""></asp:ListItem>
                            <asp:ListItem Text="Nuevo Ejercicio" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Nueva Rutina" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Agregar Ejercicio a Rutina" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
                <div class="row justify-content-center mt-2">
                    <div class="col-12 text-center">
                        <asp:DropDownList ID="ddlModificar" runat="server" CssClass="form-select m-1" AutoPostBack="true" OnSelectedIndexChanged="ddlModificar_SelectedIndexChanged">
                            <asp:ListItem Text="Modificar" Value=""></asp:ListItem>
                            <asp:ListItem Text="Modificar Ejercicio" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Modificar Rutina" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row mt-2" style="text-align: center">
                    <div class="col-12 text-center">
                        <asp:DropDownList ID="ddlListar" runat="server" CssClass="form-select m-1" AutoPostBack="true" OnSelectedIndexChanged="ddlListar_SelectedIndexChanged">
                            <asp:ListItem Text="Listar" Value=""></asp:ListItem>
                            <asp:ListItem Text="Listar Ejercicio" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Listar Rutina" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <!--*****************************************************************-->
    <div class="modal" id="nuevoModal" tabindex="-1">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h3 class="modal-title ">FORMULARIO ALTA EJERCICIO.</h3>
                <asp:Button type="button" ID="btnSalirX1" runat="server" CssClass="btn-close" data-bs-dismiss="modal"  aria-label="Close" OnClick="btnSalirX1_Click"/>
            </div>
            <div class="modal-body">
                <%--        AGREGAR EJERCICIO --%>
                <div class="container">

                    <div class="mb-3 uP">
                        <label for="lblNombre" class="form-label">NOMBRE:</label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3 ">
                        <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                        <asp:TextBox ID="txtDescripcionEj" runat="server" CssClass="form-control"></asp:TextBox>
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
                <asp:Button type="button" CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Agregar Ejercicio" Onclick="btnAgregar_Click"/>
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
