using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Models
{
    public class SuitCase
    {
        public int Id { get; set; }
        public string Itens { get; set; }
        public int QtdItens { get; set; }
        public string TypeOfItens{ get; set; }
        public int IdTravelRoute { get; set; }
    }
}
