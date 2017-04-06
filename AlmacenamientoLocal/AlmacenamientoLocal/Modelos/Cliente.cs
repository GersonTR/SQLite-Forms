using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenamientoLocal.Modelos
{
    [Table("Clientes")]
    public class Cliente
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id { get; set; }

        [NotNull]
        public string Nombre { get; set; }

        public string Direccion { get; set; }
    }
}
