namespace Singleton.Entities
{
    public static class ClasseEstatica
    {
        private static readonly int variavelEstatica;
        // Construtor Static constructor é executado 
        // somente uma vez quando o tipo for usado.   

        static ClasseEstatica()
        {
            variavelEstatica = 1;
        }

        public static string ExibirValor()
        {
            return string.Format("O valor da variável estática é {0}", variavelEstatica);
        }

        public static string Mensagem { get; set; }
    }
}
