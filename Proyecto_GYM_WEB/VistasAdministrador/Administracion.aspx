<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAministrador.Administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Style="background-image: url(../Assets/Gaming0_generated.jpg);" runat="server">

    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-position: center;
            min-height: 100vh;
        }

        .panel {
            background: rgba(0, 0, 0, 0.7);
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 20px;
        }

            .panel h5, .panel p, .panel input {
                color: white;
            }

        .btn-primary {
            border-color: #2C6D00;
            background: linear-gradient(to left, #74EB1E, #2C6D00);
        }

        .text-dark {
            color: white !important;
        }

        .font-weight-bold {
            font-weight: bold;
        }
    </style>

    <div class="container mt-5">
        <h2 class="text-center mb-4 text-white">Panel de Administración</h2>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Administrar Usuarios y Entrenadores</h5>
                    <p class="text-dark font-weight-bold">Modificar, habilitar y deshabilitar</p>
                    <asp:Button ID="BtnIrUsuario" CssClass="btn btn-primary" Text="Usuarios y Entrenadores" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Administrar Rutina</h5>
                    <p class="text-dark font-weight-bold">Modificar, habilitar y deshabilitar</p>
                    <asp:Button ID="Button6" CssClass="btn btn-primary" Text="Administrar Rutina" OnClick="IrAModificarRutina" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Aprobar Apto Fisico</h5>
                    <p class="text-dark font-weight-bold">Verificas los Aptos</p>
                    <button id="btnModalPermiso" type="button" class="btn btn-primary">Ver</button>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Historial de Usuario por DNI</h5>
                    <br />
                    <br />
                    <button type="button" id="btnModalHistorial" class="btnModalHistorial btn btn-primary">Historial</button>
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Modificar Precio de los Planes</h5>
                    <br />
                    <br />
                    <button type="button" id="BtnModificarPrecio" class="btnModal btn btn-primary">Modificar</button>
                    <asp:Label ID="CambioPrecio" runat="server" Text="" CssClass="text-white"></asp:Label>

                </div>
            </div>
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Mensaje a Clientes y Entrenadores</h5>
                    <br />
                    <br />
                    <button id="btnModalMensaje" type="button" class="btn btn-primary">Mensaje</button>
                    <asp:Label ID="LblMensaje" CssClass="text-white" Visible="false" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>


        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Cantidad de Usuarios</h5>
                    <br />
                    <br />
                    <h2 id="" class="table-responsive-lg text-white text-center"><%=usuarios %></h2>
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Cantidad de Entrenadores</h5>
                    <br />
                    <br />
                    <h2 id="" class="table-responsive-lg text-white text-center"><%=entrenadores %></h2>


                </div>
            </div>
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Cobrar</h5>
                    <br />
                    <br />
                    <button id="btnModalPago" type="button" class="btn btn-primary">Pagar</button>
                    <asp:Label ID="NoseEncuentraUsuario" CssClass="text-white" Visible="false" runat="server" Text=""></asp:Label>


                </div>
            </div>

        </div>



















        <!--
        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Reportes de Asistencia</h5>

                    <asp:Button ID="Button4" CssClass="btn btn-primary" Text="Generar Reporte" runat="server" />
                </div>
            </div>


            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Registro</h5>

                    <asp:Button ID="BtnRegistro" CssClass="btn btn-primary" Text="Agregar" OnClick="IrARegistro" runat="server" />
                </div>
            </div>
        </div>

        <div class="row">


            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Clientes que No Han Pagado el Mes</h5>

                    <asp:Button ID="Button9" CssClass="btn btn-primary" Text="Ver Clientes" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Estado Financiero</h5>

                    <asp:Button ID="Button10" CssClass="btn btn-primary" Text="Generar Reporte" OnClick="IrARegistro" runat="server" />
                </div>
            </div>
        </div>
        <!-- Modal para Modificar precio planes -->

        <div class="modal fade" id="ModalPrecio" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Modificar Precio de Planes</h5>
                        <button type="button" class="btn-close" aria-label="Close" onclick="$('#ModalPrecio').modal('hide');"></button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label for="DdlPlan">Plan:</label>
                            <asp:DropDownList ID="DdlPlan" runat="server" CssClass="form-control" ClientIDMode="Static">
                                <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                                <asp:ListItem Text="Básico" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Estándar" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Premium" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="NuevoPrecio">Nuevo Precio:</label>
                            <asp:TextBox ID="TxtNuevoPrecio" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">

                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">
                            Cancelar</button>
                        <asp:Button ID="BtnGuardarCambios" runat="server" Text="Guardar Cambios" CssClass="btn btn-primary" OnClick="BtnCambiarPrecioPlanes" />
                    </div>
                </div>
            </div>
        </div>
        <!-- Fin Modal para Modificar precio planes -->




        <!-- Modal para Modificar Historial -->

        <div class="modal fade" id="ModalHistorial" tabindex="-1" aria-labelledby="LblModalHistorial" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="LblModalHistorial">Ingrese el DNI</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:TextBox ID="TxtDNI" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                        <asp:Button ID="Button1" runat="server" Text="Buscar Historial" CssClass="btn btn-primary" OnClick="BuscarHistorial" />
                    </div>
                </div>
            </div>
        </div>

        <!-- Fin Modal para Modificar Historial -->


        <!-- Modal para Modificar Permiso -->

        <div class="modal fade" id="ModalPermiso" tabindex="-1" aria-labelledby="LblModalPermiso" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="LblModalPermiso">Ingrese el DNI</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="SingleLine" ClientIDMode="Static"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                        <asp:Button ID="Button2" runat="server" Text="Buscar Historial" CssClass="btn btn-primary" OnClick="BuscarHistorial" />
                    </div>
                </div>
            </div>
        </div>

        <!-- Fin Modal para Modificar Permiso -->




        <!-- Modal para Mensajes -->

        <div class="modal fade" id="ModalMensaje" tabindex="-1" aria-labelledby="LblModalMensaje" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="LblModalMensaje">Ingrese el Mensaje</h5>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:TextBox ID="TextMensaje" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                        <asp:Button ID="MensajeAClienteEntrenadores" CssClass="btn btn-primary" Text="Enviar Mensaje" OnClick="Mensaje" runat="server" />
                    </div>
                </div>
            </div>
        </div>

        <!-- Fin Modal para Mensajes-->



          <!-- Modal para Pagar -->

  <div class="modal fade" id="ModalPago" tabindex="-1" aria-labelledby="LblModalMensaje" aria-hidden="true">
      <div class="modal-dialog modal-dialog-centered">
          <div class="modal-content">
              <div class="modal-header">
                  <h5 class="modal-title" id="LblModalPago">Ingrese el DNI</h5>
                  <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
              </div>
              <div class="modal-body">
                  <div class="form-group">
                      <asp:TextBox ID="TxtDniUsuarioPagar" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                  </div>
              </div>
              <div class="modal-footer">
                  <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                  <asp:Button ID="Button3" CssClass="btn btn-primary" Text="Buscar" OnClick="Pagar" runat="server" />
              </div>
          </div>
      </div>
  </div>

  <!-- Fin Modal para Pagar-->
    </div>

    <script>

        $(document).ready(function () {
            // Verifica si el modal existe
            var modal = $('#ModalPrecio');
            var modal2 = $('#ModalHistorial');
            var modal3 = $('#ModalPermiso');
            var modal4 = $('#ModalMensaje');
            var modal5 = $('#ModalPago');
            if (modal.length > 0) {
                // Agrega el evento click al botón
                $('#BtnModificarPrecio').click(function () {
                    modal.modal('show');
                });
            }
            if (modal2.length > 0) {
                // Agrega el evento click al botón
                $('#btnModalHistorial').click(function () {
                    modal2.modal('show');
                });
            }
            if (modal3.length > 0) {
                // Agrega el evento click al botón
                $('#btnModalPermiso').click(function () {
                    modal3.modal('show');
                });
            } if (modal4.length > 0) {
                // Agrega el evento click al botón
                $('#btnModalMensaje').click(function () {
                    modal4.modal('show');

                });
            } if (modal5.length > 0) {
                // Agrega el evento click al botón
                $('#btnModalPago').click(function () {
                    modal5.modal('show');

                });
            }
        });


    </script>
</asp:Content>
