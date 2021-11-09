using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Servicios
{
    public class funciones
    {
        public static void Logs(string nombre_archivo, string descripcion) 
        {
            //Creamos la estructura de directorios por año, mes, dia
            string directorio = AppDomain.CurrentDomain.BaseDirectory + "logs/" +
                DateTime.Now.Year.ToString() + "/" +
                DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Day.ToString();

            //verificamos si existe el direcotorio
            //En caso de no existir, entra al if y se ejecuta el metodo para crearlo
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            StreamWriter mi_archivo = new StreamWriter(directorio+"/"+nombre_archivo+".log",true);

            string cadena = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ ">>>"+descripcion;

            mi_archivo.WriteLine(cadena);
            mi_archivo.Close();
        }
    }
}