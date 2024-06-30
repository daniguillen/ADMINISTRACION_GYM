<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto_GYM_WEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <style>
     body {
         background-image: url(./Assets/Gaming0_generated.jpg);
         background-size: cover; /* Ajusta la imagen para cubrir toda la pantalla */
         background-repeat: repeat; /* Evita que la imagen se repita */
         background-attachment: fixed; /* Fija la imagen al fondo */
         background-position: center; /* Centra la imagen */
         min-height: 100vh; /* Asegura que el fondo tenga al menos la altura de la ventana */
     }
             .panel {
            background: rgba(0, 0, 0, 0.6); /* Fondo negro semitransparente */
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 20px;
        }
     </style>
  
    <main class="mainDefaul">

        <img class="img-fluid" src="Assets/Img2.png" />




        <div class="container " id="planes">
            <div class="row ">
                <div class="col-12 mb-5 inscribete d-flex justify-content-center align-items-center">
                    <div  class="tranformar d-flex align-items-center tex-white">
                        <h1 class="inscribite">!INSCRÍBETE HOY MISMO!</h1>
                        <a href="#" type="button" class="btn m-3 btn-success">SUSCRIBITE</a>
                    </div>

                </div>
                <div class="col-12 d-flex promos  justify-content-between">

                    <div class="card align-items-md-center ms-5 me-5">


                        <div class="egg d-flex justify-content-center align-items-md-center mt-4" style="background: linear-gradient(to left, #36a9fc, #010ef3 );">
                            <h2>BASIC</h2>
                        </div>


                        <div class="card-body">
                            <h3 class="card-title precio">PRECIO: 5000</h3>
                            <h5>✅ Acceso a maquinas</h5>
                            <h5>❌ Acceso a Clases</h5>
                            <h5>✅ Instructor incluido</h5>
                            <h5>❌ Acceso a maquinas</h5>
                            <h5>❌ Acceso a maquinas</h5>

                        </div>
                    </div>
                    <div class="card  align-items-md-center ms-5 me-5 ">
                        <div class="egg d-flex justify-content-center align-items-md-center mt-4" style="background: linear-gradient(to left, white, gray);">
                            <h2>STANDART</h2>
                        </div>
                        <div class="card-body">
                            <h3 class="card-title precio">PRECIO: 5000</h3>


                            <h5>✅ Acceso a maquinas</h5>
                            <h5>✅ Acceso a Clases</h5>
                            <h5>✅ Instructor incluido</h5>
                            <h5>✅ Acceso a maquinas</h5>
                            <h5>❌ Acceso a maquinas</h5>

                        </div>
                    </div>
                    <div class="card  align-items-md-center ms-5 me-5">
                        <div class="egg d-flex justify-content-center align-items-md-center mt-4" style="background: linear-gradient(to left,#fcfc90, #E3C912);">
                            <h2>PREMIUM</h2>
                        </div>
                        <div class="card-body">
                            <h3 class="card-title precio">PRECIO: 5000</h3>
                            <h5>✅ Acceso a maquinas</h5>
                            <h5>✅ Acceso a Clases</h5>
                            <h5>✅ Instructor incluido</h5>
                            <h5>✅ Acceso a maquinas</h5>
                            <h5>✅ Acceso a maquinas</h5>

                        </div>
                    </div>

                </div>


            </div>
        </div>

        <section>
            <div class="row">
                <div class="col-lg-6 d-flex justify-content-center imagen">
                    <img src="Assets/spining.png" class="img-fluid rounded" />
                </div>
                <div class="col-lg-6 d-flex justify-content-center imagen">
                    <img src="Assets/cali.png" class="img-fluid rounded" />
                </div>

                <div class="col-lg-6 d-flex justify-content-center imagen">
                    <img src="Assets/Mancuernas.png" class="img-fluid rounded" />
                </div>
                <div class="col-lg-6 d-flex justify-content-center imagen">
                    <img src="Assets/pila.png" class="img-fluid rounded" />
                </div>
            </div>
        </section>






        <div class="containerAcerca  d-flex justify-content-center " id="about">

            <div class="containerAcerca2 d-flex justify-content-center">


                <div class="SubContainerAcerca d-flex justify-content-center">

                    <div class="">

                        <h3 class="tranformar inscribite" >¡Transforma tu vida con nosotros!</h3>
                    </div>
                    <div class="parrafoNosotro  tex-white">
                        <p class="inscribite panel ">En GYM, estamos dedicados a ayudarte a alcanzar tus objetivos de salud y bienestar. Con más de [x] años de experiencia en la industria del fitness, nuestro equipo de profesionales altamente capacitados está aquí para guiarte en cada paso de tu viaje hacia una vida más saludable.</p>


                    </div>
                </div>
            </div>



        </div>
    </main>


    <footer class="">
        <small>Made By</small>
    </footer>
</asp:Content>
