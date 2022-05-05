using Singleton.Entities;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe Normal uso e instanciação
            var classeNormal = new ClasseNormal() { variavelClasseNormal = 26 };
            Console.WriteLine("Uso da classe Normal: " + classeNormal.variavelClasseNormal);

            //Uso da classe estática
            string valorRetornado = ClasseEstatica.ExibirValor();
            Console.WriteLine("Uso da classe Static: " + valorRetornado);

            //Uso da classe Singleton
            var variavelSingleton = ClasseSingleton.Instancia;
            variavelSingleton.Mensagem = "Macoratti .net";
            Console.WriteLine("Uso da classe Singleton : " + variavelSingleton.Mensagem);

            //Teste para ver se as instâncias de Singleton são iguais
            var outraVariavelSingleton = ClasseSingleton.Instancia;
            Console.WriteLine("Verifcando se as instâncias são as mesmas : "
                                + variavelSingleton.Equals(outraVariavelSingleton));

            Console.Read();
        }
    }
}
