namespace Calculator
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUM = new System.Windows.Forms.TextBox();
            this.txtValorDOIS = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcular.Location = new System.Drawing.Point(76, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 33);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // txtValorUM
            // 
            this.txtValorUM.Location = new System.Drawing.Point(26, 145);
            this.txtValorUM.Name = "txtValorUM";
            this.txtValorUM.Size = new System.Drawing.Size(100, 20);
            this.txtValorUM.TabIndex = 3;
            this.txtValorUM.TextChanged += new System.EventHandler(this.txtValorUM_TextChanged_1);
            // 
            // txtValorDOIS
            // 
            this.txtValorDOIS.Location = new System.Drawing.Point(193, 145);
            this.txtValorDOIS.Name = "txtValorDOIS";
            this.txtValorDOIS.Size = new System.Drawing.Size(100, 20);
            this.txtValorDOIS.TabIndex = 4;
            this.txtValorDOIS.TextChanged += new System.EventHandler(this.txtValorDOIS_TextChanged);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSoma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.White;
            this.btnSoma.Location = new System.Drawing.Point(13, 294);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(59, 44);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDivisao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.White;
            this.btnDivisao.Location = new System.Drawing.Point(249, 294);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(59, 44);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacao.Location = new System.Drawing.Point(171, 294);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(59, 44);
            this.btnMultiplicacao.TabIndex = 10;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSubtracao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.White;
            this.btnSubtracao.Location = new System.Drawing.Point(91, 294);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(59, 44);
            this.btnSubtracao.TabIndex = 11;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecione a Operação Desejada";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(111, 201);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(326, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtValorDOIS);
            this.Controls.Add(this.txtValorUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorUM;
        private System.Windows.Forms.TextBox txtValorDOIS;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

