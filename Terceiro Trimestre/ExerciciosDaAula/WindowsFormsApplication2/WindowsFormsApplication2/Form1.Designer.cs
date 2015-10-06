namespace WindowsFormsApplication2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPresente3 = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtPresente1 = new System.Windows.Forms.TextBox();
            this.txtPresente2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "#2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "#1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "#3";
            // 
            // btnSalva
            // 
            this.btnSalva.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.C6A22449CCBD850D0B336C45E60AEC20;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.btnSalva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalva.Location = new System.Drawing.Point(13, 12);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(345, 103);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 293);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtPresente3
            // 
            this.txtPresente3.Location = new System.Drawing.Point(501, 320);
            this.txtPresente3.Name = "txtPresente3";
            this.txtPresente3.Size = new System.Drawing.Size(100, 20);
            this.txtPresente3.TabIndex = 7;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(258, 331);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 8;
            // 
            // txtPresente1
            // 
            this.txtPresente1.Location = new System.Drawing.Point(501, 261);
            this.txtPresente1.Name = "txtPresente1";
            this.txtPresente1.Size = new System.Drawing.Size(100, 20);
            this.txtPresente1.TabIndex = 9;
            // 
            // txtPresente2
            // 
            this.txtPresente2.Location = new System.Drawing.Point(501, 291);
            this.txtPresente2.Name = "txtPresente2";
            this.txtPresente2.Size = new System.Drawing.Size(100, 20);
            this.txtPresente2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._7bymapX;
            this.ClientSize = new System.Drawing.Size(647, 363);
            this.Controls.Add(this.txtPresente2);
            this.Controls.Add(this.txtPresente1);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtPresente3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPresente3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtPresente1;
        private System.Windows.Forms.TextBox txtPresente2;
    }
}

