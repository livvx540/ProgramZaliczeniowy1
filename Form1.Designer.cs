
namespace ProgramZaliczeniowy1
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBoxPrezenty = new System.Windows.Forms.ListBox();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImie.Location = new System.Drawing.Point(12, 57);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(183, 34);
            this.txtImie.TabIndex = 0;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(207, 57);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(183, 34);
            this.txtNazwa.TabIndex = 1;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCena.Location = new System.Drawing.Point(405, 57);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(183, 34);
            this.txtCena.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Lavender;
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodaj.Location = new System.Drawing.Point(207, 130);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 83);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBoxPrezenty
            // 
            this.listBoxPrezenty.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPrezenty.FormattingEnabled = true;
            this.listBoxPrezenty.ItemHeight = 24;
            this.listBoxPrezenty.Location = new System.Drawing.Point(453, 130);
            this.listBoxPrezenty.Name = "listBoxPrezenty";
            this.listBoxPrezenty.Size = new System.Drawing.Size(326, 292);
            this.listBoxPrezenty.TabIndex = 4;
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIlosc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIlosc.Location = new System.Drawing.Point(7, 294);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(68, 32);
            this.lblIlosc.TabIndex = 5;
            this.lblIlosc.Text = "Ilość";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuma.Location = new System.Drawing.Point(7, 363);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(78, 32);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "Suma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(267, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(464, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.listBoxPrezenty);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.txtImie);
            this.Name = "Form1";
            this.Text = "Lista prezentów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBoxPrezenty;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

