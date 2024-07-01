<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaPerfilUsuarioCliente.aspx.cs" Inherits="Proyecto_GYM_WEB.PerfilUsuario" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
     <style>
         body {
             background-image: url(../Assets/Gaming0_generated.jpg);
             background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
             background-repeat: no-repeat; /* Evita que la imagen se repita */
             background-attachment: fixed; /* Fija la imagen al fondo */
             background-position: center; /* Centra la imagen */
             min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
         }
     </style>

            <div class="container" ">
                    <div class="col-12">
                        <h1>Perfil</h1>

                     </div>
                <div class="row"  >
           <!--FOTO DE PERFIL-->
            <div class="col-4 ">
           
               <div class="card" style="width: 18rem; background-image: url('../Assets/fondocard.jpg'); background-size: cover; background-repeat: no-repeat; background-position: center;">
                  
                  <asp:Image ID="ImagePerfil" ImageUrl="<%=usuario.Foto%>" runat="server" />
                    <div class="card-body">
                        <h4 class="card-title"><%= usuario.Nombre+" "+usuario.Apellido %> </h4>
                        <h5 class="card-text">Plan: <%=usuario.plan.Tipo_Plan  %></h5>
                        <h5 class="card-text">Dni: <%=usuario.DNI  %></h5>
                          <% if (!nivel.Equals("2"))
                              {%> 
                        <input type="file" id="txtimagen" runat="server"  class="form-control" CssClass="btn btn-secondary btn-icon-split"/>
                           <%}%>
                    </div>
                </div>
            </div>
            <div class="col-4 panel">
                <!--DATOS DE LA PERSONA--->
                <div class="form-group">

                    <label  for="TxtDniEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%> )  >DNI</label>
                    <asp:TextBox ID="TxtDniEditar" runat="server" CssClass="form-control text-black"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtNombreEditar" Class="text-light mt-2">Nombre:</label>
                    <asp:TextBox ID="TxtNombreEditar" runat="server" CssClass="form-control text-black"></asp:TextBox>

                </div>

                <div class="form-group">
                    <label for="TxtApellidoEditar" Class="text-light mt-2">Apellido:</label>
                    <asp:TextBox ID="TxtApellidoEditar" runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtPlanEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%>>Plan:</label>
                    <asp:TextBox ID="TxtPlanEditar" runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtCelularEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%>>Celular:</label>
                    <asp:TextBox ID="TxtCelularEditar" runat="server" CssClass="form-control text-black"></asp:TextBox>
                </div>
                </div>
                <div class="col-md-4 panel">
                <div class="form-group">
                    <label for="TxtTelEmergenciaEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%>>Tel Emergencia:</label>
                    <asp:TextBox ID="TxtTelEmergenciaEditar" runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtEmailEditar" Class="text-light mt-2">Email:</label>
                    <asp:TextBox ID="TxtEmailEditar" runat="server" CssClass="form-control text-black"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtPasswordEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%>>Password:</label>
                    <asp:TextBox ID="TxtPasswordEditar" runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtFechaNacimientoEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%> >Fecha Nacimiento:</label>
                    <asp:TextBox ID="TxtFechaNacimientoEditar" Type="date"  runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="TxtSexoEditar"  Class="text-light mt-2" <% if (nivel.Equals("2"))
                        {%> style="display:none" <%}%>>Sexo:</label>
                       
                     <asp:DropDownList ID="DdlSexo" runat="server" CssClass="form-control">
                         <asp:ListItem Text="Seleccione..." Value=""></asp:ListItem>
                         <asp:ListItem Text="MASCULINO" Value="1"></asp:ListItem>
                         <asp:ListItem Text="FEMININO" Value="2"></asp:ListItem>
                         <asp:ListItem Text="BINARIO" Value="3"></asp:ListItem>
                         <asp:ListItem Text="S/D" Value="4"></asp:ListItem>
                     </asp:DropDownList>
                </div>

                <div class="form-group">
                    <label for="TxtFechaIngresoEditar" Class="text-light mt-2" <% if (nivel.Equals("2"))

                        {%> style="display:none" <%}%>>Fecha Ingreso:</label>
                    <asp:TextBox ID="TxtFechaIngresoEditar" runat="server" CssClass="form-control text-black" ></asp:TextBox>
                </div>
            </div>
                <div class=" d-flex mt-5 justify-content-center">
                     <% if (!nivel.Equals("2"))
                         {%> 
                    <asp:Button ID="BTN_Guardar" runat="server" Text="Guardar" CssClass="btn btn-secondary btn-icon-split" OnClick="BTN_Guardar_Click"/>
                    <%}%>
                    <a href="/VistaCliente/VistaUsuarioCliente.aspx" class="btn btn-secondary btn-icon-split ms-5">
                        <span class="icon text-white-50">
                            <i class="fas fa-arrow-right"></i>
                        </span>
                        <span class="bottom-0">volver</span>
                    </a>

                </div>
             </div>
      </div>
    
</asp:Content>

