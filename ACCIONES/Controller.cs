using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Dominio;


namespace ACCIONES
{
    public class Controller
    {
        public List<Usuario> listar_Clientes() 
        {
            List<Usuario> Aux=new List<Usuario>();

            return Aux;
        }

        public List<Persona> listarIstructores()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Persona> lista = new List<Persona>();

            datos.setearQuery("");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
              
            }

            datos.cerrarConexion();
            return lista;

        }

        public Usuario Cliente( int idusuario)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
           

            try
            {
                accesoDatos.setearQuery("SELECT  u.ID, u.MAIL, p.NOMBRE, p.APELLIDO, p.DIRECCION, p.FECHA_NACIMIENTO, p.SEXO, p.FOTO, p.DNI, p.APTO_FISICO, \r\np.TEL_EMERGENCIA, p.CELULAR, p.FECHA_INGRESO, p.IDPLANES, p.ID_ESTABLECIMIENTO , p.ESTADO, p.IDNIVEL,\r\nR.ID AS ID_RUTINA , d.NOMBRE_DIA, R.ID_EJERCICIO FROM PERSONA p \r\nINNER JOIN USUARIO u on u.ID=p.ID \r\ninner join RUTINA r on r.ID_PERSONA=p.ID \r\ninner join DIA d on r.DIA=d.ID    \r\nWHERE P.ID=1");
                accesoDatos.setearParametro("@ID", idusuario);
                accesoDatos.ejecutarLectura();
                
                Usuario aux= new Usuario();
                int id_ant = -1;

                while (accesoDatos.Lector.Read()){

                    if (accesoDatos.Lector.GetInt32(0)== idusuario) { 

                    int id = accesoDatos.Lector.GetInt32(0);
                        if (id != id_ant)
                        {
                            aux.ID = id;
                            aux.Mail = accesoDatos.Lector.GetString(1);
                            aux.Nombre = accesoDatos.Lector.GetString(2);
                            aux.Apellido = accesoDatos.Lector.GetString(3);
                            aux.Direccion = accesoDatos.Lector.GetString(4);
                            aux.Fecha_Nacimiento = accesoDatos.Lector.GetDateTime(5);
                            aux.Sexo = accesoDatos.Lector.GetInt32(6);
                            aux.Foto = accesoDatos.Lector.GetString(7);
                            aux.DNI = accesoDatos.Lector.GetString(8);
                            aux.Apto_Fisico = accesoDatos.Lector.GetString(9);
                            aux.Tel_Emergencia = accesoDatos.Lector.GetString(10);
                            aux.Cel = accesoDatos.Lector.GetString(11);
                            aux.Fecha_ingreso = accesoDatos.Lector.GetDateTime(12);
                            aux.ID_Plan = accesoDatos.Lector.GetInt16(13);
                            aux.ID_Establecimiento = accesoDatos.Lector.GetInt32(14);
                            aux.Estado = accesoDatos.Lector.GetBoolean(15);
                            aux.ID_Nivel = accesoDatos.Lector.GetInt16(16);
                           
                            id_ant = id;
                        }
                        Rutina auxRutina=new Rutina();

                        auxRutina.ID = accesoDatos.Lector.GetInt32(17);
                        auxRutina.Dia = accesoDatos.Lector.GetString(18);
                        auxRutina.ID_Ejercicio = accesoDatos.Lector.GetInt32(19);
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
                accesoDatos.cerrarConexion();
            }


        }

        public List<Ejercicio> ListarEjercicios()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Ejercicio> aux = new List<Ejercicio>();
                datos.setearQuery("select e.ID, e.DESCRIPCION, e.NOMBRE, e.REPETICIONES, e.ID_DIFICULTAD, d.DESCRIPCION, e.VIDEO, e.ID_TIPO, tp.DESCRIPCION, e.ID_GRUPO_MUSCULAR, gm.DESCRIPCION from EJERCICIO e\r\ninner join DIFICULTAD d on e.ID_DIFICULTAD=d.ID\r\ninner join TIPO_EJERCICIO TP on e.ID_TIPO=TP.ID\r\ninner join GRUPO_MUSCULAR GM on e.ID_GRUPO_MUSCULAR=GM.ID");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Ejercicio ejercicio = new Ejercicio();
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
            AccesoDatos datos = new AccesoDatos();
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
            catch(Exception ex)
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