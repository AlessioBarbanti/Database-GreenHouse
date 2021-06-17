
namespace Applicazione_GreenHouseDB
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guida = new System.Windows.Forms.Button();
            this.supervisore = new System.Windows.Forms.Button();
            this.manutentore = new System.Windows.Forms.Button();
            this.ricercatoreCapo = new System.Windows.Forms.Button();
            this.gestoreStruttura = new System.Windows.Forms.Button();
            this.Ricercatore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guida
            // 
            this.guida.AutoEllipsis = true;
            this.guida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guida.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guida.Image = global::Applicazione_GreenHouseDB.Properties.Resources.Guida;
            this.guida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guida.Location = new System.Drawing.Point(29, 339);
            this.guida.Margin = new System.Windows.Forms.Padding(20);
            this.guida.Name = "guida";
            this.guida.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guida.Size = new System.Drawing.Size(179, 270);
            this.guida.TabIndex = 8;
            this.guida.TabStop = false;
            this.guida.Text = "GUIDA";
            this.guida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guida.UseVisualStyleBackColor = true;
            this.guida.Click += new System.EventHandler(this.guida_Click);
            // 
            // supervisore
            // 
            this.supervisore.AutoEllipsis = true;
            this.supervisore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.supervisore.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.supervisore.Image = global::Applicazione_GreenHouseDB.Properties.Resources.Manovale;
            this.supervisore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.supervisore.Location = new System.Drawing.Point(248, 339);
            this.supervisore.Margin = new System.Windows.Forms.Padding(20);
            this.supervisore.Name = "supervisore";
            this.supervisore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.supervisore.Size = new System.Drawing.Size(179, 270);
            this.supervisore.TabIndex = 13;
            this.supervisore.TabStop = false;
            this.supervisore.Text = "SUPERVISORE";
            this.supervisore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supervisore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supervisore.UseCompatibleTextRendering = true;
            this.supervisore.UseVisualStyleBackColor = true;
            this.supervisore.Click += new System.EventHandler(this.supervisore_Click);
            // 
            // manutentore
            // 
            this.manutentore.AutoEllipsis = true;
            this.manutentore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manutentore.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.manutentore.Image = global::Applicazione_GreenHouseDB.Properties.Resources.Manutentore;
            this.manutentore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manutentore.Location = new System.Drawing.Point(467, 31);
            this.manutentore.Margin = new System.Windows.Forms.Padding(20);
            this.manutentore.Name = "manutentore";
            this.manutentore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.manutentore.Size = new System.Drawing.Size(179, 270);
            this.manutentore.TabIndex = 12;
            this.manutentore.TabStop = false;
            this.manutentore.Text = "MANUTENTORE / MANOVALE";
            this.manutentore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.manutentore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.manutentore.UseVisualStyleBackColor = true;
            this.manutentore.Click += new System.EventHandler(this.manutentore_Click);
            // 
            // ricercatoreCapo
            // 
            this.ricercatoreCapo.AutoEllipsis = true;
            this.ricercatoreCapo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ricercatoreCapo.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ricercatoreCapo.Image = global::Applicazione_GreenHouseDB.Properties.Resources.RicercatoreCapo;
            this.ricercatoreCapo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ricercatoreCapo.Location = new System.Drawing.Point(248, 29);
            this.ricercatoreCapo.Margin = new System.Windows.Forms.Padding(20);
            this.ricercatoreCapo.Name = "ricercatoreCapo";
            this.ricercatoreCapo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ricercatoreCapo.Size = new System.Drawing.Size(179, 270);
            this.ricercatoreCapo.TabIndex = 11;
            this.ricercatoreCapo.TabStop = false;
            this.ricercatoreCapo.Text = "GESTORE ESPERIMENTI";
            this.ricercatoreCapo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ricercatoreCapo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ricercatoreCapo.UseVisualStyleBackColor = true;
            this.ricercatoreCapo.Click += new System.EventHandler(this.ricercatoreCapo_Click);
            // 
            // gestoreStruttura
            // 
            this.gestoreStruttura.AutoEllipsis = true;
            this.gestoreStruttura.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gestoreStruttura.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gestoreStruttura.Image = global::Applicazione_GreenHouseDB.Properties.Resources.GestoreStruttura;
            this.gestoreStruttura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gestoreStruttura.Location = new System.Drawing.Point(467, 341);
            this.gestoreStruttura.Margin = new System.Windows.Forms.Padding(20);
            this.gestoreStruttura.Name = "gestoreStruttura";
            this.gestoreStruttura.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gestoreStruttura.Size = new System.Drawing.Size(179, 270);
            this.gestoreStruttura.TabIndex = 10;
            this.gestoreStruttura.TabStop = false;
            this.gestoreStruttura.Text = "GESTORE STRUTTURA";
            this.gestoreStruttura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gestoreStruttura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gestoreStruttura.UseVisualStyleBackColor = true;
            this.gestoreStruttura.Click += new System.EventHandler(this.gestoreStruttura_Click);
            // 
            // Ricercatore
            // 
            this.Ricercatore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ricercatore.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ricercatore.Image = global::Applicazione_GreenHouseDB.Properties.Resources.Ricercatore;
            this.Ricercatore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ricercatore.Location = new System.Drawing.Point(29, 29);
            this.Ricercatore.Margin = new System.Windows.Forms.Padding(20);
            this.Ricercatore.Name = "Ricercatore";
            this.Ricercatore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Ricercatore.Size = new System.Drawing.Size(179, 270);
            this.Ricercatore.TabIndex = 0;
            this.Ricercatore.TabStop = false;
            this.Ricercatore.Text = "RICERCATORE";
            this.Ricercatore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ricercatore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Ricercatore.UseVisualStyleBackColor = true;
            this.Ricercatore.Click += new System.EventHandler(this.Ricercatore_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.guida;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 640);
            this.Controls.Add(this.supervisore);
            this.Controls.Add(this.manutentore);
            this.Controls.Add(this.ricercatoreCapo);
            this.Controls.Add(this.gestoreStruttura);
            this.Controls.Add(this.guida);
            this.Controls.Add(this.Ricercatore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LOG-IN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ricercatore;
        private System.Windows.Forms.Button guida;
        private System.Windows.Forms.Button gestoreStruttura;
        private System.Windows.Forms.Button ricercatoreCapo;
        private System.Windows.Forms.Button manutentore;
        private System.Windows.Forms.Button supervisore;
    }
}

