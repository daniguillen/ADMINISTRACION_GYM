<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AprobarAptoFisico.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAdministrador.WebForm1" %>

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
</style>


<div class="container panel mt-5">
    <h2 class="text-center mb-4 text-white">Aptos Fisicos</h2>


    <div class="row mb-3 text-white panel">
        <div class="col-md-12">
            <table class="table text-white">
                <thead class="text-white">
                    <tr>
                        <th>DNI</th>
                        
                        <th>Apto Fisico</th>
                        <th>Estado</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody class="text-white">
                    <asp:Repeater ID="RepeaterHistorial" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td class="text-white text-center align-middle"><%# Eval("id") %></td>
                                <td class="text-white text-center align-middle"><%# String.Format("{0:dd/MM/yyyy}", Eval("FechaPago")) %></td>
                                <td class="text-white text-center align-middle"><%# Eval("Plan") %></td>
                                <td class="text-white text-center align-middle"><%# Eval("Pago") %></td>
                              
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>


        </div>
    </div>

    <div class="row">
        <div class="col-md-12 text-white">
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Volver" />
        </div>
    </div>

</div>
</asp:Content>