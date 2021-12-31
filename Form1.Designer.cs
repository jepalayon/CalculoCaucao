namespace CaucaoCalculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorCaucao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFinalMulta = new System.Windows.Forms.DateTimePicker();
            this.dtDataInicioCont = new System.Windows.Forms.DateTimePicker();
            this.dtDataFinalContrato = new System.Windows.Forms.DateTimePicker();
            this.txbTotalDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMultaSaida = new System.Windows.Forms.TextBox();
            this.txbDiasPrFinal = new System.Windows.Forms.TextBox();
            this.txbReaisDia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRestoCaucao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Caução  R$:";
            // 
            // txbValorCaucao
            // 
            this.txbValorCaucao.Location = new System.Drawing.Point(147, 13);
            this.txbValorCaucao.Name = "txbValorCaucao";
            this.txbValorCaucao.Size = new System.Drawing.Size(111, 20);
            this.txbValorCaucao.TabIndex = 1;
            this.txbValorCaucao.TextChanged += new System.EventHandler(this.TxbValorCauçao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final do Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Inicial do Contrato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtFinalMulta);
            this.groupBox1.Controls.Add(this.dtDataInicioCont);
            this.groupBox1.Controls.Add(this.dtDataFinalContrato);
            this.groupBox1.Controls.Add(this.txbTotalDias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo de dias de Caução";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Data Final Cobrança de Multa";
            // 
            // dtFinalMulta
            // 
            this.dtFinalMulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalMulta.Location = new System.Drawing.Point(72, 169);
            this.dtFinalMulta.Name = "dtFinalMulta";
            this.dtFinalMulta.Size = new System.Drawing.Size(106, 20);
            this.dtFinalMulta.TabIndex = 4;
            // 
            // dtDataInicioCont
            // 
            this.dtDataInicioCont.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicioCont.Location = new System.Drawing.Point(154, 55);
            this.dtDataInicioCont.Name = "dtDataInicioCont";
            this.dtDataInicioCont.Size = new System.Drawing.Size(106, 20);
            this.dtDataInicioCont.TabIndex = 3;
            // 
            // dtDataFinalContrato
            // 
            this.dtDataFinalContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinalContrato.Location = new System.Drawing.Point(10, 55);
            this.dtDataFinalContrato.Name = "dtDataFinalContrato";
            this.dtDataFinalContrato.Size = new System.Drawing.Size(106, 20);
            this.dtDataFinalContrato.TabIndex = 2;
            this.dtDataFinalContrato.ValueChanged += new System.EventHandler(this.DtDataFinalContrato_ValueChanged);
            // 
            // txbTotalDias
            // 
            this.txbTotalDias.Location = new System.Drawing.Point(97, 104);
            this.txbTotalDias.Name = "txbTotalDias";
            this.txbTotalDias.ReadOnly = true;
            this.txbTotalDias.Size = new System.Drawing.Size(67, 20);
            this.txbTotalDias.TabIndex = 0;
            this.txbTotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total de Dias";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDataSaida);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbMultaSaida);
            this.groupBox2.Controls.Add(this.txbDiasPrFinal);
            this.groupBox2.Controls.Add(this.txbReaisDia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(352, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculo do Valor da Multa";
            // 
            // dtDataSaida
            // 
            this.dtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataSaida.Location = new System.Drawing.Point(90, 48);
            this.dtDataSaida.Name = "dtDataSaida";
            this.dtDataSaida.Size = new System.Drawing.Size(84, 20);
            this.dtDataSaida.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "R$";
            // 
            // txbMultaSaida
            // 
            this.txbMultaSaida.Location = new System.Drawing.Point(332, 48);
            this.txbMultaSaida.Name = "txbMultaSaida";
            this.txbMultaSaida.ReadOnly = true;
            this.txbMultaSaida.Size = new System.Drawing.Size(77, 20);
            this.txbMultaSaida.TabIndex = 0;
            // 
            // txbDiasPrFinal
            // 
            this.txbDiasPrFinal.Location = new System.Drawing.Point(213, 48);
            this.txbDiasPrFinal.Name = "txbDiasPrFinal";
            this.txbDiasPrFinal.ReadOnly = true;
            this.txbDiasPrFinal.Size = new System.Drawing.Size(70, 20);
            this.txbDiasPrFinal.TabIndex = 0;
            this.txbDiasPrFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbReaisDia
            // 
            this.txbReaisDia.Location = new System.Drawing.Point(28, 48);
            this.txbReaisDia.Name = "txbReaisDia";
            this.txbReaisDia.ReadOnly = true;
            this.txbReaisDia.Size = new System.Drawing.Size(37, 20);
            this.txbReaisDia.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Multa de Saída";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dias p/ o final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data de Saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "R$/dia";
            // 
            // txbRestoCaucao
            // 
            this.txbRestoCaucao.Location = new System.Drawing.Point(565, 189);
            this.txbRestoCaucao.Name = "txbRestoCaucao";
            this.txbRestoCaucao.ReadOnly = true;
            this.txbRestoCaucao.Size = new System.Drawing.Size(100, 20);
            this.txbRestoCaucao.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Restante Caução: R$ ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaucaoCalculo.Properties.Resources.logo_24_px;
            this.pictureBox1.Location = new System.Drawing.Point(528, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 58);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::CaucaoCalculo.Properties.Resources.Log_Out_icon;
            this.btnSair.Location = new System.Drawing.Point(498, 321);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 41);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.Location = new System.Drawing.Point(342, 321);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(98, 41);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::CaucaoCalculo.Properties.Resources.calculadora;
            this.btnCalcular.Location = new System.Drawing.Point(181, 321);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 41);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbRestoCaucao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbValorCaucao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Multa Contratual";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValorCaucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTotalDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMultaSaida;
        private System.Windows.Forms.TextBox txbDiasPrFinal;
        private System.Windows.Forms.TextBox txbReaisDia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRestoCaucao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtDataInicioCont;
        private System.Windows.Forms.DateTimePicker dtDataFinalContrato;
        private System.Windows.Forms.DateTimePicker dtDataSaida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFinalMulta;
    }
}

