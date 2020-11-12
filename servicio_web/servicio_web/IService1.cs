using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicio_web
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    { 
        [OperationContract]
        Distribuidor GetDistribuidor(int ID);

        [OperationContract]
        Alumno GetAlumno(int ID);

        [OperationContract]
        Inventario GetInventario(int Clave);

        // TODO: agregue aquí sus operaciones de servicio
    }
    [DataContract]
    public class Distribuidor: R
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string Entrega { get; set; }
    }

    [DataContract]
    public class Alumno: R
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string Num_Control { get; set; }
        [DataMember]
        public int Calificacion { get; set; }

    }

    [DataContract]
    public class Inventario: R
    {
        [DataMember]
        public string Nom_Producto { get; set; }
        [DataMember]
        public string Cantidad { get; set; }
        [DataMember]
        public string Codigo { get; set; }
    }

    [DataContract]
    public class R
    {
        [DataMember]
        public string Error { get; set; }
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
