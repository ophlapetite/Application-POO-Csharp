namespace ProjetFBRWF
{
    partial class MajDlg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Grille = new System.Windows.Forms.DataGridView();
            this.Valider = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RBSkin = new System.Windows.Forms.RadioButton();
            this.RBPioche = new System.Windows.Forms.RadioButton();
            this.RBPlanneur = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Grille, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Grille
            // 
            this.Grille.AllowUserToAddRows = false;
            this.Grille.AllowUserToDeleteRows = false;
            this.Grille.AllowUserToResizeColumns = false;
            this.Grille.AllowUserToResizeRows = false;
            this.Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grille.Location = new System.Drawing.Point(4, 39);
            this.Grille.Margin = new System.Windows.Forms.Padding(4);
            this.Grille.Name = "Grille";
            this.Grille.RowHeadersWidth = 51;
            this.Grille.Size = new System.Drawing.Size(1131, 196);
            this.Grille.TabIndex = 0;
            this.Grille.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grille_CellEndEdit);
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(4, 243);
            this.Valider.Margin = new System.Windows.Forms.Padding(4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(1131, 74);
            this.Valider.TabIndex = 1;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel2.Controls.Add(this.RBSkin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RBPioche, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RBPlanneur, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1133, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // RBSkin
            // 
            this.RBSkin.AutoSize = true;
            this.RBSkin.BackColor = System.Drawing.Color.RoyalBlue;
            this.RBSkin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBSkin.Checked = true;
            this.RBSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBSkin.Location = new System.Drawing.Point(3, 3);
            this.RBSkin.Name = "RBSkin";
            this.RBSkin.Size = new System.Drawing.Size(381, 23);
            this.RBSkin.TabIndex = 0;
            this.RBSkin.TabStop = true;
            this.RBSkin.Text = "Skin";
            this.RBSkin.UseVisualStyleBackColor = false;
            this.RBSkin.CheckedChanged += new System.EventHandler(this.RBSkin_CheckedChanged);
            // 
            // RBPioche
            // 
            this.RBPioche.AutoSize = true;
            this.RBPioche.BackColor = System.Drawing.Color.RoyalBlue;
            this.RBPioche.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBPioche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPioche.Location = new System.Drawing.Point(390, 3);
            this.RBPioche.Name = "RBPioche";
            this.RBPioche.Size = new System.Drawing.Size(381, 23);
            this.RBPioche.TabIndex = 1;
            this.RBPioche.TabStop = true;
            this.RBPioche.Text = "Pioche";
            this.RBPioche.UseVisualStyleBackColor = false;
            this.RBPioche.CheckedChanged += new System.EventHandler(this.RBPioche_CheckedChanged);
            // 
            // RBPlanneur
            // 
            this.RBPlanneur.AutoSize = true;
            this.RBPlanneur.BackColor = System.Drawing.Color.RoyalBlue;
            this.RBPlanneur.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBPlanneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPlanneur.Location = new System.Drawing.Point(777, 3);
            this.RBPlanneur.Name = "RBPlanneur";
            this.RBPlanneur.Size = new System.Drawing.Size(353, 23);
            this.RBPlanneur.TabIndex = 2;
            this.RBPlanneur.TabStop = true;
            this.RBPlanneur.Text = "Planeur";
            this.RBPlanneur.UseVisualStyleBackColor = false;
            this.RBPlanneur.CheckedChanged += new System.EventHandler(this.RBPlanneur_CheckedChanged);
            // 
            // MajDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MajDlg";
            this.Text = "MajDlg";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Grille;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton RBSkin;
        private System.Windows.Forms.RadioButton RBPioche;
        private System.Windows.Forms.RadioButton RBPlanneur;
    }
}