namespace DemoConcurrencia
{
    public partial class FrmGestionBloqueos : Form
    {
        //El contador debe ser igual a 0.
        private int contador = 0;

        //Elemento para realizar el bloqueo
        private object bloqueo = new();

        //Definimos la simlacion de semaforo
        private SemaphoreSlim semaforo=new SemaphoreSlim(2);//Vamos a colocar solamente 2
        public FrmGestionBloqueos()
        {
            InitializeComponent();
        }

        //BOTON DISMINUIR
        private void BtnIncrementar_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Task.Run(() =>
                    {
                        semaforo.Wait();//Solicita permiso para que pueda realizar una tarea.

                        lock (bloqueo)
                       {

                            contador++;//contador =contador +1 es igual que contador ++
                            Thread.Sleep(500);//Que se duerma un segundo en ejecutar

                            this.Invoke((MethodInvoker)delegate
                            {
                                LblContador.Text = contador.ToString();
                            });
                            Monitor.Pulse(bloqueo);//Pulse notifica los bloqueos.
                        }
                        //semaforo.Release();//libera un hilo(release)
                    });
                }
            }
        }

        private void BtnDisminuir2_Click(object sender, EventArgs e)
        {
            {
                Task.Run(() =>
                {
                    lock (bloqueo)
                    {
                        //Esperar hasta que se libere el proceso y luego se puede capturar.
                        while (contador<=0)
                        {
                            ActualizarResultado("Esperando...");
                            Monitor.Wait(bloqueo);//Este codigo sirve para notificar que esta esperando que haya productos para vender.
                        }

                        //if (contador > 0) este codigo ya no seria necesario
                        {
                            contador--;
                            //contador =contador +1 es igual que contador ++
                            Thread.Sleep(1000);//Que se duerma un segundo en ejecutar

                            this.Invoke((MethodInvoker)delegate
                            {
                                LblContador.Text = contador.ToString();
                            });
                        }
                        ActualizarResultado("Procesando...");
                    }
                });
            }
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");//Environment.Newline sirve para que salga otra linea
        }

    }
}
