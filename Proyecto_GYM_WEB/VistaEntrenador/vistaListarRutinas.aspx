<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vistaListarRutinas.aspx.cs" Inherits="Proyecto_GYM_WEB.vistaListarRutinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container-fluid pb-xxl-1 align-items-center min-vh-100 px-4 bg-dark ">
        <h1>GRILLA DE RUTINAS</h1>
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
                        <td>RUTINA</td>
                        <td>DESCRIPCION</td>
                        <td>DIA</td>
                        <td>EJERCICIOS</td>
                        <td>REPETICIONES</td>
                        <td>ACCIONES</td>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeaterListarRutina" runat="server">

                        <ItemTemplate>
                            <tr>
                                <td hidden><%# Eval("ID_Rutina") %></td>
                                <td><%# Eval("NombreRutina") %></td>
                                <td><%# Eval("DescripcionRutina") %></td>
                                <td><%# Eval("DiaNombre") %></td>
                                <td><%# Eval("NombreEjercicio") %></td>
                                <td><%# Eval("Repeticiones") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>




    <script>        


</script>
</asp:Content>

