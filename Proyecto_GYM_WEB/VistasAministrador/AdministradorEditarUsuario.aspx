<%@ Page Title="" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AdministradorEditarUsuario.aspx.cs"
    Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorEditarUsuario" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div id="datatablesSimple2" class="row">
            <div class="col-12">
                <div class="row">
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtDniEditar" CssClass="text-light" >DNI:</label>
                            <asp:TextBox ID="TxtDniEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtNombreEditar">Nombre:</label>
                            <asp:TextBox ID="TxtNombreEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtApellidoEditar">Apellido:</label>
                            <asp:TextBox ID="TxtApellidoEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtPlanEditar">Plan:</label>
                            <asp:TextBox ID="TxtPlanEditar" runat="server" CssClass="form-control bg-secondary "></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtCelularEditar">Celular:</label>
                            <asp:TextBox ID="TxtCelularEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtTelEmergenciaEditar">Tel Emergencia:</label>
                            <asp:TextBox ID="TxtTelEmergenciaEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtEmailEditar">Email:</label>
                            <asp:TextBox ID="TxtEmailEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtPasswordEditar">Password:</label>
                            <asp:TextBox ID="TxtPasswordEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtFechaNacimientoEditar">Fecha Nacimiento:</label>
                            <asp:TextBox ID="TxtFechaNacimientoEditar" Type="date" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtSexoEditar">Sexo:</label>
                            <asp:TextBox ID="TxtSexoEditar" runat="server" CssClass="form-control bg-secondary "></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtFechaIngresoEditar">Fecha Ingreso:</label>
                            <asp:TextBox ID="TxtFechaIngresoEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtEstadoEditar">Estado:</label>
                            <asp:TextBox ID="TxtEstadoEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-3">
                        <div class="form-group">
                            <label for="TxtNivelEditar">Nivel:</label>
                            <asp:TextBox ID="TxtNivelEditar" runat="server" CssClass="form-control bg-secondary"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-12">
                        <a href="#" class="btn btn-secondary btn-icon-split">
                            <span class="icon text-white-50">
                                <i class="fas fa-arrow-right"></i>
                            </span>
                            <span class="bottom-0">Guardar</span>
                        </a>
                        <a href="AdministradorGeneral.aspx" class="btn btn-secondary btn-icon-split">
                            <span class="icon text-white-50">
                                <i class="fas fa-arrow-right"></i>
                            </span>
                            <span class="bottom-0">Cancelar</span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>








</asp:Content>
