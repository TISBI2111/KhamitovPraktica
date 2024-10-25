using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFilter.Models
{
    public class Pers
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Atribut { get; set; } 
        public int PersAtributId { get; set; }

        public PersAtribut PersAtribut { get; set; }
    }
}
