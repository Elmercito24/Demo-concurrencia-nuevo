namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            BtnAsignar = new Button();
            BtnRecuperar = new Button();
            TxCadenaConexion = new TextBox();
            label1 = new Label();
            LblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // BtnAsignar
            // 
            BtnAsignar.BackColor = Color.FromArgb(128, 255, 128);
            BtnAsignar.Location = new Point(25, 132);
            BtnAsignar.Name = "BtnAsignar";
            BtnAsignar.Size = new Size(197, 55);
            BtnAsignar.TabIndex = 0;
            BtnAsignar.Text = "Asignar cadena de conexion";
            BtnAsignar.UseVisualStyleBackColor = false;
            BtnAsignar.Click += BtnAsignar_Click;
            // 
            // BtnRecuperar
            // 
            BtnRecuperar.BackColor = Color.FromArgb(128, 255, 128);
            BtnRecuperar.Location = new Point(25, 237);
            BtnRecuperar.Name = "BtnRecuperar";
            BtnRecuperar.Size = new Size(197, 55);
            BtnRecuperar.TabIndex = 1;
            BtnRecuperar.Text = "Obtener cadena de conexion";
            BtnRecuperar.UseVisualStyleBackColor = false;
            BtnRecuperar.Click += BtnRecuperar_Click;
            // 
            // TxCadenaConexion
            // 
            TxCadenaConexion.Location = new Point(25, 47);
            TxCadenaConexion.Multiline = true;
            TxCadenaConexion.Name = "TxCadenaConexion";
            TxCadenaConexion.Size = new Size(505, 31);
            TxCadenaConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 3;
            label1.Text = "Cadena de conexión";
            // 
            // LblCadenaConexionRecuperada
            // 
            LblCadenaConexionRecuperada.AutoSize = true;
            LblCadenaConexionRecuperada.Location = new Point(313, 272);
            LblCadenaConexionRecuperada.Name = "LblCadenaConexionRecuperada";
            LblCadenaConexionRecuperada.Size = new Size(150, 20);
            LblCadenaConexionRecuperada.TabIndex = 4;
            LblCadenaConexionRecuperada.Text = "Conexion recuperada";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 487);
            Controls.Add(LblCadenaConexionRecuperada);
            Controls.Add(label1);
            Controls.Add(TxCadenaConexion);
            Controls.Add(BtnRecuperar);
            Controls.Add(BtnAsignar);
            Name = "FrmPatronSingleton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostracion del patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAsignar;
        private Button BtnRecuperar;
        private TextBox TxCadenaConexion;
        private Label label1;
        private Label LblCadenaConexionRecuperada;
    }
}