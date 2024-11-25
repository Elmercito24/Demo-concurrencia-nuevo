namespace DemoConcurrencia
{
    partial class FrmGestionBloqueos
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
            BtnDisminuir2 = new Button();
            LblContador = new Label();
            BtnIncrementar = new Button();
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
            splitContainer1.Panel1.Controls.Add(BtnDisminuir2);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(714, 477);
            splitContainer1.SplitterDistance = 237;
            splitContainer1.TabIndex = 3;
            // 
            // BtnDisminuir2
            // 
            BtnDisminuir2.BackColor = Color.FromArgb(128, 255, 128);
            BtnDisminuir2.Location = new Point(44, 77);
            BtnDisminuir2.Name = "BtnDisminuir2";
            BtnDisminuir2.Size = new Size(133, 40);
            BtnDisminuir2.TabIndex = 4;
            BtnDisminuir2.Text = "Disminuir";
            BtnDisminuir2.UseVisualStyleBackColor = false;
            BtnDisminuir2.Click += BtnDisminuir2_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContador.Location = new Point(101, 438);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(19, 23);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.BackColor = Color.FromArgb(128, 255, 128);
            BtnIncrementar.Location = new Point(44, 12);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(133, 40);
            BtnIncrementar.TabIndex = 3;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = false;
            BtnIncrementar.Click += BtnIncrementar_Click_1;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.White;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(473, 477);
            TxtResultado.TabIndex = 1;
            // 
            // FrmGestionBloqueos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 477);
            Controls.Add(splitContainer1);
            Name = "FrmGestionBloqueos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionDeBloqueos";
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
        private Button BtnDisminuir2;
        private Label LblContador;
        private Button BtnIncrementar;
        private TextBox TxtResultado;
    }
}