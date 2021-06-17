
namespace GreenHouse_App
{
    partial class FormSupervisore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VisualizzaPermessiButton = new System.Windows.Forms.Button();
            this.PermessiManovale = new System.Windows.Forms.Button();
            this.IDSerraDiRiferimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = "//";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(217, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(688, 524);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VisualizzaPermessiButton
            // 
            this.VisualizzaPermessiButton.AutoEllipsis = true;
            this.VisualizzaPermessiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VisualizzaPermessiButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.VisualizzaPermessiButton.Image = global::GreenHouse_App.Properties.Resources.permission1;
            this.VisualizzaPermessiButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VisualizzaPermessiButton.Location = new System.Drawing.Point(29, 82);
            this.VisualizzaPermessiButton.Margin = new System.Windows.Forms.Padding(20);
            this.VisualizzaPermessiButton.Name = "VisualizzaPermessiButton";
            this.VisualizzaPermessiButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.VisualizzaPermessiButton.Size = new System.Drawing.Size(165, 174);
            this.VisualizzaPermessiButton.TabIndex = 16;
            this.VisualizzaPermessiButton.TabStop = false;
            this.VisualizzaPermessiButton.Text = "VISUALIZZA PERMESSI";
            this.VisualizzaPermessiButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VisualizzaPermessiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VisualizzaPermessiButton.UseVisualStyleBackColor = true;
            this.VisualizzaPermessiButton.Click += new System.EventHandler(this.VisualizzaPermessiButton_Click);
            // 
            // PermessiManovale
            // 
            this.PermessiManovale.AutoEllipsis = true;
            this.PermessiManovale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PermessiManovale.Enabled = false;
            this.PermessiManovale.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PermessiManovale.Image = global::GreenHouse_App.Properties.Resources.writing;
            this.PermessiManovale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PermessiManovale.Location = new System.Drawing.Point(29, 345);
            this.PermessiManovale.Margin = new System.Windows.Forms.Padding(20);
            this.PermessiManovale.Name = "PermessiManovale";
            this.PermessiManovale.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PermessiManovale.Size = new System.Drawing.Size(165, 174);
            this.PermessiManovale.TabIndex = 15;
            this.PermessiManovale.TabStop = false;
            this.PermessiManovale.Text = "CREA NUOVO PERMESSO";
            this.PermessiManovale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PermessiManovale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PermessiManovale.UseVisualStyleBackColor = true;
            // 
            // IDSerraDiRiferimento
            // 
            this.IDSerraDiRiferimento.Location = new System.Drawing.Point(74, 39);
            this.IDSerraDiRiferimento.Name = "IDSerraDiRiferimento";
            this.IDSerraDiRiferimento.Size = new System.Drawing.Size(75, 20);
            this.IDSerraDiRiferimento.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Serra di riferimento: ";
            // 
            // FormSupervisore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDSerraDiRiferimento);
            this.Controls.Add(this.VisualizzaPermessiButton);
            this.Controls.Add(this.PermessiManovale);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupervisore";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PermessiManovale;
        private System.Windows.Forms.Button VisualizzaPermessiButton;
        private System.Windows.Forms.TextBox IDSerraDiRiferimento;
        private System.Windows.Forms.Label label1;
    }
}