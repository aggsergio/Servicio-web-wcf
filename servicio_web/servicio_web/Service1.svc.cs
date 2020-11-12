using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicio_web
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Inventario GetInventario(int Clave)
        {
            if (Clave == 123)
            {
                return new Inventario() { Nom_Producto = "Indio", Cantidad = "14", Codigo = "876403"};
            }
            else if (Clave == 321)
            {
                return new Inventario() { Nom_Producto = "Modelo", Cantidad = "26", Codigo = "068265" };
            }
            else if (Clave == 456)
            {
                return new Inventario() { Nom_Producto = "Corona", Cantidad = "17", Codigo = "692058" };
            }
            else
            {
                return new Inventario() { Error = "Producto no encontrado" };
            }
        }

        public Alumno GetAlumno(int ID)
        {
            if (ID == 1)
            {
                return new Alumno() { Nombre = "Sara", Apellidos = "Castañeda Valdez", Num_Control = "17030085", Calificacion = 10};
            }
            else if (ID == 2)
            {
                return new Alumno() { Nombre = "Arely", Apellidos = "Chávez Ramírez", Num_Control = "17030086", Calificacion = 8 };
            }
            else if (ID == 3)
            {
                return new Alumno() { Nombre = "Ámbar", Apellidos = "Salazar Rodríguez", Num_Control = "17030087", Calificacion = 9 };
            }
            else
            {
                return new Alumno() { Error = "Alumno no encontrado" };
            }
        }

        public Distribuidor GetDistribuidor(int ID)
        { 
            if (ID == 1)
            {
                return new Distribuidor() { Nombre = "Mario", Apellidos = "Romero Ramírez", Entrega = "Grupo Modelo" };
            }
            else if (ID == 2)
            {
                return new Distribuidor() { Nombre = "Alonso", Apellidos = "Cazales Guevara", Entrega = "Sabritas" };
            }
            else if (ID == 3)
            {
                return new Distribuidor() { Nombre = "Hugo", Apellidos = "Olivares Puebla", Entrega = "Barcel" };
            }
            else if (ID == 4)
            {
                return new Distribuidor() { Nombre = "Daniel", Apellidos = "Ramírez Heredia", Entrega = "Leo" };
            }
            else if (ID == 5)
            {
                return new Distribuidor() { Nombre = "Diana", Apellidos = "Rodríguez Alvarado", Entrega = "Cervezería Moctezuma" };
            }
            else
            {
                return new Distribuidor() { Error = "Distribuidor no encontrado" };
            }
        }
    }
}
