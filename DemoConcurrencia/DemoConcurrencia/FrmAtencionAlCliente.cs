using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmAtencionAlCliente : Form
    {
        private int contador = 0;

        //Elemento para realizar el bloqueo
        private object bloqueo = new();

        //Definimos la simlacion de semaforo
        private SemaphoreSlim semaforo = new SemaphoreSlim(6);//Vamos a colocar solamente 2
        public FrmAtencionAlCliente()
        {
            InitializeComponent();
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();

                lock (bloqueo)
                {
                    contador++; // Incrementa el contador de clientes en el hotel
                    Thread.Sleep(100);
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContarClientes.Text = contador.ToString(); // Actualiza la interfaz  
                    });

                    ActualizarResultado("Registrando cliente...");
                }

             // semaforo.Release();
            });
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

        private void BtnDisminuirCliente_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ActualizarResultado("Esperando..");
                        Monitor.Wait(bloqueo);
                    }

                    contador--; // Reduce el contador de clientes en el hotel  
                    Thread.Sleep(1000);//Sirve para que se ejecute en 1 segundo
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContarClientes.Text = contador.ToString(); // Actualiza la interfaz  
                    });

                    ActualizarResultado("Quitando...");
                }
            });
        }

        private void BtnTerminarAtencion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
