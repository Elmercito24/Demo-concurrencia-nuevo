namespace DemoConcurrencia
{
    public sealed class Singleton//Sealed para que no pueda heredar,es una clase unica.
    {
        private static Singleton instancia = null;
        //Elemento para realizar el bloqueo
        private static readonly object bloqueo = new object();
        public string cadenaConexion;

        //Constructor
        //ctor y tab
        public Singleton()
        {
            cadenaConexion = "";
        }
        //Defini instancia
        public static Singleton Instance
        {
            get
            {
                lock (bloqueo)
                { 
                    if (instancia == null)
                    {
                        instancia = new Singleton();
                    }
                    return instancia;
                }
            }
        }
    }
}
