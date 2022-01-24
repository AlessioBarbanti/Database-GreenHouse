
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
            this.InserisciViaggio = new System.Windows.Forms.Button();
            this.InserisciVisita = new System.Windows.Forms.Button();
            this.VisualizzaVisite = new System.Windows.Forms.Button();
            this.textBoxIDStruttura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(217, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(681, 646);
            this.dataGridView1.TabIndex = 16;
            // 
            // InserisciViaggio
            // 
            this.InserisciViaggio.AutoEllipsis = true;
            this.InserisciViaggio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InserisciViaggio.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.InserisciViaggio.Image = global::GreenHouse_App.Properties.Resources.bus;
            this.InserisciViaggio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InserisciViaggio.Location = new System.Drawing.Point(29, 457);
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
            // InserisciVisita
            // 
            this.InserisciVisita.AutoEllipsis = true;
            this.InserisciVisita.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InserisciVisita.Font = new System.Drawing.Font("Comic Sans MS", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.InserisciVisita.Image = global::GreenHouse_App.Properties.Resources.create_tour_guide;
            this.InserisciVisita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InserisciVisita.Location = new System.Drawing.Point(29, 268);
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
            // VisualizzaVisite
            // 
            this.VisualizzaVisite.AutoEllipsis = true;
            this.VisualizzaVisite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VisualizzaVisite.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.VisualizzaVisite.Image = ((System.Drawing.Image)(resources.GetObject("VisualizzaVisite.Image")));
            this.VisualizzaVisite.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VisualizzaVisite.Location = new System.Drawing.Point(29, 79);
            this.VisualizzaVisite.Margin = new System.Windows.Forms.Padding(20);
            this.VisualizzaVisite.Name = "VisualizzaVisite";
            this.VisualizzaVisite.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.VisualizzaVisite.Size = new System.Drawing.Size(165, 174);
            this.VisualizzaVisite.TabIndex = 14;
            this.VisualizzaVisite.TabStop = false;
            this.VisualizzaVisite.Text = "VISUALIZZA PROSSIME VISITE";
            this.VisualizzaVisite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VisualizzaVisite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VisualizzaVisite.UseVisualStyleBackColor = true;
            this.VisualizzaVisite.Click += new System.EventHandler(this.VisualizzaVisite_Click);
            // 
            // textBoxIDStruttura
            // 
            this.textBoxIDStruttura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDStruttura.Location = new System.Drawing.Point(124, 33);
            this.textBoxIDStruttura.Name = "textBoxIDStruttura";
            this.textBoxIDStruttura.Size = new System.Drawing.Size(62, 26);
            this.textBoxIDStruttura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Struttura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormGuida
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(901, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDStruttura);
            this.Controls.Add(this.InserisciViaggio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InserisciVisita);
            this.Controls.Add(this.VisualizzaVisite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisualizzaVisite;
        private System.Windows.Forms.Button InserisciVisita;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InserisciViaggio;
        private System.Windows.Forms.TextBox textBoxIDStruttura;
        private System.Windows.Forms.Label label1;
    }
}