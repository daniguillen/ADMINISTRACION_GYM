<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto_GYM_WEB.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <video autoplay muted loop id="videoFondo">
            <source  src="Assets/vecteezy_animated-green-color-fading-particles-background_24476461.mp4" type="video/mp4">
            Your browser does not support the video tag.
        </video>
    <div class="video-container d-flex flex-column justify-content-center min-vh-100 align-items-center">
        
           
           
                <div >
                    <label for="txtMail" class="form-label text-white ">Email</label>
                    <asp:TextBox CssClass="form-control mb-3" type="email" ID="txtMail" runat="server" placeholder="Mail" />

                </div>
                <div >
                    <label for="txtContraseña" class="form-label text-white">Password</label>
                    <asp:TextBox ID="txtContraseña" CssClass="form-control mb-3" type="password" runat="server" placeholder="Contraseña" />
                </div>

                <div>
                    <asp:Button type="submit" ID="btnIngresoSesion" Text="Iniciar Sesión" runat="server" CssClass="btn btn-primary mt-3 mb-3" OnClick="btnIngresoSesion_Click" />
                </div>
                <div >
                    <a href="RegistroPersona.aspx" class="text-white">Registrarse</a>
                </div>
           
           
        </div>






</asp:Content>
