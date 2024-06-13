﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaModificarRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaModificarRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="mb-3">
            <label for="lblNombreRutina" class="form-label">NOMBRE RUTINA:</label>
            <asp:TextBox ID="txtNombreRutina" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
            <asp:TextBox ID="txtDescripcionRutina" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="lblDia" class="form-label">DIA DE LA RUTINA:</label>
            <asp:DropDownList ID="ddlDia" runat="server" CssClass="form-control btn-secondary"></asp:DropDownList>
        </div>
        <div class="row-cols-3">
            <div class="mb-3">
                <label for="lblEjercicios" class="form-label">SELECCIONE EJERCICIOS:</label>
                <asp:ListBox ID="lbxEjercicio" runat="server" CssClass="form-control" SelectionMode="Multiple"></asp:ListBox>
            </div>
            <div>
                <label for="txtRepeticiones">REPETICIONES:</label>
                <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <%--<div class="mb-3">
            <label for="lblHorario" class="form-label">HORARIO:</label>
            <asp:TextBox ID="txtHora" runat="server" CssClass="form-control"></asp:TextBox>
        </div>--%>

            <div>
                <asp:Button ID="btnModificarRutina" Text="text" runat="server" CssClass="form-control" Onclick="btnModificarRutina_Click"/>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hfRutinaID" runat="server"/>
</asp:Content>