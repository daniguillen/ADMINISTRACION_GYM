<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroPersona.aspx.cs" Inherits="Proyecto_GYM_WEB.RegistroPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Realice su registro</h1>
    <div class="container">

        <div class="row">
            <label class="form-check-label text-dark">Ingrese Nombre:</label>
            <asp:TextBox ID="txtNombre_Ingreso" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Apellido:</label>
            <asp:TextBox ID="txtApellido_Ingreso" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Nombre de usuario:</label>
            <asp:TextBox ID="txtNombreUsuario" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Contraseña:</label>
            <asp:TextBox ID="txtContraseña" CssClass="form-control btn-secondary" Type="password" runat="server" />
            <small class="form-text text-muted">Debe tener entre 4-6 caracteres con letras y numeros.</small>
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese DNI:</label>
            <asp:TextBox ID="txtDNI" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Sexo:</label>
            <asp:TextBox ID="txtSexo" CssClass="form-control btn-secondary" runat="server" />
            <small class="form-text text-muted">Ingrese M,F o X</small>
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Fecha Nacimiento:</label>
            <asp:TextBox ID="txtFechaNac" CssClass="form-control btn-secondary" Type="date" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Mail:</label>
            <asp:TextBox ID="txtMail" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese DNI:</label>
            <asp:TextBox ID="TextBox1" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Celular:</label>
            <asp:TextBox ID="txtCelular" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese Tel. Emergencia:</label>
            <asp:TextBox ID="txtTelEmergencia" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Ingrese su Dirección:</label>
            <asp:TextBox ID="txtDireccion" CssClass="form-control btn-secondary" runat="server" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Adjunte Apto Físico:</label>
            <asp:TextBox runat="server" CssClass="form-control form-control-sm" ID="txtBoxArchivoAptoFisico" type="file" />
        </div>
        <div class="row mt-3">
            <label class="form-check-label text-dark">Suba una foto para su perfil:</label>
            <asp:TextBox runat="server" CssClass="form-control form-control-sm" ID="TextBox2" type="file" />
        </div>
        <div class="mt-3">
        <asp:Button Text="Guardar ingreso" CssClass="btn btn-primary" OnClick="btnGuardar_Ingreso" runat="server" />
        <a href="Default.aspx" class="btn btn-danger">Cancelar</a>
        </div>
    </div>


</asp:Content>
