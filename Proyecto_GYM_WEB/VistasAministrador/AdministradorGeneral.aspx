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
                        <asp:ListItem Text="Seleccion.." Value=""></asp:ListItem>
                        <asp:ListItem Text="Usuario" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Entrenador" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Rutina" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TxtBusquedad" CssClass="form-control m-1 bg-dark text-light" runat="server"></asp:TextBox>
                    <asp:Button ID="BtnBuscar" CssClass="btn btn-primary m-1" runat="server" OnClick="Buscar" Text="Buscar" UseSubmitBehavior="false" />
                    <asp:Label ID="Resultado" runat="server" Text="" CssClass="text-light m-1" Visible="false"></asp:Label>
                </div>
            </li>
        </ul>
        <div class="m-2">
            <div class="bg-dark text-light">
                <h5 class="mb-2">Mensajes a usuarios y entrenadores</h5>
                <asp:Label ID="Label1" runat="server" Text="Label" AssociatedControlID="TextBox1" CssClass="text-light mt-2"></asp:Label>
            </div>
            <asp:Label ID="TextBox2" runat="server" Text="dsa" CssClass="text-light mt-2"></asp:Label>

            <div class="">
                <asp:TextBox ID="TextBox1" CssClass="form-control mb-lg-1 bg-dark text-light" runat="server"></asp:TextBox>
                <asp:Button ID="BtnMensaje" runat="server" CssClass="btn btn-primary mt-2 mb-3" Text="Guardar Mensaje" OnClick="MensajeAUsuarioYEntrenadores" />
            </div>
        </div>

        <!-- Tabla de los Usuarios y Entrenadores -->
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="table-responsive mx-auto">
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
                                        <td><%# Convert.ToDateTime(Eval("Fecha_ingreso")).ToString("dd/MM/yyyy") %></td>
                                        <td><%# Eval("Estado").Equals(true) ? "Activo" : "Inactivo" %></td>
                                        <td class="BotonesTablaAdministrador">
                                            <asp:Button ID="BtnModal" runat="server" Text="Modificar" CssClass="btn btn-secondary btn-icon-split btnAdministrador"
                                                OnCommand="Modificar"
                                                CommandArgument='<%# Eval("ID") + "," + Eval("DNI") + "," + Eval("Nombre") + "," + Eval("Apellido") + "," + Eval("plan.Tipo_Plan") + "," + Eval("Cel") + "," + Eval("Tel_Emergencia") + "," + Eval("Mail") + "," + Eval("Password") + "," + Eval("Sexo.Tipo") + "," + Eval("Estado")+"," +Eval("Sexo.id")+"," +Eval("Plan.id")%>' />

                                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" class="btn btn-secondary btn-icon-split btnAdministrador" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnEliminar_Persona_Command" />
                                            <asp:Button ID="BtnActivar" runat="server" Text="Activar" class="btn btn-secondary btn-icon-split btnAdministrador" CommandArgument='<%# Eval("ID") %>' OnCommand="BtnActivar" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- Modal para Modificar -->
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog">
                        <div class="modal-content align-items-center">
                            <div class="modal-header justify-content-evenly w-100">
                                <h5 class="modal-title" id="exampleModalLabel">Modificar</h5>
                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body">
                                
                                <div class="form-group">
                                    <label for="TxtDNI">DNI:</label>
                                    <asp:TextBox ID="TxtDNI" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="TxtNombre">Nombre:</label>
                                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="TxtApellido">Apellido:</label>
                                    <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="DdlPlan">Plan:</label>
                                    <asp:DropDownList ID="DdlPlan" runat="server" CssClass="form-control" ClientIDMode="Static">
                                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                                        <asp:ListItem Text="Básico" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Estándar" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Premium" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Empleado" Value="4"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="TxtCel">Tel Personal:</label>
                                    <asp:TextBox ID="TxtCel" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="TxtTelEmerg">Tel Emergencia:</label>
                                    <asp:TextBox ID="TxtTelEmerg" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="TxtMail">Email:</label>
                                    <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="TxtPassword">Contraseña:</label>
                                    <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="DdlSexo">Sexo:</label>
                                    <asp:DropDownList ID="DdlSexo" runat="server" CssClass="form-control" ClientIDMode="Static">
                                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                                        <asp:ListItem Text="MASCULINO" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="FEMININO" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="BINARIO" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="S/D" Value="4"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="DdlEstado">Estado:</label>
                                    <asp:DropDownList ID="DdlEstado" runat="server" CssClass="form-control" ClientIDMode="Static">
                                        <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                                        <asp:ListItem Text="ACTIVO" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="INACTIVO" Value="0"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                                <asp:Button ID="BtnGuardarCambios" runat="server" Text="Guardar Cambios" CssClass="btn btn-primary" OnClick="BtnGuardarCambios_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
<script>
    function showModal(dni, nombre, apellido, planId, cel, telEmergencia, mail, password, sexoId, estado) {
        document.getElementById('<%= TxtDNI.ClientID %>').value = dni;
        document.getElementById('<%= TxtNombre.ClientID %>').value = nombre;
        document.getElementById('<%= TxtApellido.ClientID %>').value = apellido;
       
        document.getElementById('<%= DdlPlan.ClientID %>').value = planId;
        document.getElementById('<%= TxtCel.ClientID %>').value = cel;
        document.getElementById('<%= TxtTelEmerg.ClientID %>').value = telEmergencia;
        document.getElementById('<%= TxtMail.ClientID %>').value = mail;
        document.getElementById('<%= TxtPassword.ClientID %>').value = password;
        document.getElementById('<%= DdlSexo.ClientID %>').value = sexoId;
        document.getElementById('<%= DdlEstado.ClientID %>').value = estado;

        var modal = new bootstrap.Modal(document.getElementById('exampleModal'));
        modal.show();

    }
</script>
</asp:Content>
