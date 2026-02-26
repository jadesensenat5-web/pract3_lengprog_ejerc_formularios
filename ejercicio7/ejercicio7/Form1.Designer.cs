namespace ejercicio7
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
            txtInicio = new TextBox();
            txtFin = new TextBox();
            btnGenerPrimos = new Button();
            lstPrimos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(60, 39);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(150, 31);
            txtInicio.TabIndex = 0;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(257, 39);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(150, 31);
            txtFin.TabIndex = 1;
            // 
            // btnGenerPrimos
            // 
            btnGenerPrimos.BackColor = Color.FromArgb(192, 192, 255);
            btnGenerPrimos.Location = new Point(64, 85);
            btnGenerPrimos.Name = "btnGenerPrimos";
            btnGenerPrimos.Size = new Size(146, 34);
            btnGenerPrimos.TabIndex = 2;
            btnGenerPrimos.Text = "Generar Primos";
            btnGenerPrimos.UseVisualStyleBackColor = false;
            btnGenerPrimos.Click += btnGenerPrimos_Click;
            // 
            // lstPrimos
            // 
            lstPrimos.FormattingEnabled = true;
            lstPrimos.ItemHeight = 25;
            lstPrimos.Location = new Point(60, 125);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(180, 229);
            lstPrimos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Location = new Point(60, 5);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 4;
            label1.Text = "Numero Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.Location = new Point(257, 5);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 5;
            label2.Text = "Numero Final";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 371);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPrimos);
            Controls.Add(btnGenerPrimos);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInicio;
        private TextBox txtFin;
        private Button btnGenerPrimos;
        private ListBox lstPrimos;
        private Label label1;
        private Label label2;
    }
}
