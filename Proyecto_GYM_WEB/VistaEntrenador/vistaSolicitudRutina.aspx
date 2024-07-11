<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaSolicitudRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaSolicitudRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NavbarUsuarios" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarEntrenador" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh;
        }
    </style>

    <div class="container mt-5">
        <div class="text-end">

            <asp:Button ID="btnvolver" runat="server" Text="🢀"  OnCLick="btnvolver_Click"/>
        </div>
        <h2 style="color: white">SOLICITUDES DE RUTINA</h2>
        <div class="table-responsive mx-auto">
            <asp:GridView runat="server" ID="dgvSolicitudes" CssClass="table table-striped table-bordered table-dark" AutoGenerateColumns="false">
                <Columns>

                    <asp:BoundField HeaderText="Solicitud Nro" DataField="ID_SolicitudRutinas" />
                    <asp:TemplateField HeaderText="ID usuario">
                        <ItemTemplate>
                            <%#Eval ("usuario.ID") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <%# Eval("usuario.Nombre") + " " + Eval("usuario.Apellido") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Comentarios" DataField="Mensaje" />
                    <asp:BoundField HeaderText="Fecha" DataField="FechaSolicitud" />
                    <asp:BoundField HeaderText="RutiAsignada0" DataField="RutinaAsignada" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button Text="Crear Rutina" ID="btnCrearRutina" runat="server" CommandArgument='<%#Eval("usuario.ID") %>' CssClass="btn btn-secondary" OnClick="btnCrearRutina_Click" />
                             <a href="vistaAsignarRutina.aspx?id=<%# Eval("ID_SolicitudRutinas") + "&userid=" + Eval("usuario.ID") %>">🏋️ </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <%--  MODAL 2: CREAR RUTINA--%>
    <div class="modal" id="CrearRutinaAsignada" tabindex="-1">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h3 class="modal-title ">FORMULARIO ALTA RUTINA.</h3>
                    <asp:Button type="button" ID="btnSalirAltaRutina" CssClass="btn-close" data-bs-dismiss="modal" runat="server" aria-label="Close" OnClick="btnSalirAltaRutina_Click" />
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
                        <a href="vistaSolicitudRutina.aspx" type="button" class="btn btn-secondary">VOLVER</a>
                        <asp:Button ID="btnAgregarRutinaSolicitada" runat="server" type="button" CssClass="btn btn-primary" Text="GUARDAR" OnClick="btnAgregarRutinaSolicitada_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script> 
        function openModalCrearRutina() {
            console.log("entro al modal");
            var modal = document.getElementById('CrearRutinaAsignada');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModalRutiAsignada() {
            var modal = document.getElementById('CrearRutinaAsignada');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }
    </script>


</asp:Content>

