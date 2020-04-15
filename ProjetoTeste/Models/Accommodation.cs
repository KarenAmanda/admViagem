using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class Accommodation
    {
        public int Id { get; set; }
        public string AccommodationName { get; set; }
        public int QtdDays { get; set; }
        public string Telephone { get; set; }
        public int Value { get; set; }
        public int IdTravelRoute { get; set; }

    }
}
