<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarEjercicio.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.ModificarEjercicio" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
    <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="row mb-3">
                <div class="col-md-12 modal-dialog-centered">
                    <label for="txtNombreEjercicio" id="lblNombre" class="form-label">NOMBRE:</label>
                    <asp:TextBox runat="server" ID="txtNombreEjercicio" CssClass="form-control" />
                </div>
            </div>
            <div class="row mb-3">
                <label for="lblEjercicios" class="form-label">DESCRIPCIÓN:</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" Rows="5" />
            </div>
            <div class="row mb-3">
                <div class="col-md-6">
                    <label for="lblVideo" class="form-label">INGRESE URL DEL VIDEO:</label>
                    <asp:TextBox ID="txtVideo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                    <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="row mb-3">
                    <div class="col-md-6 ">
                        <label for="lblIdGrupoMusc" class="form-label">GRUPO MUSCULAR:</label>
                        <asp:DropDownList ID="ddlGrupoMuscu" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <label for="lblIdTipo" class="form-label">TIPO:</label>
                        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="col-md-6">
                        <label for="lblIDDificultad" class="form-label">DIFICULTAD:</label>
                        <asp:DropDownList ID="ddlDificultad" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>

 <div class="row">
     <div class="col-12">
         <asp:Button ID="btnGuardarCambiosEjercicio" Text="Guardar Cambios" runat="server" CssClass="btn btn-primary m-2"  OnCLick="btnGuardarCambiosEjercicio_Click"/>
         <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">Cancelar</a>
     </div>
 </div>










</asp:Content>
