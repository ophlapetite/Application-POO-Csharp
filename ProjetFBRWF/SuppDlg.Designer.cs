namespace ProjetFBRWF
{
    partial class SuppDlg
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RBSkin = new System.Windows.Forms.RadioButton();
            this.RBPioche = new System.Windows.Forms.RadioButton();
            this.RBPlanneur = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BRech = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.BValider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel2.Controls.Add(this.RBSkin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RBPioche, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RBPlanneur, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 48);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RBSkin
            // 
            this.RBSkin.AutoSize = true;
            this.RBSkin.BackColor = System.Drawing.Color.RoyalBlue;
            this.RBSkin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBSkin.Checked = true;
            this.RBSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBSkin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSkin.Location = new System.Drawing.Point(3, 3);
            this.RBSkin.Name = "RBSkin";
            this.RBSkin.Size = new System.Drawing.Size(273, 42);
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
            this.RBPioche.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPioche.Location = new System.Drawing.Point(282, 3);
            this.RBPioche.Name = "RBPioche";
            this.RBPioche.Size = new System.Drawing.Size(273, 42);
            this.RBPioche.TabIndex = 1;
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
            this.RBPlanneur.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPlanneur.Location = new System.Drawing.Point(561, 3);
            this.RBPlanneur.Name = "RBPlanneur";
            this.RBPlanneur.Size = new System.Drawing.Size(272, 42);
            this.RBPlanneur.TabIndex = 2;
            this.RBPlanneur.Text = "Planeur";
            this.RBPlanneur.UseVisualStyleBackColor = false;
            this.RBPlanneur.CheckedChanged += new System.EventHandler(this.RBPlanneur_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36272F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63728F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.BAnnuler, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BValider, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.92308F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.07692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(836, 390);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez le nom du Skin à Supprimer :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(407, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BRech);
            this.splitContainer1.Size = new System.Drawing.Size(426, 114);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 114);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BRech
            // 
            this.BRech.BackColor = System.Drawing.Color.SlateBlue;
            this.BRech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BRech.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRech.Location = new System.Drawing.Point(0, 0);
            this.BRech.Name = "BRech";
            this.BRech.Size = new System.Drawing.Size(197, 114);
            this.BRech.TabIndex = 0;
            this.BRech.Text = "Rechercher\r\n";
            this.BRech.UseVisualStyleBackColor = false;
            this.BRech.Click += new System.EventHandler(this.BRech_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 123);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(398, 199);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(407, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 199);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BAnnuler
            // 
            this.BAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.BAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAnnuler.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnnuler.Location = new System.Drawing.Point(3, 328);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(398, 59);
            this.BAnnuler.TabIndex = 4;
            this.BAnnuler.Text = "Annuler";
            this.BAnnuler.UseVisualStyleBackColor = false;
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Click);
            // 
            // BValider
            // 
            this.BValider.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BValider.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BValider.Location = new System.Drawing.Point(407, 328);
            this.BValider.Name = "BValider";
            this.BValider.Size = new System.Drawing.Size(426, 59);
            this.BValider.TabIndex = 5;
            this.BValider.Text = "Valider\r\n";
            this.BValider.UseVisualStyleBackColor = false;
            this.BValider.Click += new System.EventHandler(this.BValider_Click);
            // 
            // SuppDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SuppDlg";
            this.Text = "SuppDlg";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton RBSkin;
        private System.Windows.Forms.RadioButton RBPioche;
        private System.Windows.Forms.RadioButton RBPlanneur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BRech;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.Button BValider;
    }
}