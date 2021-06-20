
namespace GreenHouse_App
{
    partial class FormGestoreEsperimenti2
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
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInizio = new System.Windows.Forms.DateTimePicker();
            this.textBoxRicercatoreCapo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDAutorizzante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFine = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDCollaboratori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(302, 338);
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
            this.Inserisci.Location = new System.Drawing.Point(177, 338);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(75, 23);
            this.Inserisci.TabIndex = 32;
            this.Inserisci.Text = "Inserisci";
            this.Inserisci.UseVisualStyleBackColor = true;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click);
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(177, 168);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(200, 152);
            this.textBoxDescrizione.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Descrizione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Data Inizio:";
            // 
            // dateTimePickerInizio
            // 
            this.dateTimePickerInizio.Location = new System.Drawing.Point(177, 116);
            this.dateTimePickerInizio.Name = "dateTimePickerInizio";
            this.dateTimePickerInizio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInizio.TabIndex = 26;
            // 
            // textBoxRicercatoreCapo
            // 
            this.textBoxRicercatoreCapo.Location = new System.Drawing.Point(177, 53);
            this.textBoxRicercatoreCapo.Name = "textBoxRicercatoreCapo";
            this.textBoxRicercatoreCapo.Size = new System.Drawing.Size(200, 20);
            this.textBoxRicercatoreCapo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Ricercatore Capo:";
            // 
            // textBoxIDAutorizzante
            // 
            this.textBoxIDAutorizzante.Location = new System.Drawing.Point(177, 29);
            this.textBoxIDAutorizzante.Name = "textBoxIDAutorizzante";
            this.textBoxIDAutorizzante.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDAutorizzante.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Gestore:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data Fine Prevista:";
            // 
            // dateTimePickerFine
            // 
            this.dateTimePickerFine.Location = new System.Drawing.Point(177, 142);
            this.dateTimePickerFine.Name = "dateTimePickerFine";
            this.dateTimePickerFine.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFine.TabIndex = 34;
            // 
            // textBoxIDCollaboratori
            // 
            this.textBoxIDCollaboratori.Location = new System.Drawing.Point(177, 79);
            this.textBoxIDCollaboratori.Name = "textBoxIDCollaboratori";
            this.textBoxIDCollaboratori.Size = new System.Drawing.Size(200, 20);
            this.textBoxIDCollaboratori.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "IDs Collaboratori:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "(Separare gli IDs usando ; )";
            // 
            // FormGestoreEsperimenti2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 391);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDCollaboratori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFine);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Inserisci);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerInizio);
            this.Controls.Add(this.textBoxRicercatoreCapo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDAutorizzante);
            this.Controls.Add(this.label2);
            this.Name = "FormGestoreEsperimenti2";
            this.Text = "Inserisci Esperimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.Button Inserisci;
        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInizio;
        private System.Windows.Forms.TextBox textBoxRicercatoreCapo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDAutorizzante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFine;
        private System.Windows.Forms.TextBox textBoxIDCollaboratori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}