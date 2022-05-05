using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities
{
    public class Frango : Lanche
    {
        private readonly string _nomeLanche;

        public Frango()
        {
            _nomeLanche = "Lanche de Frango";
            Ingredientes.Add("Peito de frango");
            Ingredientes.Add("Maionese e tomate");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
