namespace Triangulos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox1Lado = new System.Windows.Forms.TextBox();
            this.txtBox3Lado = new System.Windows.Forms.TextBox();
            this.txtBox2Lado = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equilatero = new System.Windows.Forms.PictureBox();
            this.isosceles = new System.Windows.Forms.PictureBox();
            this.escalemo = new System.Windows.Forms.PictureBox();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isosceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalemo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox1Lado
            // 
            this.txtBox1Lado.Location = new System.Drawing.Point(97, 100);
            this.txtBox1Lado.Name = "txtBox1Lado";
            this.txtBox1Lado.Size = new System.Drawing.Size(100, 20);
            this.txtBox1Lado.TabIndex = 0;
            // 
            // txtBox3Lado
            // 
            this.txtBox3Lado.Location = new System.Drawing.Point(97, 212);
            this.txtBox3Lado.Name = "txtBox3Lado";
            this.txtBox3Lado.Size = new System.Drawing.Size(100, 20);
            this.txtBox3Lado.TabIndex = 1;
            // 
            // txtBox2Lado
            // 
            this.txtBox2Lado.Location = new System.Drawing.Point(97, 157);
            this.txtBox2Lado.Name = "txtBox2Lado";
            this.txtBox2Lado.Size = new System.Drawing.Size(100, 20);
            this.txtBox2Lado.TabIndex = 2;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(97, 285);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2 lado ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "3 lado";
            // 
            // equilatero
            // 
            this.equilatero.Image = ((System.Drawing.Image)(resources.GetObject("equilatero.Image")));
            this.equilatero.Location = new System.Drawing.Point(304, 100);
            this.equilatero.Name = "equilatero";
            this.equilatero.Size = new System.Drawing.Size(213, 132);
            this.equilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equilatero.TabIndex = 7;
            this.equilatero.TabStop = false;
            this.equilatero.Visible = false;
            // 
            // isosceles
            // 
            this.isosceles.Image = ((System.Drawing.Image)(resources.GetObject("isosceles.Image")));
            this.isosceles.Location = new System.Drawing.Point(304, 100);
            this.isosceles.Name = "isosceles";
            this.isosceles.Size = new System.Drawing.Size(213, 129);
            this.isosceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isosceles.TabIndex = 8;
            this.isosceles.TabStop = false;
            this.isosceles.Visible = false;
            // 
            // escalemo
            // 
            this.escalemo.Image = ((System.Drawing.Image)(resources.GetObject("escalemo.Image")));
            this.escalemo.Location = new System.Drawing.Point(304, 100);
            this.escalemo.Name = "escalemo";
            this.escalemo.Size = new System.Drawing.Size(213, 132);
            this.escalemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.escalemo.TabIndex = 9;
            this.escalemo.TabStop = false;
            this.escalemo.Visible = false;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(108, 340);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(12, 13);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 481);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.escalemo);
            this.Controls.Add(this.isosceles);
            this.Controls.Add(this.equilatero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txtBox2Lado);
            this.Controls.Add(this.txtBox3Lado);
            this.Controls.Add(this.txtBox1Lado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isosceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escalemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1Lado;
        private System.Windows.Forms.TextBox txtBox3Lado;
        private System.Windows.Forms.TextBox txtBox2Lado;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox equilatero;
        private System.Windows.Forms.PictureBox isosceles;
        private System.Windows.Forms.PictureBox escalemo;
        private System.Windows.Forms.Label resultado;
    }
}

