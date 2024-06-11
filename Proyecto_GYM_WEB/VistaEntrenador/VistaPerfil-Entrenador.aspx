<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaPerfil-Entrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaPerfil_Entrenador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NavbarUsuarios" runat="server">




    <div class="container">
        <div class="row">
            <div class="col-9">
                <h1>Perfil</h1>

            </div>
            <div class="col-4">
                .
           <!--FOTO DE PERFIL-->
                <div class="card" style="width: 18rem;">
                    <img src="/Assets/usuario1.jpg" class="card-img-top" alt="Assets/usuario.png">
                    <div class="card-body">
                       <%-- <h4 class="card-title"><% =usuario.Nombre+" "+usuario.Apellido %> </h4>
                        <h5 class="card-text">Plan: <%=usuario.plan.Tipo_Plan  %></h5>
                        <h5 class="card-text">Dni: <%=usuario.DNI  %></h5>--%>
                        <br />

                    </div>
                </div>
            </div>
            <di class="col-6">
                <!--DATOS DE LA PERSONA--->
                <div class="form-group">
                    <label for="TxtDniEditar">DNI:</label>
                    <asp:TextBox ID="TxtDniEditar" runat="server" CssClass="form-control" Text='<%=usuario.DNI %>'></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtNombreEditar">Nombre:</label>
                    <asp:TextBox ID="TxtNombreEditar" runat="server" CssClass="form-control" Text="<%=usuario.Nombre %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtApellidoEditar">Apellido:</label>
                    <asp:TextBox ID="TxtApellidoEditar" runat="server" CssClass="form-control" Text="<%=usuario.Apellido %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtPlanEditar">Plan:</label>
                    <asp:TextBox ID="TxtPlanEditar" runat="server" CssClass="form-control" Text="<%=usuario.plan.Tipo_Plan %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtCelularEditar">Celular:</label>
                    <asp:TextBox ID="TxtCelularEditar" runat="server" CssClass="form-control" Text="<%=usuario.Cel %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtTelEmergenciaEditar">Tel Emergencia:</label>
                    <asp:TextBox ID="TxtTelEmergenciaEditar" runat="server" CssClass="form-control" Text="<%=usuario.Tel_Emergencia %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtEmailEditar">Email:</label>
                    <asp:TextBox ID="TxtEmailEditar" runat="server" CssClass="form-control" Text="<%=usuario.Mail %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtPasswordEditar">Password:</label>
                    <asp:TextBox ID="TxtPasswordEditar" runat="server" CssClass="form-control" Text="<%=usuario.Password %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtFechaNacimientoEditar">Fecha Nacimiento:</label>
                    <asp:TextBox ID="TxtFechaNacimientoEditar" Type="date" runat="server" CssClass="form-control" Text="<%=usuario.Fecha_Nacimiento %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtSexoEditar">Sexo:</label>
                    <asp:TextBox ID="TxtSexoEditar" runat="server" CssClass="form-control" Text="<%=usuario.sexo.Tipo %>"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtFechaIngresoEditar">Fecha Ingreso:</label>
                    <asp:TextBox ID="TxtFechaIngresoEditar" runat="server" CssClass="form-control" Text="<%=usuario.Fecha_ingreso %>"></asp:TextBox>
                </div>


                <div class=" d-flex mt-5">

                    <a href="#" class="btn btn-secondary btn-icon-split">
                        <span class="icon text-white-50">
                            <i class="fas fa-arrow-right"></i>
                        </span>
                        <span class="bottom-0">Guardar</span>
                    </a>
                    <a href="AdministradorGeneral.aspx" class="btn btn-secondary btn-icon-split ms-5">
                        <span class="icon text-white-50">
                            <i class="fas fa-arrow-right"></i>
                        </span>
                        <span class="bottom-0">volver</span>
                    </a>

                </div>
        </div>
    </div>


</asp:Content>
