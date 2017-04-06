using SQLite;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenamientoLocal
{
    public class ContextoDatos
    {
        public string RutaConexion { get; set; }

        public Func<SQLiteConnection> NuevaConexion { get; set; }

        public void Configurar<TClass>()
            where TClass : class
        {
            using (var conexion = NuevaConexion())
            {
                conexion.CreateTable<TClass>();

                var query = conexion.Table<TClass>().ToArray();

                foreach (var item in query)
                {
                    Debug.WriteLine(item.ToString());
                }
            }
        }

        public void Guardar<TClass>(TClass[] elementos)
            where TClass : class
        {
            using (var conexion = NuevaConexion())
            {
                conexion.RunInTransaction(() => {

                    foreach (var item in elementos)
                    {
                        conexion.Insert(item);
                    }
                });
            }
        }
    }
}