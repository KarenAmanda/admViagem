using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string TypeOfBudget { get; set; }
        public string Description { get; set; }
        public int Valeu { get; set; }
        public int IdTravelRoute { get; set; }
    }
}
