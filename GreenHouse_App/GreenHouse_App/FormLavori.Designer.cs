
namespace GreenHouse_App
{
    partial class FormLavori
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
            this.maskedTextBoxDateTimeInizio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taxtBoxIDClusters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDManovale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Annulla = new System.Windows.Forms.Button();
            this.Inserisci = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxDateTimeFine = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxDateTimeInizio
            // 
            this.maskedTextBoxDateTimeInizio.Location = new System.Drawing.Point(173, 80);
            this.maskedTextBoxDateTimeInizio.Mask = "00/00/0000 00:00";
            this.maskedTextBoxDateTimeInizio.Name = "maskedTextBoxDateTimeInizio";
            this.maskedTextBoxDateTimeInizio.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxDateTimeInizio.TabIndex = 3;
            this.maskedTextBoxDateTimeInizio.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data e Ora Inizio:";
            // 
            // taxtBoxIDClusters
            // 
            this.taxtBoxIDClusters.Location = new System.Drawing.Point(173, 53);
            this.taxtBoxIDClusters.Name = "taxtBoxIDClusters";
            this.taxtBoxIDClusters.Size = new System.Drawing.Size(200, 20);
            this.taxtBoxIDClusters.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Cluster Esperimento:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxIDManovale
            // 
            this.textBoxIDManovale.Location = new System.Drawing.Point(173, 26);
            this.textBoxIDManovale.Name = "textBoxIDManovale";
            this.textBoxIDManovale.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDManovale.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Manovale:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LAVORO TERRA",
            "LAVORO PIANTA",
            "TRATTAMENTO"});
            this.comboBox2.Location = new System.Drawing.Point(173, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lavoro:";
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(298, 203);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(75, 23);
            this.Annulla.TabIndex = 8;
            this.Annulla.TabStop = false;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = true;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // Inserisci
            // 
            this.Inserisci.Location = new System.Drawing.Point(173, 203);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(75, 23);
            this.Inserisci.TabIndex = 7;
            this.Inserisci.Text = "Inserisci";
            this.Inserisci.UseVisualStyleBackColor = true;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(173, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data e Ora Fine:";
            // 
            // maskedTextBoxDateTimeFine
            // 
            this.maskedTextBoxDateTimeFine.Location = new System.Drawing.Point(173, 106);
            this.maskedTextBoxDateTimeFine.Mask = "00/00/0000 00:00";
            this.maskedTextBoxDateTimeFine.Name = "maskedTextBoxDateTimeFine";
            this.maskedTextBoxDateTimeFine.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxDateTimeFine.TabIndex = 4;
            this.maskedTextBoxDateTimeFine.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDateTimeFine.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDateTimeFine_MaskInputRejected);
            // 
            // FormLavori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 264);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxDateTimeFine);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Inserisci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taxtBoxIDClusters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDManovale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxDateTimeInizio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLavori";
            this.Text = "Inserisci Lavoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateTimeInizio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taxtBoxIDClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDManovale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.Button Inserisci;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateTimeFine;
    }
}