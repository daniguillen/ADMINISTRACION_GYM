<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroPersona.aspx.cs" Inherits="Proyecto_GYM_WEB.RegistroPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Estilo para cambiar el color del texto del FileUpload */
        input[type="file"]::file-selector-button {
            color: white;
            background-color: #007bff;
            border: 1px solid #007bff;
            padding: 5px 10px;
            border-radius: 5px;
            cursor: pointer;
        }

            input[type="file"]::file-selector-button:hover {
                background-color: #0056b3;
                border-color: #0056b3;
            }

        input[type="file"] {
            color: white; /* Color del texto "Sin archivos seleccionado" */
        }

        .container {
            margin-top: 2em;
        }
    </style>
    <div class="video-background">

        <video autoplay muted loop id=" bgVideo">
            <source src="Assets/vecteezy_animated-green-color-fading-particles-background_24476461.mp4" type="video/mp4">
            Your browser does not support the video tag.
        </video>
    </div>
    <h1 class="text-center mt-5 text-white">Realice su registro</h1>
    <div class="container d-flex justify-content-center align-items-center min-vh-100">
        <div class="container" style="max-width: 23%;">
            <div class="w-100">
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese DNI:</label>
                    <asp:TextBox ID="txtDNI" CssClass="form-control w-100 mb-3" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="DNI invalido" ControlToValidate="txtDNI" CssClass="alert alert-danger" runat="server" ValidationExpression="\d+"/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Nombre:</label>
                    <asp:TextBox ID="txtNombre_Ingreso" CssClass="form-control mb-3 w-100" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Contiene números"  ControlToValidate="txtNombre_Ingreso" CssClass="alert alert-danger" runat="server" ValidationExpression="^[a-zA-Z ]*$" />

                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Apellido:</label>
                    <asp:TextBox ID="txtApellido_Ingreso" CssClass="form-control mb-3 w-100" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Contiene números" ControlToValidate="txtApellido_Ingreso" CssClass="alert alert-danger" runat="server" ValidationExpression="^[a-zA-Z ]*$" />

                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Contraseña:</label>
                    <asp:TextBox ID="txtContraseña" CssClass="form-control mb-3 w-100" TextMode="Password" runat="server" />
                    <small class="form-text text-muted text-white">Debe tener entre 4-6 caracteres con letras y números.</small>
                    <asp:RegularExpressionValidator ErrorMessage="Invalida!" ControlToValidate="txtContraseña" CssClass="alert alert-danger" runat="server" ValidationExpression="^(?=.*\d).{4,6}$" />

                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Sexo:</label>
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control mb-3 w-100" runat="server">
                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                        <asp:ListItem Text="MASCULINO" Value="1"></asp:ListItem>
                        <asp:ListItem Text="FEMENINO" Value="2"></asp:ListItem>
                        <asp:ListItem Text="BINARIO" Value="3"></asp:ListItem>
                        <asp:ListItem Text="S/D" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">PLANES:</label>
                    <asp:DropDownList ID="ddlplanes" CssClass="form-control mb-3 w-100" runat="server">
                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                        <asp:ListItem Text="BASICO" Value="1"></asp:ListItem>
                        <asp:ListItem Text="STANDART" Value="2"></asp:ListItem>
                        <asp:ListItem Text="PREMIUM" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Fecha Nacimiento:</label>
                    <asp:TextBox ID="txtFechaNac" CssClass="form-control mb-3 w-100" TextMode="Date" runat="server" required=""/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Mail:</label>
                    <asp:TextBox ID="txtMail" CssClass="form-control mb-3 w-100" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Ingrese un Email valido" ControlToValidate="txtMail" runat="server" CssClass="alert alert-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Celular:</label>
                    <asp:TextBox ID="txtCelular" CssClass="form-control mb-3 w-100" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Solo numeros" ControlToValidate="txtCelular" runat="server" ValidationExpression="\d+" CssClass="alert alert-danger"/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese Tel. Emergencia:</label>
                    <asp:TextBox ID="txtTelEmergencia" CssClass="form-control mb-3 w-100" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Solo numeros" ControlToValidate="txtTelEmergencia" runat="server" ValidationExpression="\d+" CssClass="alert alert-danger"/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Ingrese su Dirección:</label>
                    <asp:TextBox ID="txtDireccion" CssClass="form-control mb-3 w-100" runat="server" required=""/>
                </div>
                <div class="form-group w-100">
                    <label class="form-check-label text-white d-block text-left w-100">Adjunte Apto Físico:</label>
                    <asp:FileUpload runat="server" CssClass="form-control-file mb-3 form-control-sm w-100" ID="txtBoxArchivoAptoFisico" required=""/>
                    <asp:RequiredFieldValidator ErrorMessage="Debe adjuntar el Apto Físico." ID="rfvArchivoAptoFisico" ControlToValidate="txtBoxArchivoAptoFisico"  Display="Dynamic"  runat="server" CssClass="text-danger"/>
                    </div>
                <div class="form-group w-100">
                    <asp:RequiredFieldValidator ErrorMessage="Debe adjuntar foto" ID="rfvFoto"  ControlToValidate="txtFoto" runat="server" CssClass="alert alert-danger" Display="Dynamic"/>
                    <label class="form-check-label text-white d-block text-left w-100">Suba una foto para su perfil:</label>
                    <asp:FileUpload runat="server" CssClass="form-control-file mb-5 form-control-sm w-100" ID="txtFoto" required="" />
                </div>
                <div class="form-group r w-100">
                    <div class="form-check-label justify-content-center d-flex text-white d-block text-left w-100">
                        <asp:Button Text="Guardar ingreso" CssClass="btn btn-primary " OnClick="btnGuardar_Ingreso" runat="server" />
                        <a href="Default.aspx" class="btn btn-danger ms-4 ">Cancelar</a>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- mascara para celular-->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.inputmask/5.0.6/jquery.inputmask.min.js"></script>

    <script>
        $(document).ready(function () {
            $(".Celular").inputmask({ "mask": "(999) 9999-9999" });
        });
    </script>
</asp:Content>
