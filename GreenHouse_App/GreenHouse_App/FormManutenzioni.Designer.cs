
namespace GreenHouse_App
{
    partial class FormManutenzioni
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
            this.Annulla = new System.Windows.Forms.Button();
            this.Inserisci = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDSerra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDStruttura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDManutentore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(267, 245);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(75, 23);
            this.Annulla.TabIndex = 33;
            this.Annulla.TabStop = false;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = true;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // Inserisci
            // 
            this.Inserisci.Location = new System.Drawing.Point(142, 245);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(75, 23);
            this.Inserisci.TabIndex = 32;
            this.Inserisci.Text = "Inserisci";
            this.Inserisci.UseVisualStyleBackColor = true;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 99);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Descrizione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data e Ora:";
            // 
            // textBoxIDSerra
            // 
            this.textBoxIDSerra.Location = new System.Drawing.Point(142, 67);
            this.textBoxIDSerra.Name = "textBoxIDSerra";
            this.textBoxIDSerra.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDSerra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Serra:";
            // 
            // textBoxIDStruttura
            // 
            this.textBoxIDStruttura.Enabled = false;
            this.textBoxIDStruttura.Location = new System.Drawing.Point(142, 41);
            this.textBoxIDStruttura.Name = "textBoxIDStruttura";
            this.textBoxIDStruttura.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDStruttura.TabIndex = 2;
            this.textBoxIDStruttura.TextChanged += new System.EventHandler(this.textBoxIDStruttura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Struttura:";
            // 
            // textBoxIDManutentore
            // 
            this.textBoxIDManutentore.Location = new System.Drawing.Point(142, 15);
            this.textBoxIDManutentore.Name = "textBoxIDManutentore";
            this.textBoxIDManutentore.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDManutentore.TabIndex = 1;
            this.textBoxIDManutentore.TextChanged += new System.EventHandler(this.textBoxIDManutentore_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Manutentore:";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(142, 93);
            this.dateTime.Mask = "00/00/0000 00:00";
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(100, 20);
            this.dateTime.TabIndex = 4;
            this.dateTime.ValidatingType = typeof(System.DateTime);
            // 
            // FormManutenzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 294);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.textBoxIDManutentore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Inserisci);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDSerra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDStruttura);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManutenzioni";
            this.Text = "Inserisci Manutenzione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.Button Inserisci;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIDSerra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDStruttura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDManutentore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox dateTime;
    }
}