using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public string Destiny { get; set; }
        public DateTime DateGo{ get; set; }
        public DateTime DateBack { get; set; }
        public int IdTravelRoute { get; set; }
    }
}
