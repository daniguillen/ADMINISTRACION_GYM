using System.Data.SqlTypes;

namespace Dominio
{
    public class Plan
    {

        public string Tipo_Plan { get; set; }

        public int ID { get; set; }

        public SqlMoney Cuotas { get; set; }

        public string Descripcion { get; set; }

    }
}