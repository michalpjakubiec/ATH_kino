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
            this.labelDateSolid = new System.Windows.Forms.Label();
            this.labelTimeSolid = new System.Windows.Forms.Label();
            this.groupBoxFilmInfo = new System.Windows.Forms.GroupBox();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelFilmNameSolid = new System.Windows.Forms.Label();
            this.groupBoxSeatList = new System.Windows.Forms.GroupBox();
            this.labelScreen = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRoomNumberSolid = new System.Windows.Forms.Label();
            this.groupBoxFilmInfo.SuspendLayout();
            this.groupBoxSeatList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelRoomPreview
            // 
            this.tableLayoutPanelRoomPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRoomPreview.AutoSize = true;
            this.tableLayoutPanelRoomPreview.ColumnCount = 2;
            this.tableLayoutPanelRoomPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.07407F));
            this.tableLayoutPanelRoomPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.92593F));
            this.tableLayoutPanelRoomPreview.Location = new System.Drawing.Point(9, 32);
            this.tableLayoutPanelRoomPreview.Name = "tableLayoutPanelRoomPreview";
            this.tableLayoutPanelRoomPreview.RowCount = 2;
            this.tableLayoutPanelRoomPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRoomPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRoomPreview.Size = new System.Drawing.Size(212, 186);
            this.tableLayoutPanelRoomPreview.TabIndex = 1;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(71, 74);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(94, 13);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "labelRoomNumber";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(71, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "labelDate";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(71, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "labelTime";
            // 
            // labelDateSolid
            // 
            this.labelDateSolid.AutoSize = true;
            this.labelDateSolid.Location = new System.Drawing.Point(6, 56);
            this.labelDateSolid.Name = "labelDateSolid";
            this.labelDateSolid.Size = new System.Drawing.Size(33, 13);
            this.labelDateSolid.TabIndex = 3;
            this.labelDateSolid.Text = "Data:";
            // 
            // labelTimeSolid
            // 
            this.labelTimeSolid.AutoSize = true;
            this.labelTimeSolid.Location = new System.Drawing.Point(6, 38);
            this.labelTimeSolid.Name = "labelTimeSolid";
            this.labelTimeSolid.Size = new System.Drawing.Size(49, 13);
            this.labelTimeSolid.TabIndex = 3;
            this.labelTimeSolid.Text = "Godzina:";
            // 
            // groupBoxFilmInfo
            // 
            this.groupBoxFilmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilmInfo.AutoSize = true;
            this.groupBoxFilmInfo.Controls.Add(this.labelFilmName);
            this.groupBoxFilmInfo.Controls.Add(this.labelTime);
            this.groupBoxFilmInfo.Controls.Add(this.labelFilmNameSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelTimeSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelDate);
            this.groupBoxFilmInfo.Controls.Add(this.labelRoomNumberSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelDateSolid);
            this.groupBoxFilmInfo.Controls.Add(this.labelRoomNumber);
            this.groupBoxFilmInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilmInfo.Name = "groupBoxFilmInfo";
            this.groupBoxFilmInfo.Size = new System.Drawing.Size(232, 103);
            this.groupBoxFilmInfo.TabIndex = 4;
            this.groupBoxFilmInfo.TabStop = false;
            this.groupBoxFilmInfo.Text = "Informacje o seansie";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(71, 21);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(75, 13);
            this.labelFilmName.TabIndex = 3;
            this.labelFilmName.Text = "labelFilmName";
            // 
            // labelFilmNameSolid
            // 
            this.labelFilmNameSolid.AutoSize = true;
            this.labelFilmNameSolid.Location = new System.Drawing.Point(6, 21);
            this.labelFilmNameSolid.Name = "labelFilmNameSolid";
            this.labelFilmNameSolid.Size = new System.Drawing.Size(59, 13);
            this.labelFilmNameSolid.TabIndex = 3;
            this.labelFilmNameSolid.Text = "Tytuł filmu:";
            // 
            // groupBoxSeatList
            // 
            this.groupBoxSeatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSeatList.AutoSize = true;
            this.groupBoxSeatList.Controls.Add(this.labelScreen);
            this.groupBoxSeatList.Controls.Add(this.tableLayoutPanelRoomPreview);
            this.groupBoxSeatList.Location = new System.Drawing.Point(12, 121);
            this.groupBoxSeatList.Name = "groupBoxSeatList";
            this.groupBoxSeatList.Size = new System.Drawing.Size(232, 229);
            this.groupBoxSeatList.TabIndex = 5;
            this.groupBoxSeatList.TabStop = false;
            this.groupBoxSeatList.Text = "Podgląd sali";
            // 
            // labelScreen
            // 
            this.labelScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScreen.Location = new System.Drawing.Point(10, 16);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(211, 13);
            this.labelScreen.TabIndex = 2;
            this.labelScreen.Text = "Ekran";
            this.labelScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonOK.Enabled = false;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOK.Location = new System.Drawing.Point(130, 357);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(114, 34);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Kontynuuj";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Location = new System.Drawing.Point(10, 357);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Wstecz";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelRoomNumberSolid
            // 
            this.labelRoomNumberSolid.AutoSize = true;
            this.labelRoomNumberSolid.Location = new System.Drawing.Point(6, 74);
            this.labelRoomNumberSolid.Name = "labelRoomNumberSolid";
            this.labelRoomNumberSolid.Size = new System.Drawing.Size(39, 13);
            this.labelRoomNumberSolid.TabIndex = 3;
            this.labelRoomNumberSolid.Text = "Nr sali:";
            // 
            // RoomPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(256, 403);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxSeatList);
            this.Controls.Add(this.groupBoxFilmInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RoomPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel rezerwacji";
            this.groupBoxFilmInfo.ResumeLayout(false);
            this.groupBoxFilmInfo.PerformLayout();
            this.groupBoxSeatList.ResumeLayout(false);
            this.groupBoxSeatList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoomPreview;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDateSolid;
        private System.Windows.Forms.Label labelTimeSolid;
        private System.Windows.Forms.GroupBox groupBoxFilmInfo;
        private System.Windows.Forms.GroupBox groupBoxSeatList;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelFilmNameSolid;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRoomNumberSolid;
    }
}