using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1
{
    [Table("Persona")]
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int Id { set; get; }
        public String Nombre { set; get; }
        public String Apellido { set; get; }
        public String Apodo { set; get; }
    }
}
