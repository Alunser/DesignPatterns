using System.Collections;

namespace FactoryMethod.Entities
{
    public abstract class Lanche
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}
