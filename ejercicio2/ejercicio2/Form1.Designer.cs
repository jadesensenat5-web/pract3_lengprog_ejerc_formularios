namespace ejercicio2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            numMinutos = new NumericUpDown();
            numSegundos = new NumericUpDown();
            btnIniciar = new Button();
            lblTiempo = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSegundos).BeginInit();
            SuspendLayout();
            // 
            // numMinutos
            // 
            numMinutos.Location = new Point(37, 76);
            numMinutos.Name = "numMinutos";
            numMinutos.Size = new Size(180, 31);
            numMinutos.TabIndex = 0;
            // 
            // numSegundos
            // 
            numSegundos.Location = new Point(252, 76);
            numSegundos.Name = "numSegundos";
            numSegundos.Size = new Size(180, 31);
            numSegundos.TabIndex = 1;
            numSegundos.ValueChanged += numSegundos_ValueChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(495, 76);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(81, 18);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(56, 25);
            lblTiempo.TabIndex = 3;
            lblTiempo.Text = "00:00";
            // 
            // timerReloj
            // 
            timerReloj.Interval = 1000;
            timerReloj.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnIniciar);
            Controls.Add(numSegundos);
            Controls.Add(numMinutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSegundos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMinutos;
        private NumericUpDown numSegundos;
        private Button btnIniciar;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timerReloj;
    }
}
