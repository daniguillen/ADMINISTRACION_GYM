<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaPerfil-Entrenador.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaPerfil_Entrenador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background-image: url(../Assets/fondo.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }
    </style>

    <div class="container">
        <div class="row">
            <div class="col-9">
                <h1>Perfil</h1>
            </div>
            <!--FOTO DE PERFIL-->
            <div class="col-4 ">
                .
            <div class="card" style="width: 18rem; background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">
                <asp:Image ID="ImagePerfil" ImageUrl="<%=usuario.Foto%>" runat="server" />
                <div class="card-body">
                    <h4 class="card-title"><%= usuario.Nombre+" "+usuario.Apellido %> </h4>
                    <h5 class="card-text">Plan: <%=usuario.plan.Tipo_Plan  %></h5>
                    <h5 class="card-text">Dni: <%=usuario.DNI  %></h5>

                    <input type="file" id="txtimagen" runat="server" class="form-control" cssclass="btn btn-secondary btn-icon-split" />

                </div>
            </div>
            </div>
            <div class="col-8">
                <div class="row">
                    <div class="col-md-6">
                        <!--DATOS DE LA PERSONA--->
                        <div class="form-group">

                            <label for="TxtDniEditar" class="text-light mt-2">DNI</label>
                            <asp:TextBox ID="TxtDniEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtNombreEditar" class="text-light mt-2">Nombre:</label>
                            <asp:TextBox ID="TxtNombreEditar" runat="server" CssClass="form-control"></asp:TextBox>

                        </div>

                        <div class="form-group">
                            <label for="TxtApellidoEditar" class="text-light mt-2">Apellido:</label>
                            <asp:TextBox ID="TxtApellidoEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtPlanEditar" class="text-light mt-2">Plan:</label>
                            <asp:TextBox ID="TxtPlanEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtCelularEditar" class="text-light mt-2">Celular:</label>
                            <asp:TextBox ID="TxtCelularEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-6">

                        <div class="form-group">
                            <label for="TxtTelEmergenciaEditar" class="text-light mt-2">Tel Emergencia:</label>
                            <asp:TextBox ID="TxtTelEmergenciaEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtEmailEditar" class="text-light mt-2">Email:</label>
                            <asp:TextBox ID="TxtEmailEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtPasswordEditar" class="text-light mt-2">Password:</label>
                            <asp:TextBox ID="TxtPasswordEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtFechaNacimientoEditar" class="text-light mt-2">Fecha Nacimiento:</label>
                            <asp:TextBox ID="TxtFechaNacimientoEditar" Type="date" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="TxtSexoEditar" class="text-light mt-2">Sexo:</label>

                            <asp:DropDownList ID="DdlSexo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                                <asp:ListItem Text="MASCULINO" Value="1"></asp:ListItem>
                                <asp:ListItem Text="FEMININO" Value="2"></asp:ListItem>
                                <asp:ListItem Text="BINARIO" Value="3"></asp:ListItem>
                                <asp:ListItem Text="S/D" Value="4"></asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <label for="TxtFechaIngresoEditar" class="text-light mt-2">Fecha Ingreso:</label>
                            <asp:TextBox ID="TxtFechaIngresoEditar" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class=" d-flex mt-5">
                <asp:Button ID="BTN_Guardar" runat="server" Text="Guardar" CssClass="btn btn-secondary btn-icon-split" OnClick="BTN_Guardar_Click" />
                <a href="PantallaPrincipalEntrenador.aspx" class="btn btn-secondary btn-icon-split ms-5">
                    <span class="icon text-white-50">
                        <i class="fas fa-arrow-right"></i>
                    </span>
                    <span class="bottom-0">volver</span>
                </a>
            </div>
        </div>
    </div>
</asp:Content>