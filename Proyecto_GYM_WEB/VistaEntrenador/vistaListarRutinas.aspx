<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaListarRutinas.aspx.cs" Inherits="Proyecto_GYM_WEB.vistaListarRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>RUTINA STANDART</h1>
        <ul class="breadcrumb mb-4 w-100">
            <li class="d-flex justify-content-around">
                <div class="d-flex justify-content-between">
                </div>

            </li>
        </ul>
        <div class="table-responsive">
            <table class="table table-striped table-bordered table-dark" id="tablaRutina">
                <thead class="header-class">
                    <tr class="row-class">
                        <td>DIA - HORARIO</td>
                        <td>RUTINA</td>
                        <td>DESCRIPCION</td>
                        <td>EJERCICIOS - REPETICIONES</td>
                        <td>ACCIONES</td>
                    </tr>
                </thead>
                <tbody>
                    <% 
                        int rutinaID = -1;
                        for (int i = 0; i < ListaTablaRuti.Count(); i++)
                        {
                            bool nuevaRuti = rutinaID != ListaTablaRuti[i].ID_Rutina;
                            if (nuevaRuti)
                            {
                                rutinaID = ListaTablaRuti[i].ID_Rutina;
                            %>
                    <tr>
                        <td hidden><%= ListaTablaRuti[i].ID_Rutina %></td>
                        <td>
                            <span><%= ListaTablaRuti[i].DiaNombre %></span> -
                            <span><%= ListaTablaRuti[i].Horario %></span> Hs
                        </td>
                        <td><%= ListaTablaRuti[i].NombreRutina %></td>
                        <td><%= ListaTablaRuti[i].DescripcionRutina %></td>
                        <td>
                            <span><%= ListaTablaRuti[i].NombreEjercicio %></span> -
                            <span><%= ListaTablaRuti[i].Repeticiones %></span>
                        </td>
                        <td>
                            <a href="vistaModificarRutina.aspx?id=<%= ListaTablaRuti[i].ID_Rutina %>" class="btn btn-secondary">Editar Rutina</a>
                            <a href="vistaModificarRutinaEjercicio.aspx?id=<%=ListaTablaRuti[i].ID_Ejercicio %>&editarRutina=<%=ListaTablaRuti[i].ID_Rutina %>" class="btn btn-secondary">Editar Ejercicios</a>
                            <asp:Button ID="btnOpenModal" runat="server" CssClass="btn btn-primary m-2" Text="Detalles Rutina" OnClick="btnOpenModal_Click"/>
                        </td>
                    </tr>
                    <%
                        }
                        else
                        {
                    %>
                    <tr>
                        <td hidden><%= ListaTablaRuti[i].ID_Rutina %></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>
                            <div>
                                <span><%= ListaTablaRuti[i].NombreEjercicio %></span> - 
                               
                                <span><%= ListaTablaRuti[i].Repeticiones %> reps</span>
                            </div>
                        </td>
                        <td>

                            <a href="vistaModificarRutinaEjercicio.aspx?id=<%=ListaTablaRuti[i].ID_Ejercicio %>&editarRutina=<%=ListaTablaRuti[i].ID_Rutina %>" class="btn btn-secondary">Editar Ejercicios</a>

                        </td>
                    </tr>
                    <%
                            }
                        }
                    %>
                </tbody>
            </table>
        </div>
    </div>
     <div class="modal" id="nuevoModal" tabindex="-1">
     <div class="modal-dialog">
         <div class="modal-content">
             <div class="modal-header">
                 <h3 class="modal-title ">DETALLES RUTINA.</h3>
                 <asp:Button type="button" runat="server" ID="btnSalirX1" Text="Button" CssClass="btn-close" data-bs-dismiss="modal"  aria-label="Close" OnClick="btnSalirX1_Click"/>
             </div>
             <div class="modal-body">
                
                 <div class="container">
                     <div class="mb-3 uP">
                         <label for="lblDescripcion" class="form-label">DESCRIPCION:</label>
                         <asp:TextBox ID="txtDescripcionEj" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                     <div class="mb-3">
                         <label for="lblNombre" class="form-label">NOMBRE:</label>
                         <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
                     <div class="mb-3">
                         <label for="lblRepeticiones" class="form-label">REPETICIONES:</label>
                         <asp:TextBox ID="txtRepeticiones" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>                                                            
                 </div>
             </div>
             <div class="modal-footer">
                 <a href="VistaEntrenador-EntrenamientosABM.aspx" type="button" class="btn btn-secondary">Volver</a>
                 <%--<asp:Button type="button" CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Guardar Cambios" OnClick="btnAgregar_Click" />--%>
             </div>
         </div>
     </div>
 </div>



    <script>        

        function openModal() {
            console.log("entro al modal");
            var modal = document.getElementById('nuevoModal');
            modal.style.display = 'block';
            modal.classList.add('show');

        }
        function closeModal() {
            var modal = document.getElementById('nuevoModal');
            modal.style.display = 'none';
            modal.classList.remove('show');

        }
    </script>
</asp:Content>

