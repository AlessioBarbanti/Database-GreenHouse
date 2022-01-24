
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStrumentoComplesso = new System.Windows.Forms.DataGridView();
            this.VisualizzaPermessiButton = new System.Windows.Forms.Button();
            this.PermessiManovale = new System.Windows.Forms.Button();
            this.textBoxIDStrutturaDiRiferimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewMacchinario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrumentoComplesso)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMacchinario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStrumentoComplesso
            // 
            this.dataGridViewStrumentoComplesso.AllowUserToAddRows = false;
            this.dataGridViewStrumentoComplesso.AllowUserToDeleteRows = false;
            this.dataGridViewStrumentoComplesso.AllowUserToResizeRows = false;
            this.dataGridViewStrumentoComplesso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStrumentoComplesso.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStrumentoComplesso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStrumentoComplesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "//";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStrumentoComplesso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStrumentoComplesso.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewStrumentoComplesso.Name = "dataGridViewStrumentoComplesso";
            this.dataGridViewStrumentoComplesso.ReadOnly = true;
            this.dataGridViewStrumentoComplesso.RowHeadersVisible = false;
            this.dataGridViewStrumentoComplesso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStrumentoComplesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStrumentoComplesso.ShowCellErrors = false;
            this.dataGridViewStrumentoComplesso.ShowCellToolTips = false;
            this.dataGridViewStrumentoComplesso.ShowEditingIcon = false;
            this.dataGridViewStrumentoComplesso.ShowRowErrors = false;
            this.dataGridViewStrumentoComplesso.Size = new System.Drawing.Size(631, 491);
            this.dataGridViewStrumentoComplesso.TabIndex = 1;
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
            // textBoxIDStrutturaDiRiferimento
            // 
            this.textBoxIDStrutturaDiRiferimento.Location = new System.Drawing.Point(74, 39);
            this.textBoxIDStrutturaDiRiferimento.Name = "textBoxIDStrutturaDiRiferimento";
            this.textBoxIDStrutturaDiRiferimento.Size = new System.Drawing.Size(75, 20);
            this.textBoxIDStrutturaDiRiferimento.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Struttura di riferimento: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(274, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 513);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewStrumentoComplesso);
            this.tabPage2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Strumento Complesso";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewMacchinario);
            this.tabPage3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(623, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Macchinario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMacchinario
            // 
            this.dataGridViewMacchinario.AllowUserToAddRows = false;
            this.dataGridViewMacchinario.AllowUserToDeleteRows = false;
            this.dataGridViewMacchinario.AllowUserToResizeRows = false;
            this.dataGridViewMacchinario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMacchinario.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMacchinario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMacchinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "//";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMacchinario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMacchinario.Location = new System.Drawing.Point(-4, -2);
            this.dataGridViewMacchinario.Name = "dataGridViewMacchinario";
            this.dataGridViewMacchinario.ReadOnly = true;
            this.dataGridViewMacchinario.RowHeadersVisible = false;
            this.dataGridViewMacchinario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMacchinario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMacchinario.ShowCellErrors = false;
            this.dataGridViewMacchinario.ShowCellToolTips = false;
            this.dataGridViewMacchinario.ShowEditingIcon = false;
            this.dataGridViewMacchinario.ShowRowErrors = false;
            this.dataGridViewMacchinario.Size = new System.Drawing.Size(631, 491);
            this.dataGridViewMacchinario.TabIndex = 2;
            // 
            // FormSupervisore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDStrutturaDiRiferimento);
            this.Controls.Add(this.VisualizzaPermessiButton);
            this.Controls.Add(this.PermessiManovale);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupervisore";
            this.Text = "Supervisore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrumentoComplesso)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMacchinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStrumentoComplesso;
        private System.Windows.Forms.Button PermessiManovale;
        private System.Windows.Forms.Button VisualizzaPermessiButton;
        private System.Windows.Forms.TextBox textBoxIDStrutturaDiRiferimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewMacchinario;
    }
}