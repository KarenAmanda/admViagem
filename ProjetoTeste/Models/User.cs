using System;

namespace ProjetoTeste.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime Birthday { get; set; }
        public int IdTravelRoute { get; set; }
    }
}
