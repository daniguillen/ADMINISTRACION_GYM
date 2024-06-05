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

        public List<Usuario> listar_Clientes()
        {
            // AccesoDatos datos = new Controller();
            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                datos.setearQuery("SELECT  u.ID, u.MAIL, p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, p.ID_ESTABLECIMIENTO , p.ESTADO, p.IDNIVEL ,u.PASWORD FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID   where IDNIVEL=1 ");

                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                Usuario aux = new Usuario();


                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Apellido = datos.Lector.GetString(3);
                    aux.Direccion = datos.Lector.GetString(4);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(5);
                    aux.Sexo = datos.Lector.GetInt32(6);
                    aux.Foto = datos.Lector.GetString(7);
                    aux.DNI = datos.Lector.GetString(8);
                    aux.Apto_Fisico = datos.Lector.GetString(9);
                    aux.Tel_Emergencia = datos.Lector.GetString(10);
                    aux.Cel = datos.Lector.GetString(11);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(12);
                    aux.ID_Plan = datos.Lector.GetInt16(13);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(14);
                    aux.Estado = datos.Lector.GetBoolean(15);
                    aux.ID_Nivel = datos.Lector.GetInt16(16);
                    aux.Password = datos.Lector.GetString(17);

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
        public List<Usuario> listar_Instructores()
        {
            // AccesoDatos datos = new Controller();
            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                datos.setearQuery("SELECT  u.ID, u.MAIL, p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, p.FOTO, p.DNI, p.APTO_FISICO, p.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, p.ID_ESTABLECIMIENTO , p.ESTADO, p.IDNIVEL  FROM PERSONA p INNER JOIN USUARIO u on u.ID=p.ID   where IDNIVEL=2 ");

                datos.ejecutarLectura();

                Usuario aux = new Usuario();

                while (datos.Lector.Read())
                {


                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Mail = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Apellido = datos.Lector.GetString(3);
                    aux.Direccion = datos.Lector.GetString(4);
                    aux.Fecha_Nacimiento = datos.Lector.GetDateTime(5);
                    aux.Sexo = datos.Lector.GetInt32(6);
                    aux.Foto = datos.Lector.GetString(7);
                    aux.DNI = datos.Lector.GetString(8);
                    aux.Apto_Fisico = datos.Lector.GetString(9);
                    aux.Tel_Emergencia = datos.Lector.GetString(10);
                    aux.Cel = datos.Lector.GetString(11);
                    aux.Fecha_ingreso = datos.Lector.GetDateTime(12);
                    aux.ID_Plan = datos.Lector.GetInt16(13);
                    aux.ID_Establecimiento = datos.Lector.GetInt32(14);
                    aux.Estado = datos.Lector.GetBoolean(15);
                    aux.ID_Nivel = datos.Lector.GetInt16(16);

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
                datos.setearQuery("SELECT  u.ID, u.MAIL, p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, p.FOTO, p.DNI, p.APTO_FISICO, \r\np.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, p.ID_ESTABLECIMIENTO , p.ESTADO, p.IDNIVEL,\r\nR.ID AS ID_RUTINA , d.NOMBRE_DIA, R.ID_EJERCICIO FROM PERSONA p \r\nINNER JOIN USUARIO u on u.ID=p.ID \r\ninner join RUTINA r on r.ID_PERSONA=p.ID \r\ninner join DIA d on r.DIA=d.ID    \r\nWHERE P.ID=1");
                datos.setearParametro("@ID", idusuario);
                datos.ejecutarLectura();

                Usuario aux = new Usuario();
                int id_ant = -1;

                while (datos.Lector.Read())
                {

                    if (datos.Lector.GetInt32(0) == idusuario)
                    {

                        int id = datos.Lector.GetInt32(0);
                        if (id != id_ant)
                        {
                            aux.ID = id;
                            aux.Mail = datos.Lector.GetString(1);
                            aux.Nombre = datos.Lector.GetString(2);
                            aux.Apellido = datos.Lector.GetString(3);
                            aux.Direccion = datos.Lector.GetString(4);
                            aux.Fecha_Nacimiento = datos.Lector.GetDateTime(5);
                            aux.Sexo = datos.Lector.GetInt32(6);
                            aux.Foto = datos.Lector.GetString(7);
                            aux.DNI = datos.Lector.GetString(8);
                            aux.Apto_Fisico = datos.Lector.GetString(9);
                            aux.Tel_Emergencia = datos.Lector.GetString(10);
                            aux.Cel = datos.Lector.GetString(11);
                            aux.Fecha_ingreso = datos.Lector.GetDateTime(12);
                            aux.ID_Plan = datos.Lector.GetInt16(13);
                            aux.ID_Establecimiento = datos.Lector.GetInt32(14);
                            aux.Estado = datos.Lector.GetBoolean(15);
                            aux.ID_Nivel = datos.Lector.GetInt16(16);

                            id_ant = id;
                        }
                        Rutina auxRutina = new Rutina();

                        auxRutina.ID = datos.Lector.GetInt32(17);
                        auxRutina.Dia = datos.Lector.GetString(18);
                        auxRutina.ID_Ejercicio = datos.Lector.GetInt32(19);
                        aux.rutina.Add(auxRutina);
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
                    plancito.ID = datos.Lector.GetInt16(0);
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

        public void agregarGrupoMusucular(GrupoMuscular grupoNuevo)
        {
            try
            {
                //datos.setearQuery("INSERT Into GRUPO_MUSCULAR (ID,DESCRIPCION) VALUES ('" + grupoNuevo.ID + "','" + grupoNuevo.Descripcion + "'");
                datos.setearQuery("INSERT Into GRUPO_MUSCULAR (ID,DESCRIPCION) values (@ID,@DESCRIPCION)");
                datos.setearParametro("@ID", grupoNuevo.ID);
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

    }
}