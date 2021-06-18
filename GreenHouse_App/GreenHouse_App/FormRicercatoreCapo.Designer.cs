
namespace GreenHouse_App
{
    partial class FormGestoreEsperimenti
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
            this.RevisioniInScadenza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RevisioniInScadenza
            // 
            this.RevisioniInScadenza.AutoEllipsis = true;
            this.RevisioniInScadenza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisioniInScadenza.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RevisioniInScadenza.Image = global::GreenHouse_App.Properties.Resources.microscope;
            this.RevisioniInScadenza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RevisioniInScadenza.Location = new System.Drawing.Point(318, 130);
            this.RevisioniInScadenza.Margin = new System.Windows.Forms.Padding(20);
            this.RevisioniInScadenza.Name = "RevisioniInScadenza";
            this.RevisioniInScadenza.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RevisioniInScadenza.Size = new System.Drawing.Size(163, 168);
            this.RevisioniInScadenza.TabIndex = 16;
            this.RevisioniInScadenza.TabStop = false;
            this.RevisioniInScadenza.Text = "AGGIUNGI NUOVO ESPERIMENTO";
            this.RevisioniInScadenza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RevisioniInScadenza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RevisioniInScadenza.UseVisualStyleBackColor = true;
            this.RevisioniInScadenza.Click += new System.EventHandler(this.RevisioniInScadenza_Click);
            // 
            // FormGestoreEsperimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RevisioniInScadenza);
            this.Name = "FormGestoreEsperimenti";
            this.Text = "Form Gestore Esperimenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RevisioniInScadenza;
    }
}