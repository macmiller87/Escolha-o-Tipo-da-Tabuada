
namespace p25aula
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
            this.lblNumTab = new System.Windows.Forms.Label();
            this.textBoxNumTab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTabMultiplic = new System.Windows.Forms.Button();
            this.btnTabSomando = new System.Windows.Forms.Button();
            this.listBoxMultiplic = new System.Windows.Forms.ListBox();
            this.listBoxSomar = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumTab
            // 
            this.lblNumTab.AutoSize = true;
            this.lblNumTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumTab.Location = new System.Drawing.Point(13, 41);
            this.lblNumTab.Name = "lblNumTab";
            this.lblNumTab.Size = new System.Drawing.Size(303, 19);
            this.lblNumTab.TabIndex = 0;
            this.lblNumTab.Text = "Digite um Número Para Ver a Tabuada:";
            // 
            // textBoxNumTab
            // 
            this.textBoxNumTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumTab.Location = new System.Drawing.Point(322, 34);
            this.textBoxNumTab.Name = "textBoxNumTab";
            this.textBoxNumTab.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumTab.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabuada Multiplicando!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(550, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tabuada Somando!";
            // 
            // btnTabMultiplic
            // 
            this.btnTabMultiplic.Location = new System.Drawing.Point(88, 168);
            this.btnTabMultiplic.Name = "btnTabMultiplic";
            this.btnTabMultiplic.Size = new System.Drawing.Size(108, 38);
            this.btnTabMultiplic.TabIndex = 4;
            this.btnTabMultiplic.Text = "Multiplicar";
            this.btnTabMultiplic.UseVisualStyleBackColor = true;
            this.btnTabMultiplic.Click += new System.EventHandler(this.btnTabMultiplic_Click);
            // 
            // btnTabSomando
            // 
            this.btnTabSomando.Location = new System.Drawing.Point(598, 168);
            this.btnTabSomando.Name = "btnTabSomando";
            this.btnTabSomando.Size = new System.Drawing.Size(108, 38);
            this.btnTabSomando.TabIndex = 5;
            this.btnTabSomando.Text = "Somar";
            this.btnTabSomando.UseVisualStyleBackColor = true;
            this.btnTabSomando.Click += new System.EventHandler(this.btnTabSomando_Click);
            // 
            // listBoxMultiplic
            // 
            this.listBoxMultiplic.FormattingEnabled = true;
            this.listBoxMultiplic.ItemHeight = 19;
            this.listBoxMultiplic.Location = new System.Drawing.Point(79, 264);
            this.listBoxMultiplic.Name = "listBoxMultiplic";
            this.listBoxMultiplic.Size = new System.Drawing.Size(120, 232);
            this.listBoxMultiplic.TabIndex = 6;
            // 
            // listBoxSomar
            // 
            this.listBoxSomar.FormattingEnabled = true;
            this.listBoxSomar.ItemHeight = 19;
            this.listBoxSomar.Location = new System.Drawing.Point(593, 264);
            this.listBoxSomar.Name = "listBoxSomar";
            this.listBoxSomar.Size = new System.Drawing.Size(120, 232);
            this.listBoxSomar.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpar.Location = new System.Drawing.Point(532, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 38);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(670, 34);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 38);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.ForeColor = System.Drawing.Color.Red;
            this.lblRes.Location = new System.Drawing.Point(52, 228);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 19);
            this.lblRes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listBoxSomar);
            this.Controls.Add(this.listBoxMultiplic);
            this.Controls.Add(this.btnTabSomando);
            this.Controls.Add(this.btnTabMultiplic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumTab);
            this.Controls.Add(this.lblNumTab);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "ESCOLHA O TIPO DA TABUADA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumTab;
        private System.Windows.Forms.TextBox textBoxNumTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTabMultiplic;
        private System.Windows.Forms.Button btnTabSomando;
        private System.Windows.Forms.ListBox listBoxMultiplic;
        private System.Windows.Forms.ListBox listBoxSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblRes;
    }
}

