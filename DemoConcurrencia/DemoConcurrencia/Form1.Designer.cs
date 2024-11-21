namespace DemoConcurrencia
{
    partial class FrmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            BtnCancelarHilo = new Button();
            BtnIniciarTarea = new Button();
            BtnIniciarHilo = new Button();
            btnIniciarSecuencial = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(192, 255, 192);
            splitContainer1.Panel1.Controls.Add(BtnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(889, 545);
            splitContainer1.SplitterDistance = 295;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCancelarHilo
            // 
            BtnCancelarHilo.BackColor = Color.FromArgb(255, 192, 192);
            BtnCancelarHilo.Location = new Point(60, 357);
            BtnCancelarHilo.Name = "BtnCancelarHilo";
            BtnCancelarHilo.Size = new Size(189, 35);
            BtnCancelarHilo.TabIndex = 3;
            BtnCancelarHilo.Text = "Cancelar  procesos";
            BtnCancelarHilo.UseVisualStyleBackColor = false;
            BtnCancelarHilo.Click += BtnCancelarHilo_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.BackColor = Color.FromArgb(224, 224, 224);
            BtnIniciarTarea.Location = new Point(60, 238);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(189, 54);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // BtnIniciarHilo
            // 
            BtnIniciarHilo.BackColor = Color.FromArgb(224, 224, 224);
            BtnIniciarHilo.Location = new Point(56, 136);
            BtnIniciarHilo.Name = "BtnIniciarHilo";
            BtnIniciarHilo.Size = new Size(193, 55);
            BtnIniciarHilo.TabIndex = 1;
            BtnIniciarHilo.Text = "Iniciar hilo";
            BtnIniciarHilo.UseVisualStyleBackColor = false;
            BtnIniciarHilo.Click += BtnIniciarHilo_Click;
            // 
            // btnIniciarSecuencial
            // 
            btnIniciarSecuencial.BackColor = Color.FromArgb(224, 224, 224);
            btnIniciarSecuencial.Location = new Point(56, 38);
            btnIniciarSecuencial.Name = "btnIniciarSecuencial";
            btnIniciarSecuencial.Size = new Size(193, 51);
            btnIniciarSecuencial.TabIndex = 0;
            btnIniciarSecuencial.Text = "Iniciar Secuencial";
            btnIniciarSecuencial.UseVisualStyleBackColor = false;
            btnIniciarSecuencial.Click += btnIniciarSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.White;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(590, 545);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 545);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostracion de concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnIniciarTarea;
        private Button BtnIniciarHilo;
        private Button btnIniciarSecuencial;
        private TextBox TxtResultado;
        private Button BtnCancelarHilo;
    }
}
