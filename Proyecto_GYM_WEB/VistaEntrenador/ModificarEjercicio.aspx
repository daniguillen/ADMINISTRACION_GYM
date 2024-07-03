<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarEjercicio.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.ModificarEjercicio" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }

        .btn-primary {
            border-color: #2C6D00;
            background: linear-gradient(to left, #74EB1E, #2C6D00);
        }
    </style>


    <div class="container">
        <div class="d-flex justify-content-end mb-3">

            <asp:Button ID="btnVolver" runat="server" Text="🢀" OnClick="btnVolver_Click" />
        </div>
        <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="row mb-3">
                    <div class="col-md-6">
                        <label for="txtNombreEjercicio" id="lblNombre" class="form-label lblCampos">NOMBRE:</label>
                        <asp:TextBox runat="server" ID="txtNombreEjercicio" CssClass="form-control" />
                    </div>
                </div>
                <div class="row mb-3 m-0">
                    <label for="lblEjercicios" class="form-label lblCampos">DESCRIPCIÓN:</label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" Rows="5" />
                </div>
                <div class="row mb-3">
                    <div class="col-md-6 mb">
                        <label for="lblVideo" class="form-label lblCampos">INGRESE URL DEL VIDEO:</label>
                        <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="lblRepeticiones" class="form-label lblCampos">REPETICIONES:</label>
                        <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                    <div class="row mb-3">
                        <div class="col-md-6 mt-4">
                            <label for="lblIdGrupoMusc" class="form-label lblCampos">GRUPO MUSCULAR:</label>
                            <asp:DropDownList ID="ddlGrupoMuscu" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6 mt-4">
                            <label for="lblIdTipo" class="form-label lblCampos">TIPO:</label>
                            <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6 mt-4">
                            <label for="lblIDDificultad" class="form-label lblCampos">DIFICULTAD:</label>
                            <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    
        <div class="col-12">
            <asp:Button ID="btnGuardarCambiosEjercicio" Text="Guardar Cambios" runat="server" CssClass="btn btn-primary m-2" OnClick="btnGuardarCambiosEjercicio_Click" />
            <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">Cancelar</a>
        </div>
    
    </div>










</asp:Content>
