<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaModificarRutinaEjercicio.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaModificarRutinaEjercicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="container">
    <div class="row">
        <div class="col-md-6">
            <div class="mb-3">
                <label for="lblEjercicios" class="form-label">SELECCIONE EJERCICIOS:</label>
                <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:ListBox>
            </div>
            <div>
                <label for="txtRepeticiones">REPETICIONES:</label>
                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:Button ID="btnModificarRutinaEjercicio" Text="Guardar Cambios" runat="server" CssClass="btn btn-primary m-2"  Onclick="btnModificarRutinaEjercicio_Click"/>
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CssClass="btn btn-secondary m-2"/> 
        </div>
    </div>
</div>

<asp:HiddenField ID="hfIdEjercicio" runat="server" />










</asp:Content>

