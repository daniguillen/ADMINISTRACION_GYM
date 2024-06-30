<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Proyecto_GYM_WEB.VistasAministrador.Administracion" %>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" Style="background-image: url(../Assets/Gaming0_generated.jpg);" runat="server">
    <style>
        body {
            background-image: url(../Assets/Gaming0_generated.jpg);
            background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-attachment: fixed; /* Fija la imagen al fondo */
            background-position: center; /* Centra la imagen */
            min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
        }

        .panel {
            background: rgba(0, 0, 0, 0.7); /* Fondo negro semitransparente */
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 20px;
        }

        .panel h5, .panel p, .panel input {
            color: white;
        }

        .btn-primary {
            background-color: #007bff;
            border-color: #007bff;
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
                    <h5 class="text-white">Administrar Permiso</h5>
                    <p class="text-dark font-weight-bold">Modificar, habilitar y deshabilitar</p>
                    <asp:Button ID="Button7" CssClass="btn btn-primary" Text="Administrar Permiso" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Buscar Usuario</h5>
                    <asp:TextBox ID="TextBox1" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" CssClass="btn btn-primary" Text="Buscar Usuario" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Buscar Entrenador</h5>
                    <asp:TextBox ID="TextBox2" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" CssClass="btn btn-primary" Text="Buscar Entrenador" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Historial de Usuario</h5>
                    <asp:TextBox ID="TextBox3" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" CssClass="btn btn-primary" Text="Ver Historial" OnClick="IrAHistorial" runat="server" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Reportes de Asistencia</h5>
                    <asp:TextBox ID="TextBox4" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button4" CssClass="btn btn-primary" Text="Generar Reporte" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Modificar Precio de los Planes</h5>
                    <p class="text-dark font-weight-bold">Configura ajustes del sistema del gimnasio.</p>
                    <asp:Button ID="Button5" CssClass="btn btn-primary" Text="Modificar Precios" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Agregar Nuevo Usuario/Entrenador</h5>
                    <p class="text-dark font-weight-bold">Añade nuevos usuarios o entrenadores al sistema.</p>
                    <asp:Button ID="BtnRegistro" CssClass="btn btn-primary" Text="Agregar" OnClick="IrARegistro" runat="server" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Mensaje a Clientes y Entrenadores</h5>
                    <asp:TextBox ID="TextBox5" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button8" CssClass="btn btn-primary" Text="Enviar Mensaje" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Clientes que No Han Pagado el Mes</h5>
                    <p class="text-dark font-weight-bold">Lista de clientes pendientes de pago.</p>
                    <asp:Button ID="Button9" CssClass="btn btn-primary" Text="Ver Clientes" OnClick="IrAUsuario" runat="server" />
                </div>
            </div>

            <div class="col-md-4">
                <div class="panel">
                    <h5 class="text-white">Reporte de Ganancias</h5>
                    <p class="text-dark font-weight-bold">Genera reportes de ingresos del gimnasio.</p>
                    <asp:Button ID="Button10" CssClass="btn btn-primary" Text="Generar Reporte" OnClick="IrARegistro" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
