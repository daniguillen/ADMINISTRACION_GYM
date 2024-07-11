<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaAsignarRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaAsignarRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NavbarUsuarios" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarEntrenador" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh;
        }
    </style>
    <div class="container mt-5">
        <div class="text-end">

            <asp:Button ID="btnvolver" runat="server" Text="🢀" OnClick="btnvolver_Click" />
        </div>
        <div class="d-flex justify-content-between align-items-center mb-4">
            <h2 style="color: white">ASIGNACION DE RUTINA</h2>
            <div class="d-flex align-items-center" style="color: white">
                <asp:Label Text="BUSCAR:" runat="server" AssociatedControlID="TxtBusqueda" class="mt-4"/>
                <asp:TextBox runat="server" ID="TxtBusqueda" CssClass="form-control mt-4 mx-1" AutoPostBack="true" OnTextChanged="TxtBusqueda_TextChanged" />

            </div>
        </div>
        <asp:Label ID="lblUsuarioID" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lblAsignarRutinaID" runat="server" Text="" Visible="false"></asp:Label>


        <div class="table-responsive mx-auto">
            <asp:GridView runat="server" ID="dgvRutinas" CssClass="table table-striped table-bordered table-dark" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="ID Rutina" DataField="ID" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button Text="Asignar Rutina" runat="server" CommandArgument='<%#Eval("ID") %>' ID="btnAsignarRutina" OnClick="btnAsignarRutina_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>



</asp:Content>
