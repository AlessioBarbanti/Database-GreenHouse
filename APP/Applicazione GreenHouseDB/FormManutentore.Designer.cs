
namespace Applicazione_GreenHouseDB
{
    partial class FormManutentore
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
            this.ButtonManutenzione = new System.Windows.Forms.Button();
            this.RevisioniInScadenza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonManutenzione
            // 
            this.ButtonManutenzione.AutoEllipsis = true;
            this.ButtonManutenzione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonManutenzione.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonManutenzione.Image = global::Applicazione_GreenHouseDB.Properties.Resources.settings;
            this.ButtonManutenzione.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonManutenzione.Location = new System.Drawing.Point(427, 116);
            this.ButtonManutenzione.Margin = new System.Windows.Forms.Padding(20);
            this.ButtonManutenzione.Name = "ButtonManutenzione";
            this.ButtonManutenzione.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ButtonManutenzione.Size = new System.Drawing.Size(159, 159);
            this.ButtonManutenzione.TabIndex = 17;
            this.ButtonManutenzione.TabStop = false;
            this.ButtonManutenzione.Text = "INSERISCI MANUTENZIONE";
            this.ButtonManutenzione.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonManutenzione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonManutenzione.UseVisualStyleBackColor = true;
            this.ButtonManutenzione.Click += new System.EventHandler(this.ButtonManutenzione_Click);
            // 
            // RevisioniInScadenza
            // 
            this.RevisioniInScadenza.AutoEllipsis = true;
            this.RevisioniInScadenza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisioniInScadenza.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RevisioniInScadenza.Image = global::Applicazione_GreenHouseDB.Properties.Resources.hoe;
            this.RevisioniInScadenza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RevisioniInScadenza.Location = new System.Drawing.Point(196, 116);
            this.RevisioniInScadenza.Margin = new System.Windows.Forms.Padding(20);
            this.RevisioniInScadenza.Name = "RevisioniInScadenza";
            this.RevisioniInScadenza.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RevisioniInScadenza.Size = new System.Drawing.Size(159, 159);
            this.RevisioniInScadenza.TabIndex = 16;
            this.RevisioniInScadenza.TabStop = false;
            this.RevisioniInScadenza.Text = "INSERISCI LAVORO";
            this.RevisioniInScadenza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RevisioniInScadenza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RevisioniInScadenza.UseVisualStyleBackColor = true;
            this.RevisioniInScadenza.Click += new System.EventHandler(this.RevisioniInScadenza_Click);
            // 
            // FormManutentore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonManutenzione);
            this.Controls.Add(this.RevisioniInScadenza);
            this.MaximizeBox = false;
            this.Name = "FormManutentore";
            this.Text = "Manutentore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RevisioniInScadenza;
        private System.Windows.Forms.Button ButtonManutenzione;
    }
}