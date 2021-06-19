
namespace GreenHouse_App
{
    partial class FormGuida2
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
            this.textBoxIDViaggio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Annulla = new System.Windows.Forms.Button();
            this.Inserisci = new System.Windows.Forms.Button();
            this.textBoxIDStruttura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDSerra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxIDViaggio
            // 
            this.textBoxIDViaggio.Location = new System.Drawing.Point(134, 49);
            this.textBoxIDViaggio.Name = "textBoxIDViaggio";
            this.textBoxIDViaggio.Size = new System.Drawing.Size(119, 20);
            this.textBoxIDViaggio.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Viaggio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Data:";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(134, 75);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(200, 20);
            this.Data.TabIndex = 32;
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(198, 190);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(75, 23);
            this.Annulla.TabIndex = 31;
            this.Annulla.TabStop = false;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = true;
            // 
            // Inserisci
            // 
            this.Inserisci.Location = new System.Drawing.Point(73, 190);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(75, 23);
            this.Inserisci.TabIndex = 30;
            this.Inserisci.Text = "Inserisci";
            this.Inserisci.UseVisualStyleBackColor = true;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click_1);
            // 
            // textBoxIDStruttura
            // 
            this.textBoxIDStruttura.Location = new System.Drawing.Point(134, 101);
            this.textBoxIDStruttura.Name = "textBoxIDStruttura";
            this.textBoxIDStruttura.Size = new System.Drawing.Size(119, 20);
            this.textBoxIDStruttura.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID Struttura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "ID Serra:";
            // 
            // textBoxIDSerra
            // 
            this.textBoxIDSerra.Location = new System.Drawing.Point(134, 127);
            this.textBoxIDSerra.Name = "textBoxIDSerra";
            this.textBoxIDSerra.Size = new System.Drawing.Size(119, 20);
            this.textBoxIDSerra.TabIndex = 46;
            // 
            // FormGuida2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(354, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIDSerra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIDStruttura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Inserisci);
            this.Controls.Add(this.textBoxIDViaggio);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuida2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Inserisci Visita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIDViaggio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.Button Inserisci;
        private System.Windows.Forms.TextBox textBoxIDStruttura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDSerra;
    }
}