
namespace GreenHouse_App
{
    partial class FormRicercatore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RevisioniInScadenza = new System.Windows.Forms.Button();
            this.textBoxIDRicercatore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 462);
            this.dataGridView1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Image = global::GreenHouse_App.Properties.Resources.notes;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(29, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(20);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.button1.Size = new System.Drawing.Size(163, 168);
            this.button1.TabIndex = 16;
            this.button1.TabStop = false;
            this.button1.Text = "INSERISCI ANNOTAZIONE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RevisioniInScadenza
            // 
            this.RevisioniInScadenza.AutoEllipsis = true;
            this.RevisioniInScadenza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisioniInScadenza.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RevisioniInScadenza.Image = global::GreenHouse_App.Properties.Resources.skull;
            this.RevisioniInScadenza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RevisioniInScadenza.Location = new System.Drawing.Point(29, 98);
            this.RevisioniInScadenza.Margin = new System.Windows.Forms.Padding(20);
            this.RevisioniInScadenza.Name = "RevisioniInScadenza";
            this.RevisioniInScadenza.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RevisioniInScadenza.Size = new System.Drawing.Size(163, 168);
            this.RevisioniInScadenza.TabIndex = 15;
            this.RevisioniInScadenza.TabStop = false;
            this.RevisioniInScadenza.Text = "VISUALIZZA ESPERIMENTI FALLIMENTARI";
            this.RevisioniInScadenza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RevisioniInScadenza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RevisioniInScadenza.UseVisualStyleBackColor = true;
            this.RevisioniInScadenza.Click += new System.EventHandler(this.RevisioniInScadenza_Click);
            // 
            // textBoxIDRicercatore
            // 
            this.textBoxIDRicercatore.Location = new System.Drawing.Point(74, 55);
            this.textBoxIDRicercatore.Name = "textBoxIDRicercatore";
            this.textBoxIDRicercatore.Size = new System.Drawing.Size(67, 20);
            this.textBoxIDRicercatore.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Ricercatore:";
            // 
            // FormRicercatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 486);
            this.Controls.Add(this.textBoxIDRicercatore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RevisioniInScadenza);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRicercatore";
            this.Text = "Form Ricercatore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RevisioniInScadenza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxIDRicercatore;
        private System.Windows.Forms.Label label1;
    }
}