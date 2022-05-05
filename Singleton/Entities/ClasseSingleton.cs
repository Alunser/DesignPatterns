namespace Singleton.Entities
{
    public sealed class ClasseSingleton
    {
        static ClasseSingleton _instancia;

        public static ClasseSingleton Instancia
        {
            get { return _instancia ?? (_instancia = new ClasseSingleton()); }
        }

        private ClasseSingleton() { }
        
        public string Mensagem { get; set; }
    }
}
