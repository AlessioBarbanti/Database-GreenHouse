
namespace Applicazione_GreenHouseDB
{
    partial class FormGestoreStruttura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestoreStruttura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RevisioniInScadenza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(779, 491);
            this.dataGridView1.TabIndex = 15;
            // 
            // RevisioniInScadenza
            // 
            this.RevisioniInScadenza.AutoEllipsis = true;
            this.RevisioniInScadenza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisioniInScadenza.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RevisioniInScadenza.Image = ((System.Drawing.Image)(resources.GetObject("RevisioniInScadenza.Image")));
            this.RevisioniInScadenza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RevisioniInScadenza.Location = new System.Drawing.Point(29, 163);
            this.RevisioniInScadenza.Margin = new System.Windows.Forms.Padding(20);
            this.RevisioniInScadenza.Name = "RevisioniInScadenza";
            this.RevisioniInScadenza.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RevisioniInScadenza.Size = new System.Drawing.Size(165, 174);
            this.RevisioniInScadenza.TabIndex = 13;
            this.RevisioniInScadenza.TabStop = false;
            this.RevisioniInScadenza.Text = "VISUALIZZA REVISIONI IN SCADENZA";
            this.RevisioniInScadenza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RevisioniInScadenza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RevisioniInScadenza.UseVisualStyleBackColor = true;
            this.RevisioniInScadenza.Click += new System.EventHandler(this.RevisioniInScadenza_Click);
            // 
            // FormGestoreStruttura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RevisioniInScadenza);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestoreStruttura";
            this.Text = "Gestore Struttura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RevisioniInScadenza;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}