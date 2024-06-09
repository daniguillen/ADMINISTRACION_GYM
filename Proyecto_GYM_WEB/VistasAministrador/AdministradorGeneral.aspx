<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AdministradorGeneral.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorGeneral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark">
        <asp:Literal ID="LiteralUsuarios" runat="server" Text="<h1>Usuarios</h1>" />
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around w-100">
                <div class="d-flex justify-content-between ">
                    <asp:Button ID="BtnEntrenador" CssClass="btn btn-primary m-2" runat="server" Text="Entrenadores" OnClick="Entrenadores" />
                    <asp:Button ID="BtnUsuario" CssClass="btn btn-primary m-2" runat="server" Text="Usuarios" OnClick="Usuarios" />
                    <asp:Button ID="BtnRutina" CssClass="btn btn-primary m-2" runat="server" Text="Rutinas" />
                </div>
                <div class="d-flex justify-content-lg-around">
                    <asp:Label AssociatedControlID="TxtBusquedad" runat="server" Text="Filtrar por: " CssClass="text-light m-1"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select m-1">
                        <asp:ListItem Text="Usuario" Value="Usuario"></asp:ListItem>
                        <asp:ListItem Text="Entrenador" Value="Entrenador"></asp:ListItem>
                        <asp:ListItem Text="Rutina" Value="Rutina"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TxtBusquedad" CssClass="form-control m-1 bg-dark text-light" runat="server"></asp:TextBox>
                    <asp:Button ID="BtnBuscar" CssClass="btn btn-primary m-1" runat="server" OnClick="Buscar" Text="Buscar" UseSubmitBehavior="false" />
                </div>
            </li>
        </ul>
        <div class="m-2">
            <div class="bg-dark text-light">
                <h5 class="mb-2">Mensajes a usuarios y entrenadores</h5>
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-light mt-2"></asp:Label>
            </div>
            <div class="">
                <asp:TextBox ID="TextBox1" CssClass="form-control mb-lg-1 bg-dark text-light" runat="server"></asp:TextBox>
                <asp:Button ID="BtnMensaje" runat="server" CssClass="btn btn-primary mt-2 mb-3" Text="Guardar Mensaje" />
            </div>
        </div>

        <div class="table-responsive">
            <table id="datatablesSimple" class="table table-striped table-bordered table-dark">
                <thead>
                    <tr>
                        <th>Dni</th>
                        <th>Nombre Completo</th>
                        <th>Plan</th>
                        <th>Celular</th>
                        <th>Tel Emergencia</th>
                        <th>Email</th>
                        <th>Password</th>
                        <th>Edad</th>
                        <th>Sexo</th>
                        <th>Fecha Ingreso</th>
                        <th>Estado</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeaterUsuarios" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("DNI") %></td>
                                <td><%# Eval("Nombre") + " " + Eval("Apellido") %></td>
                                <td><%# Eval("plan.Tipo_Plan") %></td>
                                <td><%# Eval("Cel") %></td>
                                <td><%# Eval("Tel_Emergencia") %></td>
                                <td><%# Eval("Mail") %></td>
                                <td><%# Eval("Password") %></td>
                                <td>
                                    <%# DateTime.Now.Year - Convert.ToDateTime(Eval("Fecha_Nacimiento")).Year - (Convert.ToDateTime(Eval("Fecha_Nacimiento")).Date > DateTime.Now.Date ? 1 : 0) %>
                                </td>
                                <td><%# Eval("Sexo.Tipo") %></td>
                                <td>
                                    <%# Convert.ToDateTime(Eval("Fecha_ingreso")).Day + " / " + Convert.ToDateTime(Eval("Fecha_ingreso")).Month + " / " + Convert.ToDateTime(Eval("Fecha_ingreso")).Year %>
                                </td>
                                <td><%# Convert.ToBoolean(Eval("Estado")) ? "Activo" : "Inactivo" %></td>
                                <td>
                                    <a href="AdministradorEditarUsuario.aspx?id=<%# Eval("ID") %>" class="btn btn-secondary btn-icon-split">
                                        <span class="icon text-white-50">
                                            <i class="fas fa-arrow-right"></i>
                                        </span>
                                        <span class="bottom-0">Editar</span>
                                    </a>
                                    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnEliminar_Persona_Command" />
                                    <asp:Button ID="BtnAgregar" runat="server" Text="Activar" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnActivar" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                                   
                </tbody>
            </table>
        </div>
    </div>
    
</asp:Content>

