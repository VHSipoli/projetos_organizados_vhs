namespace Resistores
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
            this.R1 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAcumula = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntTensao = new System.Windows.Forms.Button();
            this.pot1 = new System.Windows.Forms.TextBox();
            this.pot2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.checkBoxT = new System.Windows.Forms.CheckBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resistencia = new System.Windows.Forms.TextBox();
            this.ddp = new System.Windows.Forms.TextBox();
            this.intensidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.R4 = new System.Windows.Forms.TextBox();
            this.R3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(19, 50);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(58, 20);
            this.R1.TabIndex = 0;
            this.R1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R1_KeyPress);
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(19, 89);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(58, 20);
            this.R2.TabIndex = 1;
            this.R2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.R3);
            this.groupBox1.Controls.Add(this.R4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAcumula);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.R1);
            this.groupBox1.Controls.Add(this.R2);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resistores";
            // 
            // btnAcumula
            // 
            this.btnAcumula.Location = new System.Drawing.Point(161, 146);
            this.btnAcumula.Name = "btnAcumula";
            this.btnAcumula.Size = new System.Drawing.Size(86, 28);
            this.btnAcumula.TabIndex = 5;
            this.btnAcumula.Text = "Acumular";
            this.btnAcumula.UseVisualStyleBackColor = true;
            this.btnAcumula.Click += new System.EventHandler(this.btnAcumula_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnP);
            this.groupBox2.Controls.Add(this.btnS);
            this.groupBox2.Location = new System.Drawing.Point(161, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(6, 50);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 1;
            this.btnP.Text = "Paralelo";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(6, 19);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 0;
            this.btnS.Text = "Série";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resistência 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resistência 1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.resultado);
            this.groupBox3.Location = new System.Drawing.Point(305, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ω";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(6, 27);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(64, 20);
            this.resultado.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 223);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Associação";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(12, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 223);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Corrente Elétrica";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.resistencia);
            this.groupBox6.Controls.Add(this.ddp);
            this.groupBox6.Controls.Add(this.intensidade);
            this.groupBox6.Location = new System.Drawing.Point(18, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(413, 181);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Circuito";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.bntTensao);
            this.groupBox8.Controls.Add(this.pot1);
            this.groupBox8.Controls.Add(this.pot2);
            this.groupBox8.Location = new System.Drawing.Point(131, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(129, 156);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tensão";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Potencial 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Potencial 1";
            // 
            // bntTensao
            // 
            this.bntTensao.Location = new System.Drawing.Point(6, 128);
            this.bntTensao.Name = "bntTensao";
            this.bntTensao.Size = new System.Drawing.Size(117, 22);
            this.bntTensao.TabIndex = 2;
            this.bntTensao.Text = "Tensão";
            this.bntTensao.UseVisualStyleBackColor = true;
            this.bntTensao.Click += new System.EventHandler(this.bntTensao_Click);
            // 
            // pot1
            // 
            this.pot1.Location = new System.Drawing.Point(6, 45);
            this.pot1.Name = "pot1";
            this.pot1.Size = new System.Drawing.Size(59, 20);
            this.pot1.TabIndex = 1;
            this.pot1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pot1_KeyPress);
            // 
            // pot2
            // 
            this.pot2.Location = new System.Drawing.Point(6, 93);
            this.pot2.Name = "pot2";
            this.pot2.Size = new System.Drawing.Size(59, 20);
            this.pot2.TabIndex = 0;
            this.pot2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pot2_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.checkBoxR);
            this.groupBox7.Controls.Add(this.btnLimpa);
            this.groupBox7.Controls.Add(this.checkBoxT);
            this.groupBox7.Controls.Add(this.checkBoxI);
            this.groupBox7.Controls.Add(this.btnCalcula);
            this.groupBox7.Location = new System.Drawing.Point(289, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(118, 152);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calcular";
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Location = new System.Drawing.Point(23, 65);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(81, 17);
            this.checkBoxR.TabIndex = 8;
            this.checkBoxR.Text = "Resistência";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(6, 123);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(106, 23);
            this.btnLimpa.TabIndex = 8;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // checkBoxT
            // 
            this.checkBoxT.AutoSize = true;
            this.checkBoxT.Location = new System.Drawing.Point(23, 42);
            this.checkBoxT.Name = "checkBoxT";
            this.checkBoxT.Size = new System.Drawing.Size(62, 17);
            this.checkBoxT.TabIndex = 7;
            this.checkBoxT.Text = "Tensão";
            this.checkBoxT.UseVisualStyleBackColor = true;
            this.checkBoxT.CheckedChanged += new System.EventHandler(this.checkBoxT_CheckedChanged);
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.Location = new System.Drawing.Point(23, 19);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(81, 17);
            this.checkBoxI.TabIndex = 6;
            this.checkBoxI.Text = "Intensidade";
            this.checkBoxI.UseVisualStyleBackColor = true;
            this.checkBoxI.CheckedChanged += new System.EventHandler(this.checkBoxI_CheckedChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(6, 94);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(106, 23);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resistência (Ω)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tensão (V)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intensidade (A)";
            // 
            // resistencia
            // 
            this.resistencia.Location = new System.Drawing.Point(15, 146);
            this.resistencia.Name = "resistencia";
            this.resistencia.Size = new System.Drawing.Size(58, 20);
            this.resistencia.TabIndex = 2;
            this.resistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistencia_KeyPress);
            // 
            // ddp
            // 
            this.ddp.Location = new System.Drawing.Point(15, 96);
            this.ddp.Name = "ddp";
            this.ddp.Size = new System.Drawing.Size(58, 20);
            this.ddp.TabIndex = 1;
            this.ddp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ddp_KeyPress);
            // 
            // intensidade
            // 
            this.intensidade.Location = new System.Drawing.Point(13, 40);
            this.intensidade.Name = "intensidade";
            this.intensidade.Size = new System.Drawing.Size(58, 20);
            this.intensidade.TabIndex = 0;
            this.intensidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intensidade_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Resistência 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Resistência 3";
            // 
            // R4
            // 
            this.R4.Location = new System.Drawing.Point(19, 167);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(58, 20);
            this.R4.TabIndex = 8;
            this.R4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R4_KeyPress);
            // 
            // R3
            // 
            this.R3.Location = new System.Drawing.Point(19, 128);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(58, 20);
            this.R3.TabIndex = 9;
            this.R3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R3_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(459, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculando Resistência";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox ddp;
        private System.Windows.Forms.TextBox intensidade;
        private System.Windows.Forms.TextBox resistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxT;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnAcumula;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntTensao;
        private System.Windows.Forms.TextBox pot1;
        private System.Windows.Forms.TextBox pot2;
        private System.Windows.Forms.TextBox R3;
        private System.Windows.Forms.TextBox R4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

