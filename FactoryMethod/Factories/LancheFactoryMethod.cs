using FactoryMethod.Entities;

namespace FactoryMethod.Factories
{
    public abstract class LancheFactoryMethod
    {
        public abstract Lanche CriarLanche(int tipo);
    }
}
