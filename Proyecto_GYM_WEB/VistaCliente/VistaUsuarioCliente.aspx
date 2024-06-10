<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.VistaUsuarioCliente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {
            background-color: black;
        }
    </style>

    <div id="Vista-Usuario" class="Vista-Usuario justify-content-center ms-5">

        <div id="noticias" class="d-flex justify-content-center align-items-center mb-5 mt-5">

            <div class="d-flex justify-content-center justify-content-center me-5 ms-5">
                <div class="col-2 d-flex me-2 ms-2">
                    <div class="card" style="width: 18rem;">
                        <img src="/Assets/usuario1.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title"><% =Perfil.Nombre+" "+Perfil.Apellido %> </h4>
                            <h5 class="card-text">Plan: <%=Plan.Tipo_Plan  %></h5>
                            <h5 class="card-text">Dni: <%=Perfil.DNI  %></h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                        </div>
                    </div>
                </div>

                <div class="col-8 d-flex justify-content-center m-5">

                    <asp:Label ID="LblInformacion" runat="server" Font-Size="X-Large" ForeColor="White" BorderStyle="Double" BorderColor="#009933" Text="En este Text van a recibir las noticias con respecto al gimnasio, sea horarios de feriados, o algun informacion relevante"></asp:Label>

                </div>




                <div class="col-2 d-flex me-5">
                    <div class="card" style="width: 18rem;">
                        <img src="/Assets/Lionel_Scaloni_-_2022.jpg" class="card-img-top" alt="Assets/usuario.png">
                        <div class="card-body">
                            <h4 class="card-title">Lionel Scaloni </h4>
                            <h5 class="card-text">Entrenador</h5>
                            <br />
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center">Ver Perfil</a>
                            <a href="VistaPerfilUsuarioCliente.aspx" class="btn btn-secondary d-flex justify-content-center mt-2">Solicitar Rutina</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class="row">
        <div class="card-body d-flex justify-content-center me-5">
            <asp:GridView ID="GridViewRutinas" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered bg-light">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre"></asp:BoundField>
                    <asp:BoundField DataField="descripcion" HeaderText="Descripción"></asp:BoundField>
                    <asp:BoundField DataField="estado" HeaderText="Estado"></asp:BoundField>
                    <asp:TemplateField HeaderText="Ejercicios">
                        <ItemTemplate>
                            <asp:Repeater ID="RepeaterEjercicios" runat="server">
                                <ItemTemplate>
                                    <div>
                                        <strong><%# Eval("ejercicio.Nombre") %></strong>
                                        <br />
                                        Día: <%# Eval("dia") %>
                                        <br />
                                        Hora: <%# Eval("hora") %>
                                    </div>
                                    <hr />
                                </ItemTemplate>
                            </asp:Repeater>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
