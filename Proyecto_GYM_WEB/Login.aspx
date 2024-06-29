﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto_GYM_WEB.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="video-container">
    <video autoplay muted loop id="videoFondo">
        <source src="Assets/vecteezy_animated-green-color-fading-particles-background_24476461.mp4" type="video/mp4"  >
        Your browser does not support the video tag.
   
    <div class="row">
        <div class="col-4"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtMail" class="form-label">Email</label>
                <asp:TextBox CssClass="form-control"  type="email" ID="txtMail" runat="server" placeholder="Mail" />

            </div>
            <div class="mb-3">
                <label for="txtContraseña" class="form-label">Password</label>
                <asp:TextBox ID="txtContraseña" CssClass="form-control" type="password" runat="server" placeholder="Contraseña" />
            </div>

            <div>
                <asp:Button type="submit" ID="btnIngresoSesion" Text="Iniciar Sesión" runat="server" CssClass="btn btn-primary" OnClick="btnIngresoSesion_Click"/>
            </div>
            <div class="mt-3">
                <a href="RegistroPersona.aspx">Registrarse</a>
            </div>
        </div>
        <div class="col-4"></div>
    </div>
    </video>

    </div>




</asp:Content>
