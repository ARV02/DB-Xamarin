using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;

namespace App1
{
    public class Conexion : SQLiteConnection
    {
        public Conexion(string path) : base(path)
        {
            Initialize();
        }
        void Initialize()
        {
            CreateTable<Persona>();
        }
        public Persona GetPersona(string nombre)
        {
            try
            {
                return Table<Persona>().Where(t => t.Nombre == nombre).First();
            }
            catch(Exception ex)
            {
                Persona vacio = new Persona();
                return vacio;
            }
        }
        public Persona GetPersona(string nombre, string apellido)
        {
            try
            {
                return Table<Persona>().Where(t => t.Nombre == nombre).Where(t => t.Apellido == apellido).First();
            }catch(Exception ex)
            {
                Persona vacio = new Persona();
                return vacio;
            }
        }

        public int Registra(Persona persona)
        {
            return Insert(persona);
        }
        public int Actuali(Persona persona)
        {
            return Update(persona);
        }
        public int Elimina(Persona persona)
        {
            return Delete(persona);
        }
    }
}
