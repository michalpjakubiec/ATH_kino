namespace ATH_kino
{
    partial class ClientPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPanel));
            this.comboBoxFilmsList = new System.Windows.Forms.ComboBox();
            this.groupBoxFilmInfo = new System.Windows.Forms.GroupBox();
            this.labelFilmList = new System.Windows.Forms.Label();
            this.groupBoxFilmDetails = new System.Windows.Forms.GroupBox();
            this.labelActor = new System.Windows.Forms.Label();
            this.labelPremiere = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelWriter = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelActorSolid = new System.Windows.Forms.Label();
            this.labelPremiereSolid = new System.Windows.Forms.Label();
            this.labelCountrySolid = new System.Windows.Forms.Label();
            this.labelWriterSolid = new System.Windows.Forms.Label();
            this.labelDirectorSolid = new System.Windows.Forms.Label();
            this.labelGenreSolid = new System.Windows.Forms.Label();
            this.labelFilmNameSolid = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonRoomPreview = new System.Windows.Forms.Button();
            this.comboBoxDateSelection = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeSelection = new System.Windows.Forms.ComboBox();
            this.labelDateSelection = new System.Windows.Forms.Label();
            this.labelTimeSelection = new System.Windows.Forms.Label();
            this.groupBoxFilmInfo.SuspendLayout();
            this.groupBoxFilmDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilmsList
            // 
            this.comboBoxFilmsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxFilmsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFilmsList.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFilmsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilmsList.FormattingEnabled = true;
            this.comboBoxFilmsList.Items.AddRange(new object[] {
            ""});
            this.comboBoxFilmsList.Location = new System.Drawing.Point(212, 41);
            this.comboBoxFilmsList.Name = "comboBoxFilmsList";
            this.comboBoxFilmsList.Size = new System.Drawing.Size(321, 21);
            this.comboBoxFilmsList.Sorted = true;
            this.comboBoxFilmsList.TabIndex = 1;
            this.comboBoxFilmsList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmsList_SelectedIndexChanged);
            // 
            // groupBoxFilmInfo
            // 
            this.groupBoxFilmInfo.Controls.Add(this.labelFilmList);
            this.groupBoxFilmInfo.Controls.Add(this.groupBoxFilmDetails);
            this.groupBoxFilmInfo.Controls.Add(this.comboBoxFilmsList);
            this.groupBoxFilmInfo.Controls.Add(this.pictureBoxCover);
            this.groupBoxFilmInfo.Location = new System.Drawing.Point(10, 10);
            this.groupBoxFilmInfo.Name = "groupBoxFilmInfo";
            this.groupBoxFilmInfo.Size = new System.Drawing.Size(539, 327);
            this.groupBoxFilmInfo.TabIndex = 5;
            this.groupBoxFilmInfo.TabStop = false;
            this.groupBoxFilmInfo.Text = "Informacje o filmie";
            // 
            // labelFilmList
            // 
            this.labelFilmList.AutoSize = true;
            this.labelFilmList.Location = new System.Drawing.Point(209, 19);
            this.labelFilmList.Name = "labelFilmList";
            this.labelFilmList.Size = new System.Drawing.Size(66, 13);
            this.labelFilmList.TabIndex = 0;
            this.labelFilmList.Text = "Wybierz film:";
            // 
            // groupBoxFilmDetails
            // 
            this.groupBoxFilmDetails.Controls.Add(this.labelActor);
            this.groupBoxFilmDetails.Controls.Add(this.labelPremiere);
            this.groupBoxFilmDetails.Controls.Add(this.labelCountry);
            this.groupBoxFilmDetails.Controls.Add(this.labelWriter);
            this.groupBoxFilmDetails.Controls.Add(this.labelDirector);
            this.groupBoxFilmDetails.Controls.Add(this.labelGenre);
            this.groupBoxFilmDetails.Controls.Add(this.labelFilmName);
            this.groupBoxFilmDetails.Controls.Add(this.labelActorSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelPremiereSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelCountrySolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelWriterSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelDirectorSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelGenreSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelFilmNameSolid);
            this.groupBoxFilmDetails.Location = new System.Drawing.Point(212, 68);
            this.groupBoxFilmDetails.Name = "groupBoxFilmDetails";
            this.groupBoxFilmDetails.Size = new System.Drawing.Size(321, 251);
            this.groupBoxFilmDetails.TabIndex = 1;
            this.groupBoxFilmDetails.TabStop = false;
            // 
            // labelActor
            // 
            this.labelActor.AutoSize = true;
            this.labelActor.Location = new System.Drawing.Point(79, 121);
            this.labelActor.Name = "labelActor";
            this.labelActor.Size = new System.Drawing.Size(0, 13);
            this.labelActor.TabIndex = 0;
            // 
            // labelPremiere
            // 
            this.labelPremiere.AutoSize = true;
            this.labelPremiere.Location = new System.Drawing.Point(79, 103);
            this.labelPremiere.Name = "labelPremiere";
            this.labelPremiere.Size = new System.Drawing.Size(0, 13);
            this.labelPremiere.TabIndex = 1;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(79, 85);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(0, 13);
            this.labelCountry.TabIndex = 2;
            // 
            // labelWriter
            // 
            this.labelWriter.AutoSize = true;
            this.labelWriter.Location = new System.Drawing.Point(79, 67);
            this.labelWriter.Name = "labelWriter";
            this.labelWriter.Size = new System.Drawing.Size(0, 13);
            this.labelWriter.TabIndex = 3;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(79, 49);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(0, 13);
            this.labelDirector.TabIndex = 4;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(79, 31);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(0, 13);
            this.labelGenre.TabIndex = 5;
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(79, 13);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(0, 13);
            this.labelFilmName.TabIndex = 6;
            // 
            // labelActorSolid
            // 
            this.labelActorSolid.AutoSize = true;
            this.labelActorSolid.Location = new System.Drawing.Point(6, 121);
            this.labelActorSolid.Name = "labelActorSolid";
            this.labelActorSolid.Size = new System.Drawing.Size(60, 13);
            this.labelActorSolid.TabIndex = 7;
            this.labelActorSolid.Text = "Występują:";
            // 
            // labelPremiereSolid
            // 
            this.labelPremiereSolid.AutoSize = true;
            this.labelPremiereSolid.Location = new System.Drawing.Point(6, 103);
            this.labelPremiereSolid.Name = "labelPremiereSolid";
            this.labelPremiereSolid.Size = new System.Drawing.Size(75, 13);
            this.labelPremiereSolid.TabIndex = 8;
            this.labelPremiereSolid.Text = "Data premiery:";
            // 
            // labelCountrySolid
            // 
            this.labelCountrySolid.AutoSize = true;
            this.labelCountrySolid.Location = new System.Drawing.Point(6, 84);
            this.labelCountrySolid.Name = "labelCountrySolid";
            this.labelCountrySolid.Size = new System.Drawing.Size(58, 13);
            this.labelCountrySolid.TabIndex = 9;
            this.labelCountrySolid.Text = "Produkcja:";
            // 
            // labelWriterSolid
            // 
            this.labelWriterSolid.AutoSize = true;
            this.labelWriterSolid.Location = new System.Drawing.Point(6, 67);
            this.labelWriterSolid.Name = "labelWriterSolid";
            this.labelWriterSolid.Size = new System.Drawing.Size(68, 13);
            this.labelWriterSolid.TabIndex = 10;
            this.labelWriterSolid.Text = "Scenarzysta:";
            // 
            // labelDirectorSolid
            // 
            this.labelDirectorSolid.AutoSize = true;
            this.labelDirectorSolid.Location = new System.Drawing.Point(6, 49);
            this.labelDirectorSolid.Name = "labelDirectorSolid";
            this.labelDirectorSolid.Size = new System.Drawing.Size(48, 13);
            this.labelDirectorSolid.TabIndex = 11;
            this.labelDirectorSolid.Text = "Reżyser:";
            // 
            // labelGenreSolid
            // 
            this.labelGenreSolid.AutoSize = true;
            this.labelGenreSolid.Location = new System.Drawing.Point(6, 31);
            this.labelGenreSolid.Name = "labelGenreSolid";
            this.labelGenreSolid.Size = new System.Drawing.Size(51, 13);
            this.labelGenreSolid.TabIndex = 12;
            this.labelGenreSolid.Text = "Gatunek:";
            // 
            // labelFilmNameSolid
            // 
            this.labelFilmNameSolid.AutoSize = true;
            this.labelFilmNameSolid.Location = new System.Drawing.Point(6, 13);
            this.labelFilmNameSolid.Name = "labelFilmNameSolid";
            this.labelFilmNameSolid.Size = new System.Drawing.Size(43, 13);
            this.labelFilmNameSolid.TabIndex = 13;
            this.labelFilmNameSolid.Text = "Nazwa:";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.ErrorImage = null;
            this.pictureBoxCover.InitialImage = null;
            this.pictureBoxCover.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // buttonRoomPreview
            // 
            this.buttonRoomPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonRoomPreview.Enabled = false;
            this.buttonRoomPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoomPreview.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRoomPreview.Location = new System.Drawing.Point(10, 393);
            this.buttonRoomPreview.Name = "buttonRoomPreview";
            this.buttonRoomPreview.Size = new System.Drawing.Size(539, 34);
            this.buttonRoomPreview.TabIndex = 4;
            this.buttonRoomPreview.Text = "Podgląd sali";
            this.buttonRoomPreview.UseVisualStyleBackColor = false;
            this.buttonRoomPreview.Click += new System.EventHandler(this.buttonRoomPreview_Click);
            // 
            // comboBoxDateSelection
            // 
            this.comboBoxDateSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDateSelection.Enabled = false;
            this.comboBoxDateSelection.FormatString = "dd.MM.yyy, dddd";
            this.comboBoxDateSelection.FormattingEnabled = true;
            this.comboBoxDateSelection.Items.AddRange(new object[] {
            ""});
            this.comboBoxDateSelection.Location = new System.Drawing.Point(10, 361);
            this.comboBoxDateSelection.Name = "comboBoxDateSelection";
            this.comboBoxDateSelection.Size = new System.Drawing.Size(266, 21);
            this.comboBoxDateSelection.Sorted = true;
            this.comboBoxDateSelection.TabIndex = 2;
            this.comboBoxDateSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateSelection_SelectedIndexChanged);
            // 
            // comboBoxTimeSelection
            // 
            this.comboBoxTimeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeSelection.Enabled = false;
            this.comboBoxTimeSelection.FormatString = "HH:mm";
            this.comboBoxTimeSelection.FormattingEnabled = true;
            this.comboBoxTimeSelection.Location = new System.Drawing.Point(283, 361);
            this.comboBoxTimeSelection.Name = "comboBoxTimeSelection";
            this.comboBoxTimeSelection.Size = new System.Drawing.Size(266, 21);
            this.comboBoxTimeSelection.Sorted = true;
            this.comboBoxTimeSelection.TabIndex = 3;
            this.comboBoxTimeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeSelection_SelectedIndexChanged);
            // 
            // labelDateSelection
            // 
            this.labelDateSelection.AutoSize = true;
            this.labelDateSelection.Location = new System.Drawing.Point(7, 340);
            this.labelDateSelection.Name = "labelDateSelection";
            this.labelDateSelection.Size = new System.Drawing.Size(109, 13);
            this.labelDateSelection.TabIndex = 1;
            this.labelDateSelection.Text = "Wybierz datę seansu:";
            // 
            // labelTimeSelection
            // 
            this.labelTimeSelection.AutoSize = true;
            this.labelTimeSelection.Location = new System.Drawing.Point(280, 340);
            this.labelTimeSelection.Name = "labelTimeSelection";
            this.labelTimeSelection.Size = new System.Drawing.Size(125, 13);
            this.labelTimeSelection.TabIndex = 0;
            this.labelTimeSelection.Text = "Wybierz godzinę seansu:";
            // 
            // ClientPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(561, 437);
            this.Controls.Add(this.labelTimeSelection);
            this.Controls.Add(this.labelDateSelection);
            this.Controls.Add(this.buttonRoomPreview);
            this.Controls.Add(this.comboBoxTimeSelection);
            this.Controls.Add(this.comboBoxDateSelection);
            this.Controls.Add(this.groupBoxFilmInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel klienta";
            this.Load += new System.EventHandler(this.ClientPanel_Load);
            this.groupBoxFilmInfo.ResumeLayout(false);
            this.groupBoxFilmInfo.PerformLayout();
            this.groupBoxFilmDetails.ResumeLayout(false);
            this.groupBoxFilmDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.GroupBox groupBoxFilmInfo;
        private System.Windows.Forms.Button buttonRoomPreview;
        private System.Windows.Forms.ComboBox comboBoxFilmsList;
        private System.Windows.Forms.GroupBox groupBoxFilmDetails;
        private System.Windows.Forms.Label labelActor;
        private System.Windows.Forms.Label labelPremiere;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelWriter;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelActorSolid;
        private System.Windows.Forms.Label labelPremiereSolid;
        private System.Windows.Forms.Label labelCountrySolid;
        private System.Windows.Forms.Label labelWriterSolid;
        private System.Windows.Forms.Label labelDirectorSolid;
        private System.Windows.Forms.Label labelGenreSolid;
        private System.Windows.Forms.Label labelFilmNameSolid;
        private System.Windows.Forms.ComboBox comboBoxDateSelection;
        private System.Windows.Forms.ComboBox comboBoxTimeSelection;
        private System.Windows.Forms.Label labelFilmList;
        private System.Windows.Forms.Label labelDateSelection;
        private System.Windows.Forms.Label labelTimeSelection;
    }
}

