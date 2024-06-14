<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="AdministradorGeneral.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAministrador.AdministradorGeneral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark">
        <asp:Literal ID="LiteralUsuarios" runat="server" Text="<h1>Usuarios</h1>" />
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around w-100">
                <div class="d-flex justify-content-between ">
                    <asp:Button ID="BtnEntrenador" CssClass="btn btn-primary m-2" runat="server" Text="Entrenadores" OnClick="Entrenadores" />
                    <asp:Button ID="BtnUsuario" CssClass="btn btn-primary m-2" runat="server" Text="Usuarios" OnClick="Usuarios" />
                    <asp:Button ID="BtnRutina" CssClass="btn btn-primary m-2" runat="server" Text="Rutinas" OnClick="Rutinas" />
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
            <asp:Label ID="TextBox2" runat="server" Text="" CssClass="text-light mt-2"></asp:Label>

            <div class="">
                <asp:TextBox ID="TextBox1" CssClass="form-control mb-lg-1 bg-dark text-light" runat="server"></asp:TextBox>
                <asp:Button ID="BtnMensaje" runat="server" CssClass="btn btn-primary mt-2 mb-3" Text="Guardar Mensaje" OnClick="MensajeAUsuarioYEntrenadores" />
            </div>
        </div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="table-responsive mx-auto">
                    <table id="datatablesSimple" class="table table-striped table-bordered table-dark ">
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
                                        <td class="BotonesTablaAdministrador">
                                            <asp:Button ID="BtnModal" runat="server" OnCommand="Modificar" Text="Modificar" CssClass="btn btn-secondary btn-icon-split btnAdministrador"
                                                OnClientClick='<%# "showModal(\"" + Eval("DNI") + "\",\"" + Eval("Nombre") + "\",\"" + Eval("Apellido") + "\",\"" + Eval("plan.Tipo_Plan") + "\",\"" + Eval("Cel") + "\",\"" + Eval("Tel_Emergencia") + "\",\"" + Eval("Mail") + "\",\"" + Eval("Password") + "\",\"" + Eval("Sexo.Tipo") + "\",\"" + Eval("Estado") + "\"); return false;" %>' CommandArgument='<%# Eval("ID") + "," + Eval("DNI") + "," + Eval("Nombre") + "," + Eval("Apellido") + "," + Eval("plan.Tipo_Plan") + "," + Eval("Cel") + "," + Eval("Tel_Emergencia") + "," + Eval("Mail") + "," + Eval("Password") + "," + Eval("Sexo.Tipo") + "," + Eval("Estado") %>' />
                                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" class="btn btn-secondary btn-icon-split btnAdministrador" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnEliminar_Persona_Command" />
                                            <asp:Button ID="BtnAgregar" runat="server" Text="Activar" class="btn btn-secondary btn-icon-split btnAdministrador" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnActivar" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>



    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modificar</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="TxtDNI">DNI:</label>
                        <asp:TextBox ID="TxtDNI" runat="server" CssClass="form-control" TextMode="SingleLine" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtNombre">Nombre:</label>
                        <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtApellido">Apellido:</label>
                        <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtPlan">Plan:</label>
                        <asp:TextBox ID="TxtPlan" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtTelEmerg">Tel Emergencia:</label>
                        <asp:TextBox ID="TxtTelEmerg" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtMail">Email:</label>
                        <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtSexo">Sexo:</label>
                        <asp:TextBox ID="TxtSexo" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TxtEstado">Estado:</label>
                        <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                    <asp:Button ID="BtnGuardarCambios" runat="server" Text="Guardar Cambios" CssClass="btn btn-primary" OnClick="BtnGuardarCambios_Click" />
                </div>
            </div>
        </div>
    </div>







    <script>
        function showModal(dni, nombre, apellido, plan, cel, telEmergencia, mail, password, sexo, estado) {
            document.getElementById('<%= TxtDNI.ClientID %>').value = dni;
            document.getElementById('<%= TxtNombre.ClientID %>').value = nombre;
            document.getElementById('<%= TxtApellido.ClientID %>').value = apellido;
            document.getElementById('<%= TxtPlan.ClientID %>').value = plan;
            document.getElementById('<%= TxtTelEmerg.ClientID %>').value = telEmergencia;
            document.getElementById('<%= TxtMail.ClientID %>').value = mail;
            document.getElementById('<%= TxtSexo.ClientID %>').value = sexo;
            document.getElementById('<%= TxtEstado.ClientID %>').value = estado;

            var modal = new bootstrap.Modal(document.getElementById('exampleModal'));
            modal.show();
    </script>


</asp:Content>
