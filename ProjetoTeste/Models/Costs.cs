using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class Costs
    {
        public int Id { get; set; }
        public string TypeOfCost { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public int IdTravelRoute { get; set; }
    }
}
