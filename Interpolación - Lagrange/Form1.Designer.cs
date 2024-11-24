namespace Interpolación___Lagrange
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtResultado = new TextBox();
            x3 = new TextBox();
            x2 = new TextBox();
            x1 = new TextBox();
            x4 = new TextBox();
            Y1 = new TextBox();
            Y3 = new TextBox();
            Y2 = new TextBox();
            Y4 = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            panelG = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 119);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(24, 24);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 119);
            label2.Name = "label2";
            label2.Size = new Size(24, 24);
            label2.TabIndex = 2;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 311);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 3;
            label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(590, 349);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(661, 230);
            txtResultado.TabIndex = 4;
            // 
            // x3
            // 
            x3.Location = new Point(130, 349);
            x3.Multiline = true;
            x3.Name = "x3";
            x3.Size = new Size(69, 45);
            x3.TabIndex = 6;
            // 
            // x2
            // 
            x2.Location = new Point(130, 252);
            x2.Multiline = true;
            x2.Name = "x2";
            x2.Size = new Size(69, 45);
            x2.TabIndex = 7;
            // 
            // x1
            // 
            x1.Location = new Point(130, 167);
            x1.Multiline = true;
            x1.Name = "x1";
            x1.Size = new Size(69, 45);
            x1.TabIndex = 8;
            // 
            // x4
            // 
            x4.Location = new Point(130, 437);
            x4.Multiline = true;
            x4.Name = "x4";
            x4.Size = new Size(69, 45);
            x4.TabIndex = 9;
            // 
            // Y1
            // 
            Y1.Location = new Point(257, 167);
            Y1.Multiline = true;
            Y1.Name = "Y1";
            Y1.Size = new Size(69, 45);
            Y1.TabIndex = 10;
            // 
            // Y3
            // 
            Y3.Location = new Point(257, 349);
            Y3.Multiline = true;
            Y3.Name = "Y3";
            Y3.Size = new Size(69, 45);
            Y3.TabIndex = 11;
            // 
            // Y2
            // 
            Y2.Location = new Point(257, 252);
            Y2.Multiline = true;
            Y2.Name = "Y2";
            Y2.Size = new Size(69, 45);
            Y2.TabIndex = 12;
            // 
            // Y4
            // 
            Y4.Location = new Point(257, 437);
            Y4.Multiline = true;
            Y4.Name = "Y4";
            Y4.Size = new Size(69, 45);
            Y4.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(617, 119);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 59);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(617, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(187, 55);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // panelG
            // 
            panelG.Location = new Point(3, 585);
            panelG.Name = "panelG";
            panelG.Size = new Size(888, 544);
            panelG.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 1061);
            Controls.Add(panelG);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(Y4);
            Controls.Add(Y2);
            Controls.Add(Y3);
            Controls.Add(Y1);
            Controls.Add(x4);
            Controls.Add(x1);
            Controls.Add(x2);
            Controls.Add(x3);
            Controls.Add(txtResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtResultado;
        private TextBox x3;
        private TextBox x2;
        private TextBox x1;
        private TextBox x4;
        private TextBox Y1;
        private TextBox Y3;
        private TextBox Y2;
        private TextBox Y4;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Panel panelG;
    }
}
