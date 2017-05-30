namespace ATH_kino
{
    partial class RoomPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomPreview));
            this.tableLayoutPanelRoomPreview = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRoomNumberSolid = new System.Windows.Forms.Label();
            this.labelDateSolid = new System.Windows.Forms.Label();
            this.labelTimeSolid = new System.Windows.Forms.Label();
            this.groupBoxFilmInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxFilmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRoomPreview
            // 
            this.tableLayoutPanelRoomPreview.AutoSize = true;
            this.tableLayoutPanelRoomPreview.ColumnCount = 2;
            this.tableLayoutPanelRoomPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanelRoomPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanelRoomPreview.Location = new System.Drawing.Point(12, 118);
            this.tableLayoutPanelRoomPreview.Name = "tableLayoutPanelRoomPreview";
            this.tableLayoutPanelRoomPreview.RowCount = 2;
            this.tableLayoutPanelRoomPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRoomPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRoomPreview.Size = new System.Drawing.Size(123, 122);
            this.tableLayoutPanelRoomPreview.TabIndex = 1;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(54, 21);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(94, 13);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "labelRoomNumber";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(54, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "labelDate";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(54, 57);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "labelTime";
            // 
            // labelRoomNumberSolid
            // 
            this.labelRoomNumberSolid.AutoSize = true;
            this.labelRoomNumberSolid.Location = new System.Drawing.Point(6, 21);
            this.labelRoomNumberSolid.Name = "labelRoomNumberSolid";
            this.labelRoomNumberSolid.Size = new System.Drawing.Size(42, 13);
            this.labelRoomNumberSolid.TabIndex = 3;
            this.labelRoomNumberSolid.Text = "Nr. sali:";
            // 
            // labelDateSolid
            // 
            this.labelDateSolid.AutoSize = true;
            this.labelDateSolid.Location = new System.Drawing.Point(6, 39);
            this.labelDateSolid.Name = "labelDateSolid";
            this.labelDateSolid.Size = new System.Drawing.Size(33, 13);
            this.labelDateSolid.TabIndex = 3;
            this.labelDateSolid.Text = "Data:";
            // 
            // labelTimeSolid
            // 
            this.labelTimeSolid.AutoSize = true;
            this.labelTimeSolid.Location = new System.Drawing.Point(6, 57);
            this.labelTimeSolid.Name = "labelTimeSolid";
            this.labelTimeSolid.Size = new System.Drawing.Size(33, 13);
            this.labelTimeSolid.TabIndex = 3;
            this.labelTimeSolid.Text = "Czas:";
            // 
            // groupBoxFilmInfo
            // 
            this.groupBoxFilmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilmInfo.Controls.Add(this.labelRoomNumberSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelTime);
            this.groupBoxFilmInfo.Controls.Add(this.labelTimeSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelDate);
            this.groupBoxFilmInfo.Controls.Add(this.labelDateSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelRoomNumber);
            this.groupBoxFilmInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilmInfo.Name = "groupBoxFilmInfo";
            this.groupBoxFilmInfo.Size = new System.Drawing.Size(240, 80);
            this.groupBoxFilmInfo.TabIndex = 4;
            this.groupBoxFilmInfo.TabStop = false;
            this.groupBoxFilmInfo.Text = "Informacje o wybranym seansie";
            // 
            // RoomPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(257, 337);
            this.Controls.Add(this.groupBoxFilmInfo);
            this.Controls.Add(this.tableLayoutPanelRoomPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RoomPreview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podgląd Sali";
            this.groupBoxFilmInfo.ResumeLayout(false);
            this.groupBoxFilmInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoomPreview;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRoomNumberSolid;
        private System.Windows.Forms.Label labelDateSolid;
        private System.Windows.Forms.Label labelTimeSolid;
        private System.Windows.Forms.GroupBox groupBoxFilmInfo;
    }
}