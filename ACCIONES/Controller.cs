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
        public List<Persona> listar() //Listado de personas para el entrenador
        {
            AccesoDatos datos = new AccesoDatos();
            List<Persona> lista= new List<Persona>();
           
                datos.setearQuery(" SELECT ID_USUARIO, NOMBRE, APELLIDO, CELULAR, FOTO, IDPLANES, TEL_EMERGENCIA FROM PERSONA");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Persona aux = new Persona();
                    aux.ID_Usuario = datos.Lector.GetInt32(0);
                    aux.Nombre = datos.Lector.GetString(1);
                    aux.Apellido = datos.Lector.GetString(2);
                    aux.Cel = datos.Lector.GetString(3);
                    aux.Foto = datos.Lector.GetString(4);
                    aux.ID_Planes = datos.Lector.GetInt32(5);
                    aux.Tel_Emergencia = datos.Lector.GetString(6);

                    lista.Add(aux);
                }

            datos.cerrarConexion();
            return lista;

        }

    }
}