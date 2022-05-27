namespace IMC
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
            this.Titulo_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Altura_textBox = new System.Windows.Forms.TextBox();
            this.Peso_textBox = new System.Windows.Forms.TextBox();
            this.Calcular_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo_txt
            // 
            this.Titulo_txt.AutoSize = true;
            this.Titulo_txt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo_txt.Location = new System.Drawing.Point(137, 9);
            this.Titulo_txt.Name = "Titulo_txt";
            this.Titulo_txt.Size = new System.Drawing.Size(343, 37);
            this.Titulo_txt.TabIndex = 0;
            this.Titulo_txt.Text = "Programa para Calculo IMC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso";
            // 
            // Altura_textBox
            // 
            this.Altura_textBox.Location = new System.Drawing.Point(106, 63);
            this.Altura_textBox.Name = "Altura_textBox";
            this.Altura_textBox.Size = new System.Drawing.Size(100, 23);
            this.Altura_textBox.TabIndex = 3;
            this.Altura_textBox.Text = "0";
            // 
            // Peso_textBox
            // 
            this.Peso_textBox.Location = new System.Drawing.Point(106, 100);
            this.Peso_textBox.Name = "Peso_textBox";
            this.Peso_textBox.Size = new System.Drawing.Size(100, 23);
            this.Peso_textBox.TabIndex = 4;
            this.Peso_textBox.Text = "0";
            // 
            // Calcular_btn
            // 
            this.Calcular_btn.Location = new System.Drawing.Point(106, 144);
            this.Calcular_btn.Name = "Calcular_btn";
            this.Calcular_btn.Size = new System.Drawing.Size(100, 23);
            this.Calcular_btn.TabIndex = 5;
            this.Calcular_btn.Text = "Calcular";
            this.Calcular_btn.UseVisualStyleBackColor = true;
            this.Calcular_btn.Click += new System.EventHandler(this.Calcular_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // Resultado_lbl
            // 
            this.Resultado_lbl.AutoSize = true;
            this.Resultado_lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado_lbl.Location = new System.Drawing.Point(158, 187);
            this.Resultado_lbl.Name = "Resultado_lbl";
            this.Resultado_lbl.Size = new System.Drawing.Size(39, 37);
            this.Resultado_lbl.TabIndex = 7;
            this.Resultado_lbl.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 286);
            this.Controls.Add(this.Resultado_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcular_btn);
            this.Controls.Add(this.Peso_textBox);
            this.Controls.Add(this.Altura_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Titulo_txt;
        private Label label1;
        private Label label2;
        private TextBox Altura_textBox;
        private TextBox Peso_textBox;
        private Button Calcular_btn;
        private Label label3;
        private Label Resultado_lbl;
    }
}