
namespace Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btSete = new System.Windows.Forms.Button();
            this.btOito = new System.Windows.Forms.Button();
            this.btNove = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btQuatro = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btDois = new System.Windows.Forms.Button();
            this.btUm = new System.Windows.Forms.Button();
            this.btVirgula = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btSubt = new System.Windows.Forms.Button();
            this.btAdicao = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btLimparCE = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(13, 13);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(304, 57);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btSete
            // 
            this.btSete.Location = new System.Drawing.Point(13, 76);
            this.btSete.Name = "btSete";
            this.btSete.Size = new System.Drawing.Size(56, 56);
            this.btSete.TabIndex = 1;
            this.btSete.Text = "7";
            this.btSete.UseVisualStyleBackColor = true;
            this.btSete.Click += new System.EventHandler(this.btSete_Click);
            // 
            // btOito
            // 
            this.btOito.Location = new System.Drawing.Point(75, 76);
            this.btOito.Name = "btOito";
            this.btOito.Size = new System.Drawing.Size(56, 56);
            this.btOito.TabIndex = 2;
            this.btOito.Text = "8";
            this.btOito.UseVisualStyleBackColor = true;
            this.btOito.Click += new System.EventHandler(this.btOito_Click);
            // 
            // btNove
            // 
            this.btNove.Location = new System.Drawing.Point(137, 76);
            this.btNove.Name = "btNove";
            this.btNove.Size = new System.Drawing.Size(56, 56);
            this.btNove.TabIndex = 3;
            this.btNove.Text = "9";
            this.btNove.UseVisualStyleBackColor = true;
            this.btNove.Click += new System.EventHandler(this.btNove_Click);
            // 
            // btSeis
            // 
            this.btSeis.Location = new System.Drawing.Point(137, 138);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(56, 56);
            this.btSeis.TabIndex = 6;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btCinco
            // 
            this.btCinco.Location = new System.Drawing.Point(75, 138);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(56, 56);
            this.btCinco.TabIndex = 5;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btQuatro
            // 
            this.btQuatro.Location = new System.Drawing.Point(13, 138);
            this.btQuatro.Name = "btQuatro";
            this.btQuatro.Size = new System.Drawing.Size(56, 56);
            this.btQuatro.TabIndex = 4;
            this.btQuatro.Text = "4";
            this.btQuatro.UseVisualStyleBackColor = true;
            this.btQuatro.Click += new System.EventHandler(this.btQuatro_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(137, 200);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(56, 56);
            this.btTres.TabIndex = 9;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btDois
            // 
            this.btDois.Location = new System.Drawing.Point(75, 200);
            this.btDois.Name = "btDois";
            this.btDois.Size = new System.Drawing.Size(56, 56);
            this.btDois.TabIndex = 8;
            this.btDois.Text = "2";
            this.btDois.UseVisualStyleBackColor = true;
            this.btDois.Click += new System.EventHandler(this.btDois_Click);
            // 
            // btUm
            // 
            this.btUm.Location = new System.Drawing.Point(13, 200);
            this.btUm.Name = "btUm";
            this.btUm.Size = new System.Drawing.Size(56, 56);
            this.btUm.TabIndex = 7;
            this.btUm.Text = "1";
            this.btUm.UseVisualStyleBackColor = true;
            this.btUm.Click += new System.EventHandler(this.btUm_Click);
            // 
            // btVirgula
            // 
            this.btVirgula.Location = new System.Drawing.Point(137, 262);
            this.btVirgula.Name = "btVirgula";
            this.btVirgula.Size = new System.Drawing.Size(56, 56);
            this.btVirgula.TabIndex = 12;
            this.btVirgula.Text = ",";
            this.btVirgula.UseVisualStyleBackColor = true;
            this.btVirgula.Click += new System.EventHandler(this.button10_Click);
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(13, 262);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(118, 56);
            this.btZero.TabIndex = 11;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btSubt
            // 
            this.btSubt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSubt.Location = new System.Drawing.Point(199, 262);
            this.btSubt.Name = "btSubt";
            this.btSubt.Size = new System.Drawing.Size(56, 56);
            this.btSubt.TabIndex = 16;
            this.btSubt.Text = "-";
            this.btSubt.UseVisualStyleBackColor = false;
            this.btSubt.Click += new System.EventHandler(this.btSubt_Click);
            // 
            // btAdicao
            // 
            this.btAdicao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAdicao.Location = new System.Drawing.Point(199, 200);
            this.btAdicao.Name = "btAdicao";
            this.btAdicao.Size = new System.Drawing.Size(56, 56);
            this.btAdicao.TabIndex = 15;
            this.btAdicao.Text = "+";
            this.btAdicao.UseVisualStyleBackColor = false;
            this.btAdicao.Click += new System.EventHandler(this.btAdicao_Click);
            // 
            // btMulti
            // 
            this.btMulti.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btMulti.Location = new System.Drawing.Point(199, 138);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(56, 56);
            this.btMulti.TabIndex = 14;
            this.btMulti.Text = "x";
            this.btMulti.UseVisualStyleBackColor = false;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btDivisao.Location = new System.Drawing.Point(199, 76);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(56, 56);
            this.btDivisao.TabIndex = 13;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = false;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btIgual.Location = new System.Drawing.Point(261, 200);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(56, 118);
            this.btIgual.TabIndex = 19;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btLimparCE
            // 
            this.btLimparCE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimparCE.Location = new System.Drawing.Point(261, 138);
            this.btLimparCE.Name = "btLimparCE";
            this.btLimparCE.Size = new System.Drawing.Size(56, 56);
            this.btLimparCE.TabIndex = 18;
            this.btLimparCE.Text = "CE";
            this.btLimparCE.UseVisualStyleBackColor = false;
            this.btLimparCE.Click += new System.EventHandler(this.btLimparCE_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpar.Location = new System.Drawing.Point(261, 76);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(56, 56);
            this.btLimpar.TabIndex = 17;
            this.btLimpar.Text = "C";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 332);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btLimparCE);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSubt);
            this.Controls.Add(this.btAdicao);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btVirgula);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btDois);
            this.Controls.Add(this.btUm);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btQuatro);
            this.Controls.Add(this.btNove);
            this.Controls.Add(this.btOito);
            this.Controls.Add(this.btSete);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btSete;
        private System.Windows.Forms.Button btOito;
        private System.Windows.Forms.Button btNove;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btQuatro;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDois;
        private System.Windows.Forms.Button btUm;
        private System.Windows.Forms.Button btVirgula;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btSubt;
        private System.Windows.Forms.Button btAdicao;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btLimparCE;
        private System.Windows.Forms.Button btLimpar;
    }
}

