using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class TravelRouteModel
    {
        public int Id { get; set; }
        public string TypeOfRoute { get; set; }
        public int IdSuitCase { get; set; }
        public int IdAccommodation { get; set; }
        public int IdCost { get; set; }
        public int IdBudget { get; set; }
    }
}
