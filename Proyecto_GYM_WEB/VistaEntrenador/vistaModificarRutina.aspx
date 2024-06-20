<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaModificarRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaModificarRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">

            <div class="col-md-6">
                <div class="mb-3">
                    <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
                    <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                    <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">               
                <div class="mb-3">
                    <label for="lblHorario" class="form-label">HORARIO:</label>
                    <asp:DropDownList ID="ddlHorario" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
                    <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
                </div>
            </div>
            <div>
                <asp:Button ID="btnModificarRutina" Text="Guardar Cambios" runat="server" CssClass="btn btn-primary m-2" OnClick="btnModificarRutina_Click" />
                 <asp:Button ID="btnVolver" runat="server" Text="Cancelar" CssClass="btn btn-secondary m-2" OnClick="btnVolver_Click"/>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hfRutinaID" runat="server" />
</asp:Content>
