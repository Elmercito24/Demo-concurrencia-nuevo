using System.Linq.Expressions;
using System.Net;

namespace DemoConcurrencia
{
    public partial class FrmConcurrencia : Form
    {
        //Vamos a definir un metood privado para cancelar los metodos
        //Fuente de cancelacion de tokens
        private CancellationTokenSource _cts;

        public FrmConcurrencia()
        {
            InitializeComponent();
        }
        private void btnIniciarSecuencial_Click(object sender, EventArgs e)
        {

            ActualizarResultado("Iniciando proceso secuencial...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);//Que se demore 1 segundo
                ActualizarResultado($"Actividad - paso {i + 1}");
            }
            ActualizarResultado("Finalizar del proceso secuencial");
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");//Environment.line sirve para que salga otra linea
        }

        //BOTON INICIAR HILO
        private void BtnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;//Creamos la variable token
            Thread hilo1 = new Thread(() =>
            {
                try//Se pulsa dos veces tab para que se cree automaticamnete try y catch
                {
                    ActualizarResultado($"Iniciar nuevo hilo {Thread.CurrentThread.ManagedThreadId}.....");
                    Thread.Sleep(1000);//que se demore 1 segundo en ejecutar.
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();//Dedemos agregar este codigo para que pueda cancelar
                        Thread.Sleep(1000);//Que se demore 1 segundo
                        ActualizarResultado($"Actividad en hilo: {Thread.CurrentThread.ManagedThreadId}- Paso{i + 1}");
                    }

                    ActualizarResultado($"Hilo {Thread.CurrentThread.ManagedThreadId}terminado");

                }
                catch (OperationCanceledException)
                {
                    ActualizarResultado("Hilo cancelado");
                }         
            });
            hilo1.Start();//Para que se inicialize el hilo
        }

        //BOTON INICIAR TAREA
        //Para cada vez que utilizamos await tenemos que utlizar async.
        private async void BtnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;//Creamos la variable token.
            await Task.Run(() =>
            {
                try
                {
                    //Task es tarea ("Iniciando task") o ("Iniciar tarea") es igual.
                    ActualizarResultado($"Iniciando tarea{Task.CurrentId}.....");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();//Dedemos agregar este codigo para que pueda cancelar
                        Thread.Sleep(1000);//Que se tarde 1 segundo en ejecutar.
                        ActualizarResultado($"Actividad en tarea {Task.CurrentId} -paso{i + 1}");
                    }
                    ActualizarResultado($"Tarea {Task.CurrentId}completada");
                }
                catch (Exception)
                {

                    ActualizarResultado("Tarea cancelada con exito");
                }
            });
        }
        private void BtnCancelarHilo_Click(object sender, EventArgs e)
        {
           _cts?.Cancel();//El signo de interrogacion sirve para no cancele cuando no se encuentre nada que pueda cancelar.
        }
    }
}
    
