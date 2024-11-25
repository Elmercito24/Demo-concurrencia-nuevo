namespace DemoConcurrencia
{
    partial class FrmAtencionAlCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            BtnDisminuirCliente = new Button();
            LblContarClientes = new Label();
            BtnTerminarAtencion = new Button();
            BtnNuevoCliente = new Button();
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
            splitContainer1.Panel1.Controls.Add(BtnDisminuirCliente);
            splitContainer1.Panel1.Controls.Add(LblContarClientes);
            splitContainer1.Panel1.Controls.Add(BtnTerminarAtencion);
            splitContainer1.Panel1.Controls.Add(BtnNuevoCliente);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(771, 456);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 0;
            // 
            // BtnDisminuirCliente
            // 
            BtnDisminuirCliente.BackColor = Color.FromArgb(128, 255, 128);
            BtnDisminuirCliente.Location = new Point(66, 88);
            BtnDisminuirCliente.Name = "BtnDisminuirCliente";
            BtnDisminuirCliente.Size = new Size(133, 40);
            BtnDisminuirCliente.TabIndex = 7;
            BtnDisminuirCliente.Text = "Disminuir cliente";
            BtnDisminuirCliente.UseVisualStyleBackColor = false;
            BtnDisminuirCliente.Click += BtnDisminuirCliente_Click;
            // 
            // LblContarClientes
            // 
            LblContarClientes.AutoSize = true;
            LblContarClientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContarClientes.ForeColor = Color.Red;
            LblContarClientes.Location = new Point(117, 342);
            LblContarClientes.Name = "LblContarClientes";
            LblContarClientes.Size = new Size(20, 23);
            LblContarClientes.TabIndex = 6;
            LblContarClientes.Text = "0";
            // 
            // BtnTerminarAtencion
            // 
            BtnTerminarAtencion.BackColor = Color.FromArgb(128, 255, 128);
            BtnTerminarAtencion.Location = new Point(66, 168);
            BtnTerminarAtencion.Name = "BtnTerminarAtencion";
            BtnTerminarAtencion.Size = new Size(133, 53);
            BtnTerminarAtencion.TabIndex = 5;
            BtnTerminarAtencion.Text = "Terminar atencion";
            BtnTerminarAtencion.UseVisualStyleBackColor = false;
            BtnTerminarAtencion.Click += BtnTerminarAtencion_Click;
            // 
            // BtnNuevoCliente
            // 
            BtnNuevoCliente.BackColor = Color.FromArgb(128, 255, 128);
            BtnNuevoCliente.Location = new Point(66, 12);
            BtnNuevoCliente.Name = "BtnNuevoCliente";
            BtnNuevoCliente.Size = new Size(133, 40);
            BtnNuevoCliente.TabIndex = 4;
            BtnNuevoCliente.Text = "Nuevo cliente";
            BtnNuevoCliente.UseVisualStyleBackColor = false;
            BtnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(3, 3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(507, 441);
            TxtResultado.TabIndex = 0;
            // 
            // FrmAtencionAlCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 456);
            Controls.Add(splitContainer1);
            Name = "FrmAtencionAlCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContarClientesHotel";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
        private Button BtnTerminarAtencion;
        private Button BtnNuevoCliente;
        private Label LblContarClientes;
        private Button BtnDisminuirCliente;
    }
}