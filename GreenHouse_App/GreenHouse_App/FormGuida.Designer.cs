
namespace GreenHouse_App
{
    partial class FormGuida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuida));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InserisciVisita = new System.Windows.Forms.Button();
            this.RevisioniInScadenza = new System.Windows.Forms.Button();
            this.InserisciViaggio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 552);
            this.dataGridView1.TabIndex = 16;
            // 
            // InserisciVisita
            // 
            this.InserisciVisita.AutoEllipsis = true;
            this.InserisciVisita.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InserisciVisita.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.InserisciVisita.Image = global::GreenHouse_App.Properties.Resources.create_tour_guide;
            this.InserisciVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InserisciVisita.Location = new System.Drawing.Point(29, 191);
            this.InserisciVisita.Margin = new System.Windows.Forms.Padding(20);
            this.InserisciVisita.Name = "InserisciVisita";
            this.InserisciVisita.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.InserisciVisita.Size = new System.Drawing.Size(165, 174);
            this.InserisciVisita.TabIndex = 15;
            this.InserisciVisita.TabStop = false;
            this.InserisciVisita.Text = "INSERISCI VISITA";
            this.InserisciVisita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InserisciVisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InserisciVisita.UseVisualStyleBackColor = true;
            this.InserisciVisita.Click += new System.EventHandler(this.button1_Click);
            // 
            // RevisioniInScadenza
            // 
            this.RevisioniInScadenza.AutoEllipsis = true;
            this.RevisioniInScadenza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisioniInScadenza.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RevisioniInScadenza.Image = ((System.Drawing.Image)(resources.GetObject("RevisioniInScadenza.Image")));
            this.RevisioniInScadenza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RevisioniInScadenza.Location = new System.Drawing.Point(29, 3);
            this.RevisioniInScadenza.Margin = new System.Windows.Forms.Padding(20);
            this.RevisioniInScadenza.Name = "RevisioniInScadenza";
            this.RevisioniInScadenza.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RevisioniInScadenza.Size = new System.Drawing.Size(165, 174);
            this.RevisioniInScadenza.TabIndex = 14;
            this.RevisioniInScadenza.TabStop = false;
            this.RevisioniInScadenza.Text = "VISUALIZZA PROSSIME VISITE";
            this.RevisioniInScadenza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RevisioniInScadenza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RevisioniInScadenza.UseVisualStyleBackColor = true;
            this.RevisioniInScadenza.Click += new System.EventHandler(this.RevisioniInScadenza_Click);
            // 
            // InserisciViaggio
            // 
            this.InserisciViaggio.AutoEllipsis = true;
            this.InserisciViaggio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InserisciViaggio.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.InserisciViaggio.Image = global::GreenHouse_App.Properties.Resources.create_tour_guide;
            this.InserisciViaggio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InserisciViaggio.Location = new System.Drawing.Point(29, 381);
            this.InserisciViaggio.Margin = new System.Windows.Forms.Padding(20);
            this.InserisciViaggio.Name = "InserisciViaggio";
            this.InserisciViaggio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.InserisciViaggio.Size = new System.Drawing.Size(165, 174);
            this.InserisciViaggio.TabIndex = 17;
            this.InserisciViaggio.TabStop = false;
            this.InserisciViaggio.Text = "INSERISCI VIAGGIO D\'ISTRUZIONE";
            this.InserisciViaggio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InserisciViaggio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InserisciViaggio.UseVisualStyleBackColor = true;
            this.InserisciViaggio.Click += new System.EventHandler(this.InserisciViaggio_Click);
            // 
            // FormGuida
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.InserisciViaggio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InserisciVisita);
            this.Controls.Add(this.RevisioniInScadenza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RevisioniInScadenza;
        private System.Windows.Forms.Button InserisciVisita;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InserisciViaggio;
    }
}