namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtBoxPalavra1 = new System.Windows.Forms.TextBox();
            this.txtBoxPalavra2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(34, 27);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(230, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Informe as duas palavras que deseja comparar:";
            // 
            // txtBoxPalavra1
            // 
            this.txtBoxPalavra1.Location = new System.Drawing.Point(37, 70);
            this.txtBoxPalavra1.Name = "txtBoxPalavra1";
            this.txtBoxPalavra1.Size = new System.Drawing.Size(142, 20);
            this.txtBoxPalavra1.TabIndex = 1;
            // 
            // txtBoxPalavra2
            // 
            this.txtBoxPalavra2.Location = new System.Drawing.Point(242, 70);
            this.txtBoxPalavra2.Name = "txtBoxPalavra2";
            this.txtBoxPalavra2.Size = new System.Drawing.Size(142, 20);
            this.txtBoxPalavra2.TabIndex = 2;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(169, 118);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(34, 184);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 13);
            this.lblSaida.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 360);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtBoxPalavra2);
            this.Controls.Add(this.txtBoxPalavra1);
            this.Controls.Add(this.lblDescricao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtBoxPalavra1;
        private System.Windows.Forms.TextBox txtBoxPalavra2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblSaida;
    }
}

