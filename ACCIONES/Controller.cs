using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;
using Dominio;
using Microsoft.SqlServer.Server;



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
        public List<Usuario> Listar_Clientes()
        {

            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID_USUARIO  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID");

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
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID_USUARIO  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID WHERE p.ID=@ID");
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
                        if (aux.nivel.ID == 1)
                        {
                            aux.ID_rutina = datos.Lector.GetInt32(23);
                        }
                        else
                        {
                            aux.ID_rutina = 0;

                        }


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

        public void AltaCliente(Usuario usuario)
        {
            try


            {


                datos.setearProcedimiento("SP_Nuevo_cliente");

                // Define los parámetros del procedimiento almacenado
                datos.setearParametro("@mail", usuario.Mail);
                datos.setearParametro("@pasword", usuario.Password);
                datos.setearParametro("@apellido", usuario.Apellido);
                datos.setearParametro("@nombre", usuario.Nombre);
                datos.setearParametro("@aptofisico", usuario.Apto_Fisico);
                datos.setearParametro("@celular", usuario.Cel);
                datos.setearParametro("@direccion", usuario.Direccion);
                datos.setearParametro("@dni", usuario.DNI);
                datos.setearParametro("@fecha_nacimiento", usuario.Fecha_Nacimiento);
                datos.setearParametro("@foto", usuario.Foto);
                datos.setearParametro("@idplan", usuario.plan.ID);
                datos.setearParametro("@sexo", usuario.sexo.ID);
                datos.setearParametro("@tel_emergencia", usuario.Tel_Emergencia);

                datos.setearParametro("@id_establecimiento", usuario.ID_Establecimiento = 1);
                datos.setearParametro("@id_rutina", usuario.ID_rutina);

                // Ejecuta el procedimiento almacenado
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

        public void ModificarCliente(Usuario usuario)
        {
            try
            {
                // Define la consulta SQL para actualizar los datos del cliente
                //datos.setearQuery("BEGIN TRANSACTION\r\n  UPDATE PERSONA AS p\r\n  SET \r\n    APELLIDO = @Apellido,\r\n    NOMBRE = @Nombre,\r\n    APTO_FISICO = @AptoFisico,\r\n    CELULAR = @Celular,\r\n    DIRECCION = @Direccion,\r\n    DNI = @DNI,\r\n    FECHA_INGRESO = @FechaIngreso,\r\n    FECHA_NACIMIENTO = @FechaNacimiento,\r\n    FOTO = @Foto,\r\n    IDPLANES = @IDPlanes,\r\n    SEXO = @Sexo,\r\n    TEL_EMERGENCIA = @TelEmergencia,\r\n    ID_ESTABLECIMIENTO = @IDEstablecimiento,\r\n    ESTADO = @Estado,\r\n    ID_RUTINA = @IDRutina\r\n  WHERE p.ID = @ID;\r\n\r\n  UPDATE USUARIO AS u\r\n  SET PASWORD = @PASS\r\n  WHERE u.MAIL = @MAIL;\r\n\r\nCOMMIT TRANSACTION; \r\nGO ");
                datos.setearProcedimiento("SP_Modificar_Cliente");

                datos.setearParametro("@ID", usuario.ID);
                datos.setearParametro("@PASS", usuario.Password);
                datos.setearParametro("@MAIL", usuario.Mail);
                datos.setearParametro("@Nombre", usuario.Nombre);
                datos.setearParametro("@Apellido", usuario.Apellido);
                datos.setearParametro("@Direccion", usuario.Direccion);
             //   datos.setearParametro("@FechaNacimiento", usuario.Fecha_Nacimiento);
                datos.setearParametro("@Sexo", usuario.sexo.ID);
                datos.setearParametro("@Foto", usuario.Foto);
               // datos.setearParametro("@DNI", usuario.DNI);
                datos.setearParametro("@AptoFisico", usuario.Apto_Fisico);
                datos.setearParametro("@TelEmergencia", usuario.Tel_Emergencia);
                datos.setearParametro("@Celular", usuario.Cel);
             //   datos.setearParametro("@FechaIngreso", usuario.Fecha_ingreso);
             //   datos.setearParametro("@IDPlanes", usuario.plan.ID);
                datos.setearParametro("@IDEstablecimiento", usuario.ID_Establecimiento);
             //   datos.setearParametro("@Estado", usuario.Estado);
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
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID_USUARIO  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar");
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
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID_USUARIO  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where (p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar) and u.IDNIVEL=1");
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
                datos.setearQuery("SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID_USUARIO  INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID where (p.NOMBRE like '%' + @Buscar + '%' or p.APELLIDO like '%'+ @Buscar + '%'or p.DNI=@Buscar) and u.IDNIVEL=2");
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

        public bool ModificarUsuarioEntrenador(Usuario usuario)
        {
            bool transaccion;
            try
            {

                datos.setearQuery(@"BEGIN TRY
                    BEGIN TRANSACTION;
                    UPDATE PERSONA
                    SET DNI = @DNI, 
                        NOMBRE = @NOMBRE, 
                        APELLIDO = @APELLIDO, 
                        IDPLANES = @IDPLANES, 
                        TEL_EMERGENCIA = @TEL_EMERGENCIA, 
                        CELULAR = @CEL, 
                        SEXO = @IDSEXO, 
                        ESTADO = @ESTADO
                    WHERE ID_USUARIO = @ID;
                    UPDATE USUARIO
                    SET MAIL = @MAIL, 
                        PASWORD = @PASSWORD
                    WHERE ID = @ID;

                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
  
                    ROLLBACK TRANSACTION;

                  
                    DECLARE @ErrorMessage NVARCHAR(4000);
                    DECLARE @ErrorSeverity INT;
                    DECLARE @ErrorState INT;
                    DECLARE @ErrorNumber INT;

                    SELECT
                        @ErrorMessage = ERROR_MESSAGE(),
                        @ErrorSeverity = ERROR_SEVERITY(),
                        @ErrorState = ERROR_STATE(),
                        @ErrorNumber = ERROR_NUMBER();

                    IF @ErrorNumber BETWEEN 1 AND 25
                    BEGIN
                        RAISERROR('Error específico con código de error entre 1 y 25: %s', @ErrorSeverity, @ErrorState, @ErrorMessage);
                    END
                    ELSE
                    BEGIN
                        RAISERROR('Error general: %s', @ErrorSeverity, @ErrorState, @ErrorMessage);
                    END
                END CATCH;");
                datos.setearParametro("@ID", usuario.ID);
                datos.setearParametro("@DNI", usuario.DNI);
                datos.setearParametro("@NOMBRE", usuario.Nombre);
                datos.setearParametro("@APELLIDO", usuario.Apellido);
                datos.setearParametro("@IDPLANES", usuario.plan.ID);
                datos.setearParametro("@TEL_EMERGENCIA", usuario.Tel_Emergencia);
                datos.setearParametro("@CEL", usuario.Cel);
                datos.setearParametro("@IDSEXO", usuario.sexo.ID);
                datos.setearParametro("@MAIL", usuario.Mail);
                datos.setearParametro("@PASSWORD", usuario.Password);
                datos.setearParametro("@ESTADO", usuario.Estado);
                datos.ejecutarLectura();
                transaccion = true;
            }
            catch
            {
                transaccion = false;


            }

            finally
            {
                datos.cerrarConexion();
            }
            return transaccion;
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
        public void AgregarRutina(Rutina rutiNueva)
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
        public void AgregarRutinaXEjercicio(int rutinaID, int idEjercicio, Dias dia, Rutina_ejercicio nuevaRutinaEjercicio)
        {

            try
            {
                datos.setearQuery("INSERT INTO RUTINA_EJERCICIO (ID_RUTINA, ID_EJERCICIO, ID_DIA, HORARIO) \r\nVALUES (@ID_RUTINA, @ID_EJERCICIO, @ID_DIA, @HORARIO) ");
                datos.setearParametro("@ID_EJERCICIO", idEjercicio);
                datos.setearParametro("@ID_RUTINA", rutinaID);
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
                datos.setearQuery("SELECT ID_RUTINA, ID_EJERCICIO, ID_DIA, HORARIO  FROM RUTINA_EJERCICIO WHERE ID_RUTINA =@ID_RUTINAPP");
                datos.setearParametro("@ID_RUTINAPP", ID_Rutina);
                datos.ejecutarLectura();

                Rutina_ejercicio rutina_Ejercicio_aux = new Rutina_ejercicio();
                rutina_Ejercicio_aux.ejercicio = new List<Ejercicio>();
                rutina_Ejercicio_aux.dia = new Dias();


                while (datos.Lector.Read())
                {
                    if (ID_Rutina == datos.Lector.GetInt32(0))
                    {
                        var objEjercicio = new Ejercicio();
                        objEjercicio.ID = datos.Lector.GetInt32(1);
                        rutina_Ejercicio_aux.ejercicio.Add(objEjercicio);
                    }

                    rutina_Ejercicio_aux.dia.id = datos.Lector.GetInt32(2);
                    rutina_Ejercicio_aux.hora = datos.Lector.GetInt32(3);
                }


                return rutina_Ejercicio_aux;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }

        }
        public void ModificarRutinaEjerciDiaHora(Dias idDia, Rutina_ejercicio rutina_EjerHora, Rutina rutina)
        {
            try
            {
                datos.setearQuery("UPDATE RUTINA_EJERCICIO SET ID_DIA =@ID_DIA, HORARIO=@HORARIO WHERE ID_RUTINA =@ID_RUTINA ");
                datos.setearQuery("UPDATE RUTINA_EJERCICIO  WHERE ID_RUTINA =@ID_RUTINA ");
                datos.setearParametro("@ID_DIA", idDia.id);
                datos.setearParametro("@HORARIO", rutina_EjerHora.hora);
                datos.setearParametro("@ID_RUTINA", rutina.ID);
                //datos.setearParametro("@ID_EJERCICIO", ejercicioID);
                // datos.setearParametro("@ID_EJERCICIOANTERIOR", idEjercicioAnterior);

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

        public void ModificarEjercicioParaRutina_Ejercicio(int idrutinaEjercicio, int idEjercicioAnterior, Rutina rutina)
        {
            try
            {
                datos.setearQuery("UPDATE RUTINA_EJERCICIO SET ID_EJERCICIO=@ID_EJERCICIO WHERE ID_RUTINA =@ID_RUTINA AND ID_EJERCICIO =@ID_EJERCICIOANTERIOR");
                datos.setearParametro("@ID_EJERCICIO", idrutinaEjercicio);     //Aca va el nuevo valor
                datos.setearParametro("@ID_RUTINA", rutina.ID);
                datos.setearParametro("@ID_EJERCICIOANTERIOR", idEjercicioAnterior);
                datos.ejecutarAccion();


            }
            catch (Exception ex) { throw ex; }
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
                datos.setearQuery("SELECT  R.ID, R.NOMBRE, R.DESCRIPCION, D.NOMBRE_DIA, E.NOMBRE, E.REPETICIONES, RE.HORARIO, E.ID FROM RUTINA R INNER JOIN RUTINA_EJERCICIO RE ON R.ID = RE.ID_RUTINA INNER JOIN DIA D ON D.ID = RE.ID_DIA INNER JOIN EJERCICIO E ON E.ID = RE.ID_EJERCICIO ORDER BY R.NOMBRE");
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
                    auxTabla.Horario = datos.Lector.GetInt32(6);
                    auxTabla.ID_Ejercicio = datos.Lector.GetInt32(7);
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
        public void AgregarEjercicio(Ejercicio ejercicioNuevo)
        {
            try
            {
                datos.setearQuery("INSERT into EJERCICIO (DESCRIPCION,NOMBRE,REPETICIONES,ID_DIFICULTAD,VIDEO,ID_TIPO,ID_GRUPO_MUSCULAR) values (@DESCRIPCION,@NOMBRE,@REPETICIONES,@ID_DIFICULTAD,@VIDEO,@ID_TIPO,@ID_GRUPO_MUSCULAR)");
                datos.setearParametro("@NOMBRE", ejercicioNuevo.Nombre);
                datos.setearParametro("@DESCRIPCION", ejercicioNuevo.Descripcion);
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
        public void AgregarGrupoMusucular(GrupoMuscular grupoNuevo)
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


        public List<Ejercicio> ListarEjerciciosXGrupoMuscular(int grupoMuscularID)
        {
            try
            {
                List<Ejercicio> aux = new List<Ejercicio>();
                datos.setearQuery("SELECT e.ID, e.NOMBRE, e.REPETICIONES  FROM EJERCICIO e WHERE e.ID_GRUPO_MUSCULAR = @ID_GRUPO_MUSCULAR");
                datos.setearParametro("@ID_GRUPO_MUSCULAR", grupoMuscularID);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.ID = datos.Lector.GetInt32(0);
                    ejercicio.Nombre = datos.Lector.GetString(1);
                    ejercicio.Repeticiones = datos.Lector.GetInt32(2);

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


        public Ejercicio BuscarEjercicioPorID(int ejercicioID)
        {
            try
            {
                Ejercicio ejercicio = null;
                datos.setearQuery("SELECT ID, DESCRIPCION,NOMBRE,REPETICIONES,ID_DIFICULTAD,VIDEO, ID_TIPO, ID_GRUPO_MUSCULAR from EJERCICIO WHERE ID=@ID_EJERCICIO");
                datos.setearParametro("@ID_EJERCICIO", ejercicioID);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    if (datos.Lector.GetInt32(0) == ejercicioID)
                    {
                        ejercicio = new Ejercicio();
                        ejercicio.ID = datos.Lector.GetInt32(0);
                        ejercicio.Descripcion = datos.Lector.GetString(1);
                        ejercicio.Nombre = datos.Lector.GetString(2);
                        ejercicio.Repeticiones = datos.Lector.GetInt32(3);
                        ejercicio.Tipo_Dificultad.ID = datos.Lector.GetInt32(4);
                        ejercicio.Video = datos.Lector.GetString(5);
                        ejercicio.Tipo_Ejercicio.ID = datos.Lector.GetInt32(6);
                        ejercicio.Grupo_Muscular.ID = datos.Lector.GetInt32(7);
                    }

                }
                return ejercicio;
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

        public void ModificarEjercicio(int rutinaId, int IDejercicioQueMeTraigoDelFront, int ejercicioID)
        {
            try
            {

                datos.setearQuery("UPDATE RUTINA_EJERCICIO SET  ID_EJERCICIO=@ID_EJERCICIO WHERE ID_RUTINA = @ID_RUTINAS AND ID_EJERCICIO=@ID_EJERCICIOANTERIOR");
                datos.setearParametro("@ID_RUTINAS", rutinaId);
                datos.setearParametro("@ID_EJERCICIO", ejercicioID);
                datos.setearParametro("ID_EJERCICIOANTERIOR", IDejercicioQueMeTraigoDelFront);

                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        //REVISION DE METODO SI LO USO...
        public int ObtenerEjercicioIDAnterior(int rutinaId)     //Metodo que lo utilizo para cambiar el ejercicio a rutina.
        {
            int ejercicioIdAnterior = 0;
            try
            {

                datos.setearQuery("SELECT ID_EJERCICIO FROM RUTINA_EJERCICIO WHERE ID_RUTINA = @ID_RUTINA");
                datos.setearParametro("@ID_RUTINA", rutinaId);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ejercicioIdAnterior = (int)datos.Lector["ID_EJERCICIO"];
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
            return ejercicioIdAnterior;
        }

        public void eliminarEjercicio(int rutinaID, int ejercicioID)
        {
            try
            {
                datos.setearQuery("DELETE RUTINA_EJERCICIO WHERE ID_EJERCICIO =@ID_EJERCICIO AND ID_RUTINA=@ID_RUTINAEli");
                datos.setearParametro("@ID_EJERCICIO", ejercicioID);
                datos.setearParametro("@ID_RUTINAEli", rutinaID);

                datos.ejecutarAccion();
            }
            catch (Exception e) { throw e; }
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

        public Usuario IngresoConLogin(string mail, string password)
        {
            Usuario usuario = new Usuario();

            try
            {
                datos.setearQuery(" SELECT  u.ID AS id_USUARIO, u.MAIL,u.PASWORD, u.IDNIVEL , NI.Nivel_Acceso , p.NOMBRE,  p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, S.TIPO, p.FOTO, p.DNI, p.APTO_FISICO,  p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, PL.DESCRIPCION, PL.CUOTA , PL.TIPO_PLAN , p.ID_ESTABLECIMIENTO , p.ESTADO, p.ID_RUTINA FROM PERSONA p  INNER JOIN USUARIO u on u.ID=p.ID_USUARIO   INNER JOIN PLANES PL ON PL.ID=P.IDPLANES INNER JOIN NIVEL NI ON NI.ID=U.IDNIVEL INNER JOIN SEXO S ON P.SEXO=S.ID WHERE u.MAIL = @MAIL AND u.PASWORD= @PASSWORD");
                datos.setearParametro("@MAIL", mail);
                datos.setearParametro("@PASSWORD", password);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    usuario.ID = datos.Lector.GetInt32(0);
                    usuario.Mail = datos.Lector.GetString(1);
                    usuario.Password = datos.Lector.GetString(2);
                    usuario.nivel.ID = datos.Lector.GetInt32(3);
                    usuario.nivel.level = datos.Lector.GetString(4);
                    usuario.Nombre = datos.Lector.GetString(5);
                    usuario.Apellido = datos.Lector.GetString(6);
                    usuario.Direccion = datos.Lector.GetString(7);
                    usuario.Fecha_Nacimiento = datos.Lector.GetDateTime(8);
                    usuario.sexo.ID = datos.Lector.GetInt32(9);
                    usuario.sexo.Tipo = datos.Lector.GetString(10);
                    usuario.Foto = datos.Lector.GetString(11);
                    usuario.DNI = datos.Lector.GetString(12);
                    usuario.Apto_Fisico = datos.Lector.GetString(13);
                    usuario.Tel_Emergencia = datos.Lector.GetString(14);
                    usuario.Cel = datos.Lector.GetString(15);
                    usuario.Fecha_ingreso = datos.Lector.GetDateTime(16);
                    usuario.plan.ID = datos.Lector.GetInt32(17);
                    usuario.plan.Descripcion = datos.Lector.GetString(18);
                    usuario.plan.Cuotas = datos.Lector.GetSqlMoney(19);
                    usuario.plan.Tipo_Plan = datos.Lector.GetString(20);
                    usuario.ID_Establecimiento = datos.Lector.GetInt32(21);
                    usuario.Estado = datos.Lector.GetBoolean(22);
                    usuario.ID_rutina = datos.Lector.GetInt32(23);

                    return usuario;
                }
                else
                {
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }


        public string MensajeDeAdministrador()
        {


            string mensaje = "";

            try
            {
                datos.setearQuery("  select top 1 cast(FechaMensaje as date) as fecha, DescripcionNota from Mensajes");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    
                        DateTime fechaMensaje = datos.Lector.GetDateTime(0);
                        string textoMensaje = datos.Lector.GetString(1);

                        mensaje = $"{fechaMensaje:dd-MM-yyyy} -- {textoMensaje}";
                 




                }
                if (mensaje.Equals(""))
                {
                    mensaje = "No hay mensajes";
                }

                return mensaje;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }
        }


        public void ModificarEjercicioCompleto(Ejercicio ejercicio,GrupoMuscular muscular,TipoEjercicio tipo, Dificultad dificultad)
        {
            try
            {
                datos.setearQuery("UPDATE EJERCICIO SET DESCRIPCION=@DESCRIPCION, NOMBRE=@NOMBRE, REPETICIONES=@REPETICIONES, ID_DIFICULTAD=@ID_DIFICULTAD, VIDEO=@VIDEO, ID_TIPO=@ID_TIPO, ID_GRUPO_MUSCULAR=@ID_GRUPO_MUSCULAR  WHERE ID=@ID");
                datos.setearParametro("@ID", ejercicio.ID);
                datos.setearParametro("@DESCRIPCION", ejercicio.Descripcion);
                datos.setearParametro("@NOMBRE", ejercicio.Nombre);
                datos.setearParametro("@REPETICIONES", ejercicio.Repeticiones);
                datos.setearParametro("@ID_DIFICULTAD", dificultad.ID);
                datos.setearParametro("@VIDEO", ejercicio.Video);
                datos.setearParametro("@ID_TIPO", tipo.ID);
                datos.setearParametro("@ID_GRUPO_MUSCULAR", muscular.ID);
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


        public bool enviarMensaje(String a) {

            bool estado;
            try
            {
                datos.setearQuery("insert into Mensajes (DescripcionNota) values(@mensaje)");
                datos.setearParametro("@mensaje", a);
             
                datos.ejecutarLectura();
                estado=true;
            }
            catch (Exception ex)
            {
                estado=false;   
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return estado;
        }
        public bool ActualizacionDePrecio(int precio , int id)
        {

            bool estado;
            try
            {
                datos.setearQuery("update PLANES set CUOTA=@precio where id=@id");
                datos.setearParametro("@precio", precio);
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();
                estado = true;
            }
            catch (Exception ex)
            {
                estado = false;
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return estado;
        }


        public List<Historial> historiaPorDNI(int dni)
        {

                List<Historial> historial = new List<Historial>();
            
            try
            {
                datos.setearQuery("SELECT h.id, p.NOMBRE,p.APELLIDO, p.FECHA_INGRESO,DATEDIFF(YEAR, p.FECHA_NACIMIENTO, GETDATE()) - CASE WHEN MONTH(GETDATE()) < MONTH(p.FECHA_NACIMIENTO) OR (MONTH(GETDATE()) = MONTH(p.FECHA_NACIMIENTO) AND DAY(GETDATE()) < DAY(p.FECHA_NACIMIENTO)) THEN 1 ELSE 0 END AS Edad,(SELECT TIPO_PLAN FROM PLANES WHERE id = h.ID_Planes) AS 'Plan', h.Pago,h.FechaPago, h.DescripcionNota FROM PERSONA p INNER JOIN Historial h ON h.Id_Persona = p.ID WHERE p.DNI = @dni");
                datos.setearParametro("@dni", dni);
                datos.ejecutarLectura();
                
                while (datos.Lector.Read()) {
                    Historial Aux = new Historial();
                    Aux.ID = datos.Lector.GetInt32(0);
                    Aux.NombrePersona = datos.Lector.GetString(1) + " " + datos.Lector.GetString(2);
                    Aux.Ingreso = datos.Lector.GetDateTime(3);
                    Aux.Edad = datos.Lector.GetInt32(4);
                    Aux.Plan= datos.Lector.GetString(5);
                    Aux.Pago= datos.Lector.GetSqlMoney(6);
                    Aux.FechaPago= datos.Lector.GetDateTime(7);
                    Aux.DescripcionNota= datos.Lector.GetString(8);


                    historial.Add(Aux);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return historial;
        }


        //Metodo para listar las rutinas con sus ejercicios

        //Creo el metodo para realizar la modificación de la rutina

        //Modificar Rutina




    }
}