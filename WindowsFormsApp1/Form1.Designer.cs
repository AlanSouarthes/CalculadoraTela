namespace WindowsFormsApp1
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numeroUm = new System.Windows.Forms.Button();
            this.numeroDois = new System.Windows.Forms.Button();
            this.numeroTres = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.numeroQuatro = new System.Windows.Forms.Button();
            this.numeroCinco = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numeroSeis = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.numeroSete = new System.Windows.Forms.Button();
            this.numeroOito = new System.Windows.Forms.Button();
            this.numeroNove = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.numeroZero = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(66, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 68);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Calculadora";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // numeroUm
            // 
            this.numeroUm.BackColor = System.Drawing.Color.LightCyan;
            this.numeroUm.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroUm.ForeColor = System.Drawing.Color.Black;
            this.numeroUm.Location = new System.Drawing.Point(66, 244);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(81, 63);
            this.numeroUm.TabIndex = 1;
            this.numeroUm.Text = "1";
            this.numeroUm.UseVisualStyleBackColor = false;
            this.numeroUm.Click += new System.EventHandler(this.numeroUm_Click);
            // 
            // numeroDois
            // 
            this.numeroDois.BackColor = System.Drawing.Color.LightCyan;
            this.numeroDois.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDois.ForeColor = System.Drawing.Color.Black;
            this.numeroDois.Location = new System.Drawing.Point(153, 244);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(81, 63);
            this.numeroDois.TabIndex = 2;
            this.numeroDois.Text = "2";
            this.numeroDois.UseVisualStyleBackColor = false;
            this.numeroDois.Click += new System.EventHandler(this.numeroDois_Click);
            // 
            // numeroTres
            // 
            this.numeroTres.BackColor = System.Drawing.Color.LightCyan;
            this.numeroTres.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTres.ForeColor = System.Drawing.Color.Black;
            this.numeroTres.Location = new System.Drawing.Point(240, 244);
            this.numeroTres.Name = "numeroTres";
            this.numeroTres.Size = new System.Drawing.Size(81, 63);
            this.numeroTres.TabIndex = 3;
            this.numeroTres.Text = "3";
            this.numeroTres.UseVisualStyleBackColor = false;
            this.numeroTres.Click += new System.EventHandler(this.numeroTres_Click);
            // 
            // somar
            // 
            this.somar.BackColor = System.Drawing.Color.LightCyan;
            this.somar.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.ForeColor = System.Drawing.Color.Black;
            this.somar.Location = new System.Drawing.Point(327, 244);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(81, 63);
            this.somar.TabIndex = 4;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = false;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // numeroQuatro
            // 
            this.numeroQuatro.BackColor = System.Drawing.Color.LightCyan;
            this.numeroQuatro.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroQuatro.ForeColor = System.Drawing.Color.Black;
            this.numeroQuatro.Location = new System.Drawing.Point(66, 313);
            this.numeroQuatro.Name = "numeroQuatro";
            this.numeroQuatro.Size = new System.Drawing.Size(81, 63);
            this.numeroQuatro.TabIndex = 5;
            this.numeroQuatro.Text = "4";
            this.numeroQuatro.UseVisualStyleBackColor = false;
            this.numeroQuatro.Click += new System.EventHandler(this.numeroQuatro_Click);
            // 
            // numeroCinco
            // 
            this.numeroCinco.BackColor = System.Drawing.Color.LightCyan;
            this.numeroCinco.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCinco.ForeColor = System.Drawing.Color.Black;
            this.numeroCinco.Location = new System.Drawing.Point(153, 313);
            this.numeroCinco.Name = "numeroCinco";
            this.numeroCinco.Size = new System.Drawing.Size(81, 63);
            this.numeroCinco.TabIndex = 6;
            this.numeroCinco.Text = "5";
            this.numeroCinco.UseVisualStyleBackColor = false;
            this.numeroCinco.Click += new System.EventHandler(this.numeroCinco_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCyan;
            this.button7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(240, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 63);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // numeroSeis
            // 
            this.numeroSeis.BackColor = System.Drawing.Color.LightCyan;
            this.numeroSeis.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroSeis.ForeColor = System.Drawing.Color.Black;
            this.numeroSeis.Location = new System.Drawing.Point(240, 313);
            this.numeroSeis.Name = "numeroSeis";
            this.numeroSeis.Size = new System.Drawing.Size(81, 63);
            this.numeroSeis.TabIndex = 7;
            this.numeroSeis.Text = "6";
            this.numeroSeis.UseVisualStyleBackColor = false;
            this.numeroSeis.Click += new System.EventHandler(this.numeroSeis_Click);
            // 
            // subtrair
            // 
            this.subtrair.BackColor = System.Drawing.Color.LightCyan;
            this.subtrair.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.ForeColor = System.Drawing.Color.Black;
            this.subtrair.Location = new System.Drawing.Point(327, 313);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(81, 63);
            this.subtrair.TabIndex = 8;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = false;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // numeroSete
            // 
            this.numeroSete.BackColor = System.Drawing.Color.LightCyan;
            this.numeroSete.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroSete.ForeColor = System.Drawing.Color.Black;
            this.numeroSete.Location = new System.Drawing.Point(66, 382);
            this.numeroSete.Name = "numeroSete";
            this.numeroSete.Size = new System.Drawing.Size(81, 63);
            this.numeroSete.TabIndex = 9;
            this.numeroSete.Text = "7";
            this.numeroSete.UseVisualStyleBackColor = false;
            this.numeroSete.Click += new System.EventHandler(this.numeroSete_Click);
            // 
            // numeroOito
            // 
            this.numeroOito.BackColor = System.Drawing.Color.LightCyan;
            this.numeroOito.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroOito.ForeColor = System.Drawing.Color.Black;
            this.numeroOito.Location = new System.Drawing.Point(153, 382);
            this.numeroOito.Name = "numeroOito";
            this.numeroOito.Size = new System.Drawing.Size(81, 63);
            this.numeroOito.TabIndex = 10;
            this.numeroOito.Text = "8";
            this.numeroOito.UseVisualStyleBackColor = false;
            this.numeroOito.Click += new System.EventHandler(this.numeroOito_Click);
            // 
            // numeroNove
            // 
            this.numeroNove.BackColor = System.Drawing.Color.LightCyan;
            this.numeroNove.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroNove.ForeColor = System.Drawing.Color.Black;
            this.numeroNove.Location = new System.Drawing.Point(240, 382);
            this.numeroNove.Name = "numeroNove";
            this.numeroNove.Size = new System.Drawing.Size(81, 63);
            this.numeroNove.TabIndex = 11;
            this.numeroNove.Text = "9";
            this.numeroNove.UseVisualStyleBackColor = false;
            this.numeroNove.Click += new System.EventHandler(this.numeroNove_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.LightCyan;
            this.multiplicar.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.ForeColor = System.Drawing.Color.Black;
            this.multiplicar.Location = new System.Drawing.Point(327, 382);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(81, 63);
            this.multiplicar.TabIndex = 12;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.LightCyan;
            this.limpar.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.Color.Black;
            this.limpar.Location = new System.Drawing.Point(66, 451);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(81, 63);
            this.limpar.TabIndex = 13;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // numeroZero
            // 
            this.numeroZero.BackColor = System.Drawing.Color.LightCyan;
            this.numeroZero.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroZero.ForeColor = System.Drawing.Color.Black;
            this.numeroZero.Location = new System.Drawing.Point(153, 451);
            this.numeroZero.Name = "numeroZero";
            this.numeroZero.Size = new System.Drawing.Size(81, 63);
            this.numeroZero.TabIndex = 14;
            this.numeroZero.Text = "0";
            this.numeroZero.UseVisualStyleBackColor = false;
            this.numeroZero.Click += new System.EventHandler(this.numeroZero_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.LightCyan;
            this.igual.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.Color.Black;
            this.igual.Location = new System.Drawing.Point(240, 451);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(81, 63);
            this.igual.TabIndex = 15;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.LightCyan;
            this.dividir.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.ForeColor = System.Drawing.Color.Black;
            this.dividir.Location = new System.Drawing.Point(327, 451);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(81, 63);
            this.dividir.TabIndex = 16;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.LightCyan;
            this.resultado.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.SpringGreen;
            this.resultado.Location = new System.Drawing.Point(66, 573);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(342, 62);
            this.resultado.TabIndex = 17;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 677);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.numeroZero);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.numeroNove);
            this.Controls.Add(this.numeroOito);
            this.Controls.Add(this.numeroSete);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.numeroSeis);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.numeroCinco);
            this.Controls.Add(this.numeroQuatro);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroTres);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "CalculadoraTela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button numeroUm;
        private System.Windows.Forms.Button numeroDois;
        private System.Windows.Forms.Button numeroTres;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button numeroQuatro;
        private System.Windows.Forms.Button numeroCinco;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button numeroSeis;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button numeroSete;
        private System.Windows.Forms.Button numeroOito;
        private System.Windows.Forms.Button numeroNove;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button numeroZero;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.TextBox resultado;
    }
}

