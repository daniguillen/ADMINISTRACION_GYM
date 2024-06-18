using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Dominio;



namespace ACCIONES
{
    public class Controller

    {
        public AccesoDatos datos;
        public Controller()
        {
            datos = new AccesoDatos();
        }

  //clientes
        public void Activar_Cliente_PorID(int a)
        {

            try
            {
                datos.setearQuery("update PERSONA set ESTADO=1 where ID=" + a + ";");
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public void Eliminar_Persona_x_ID(int a)
        {

            try
            {
                datos.setearQuery("update PERSONA set ESTADO=0 where ID=" + a + ";");
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public List<Usuario> listar_Clientes()
        {

            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID");

                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();


                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Password = datos.Lector.GetString(2);
                    aux.nivel.ID = datos.Lector.GetInt32(3);
                    aux.nivel.level = datos.Lector.GetString(4);
                    aux.Nombre = datos.Lector.GetString(5);
                    aux.Apellido = datos.Lector.GetString(6);
                    aux.Direccion = datos.Lector.GetString(7);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                    aux.sexo.ID = datos.Lector.GetInt32(9);
                    aux.sexo.Tipo = datos.Lector.GetString(10);
                    aux.Foto = datos.Lector.GetString(11);
                    aux.DNI = datos.Lector.GetString(12);
                    aux.Apto_Fisico = datos.Lector.GetString(13);
                    aux.Tel_Emergencia = datos.Lector.GetString(14);
                    aux.Cel = datos.Lector.GetString(15);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(16);
                    aux.plan.ID = datos.Lector.GetInt32(17);
                    aux.plan.Descripcion = datos.Lector.GetString(18);
                    aux.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                    aux.plan.Tipo_Plan = datos.Lector.GetString(20);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(21);
                    aux.Estado = datos.Lector.GetBoolean(22);
             

                    ListaUsuario.Add(aux);
                }
                return ListaUsuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public Usuario Cliente(int idusuario)
        {

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID WHERE p.ID=@ID");
                datos.setearParametro("@ID", idusuario);


                datos.ejecutarLectura();

                Usuario aux = new Usuario();


                while (datos.Lector.Read())
                {

                    if (datos.Lector.GetInt32(0) == idusuario)
                    {



                        aux.ID = datos.Lector.GetInt32(0);
                        aux.Mail = datos.Lector.GetString(1);
                        aux.Password = datos.Lector.GetString(2);
                        aux.nivel.ID = datos.Lector.GetInt32(3);
                        aux.nivel.level = datos.Lector.GetString(4);
                        aux.Nombre = datos.Lector.GetString(5);
                        aux.Apellido = datos.Lector.GetString(6);
                        aux.Direccion = datos.Lector.GetString(7);
                        aux.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                        aux.sexo.ID = datos.Lector.GetInt32(9);
                        aux.sexo.Tipo = datos.Lector.GetString(10);
                        aux.Foto = datos.Lector.GetString(11);
                        aux.DNI = datos.Lector.GetString(12);
                        aux.Apto_Fisico = datos.Lector.GetString(13);
                        aux.Tel_Emergencia = datos.Lector.GetString(14);
                        aux.Cel = datos.Lector.GetString(15);
                        aux.Fecha_ingreso = datos.Lector.GetDateTime(16);
                        aux.plan.ID = datos.Lector.GetInt32(17);
                        aux.plan.Descripcion = datos.Lector.GetString(18);
                        aux.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                        aux.plan.Tipo_Plan = datos.Lector.GetString(20);
                        aux.ID_Establecimiento = datos.Lector.GetInt32(21);
                        aux.Estado = datos.Lector.GetBoolean(22);
                        aux.ID_rutina = datos.Lector.GetInt32(23);



                    }


                }
                return aux;



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void ModificarCliente(Usuario usuario)
        {
            try
            {
                // Define la consulta SQL para actualizar los datos del cliente
                datos.setearQuery("UPDATE PERSONA SET  APELLIDO =@Apellido, NOMBRE = @Nombre, APTO_FISICO = @AptoFisico, CELULAR = @Celular, DIRECCION =@Direccion,  DNI = @DNI, FECHA_INGRESO = @FechaIngreso, FECHA_NACIMIENTO = @FechaNacimiento,FOTO = @Foto, IDPLANES = @IDPlanes, SEXO = @Sexo,  TEL_EMERGENCIA = @TelEmergencia, ID_ESTABLECIMIENTO = @IDEstablecimiento, ESTADO = @Estado, ID_RUTINA=@IDRutina WHERE ID = @ID");

               
                datos.setearParametro("@ID", usuario.ID);
                datos.setearParametro("@Nombre", usuario.Nombre);
                datos.setearParametro("@Apellido", usuario.Apellido);
                datos.setearParametro("@Direccion", usuario.Direccion);
                datos.setearParametro("@FechaNacimiento", usuario.Fecha_Nacimiento);
                datos.setearParametro("@Sexo", usuario.sexo.ID);
                datos.setearParametro("@Foto", usuario.Foto);
                datos.setearParametro("@DNI", usuario.DNI);
                datos.setearParametro("@AptoFisico", usuario.Apto_Fisico);
                datos.setearParametro("@TelEmergencia", usuario.Tel_Emergencia);
                datos.setearParametro("@Celular", usuario.Cel);
                datos.setearParametro("@FechaIngreso", usuario.Fecha_ingreso);
                datos.setearParametro("@IDPlanes", usuario.plan.ID);
                datos.setearParametro("@IDEstablecimiento", usuario.ID_Establecimiento);
                datos.setearParametro("@Estado", usuario.Estado);
                datos.setearParametro("@IDRutina", usuario.ID_rutina);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {
               
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        //busca un usuario o entrenador sin filtro
        public Usuario BuscarAllCliente(string buscar)
        {

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar");
                datos.setearParametro("@Buscar", buscar);
                datos.ejecutarLectura();

                Usuario aux = null;


                while (datos.Lector.Read())
                {
                    aux = new Usuario();
                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Password = datos.Lector.GetString(2);
                    aux.nivel.ID = datos.Lector.GetInt32(3);
                    aux.nivel.level = datos.Lector.GetString(4);
                    aux.Nombre = datos.Lector.GetString(5);
                    aux.Apellido = datos.Lector.GetString(6);
                    aux.Direccion = datos.Lector.GetString(7);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                    aux.sexo.ID = datos.Lector.GetInt32(9);
                    aux.sexo.Tipo = datos.Lector.GetString(10);
                    aux.Foto = datos.Lector.GetString(11);
                    aux.DNI = datos.Lector.GetString(12);
                    aux.Apto_Fisico = datos.Lector.GetString(13);
                    aux.Tel_Emergencia = datos.Lector.GetString(14);
                    aux.Cel = datos.Lector.GetString(15);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(16);
                    aux.plan.ID = datos.Lector.GetInt32(17);
                    aux.plan.Descripcion = datos.Lector.GetString(18);
                    aux.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                    aux.plan.Tipo_Plan = datos.Lector.GetString(20);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(21);
                    aux.Estado = datos.Lector.GetBoolean(22);
                }
                return aux;



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        //buscar por usuario
        public Usuario BuscarOneCliente(string buscar)
        {

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where (p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar) and u.IDNIVEL=1");
                datos.setearParametro("@Buscar", buscar);
                datos.ejecutarLectura();

                Usuario aux = null;


                while (datos.Lector.Read())
                {
                    aux = new Usuario();
                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Password = datos.Lector.GetString(2);
                    aux.nivel.ID = datos.Lector.GetInt32(3);
                    aux.nivel.level = datos.Lector.GetString(4);
                    aux.Nombre = datos.Lector.GetString(5);
                    aux.Apellido = datos.Lector.GetString(6);
                    aux.Direccion = datos.Lector.GetString(7);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                    aux.sexo.ID = datos.Lector.GetInt32(9);
                    aux.sexo.Tipo = datos.Lector.GetString(10);
                    aux.Foto = datos.Lector.GetString(11);
                    aux.DNI = datos.Lector.GetString(12);
                    aux.Apto_Fisico = datos.Lector.GetString(13);
                    aux.Tel_Emergencia = datos.Lector.GetString(14);
                    aux.Cel = datos.Lector.GetString(15);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(16);
                    aux.plan.ID = datos.Lector.GetInt32(17);
                    aux.plan.Descripcion = datos.Lector.GetString(18);
                    aux.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                    aux.plan.Tipo_Plan = datos.Lector.GetString(20);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(21);
                    aux.Estado = datos.Lector.GetBoolean(22);
                }
                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Usuario BuscarOneEntrenador(string buscar)
        {

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where (p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar) and u.IDNIVEL=2");
                datos.setearParametro("@Buscar", buscar);
                datos.ejecutarLectura();

                Usuario aux = null;


                while (datos.Lector.Read())
                {
                    aux = new Usuario();
                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Password = datos.Lector.GetString(2);
                    aux.nivel.ID = datos.Lector.GetInt32(3);
                    aux.nivel.level = datos.Lector.GetString(4);
                    aux.Nombre = datos.Lector.GetString(5);
                    aux.Apellido = datos.Lector.GetString(6);
                    aux.Direccion = datos.Lector.GetString(7);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                    aux.sexo.ID = datos.Lector.GetInt32(9);
                    aux.sexo.Tipo = datos.Lector.GetString(10);
                    aux.Foto = datos.Lector.GetString(11);
                    aux.DNI = datos.Lector.GetString(12);
                    aux.Apto_Fisico = datos.Lector.GetString(13);
                    aux.Tel_Emergencia = datos.Lector.GetString(14);
                    aux.Cel = datos.Lector.GetString(15);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(16);
                    aux.plan.ID = datos.Lector.GetInt32(17);
                    aux.plan.Descripcion = datos.Lector.GetString(18);
                    aux.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                    aux.plan.Tipo_Plan = datos.Lector.GetString(20);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(21);
                    aux.Estado = datos.Lector.GetBoolean(22);
                }
                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        //Rutinas
        public List<Rutina> ListarRutinas()

        {
            try
            {
                datos.setearQuery("SELECT R.ID AS RUTINA_ID, R.NOMBRE, R.DESCRIPCION, r.ESTADO, RE.ID AS id_RUTI_EJE, RE.HORARIO, D.ID AS ID_DIA, D.NOMBRE_DIA, E.ID AS ID_EJER, E.DESCRIPCION, E.NOMBRE, E.REPETICIONES, TE.ID AS ID_TIPO_EJER, TE.DESCRIPCION, DI.ID AS ID_DIFICULTAD, DI.DESCRIPCION, E.VIDEO, GM.ID AS ID_GRUPO_MUSCULAR, GM.DESCRIPCION  FROM RUTINA R\r\nINNER JOIN RUTINA_EJERCICIO RE ON R.ID=RE.ID_RUTINA \r\nINNER JOIN DIA D ON D.ID=RE.ID_DIA \r\nINNER JOIN EJERCICIO E ON E.ID=RE.ID_EJERCICIO \r\nINNER JOIN TIPO_EJERCICIO TE ON TE.ID=E.ID_TIPO\r\nINNER JOIN DIFICULTAD DI ON DI.ID=E.ID_DIFICULTAD \r\nINNER JOIN GRUPO_MUSCULAR GM ON E.ID_GRUPO_MUSCULAR=GM.ID\r\n");

                datos.ejecutarLectura();
                List<Rutina> ListitaRutina = new List<Rutina>();
                int rut_ant = -1;

                int rut_ejer_ant = -1;

                while (datos.Lector.Read())
                {

                    Rutina Rutina_aux = new Rutina();



                    int idrutina = datos.Lector.GetInt32(0);

                    if (idrutina != rut_ant)
                    {

                        Rutina_aux.ID = idrutina;
                        Rutina_aux.nombre = datos.Lector.GetString(1);
                        Rutina_aux.descripcion = datos.Lector.GetString(2);
                        Rutina_aux.estado = datos.Lector.GetBoolean(3);
                        Rutina_aux.personal = datos.Lector.GetBoolean(19);
                        int id_rut_ejer = datos.Lector.GetInt32(4);

                        if (id_rut_ejer != rut_ejer_ant)
                        {
                            Rutina_ejercicio Ru_ejer = new Rutina_ejercicio();

                            Ru_ejer.ID = id_rut_ejer;
                            Ru_ejer.hora = datos.Lector.GetInt32(5);
                            Dias dias = new Dias();
                            dias.id = datos.Lector.GetInt32(6);
                            dias.dia = datos.Lector.GetString(7);
                            Ru_ejer.dia = dias;



                            int id_ejer = datos.Lector.GetInt32(8);




                            Ejercicio eje_aux = new Ejercicio();
                            eje_aux.ID = id_ejer;
                            eje_aux.Descripcion = datos.Lector.GetString(9);
                            eje_aux.Nombre = datos.Lector.GetString(10);
                            eje_aux.Repeticiones = datos.Lector.GetInt32(11);
                            eje_aux.Tipo_Ejercicio.ID = datos.Lector.GetInt32(12);
                            eje_aux.Tipo_Ejercicio.Descripcion = datos.Lector.GetString(13);
                            eje_aux.Tipo_Dificultad.ID = datos.Lector.GetInt32(14);
                            eje_aux.Tipo_Dificultad.Descripcion = datos.Lector.GetString(15);
                            eje_aux.Video = datos.Lector.GetString(16);
                            eje_aux.Grupo_Muscular.ID = datos.Lector.GetInt32(17);
                            eje_aux.Grupo_Muscular.Descripcion = datos.Lector.GetString(18);

                            Ru_ejer.ejercicio.Add(eje_aux);


                            rut_ant = idrutina;

                        }

                        ListitaRutina.Add(Rutina_aux);


                    }


                }
                return ListitaRutina;



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public Rutina Rutinas_id(int id_rutina)

        {
            try
            {
                datos.setearQuery("SELECT R.ID AS RUTINA_ID, R.NOMBRE, R.DESCRIPCION, r.ESTADO, RE.ID AS id_RUTI_EJE, RE.HORARIO, D.ID AS ID_DIA, D.NOMBRE_DIA, E.ID AS ID_EJER, E.DESCRIPCION, E.NOMBRE, E.REPETICIONES, TE.ID AS ID_TIPO_EJER,TE.DESCRIPCION, DI.ID AS ID_DIFICULTAD, DI.DESCRIPCION, E.VIDEO, GM.ID AS ID_GRUPO_MUSCULAR, GM.DESCRIPCION , R.PERSONAL FROM RUTINA R\r\nINNER JOIN RUTINA_EJERCICIO RE ON R.ID=RE.ID_RUTINA \r\nINNER JOIN DIA D ON D.ID=RE.ID_DIA \r\nINNER JOIN EJERCICIO E ON E.ID=RE.ID_EJERCICIO \r\nINNER JOIN TIPO_EJERCICIO TE ON TE.ID=E.ID_TIPO\r\nINNER JOIN DIFICULTAD DI ON DI.ID=E.ID_DIFICULTAD \r\nINNER JOIN GRUPO_MUSCULAR GM ON E.ID_GRUPO_MUSCULAR=GM.ID\r\nwhere R.ID =@IDR");
                datos.setearParametro("@IDR", id_rutina);
                datos.ejecutarLectura();


                int rut_ejer_ant = -1;
                int id_ejer_ante = -1;
                Rutina Rutina_aux = new Rutina();
                while (datos.Lector.Read())
                {


                    Rutina_aux.ID = datos.Lector.GetInt32(0);
                    Rutina_aux.nombre = datos.Lector.GetString(1);
                    Rutina_aux.descripcion = datos.Lector.GetString(2);
                    Rutina_aux.estado = datos.Lector.GetBoolean(3);
                    Rutina_aux.personal = datos.Lector.GetBoolean(19);
                    int id_rut_ejer = datos.Lector.GetInt32(4);

                    if (id_rut_ejer != rut_ejer_ant)
                    {
                        Rutina_ejercicio Ru_ejer = new Rutina_ejercicio();

                        Ru_ejer.ID = id_rut_ejer;
                        Ru_ejer.hora = datos.Lector.GetInt32(5);
                        Dias dias = new Dias();
                        dias.id = datos.Lector.GetInt32(6);
                        dias.dia = datos.Lector.GetString(7);
                        Ru_ejer.dia = dias;



                        int id_ejer = datos.Lector.GetInt32(8);
                        if (id_ejer != id_ejer_ante)
                        {
                            Ejercicio eje_aux = new Ejercicio();
                            eje_aux.ID = id_ejer;
                            eje_aux.Descripcion = datos.Lector.GetString(9);
                            eje_aux.Nombre = datos.Lector.GetString(10);
                            eje_aux.Repeticiones = datos.Lector.GetInt32(11);
                            eje_aux.Tipo_Ejercicio.ID = datos.Lector.GetInt32(12);
                            eje_aux.Tipo_Ejercicio.Descripcion = datos.Lector.GetString(13);
                            eje_aux.Tipo_Dificultad.ID = datos.Lector.GetInt32(14);
                            eje_aux.Tipo_Dificultad.Descripcion = datos.Lector.GetString(15);
                            eje_aux.Video = datos.Lector.GetString(16);
                            eje_aux.Grupo_Muscular.ID = datos.Lector.GetInt32(17);
                            eje_aux.Grupo_Muscular.Descripcion = datos.Lector.GetString(18);
                            Ru_ejer.ejercicio.Add(eje_aux);
                            id_ejer_ante = id_ejer;
                        }

                        rut_ejer_ant = id_rut_ejer;

                        Rutina_aux.rutina_Ejercicios.Add(Ru_ejer);
                    }




                }
                return Rutina_aux;



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public List<Ejercicio> ListarEjercicios()
        {

            try
            {
                List<Ejercicio> aux = new List<Ejercicio>();
                datos.setearQuery("select e.ID, e.DESCRIPCION, e.NOMBRE, e.REPETICIONES, e.ID_DIFICULTAD, d.DESCRIPCION, e.VIDEO, e.ID_TIPO, tp.DESCRIPCION, e.ID_GRUPO_MUSCULAR, gm.DESCRIPCION from EJERCICIO e\r\ninner join DIFICULTAD d on e.ID_DIFICULTAD=d.ID\r\ninner join TIPO_EJERCICIO TP on e.ID_TIPO=TP.ID\r\ninner join GRUPO_MUSCULAR GM on e.ID_GRUPO_MUSCULAR=GM.ID");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.Tipo_Ejercicio = new TipoEjercicio();
                    ejercicio.Tipo_Dificultad = new Dificultad();
                    ejercicio.Grupo_Muscular = new GrupoMuscular();
                    ejercicio.ID = datos.Lector.GetInt32(0);
                    ejercicio.Descripcion = datos.Lector.GetString(1);
                    ejercicio.Nombre = datos.Lector.GetString(2);
                    ejercicio.Repeticiones = datos.Lector.GetInt32(3);
                    ejercicio.Tipo_Dificultad.ID = datos.Lector.GetInt32(4);
                    ejercicio.Tipo_Dificultad.Descripcion = datos.Lector.GetString(5);
                    ejercicio.Video = datos.Lector.GetString(6);
                    ejercicio.Tipo_Ejercicio.ID = datos.Lector.GetInt32(7);
                    ejercicio.Tipo_Ejercicio.Descripcion = datos.Lector.GetString(8);
                    ejercicio.Grupo_Muscular.ID = datos.Lector.GetInt32(9);
                    ejercicio.Grupo_Muscular.Descripcion = datos.Lector.GetString(10);


                    aux.Add(ejercicio);

                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregarRutina(Rutina rutiNueva)
        {
            try
            {
                datos.setearQuery("INSERT INTO RUTINA(NOMBRE, DESCRIPCION, PERSONAL, ESTADO) VALUES (@NOMBRE,@DESCRIPCION,@PERSONAL,@ESTADO)");
                datos.setearParametro("@NOMBRE", rutiNueva.nombre);
                datos.setearParametro("@DESCRIPCION", rutiNueva.descripcion);
                datos.setearParametro("@PERSONAL", 0);
                datos.setearParametro("@ESTADO", 1);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public void agregarRutinaXEjercicio(int rutinaID, int idEjercicio, Dias dia, Rutina_ejercicio nuevaRutinaEjercicio)
        {

            try
            {
                datos.setearQuery("INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, ID_DIA, HORARIO) \r\nVALUES (@ID_RUTINA, @ID_EJERCICIO, @ID_DIA, @HORARIO) ");
                datos.setearParametro("@ID_RUTINA", rutinaID);
                datos.setearParametro("@ID_EJERCICIO", idEjercicio);
                datos.setearParametro("@ID_DIA", dia.id);
                datos.setearParametro("@HORARIO", nuevaRutinaEjercicio.hora);
                datos.ejecutarAccion();
            }

            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public List<Rutina> ListarRutinaParaAgregarEjercicio()
        {

            try
            {
                List<Rutina> aux = new List<Rutina>();
                datos.setearQuery("SELECT * FROM RUTINA");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Rutina ruti = new Rutina();
                    ruti.ID = datos.Lector.GetInt32(0);
                    ruti.nombre = datos.Lector.GetString(1);
                    ruti.descripcion = datos.Lector.GetString(2);
                    ruti.personal = datos.Lector.GetBoolean(3);
                    ruti.estado = datos.Lector.GetBoolean(4);

                    aux.Add(ruti);
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void ModificarRutina(Rutina modifRutina)
        {
            try
            {
                datos.setearQuery("UPDATE RUTINA SET NOMBRE = @NOMBRE, DESCRIPCION = @DESCRIPCION WHERE ID=@ID ");

                datos.setearParametro("@ID", modifRutina.ID);
                datos.setearParametro("@NOMBRE", modifRutina.nombre);
                datos.setearParametro("@DESCRIPCION", modifRutina.descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Rutina_ejercicio Rutina_EjercicioIdParaModificarRutina(int ID_Rutina)
        {
            try
            {
                datos.setearQuery("SELECT ID_RUTINA, ID_EJERCICIO, ID_DIA FROM RUTINA_EJERCICIO WHERE ID_RUTINA =@ID_RUTINA");

                datos.setearParametro("@ID_RUTINA", ID_Rutina);
                datos.ejecutarLectura();

                Rutina_ejercicio rutina_Ejercicio_aux = new Rutina_ejercicio();
                //rutina_Ejercicio_aux.ID= ID_Rutina;
                rutina_Ejercicio_aux.ejercicio = new List<Ejercicio>();
                var objEjercicio = new Ejercicio();
                rutina_Ejercicio_aux.dia = new Dias();


                while (datos.Lector.Read())
                {
                    if (ID_Rutina == datos.Lector.GetInt32(0))
                    {
                        objEjercicio.ID = datos.Lector.GetInt32(0);
                        rutina_Ejercicio_aux.ejercicio.Add(objEjercicio);
                    }

                    rutina_Ejercicio_aux.dia.id = datos.Lector.GetInt32(2);
                }


                return rutina_Ejercicio_aux;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }

        }
        public void ModificarRutinaEjercicio(Rutina rutina,  int idDia, int ejercicioID, int idEjercicioAnterior)
        {
            try
            {
                datos.setearQuery("UPDATE RUTINA_EJERCICIO SET ID_EJERCICIO=@ID_EJERCICIO, ID_DIA =@ID_DIA WHERE ID_RUTINA =@ID_RUTINAA AND ID_EJERCICIO =@ID_EJERCICIOANTERIOR");
                datos.setearParametro("@ID_EJERCICIOANTERIOR", idEjercicioAnterior);
                datos.setearParametro("@ID_RUTINAA", rutina.ID);
                datos.setearParametro("@ID_EJERCICIO", ejercicioID);
                datos.setearParametro("@ID_DIA", idDia);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<AuxTablaRutina> ListarTablaRutinas()
        {
            try
            {
                List<AuxTablaRutina> aux = new List<AuxTablaRutina>();
                // datos.setearQuery("SELECT RE.ID_RUTINA, R.NOMBRE, R.DESCRIPCION, D.NOMBRE_DIA, E.NOMBRE, E.REPETICIONES\r\nFROM RUTINA_EJERCICIO RE\r\nINNER JOIN RUTINA R ON RE.ID = R.ID\r\nINNER JOIN DIA D ON D.ID = RE.ID\r\nINNER JOIN EJERCICIO E ON RE.ID_EJERCICIO = E.ID");
                datos.setearQuery("SELECT  R.ID, R.NOMBRE, R.DESCRIPCION, D.NOMBRE_DIA, E.NOMBRE, E.REPETICIONES FROM RUTINA R INNER JOIN RUTINA_EJERCICIO RE ON R.ID = RE.ID_RUTINA INNER JOIN DIA D ON D.ID = RE.ID_DIA INNER JOIN EJERCICIO E ON E.ID = RE.ID_EJERCICIO ORDER BY R.NOMBRE");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    AuxTablaRutina auxTabla = new AuxTablaRutina();
                    auxTabla.ID_Rutina = datos.Lector.GetInt32(0);
                    auxTabla.NombreRutina = datos.Lector.GetString(1);
                    auxTabla.DescripcionRutina = datos.Lector.GetString(2);
                    auxTabla.DiaNombre = datos.Lector.GetString(3);
                    auxTabla.NombreEjercicio = datos.Lector.GetString(4);
                    auxTabla.Repeticiones = datos.Lector.GetInt32(5);
                    aux.Add(auxTabla);

                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Rutina RutinaIdParaModificarRutina(int ID_Rutina)
        {
            try
            {
                datos.setearQuery("SELECT ID,NOMBRE, DESCRIPCION FROM RUTINA WHERE ID = @ID");
                datos.setearParametro("@ID", ID_Rutina);
                datos.ejecutarLectura();

                Rutina Rutina_aux = new Rutina();
                while (datos.Lector.Read())
                {
                    Rutina_aux.ID = datos.Lector.GetInt32(0);
                    Rutina_aux.nombre = datos.Lector.GetString(1);
                    Rutina_aux.descripcion = datos.Lector.GetString(2);


                }
                return Rutina_aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

 //musculacion
        public List<TipoEjercicio> ListadoTipoEjercicio()
        {
            try
            {
                List<TipoEjercicio> aux = new List<TipoEjercicio>();
                datos.setearQuery("SELECT * FROM TIPO_EJERCICIO");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoEjercicio tipoEjercicio = new TipoEjercicio();
                    tipoEjercicio.ID = datos.Lector.GetInt32(0);
                    tipoEjercicio.Descripcion = datos.Lector.GetString(1);

                    aux.Add(tipoEjercicio);
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<GrupoMuscular> ListarGrupoMuscular()
        {


            try
            {
                List<GrupoMuscular> aux = new List<GrupoMuscular>();
                datos.setearQuery("Select * from GRUPO_MUSCULAR ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    GrupoMuscular grupoMusc = new GrupoMuscular();
                    grupoMusc.ID = datos.Lector.GetInt32(0);
                    grupoMusc.Descripcion = datos.Lector.GetString(1);

                    aux.Add(grupoMusc);
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
        public List<Dificultad> ListadoDeDificultad()
        {
            try
            {
                List<Dificultad> aux = new List<Dificultad>();
                datos.setearQuery("SELECT * FROM DIFICULTAD");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Dificultad dificultad = new Dificultad();
                    dificultad.ID = datos.Lector.GetInt32(0);
                    dificultad.Descripcion = datos.Lector.GetString(1);

                    aux.Add(dificultad);
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void agregarEjercicio(Ejercicio ejercicioNuevo)
        {
            try
            {
                //datos.setearQuery("INSERT INTO EJERCICIO (DESCRIPCION,NOMBRE,REPETICIONES,ID_DIFICULTAD,VIDEO,ID_TIPO,ID_GRUPO_MUSCULAR) VALUES ('" + ejercicioNuevo.Descripcion + "','" + ejercicioNuevo.Nombre + "','" + ejercicioNuevo.Repeticiones + "','" + ejercicioNuevo.Tipo_Dificultad.ID + "', '" + ejercicioNuevo.Video + "','" + ejercicioNuevo.Tipo_Ejercicio.ID + "','" + ejercicioNuevo.Grupo_Muscular.ID + "'");
                datos.setearQuery("INSERT into EJERCICIO (DESCRIPCION,NOMBRE,REPETICIONES,ID_DIFICULTAD,VIDEO,ID_TIPO,ID_GRUPO_MUSCULAR) values (@DESCRIPCION,@NOMBRE,@REPETICIONES,@ID_DIFICULTAD,@VIDEO,@ID_TIPO,@ID_GRUPO_MUSCULAR)");
                datos.setearParametro("@DESCRIPCION", ejercicioNuevo.Descripcion);
                datos.setearParametro("@NOMBRE", ejercicioNuevo.Nombre);
                datos.setearParametro("@REPETICIONES", ejercicioNuevo.Repeticiones);
                datos.setearParametro("@ID_DIFICULTAD", ejercicioNuevo.Tipo_Dificultad.ID);
                datos.setearParametro("@VIDEO", ejercicioNuevo.Video);
                datos.setearParametro("@ID_TIPO", ejercicioNuevo.Tipo_Ejercicio.ID);
                datos.setearParametro("@ID_GRUPO_MUSCULAR", ejercicioNuevo.Grupo_Muscular.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregarGrupoMusucular(GrupoMuscular grupoNuevo)
        {
            try
            {
                datos.setearQuery("INSERT Into GRUPO_MUSCULAR (DESCRIPCION) values (@DESCRIPCION)");
                datos.setearParametro("@DESCRIPCION", grupoNuevo.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

 //otros
        public List<Plan> ListarPLan()
        {

            try
            {
                List<Plan> Aux = new List<Plan>();
                datos.setearQuery("select * from PLANES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Plan plancito = new Plan();
                    plancito.ID = datos.Lector.GetInt32(0);
                    plancito.Cuotas = datos.Lector.GetSqlMoney(1);
                    plancito.Tipo_Plan = datos.Lector.GetString(2);
                    plancito.Descripcion = datos.Lector.GetString(3);

                    Aux.Add(plancito);


                }
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public List<Dias> ListarDias()
        {
            try
            {
                List<Dias> aux = new List<Dias>();
                datos.setearQuery("SELECT * FROM DIA");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Dias dias = new Dias();
                    dias.id = datos.Lector.GetInt32(0);
                    dias.dia = datos.Lector.GetString(1);

                    aux.Add(dias);
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }















        //Metodo para listar las rutinas con sus ejercicios

        //Creo el metodo para realizar la modificación de la rutina

        //Modificar Rutina




    }
}