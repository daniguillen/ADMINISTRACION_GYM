<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroPersona.aspx.cs" Inherits="Proyecto_GYM_WEB.RegistroPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center">Realice su registro</h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese DNI:</label>
                    <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Nombre:</label>
                    <asp:TextBox ID="txtNombre_Ingreso" CssClass="form-control" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Apellido:</label>
                    <asp:TextBox ID="txtApellido_Ingreso" CssClass="form-control" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Nombre de usuario:</label>
                    <asp:TextBox ID="txtNombreUsuario" CssClass="form-control" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Contraseña:</label>
                    <asp:TextBox ID="txtContraseña" CssClass="form-control" TextMode="Password" runat="server" />
                    <small class="form-text text-muted">Debe tener entre 4-6 caracteres con letras y números.</small>
                </div>
            </div>
            <div class="col-md-6 offset-md-3">
                <div class="form-group">
                    <label class="form-check-label text-dark">Sexo:</label>
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                        <asp:ListItem Text="MASCULINO" Value="1"></asp:ListItem>
                        <asp:ListItem Text="FEMENINO" Value="2"></asp:ListItem>
                        <asp:ListItem Text="BINARIO" Value="3"></asp:ListItem>
                        <asp:ListItem Text="S/D" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Fecha Nacimiento:</label>
                    <asp:TextBox ID="txtFechaNac" CssClass="form-control" TextMode="Date" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Mail:</label>
                    <asp:TextBox ID="txtMail" CssClass="form-control" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Celular:</label>
                    <asp:TextBox ID="txtCelular" CssClass="form-control Celular" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese Tel. Emergencia:</label>
                    <asp:TextBox ID="txtTelEmergencia" CssClass="form-control Celular" runat="server" />
                </div>
                <div class="form-group">
                    <label class="form-check-label text-dark">Ingrese su Dirección:</label>
                    <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server" />
                </div>
                <div class="row mt-3">
                    <label class="form-check-label text-dark">Adjunte Apto Físico:</label>
                    <div class="col">
                        <asp:FileUpload runat="server" CssClass="form-control-file form-control-sm" ID="txtBoxArchivoAptoFisico" />
                    </div>
                </div>
                <div class="row mt-3">
                    <label class="form-check-label text-dark">Suba una foto para su perfil:</label>
                    <div class="col">
                        <asp:FileUpload runat="server" CssClass="form-control-file form-control-sm" ID="TextBox2" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-6 offset-md-3">
                <asp:Button Text="Guardar ingreso" CssClass="btn btn-primary" OnClick="btnGuardar_Ingreso" runat="server" />
                <a href="Default.aspx" class="btn btn-danger">Cancelar</a>
            </div>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/5.0.6/jquery.inputmask.min.js"></script>

    <script>
        $(document).ready(function () {
            $(".Celular").inputmask({ "mask": "(999) 999-9999" });
        });
    </script>
</asp:Content>
