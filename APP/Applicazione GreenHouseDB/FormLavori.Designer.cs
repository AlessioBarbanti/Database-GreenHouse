
namespace Applicazione_GreenHouseDB
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDGuida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rICERCATORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaDataSet1 = new Applicazione_GreenHouseDB.ProvaDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Annulla = new System.Windows.Forms.Button();
            this.Inserisci = new System.Windows.Forms.Button();
            this.rICERCATORITableAdapter = new Applicazione_GreenHouseDB.ProvaDataSet1TableAdapters.RICERCATORITableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rICERCATORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(226, 85);
            this.maskedTextBox1.Mask = "00/00/0000 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data e Ora:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Cluster Interessato:";
            // 
            // IDGuida
            // 
            this.IDGuida.Location = new System.Drawing.Point(226, 34);
            this.IDGuida.Name = "IDGuida";
            this.IDGuida.Size = new System.Drawing.Size(200, 20);
            this.IDGuida.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Manovale:";
            // 
            // rICERCATORIBindingSource
            // 
            this.rICERCATORIBindingSource.DataMember = "RICERCATORI";
            this.rICERCATORIBindingSource.DataSource = this.provaDataSet1;
            // 
            // provaDataSet1
            // 
            this.provaDataSet1.DataSetName = "ProvaDataSet1";
            this.provaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LAVORO TERRA",
            "LAVORO PIANTA",
            "TRATTAMENTO"});
            this.comboBox2.Location = new System.Drawing.Point(226, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lavoro:";
            // 
            // Annulla
            // 
            this.Annulla.Location = new System.Drawing.Point(285, 245);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(75, 23);
            this.Annulla.TabIndex = 30;
            this.Annulla.TabStop = false;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = true;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // Inserisci
            // 
            this.Inserisci.Location = new System.Drawing.Point(149, 246);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(75, 23);
            this.Inserisci.TabIndex = 29;
            this.Inserisci.Text = "Inserisci";
            this.Inserisci.UseVisualStyleBackColor = true;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click);
            // 
            // rICERCATORITableAdapter
            // 
            this.rICERCATORITableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.rICERCATORIBindingSource;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(226, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.ValueMember = "Nome";
            // 
            // FormLavori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 306);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Inserisci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDGuida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLavori";
            this.Text = "Inserisci Lavoro";
            this.Load += new System.EventHandler(this.FormLavori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rICERCATORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDGuida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Annulla;
        private System.Windows.Forms.Button Inserisci;
        private ProvaDataSet1 provaDataSet1;
        private System.Windows.Forms.BindingSource rICERCATORIBindingSource;
        private ProvaDataSet1TableAdapters.RICERCATORITableAdapter rICERCATORITableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}