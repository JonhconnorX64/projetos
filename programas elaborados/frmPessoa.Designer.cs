namespace ProgramasIdeias
{
    partial class frmPessoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtQI = new System.Windows.Forms.TextBox();
            this.lblInformacao = new System.Windows.Forms.TextBox();
            this.btnMostrarDataCompleta = new System.Windows.Forms.Button();
            this.btnMostrarData = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia Nasciento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mês Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "QI";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(180, 55);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(82, 20);
            this.txtAno.TabIndex = 6;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(88, 55);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(83, 20);
            this.txtMes.TabIndex = 7;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(8, 55);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(71, 20);
            this.txtDia.TabIndex = 8;
            // 
            // txtQI
            // 
            this.txtQI.Location = new System.Drawing.Point(8, 104);
            this.txtQI.Name = "txtQI";
            this.txtQI.Size = new System.Drawing.Size(71, 20);
            this.txtQI.TabIndex = 9;
            // 
            // lblInformacao
            // 
            this.lblInformacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformacao.Location = new System.Drawing.Point(8, 188);
            this.lblInformacao.Multiline = true;
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(254, 76);
            this.lblInformacao.TabIndex = 10;
            // 
            // btnMostrarDataCompleta
            // 
            this.btnMostrarDataCompleta.Location = new System.Drawing.Point(8, 130);
            this.btnMostrarDataCompleta.Name = "btnMostrarDataCompleta";
            this.btnMostrarDataCompleta.Size = new System.Drawing.Size(254, 23);
            this.btnMostrarDataCompleta.TabIndex = 11;
            this.btnMostrarDataCompleta.Text = "Mostrar Data Completa";
            this.btnMostrarDataCompleta.UseVisualStyleBackColor = true;
            this.btnMostrarDataCompleta.Click += new System.EventHandler(this.btnMostrarDataCompleta_Click);
            // 
            // btnMostrarData
            // 
            this.btnMostrarData.Location = new System.Drawing.Point(8, 159);
            this.btnMostrarData.Name = "btnMostrarData";
            this.btnMostrarData.Size = new System.Drawing.Size(254, 23);
            this.btnMostrarData.TabIndex = 12;
            this.btnMostrarData.Text = "Mostrar Data";
            this.btnMostrarData.UseVisualStyleBackColor = true;
            this.btnMostrarData.Click += new System.EventHandler(this.btnMostrarData_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 270);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrarData);
            this.Controls.Add(this.btnMostrarDataCompleta);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.txtQI);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtQI;
        private System.Windows.Forms.TextBox lblInformacao;
        private System.Windows.Forms.Button btnMostrarDataCompleta;
        private System.Windows.Forms.Button btnMostrarData;
        private System.Windows.Forms.Button btnLimpar;
    }
}