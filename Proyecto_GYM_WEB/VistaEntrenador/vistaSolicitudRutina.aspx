<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaSolicitudRutina.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaEntrenador.vistaSolicitudRutina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NavbarUsuarios" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarEntrenador" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <h2>SOLICITUDES DE RUTINA</h2>
        <div class="table-responsive mx-auto">
            <asp:GridView runat="server" ID="dgvSolicitudes" CssClass="table table-striped table-bordered table-dark" AutoGenerateColumns="false">
                <Columns>
                  
                    <asp:BoundField HeaderText="Solicitud" DataField="ID_SolicitudRutinas" />
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <%# Eval("usuario.Nombre") + " " + Eval("usuario.Apellido") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Comentarios" DataField="Mensaje" />
                    <asp:BoundField HeaderText="Fecha" DataField="FechaSolicitud" />
                    
                    <%--<asp:TemplateField>
                        <ItemTemplate>
                                                       <asp:Button Text="Ver detalles" ID="btnVerDetalles" runat="server" CommandArgument='<%#Eval("ID_SolicitudRutinas") %>' CssClass="btn btn-secondary" OnClick="btnVerDetalles_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                </Columns>
            </asp:GridView>
        </div>
    </div>


</asp:Content>
