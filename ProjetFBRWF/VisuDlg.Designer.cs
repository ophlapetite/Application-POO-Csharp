namespace ProjetFBRWF
{
    partial class VisuDlg
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ArbreSkins = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Edition = new System.Windows.Forms.RichTextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RBSkin = new System.Windows.Forms.RadioButton();
            this.RBPioche = new System.Windows.Forms.RadioButton();
            this.RBPlanneur = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ArbreSkins);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(794, 402);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // ArbreSkins
            // 
            this.ArbreSkins.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ArbreSkins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArbreSkins.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArbreSkins.Location = new System.Drawing.Point(0, 0);
            this.ArbreSkins.Name = "ArbreSkins";
            this.ArbreSkins.Size = new System.Drawing.Size(264, 402);
            this.ArbreSkins.TabIndex = 0;
            this.ArbreSkins.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArbreSkins_AfterSelect);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Edition, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Photo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.30846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.69154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Edition
            // 
            this.Edition.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edition.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition.Location = new System.Drawing.Point(3, 3);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(520, 148);
            this.Edition.TabIndex = 0;
            this.Edition.Text = "";
            // 
            // Photo
            // 
            this.Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Photo.Location = new System.Drawing.Point(3, 157);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(520, 242);
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44444F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel3.Controls.Add(this.RBSkin, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RBPioche, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RBPlanneur, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 36);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.RBSkin.Size = new System.Drawing.Size(253, 30);
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
            this.RBPioche.Location = new System.Drawing.Point(262, 3);
            this.RBPioche.Name = "RBPioche";
            this.RBPioche.Size = new System.Drawing.Size(265, 30);
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
            this.RBPlanneur.Location = new System.Drawing.Point(533, 3);
            this.RBPlanneur.Name = "RBPlanneur";
            this.RBPlanneur.Size = new System.Drawing.Size(258, 30);
            this.RBPlanneur.TabIndex = 2;
            this.RBPlanneur.Text = "Planeur";
            this.RBPlanneur.UseVisualStyleBackColor = false;
            this.RBPlanneur.CheckedChanged += new System.EventHandler(this.RBPlanneur_CheckedChanged);
            // 
            // VisuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "VisuDlg";
            this.Text = "VisuSkinDlg";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView ArbreSkins;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox Edition;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton RBSkin;
        private System.Windows.Forms.RadioButton RBPioche;
        private System.Windows.Forms.RadioButton RBPlanneur;
    }
}