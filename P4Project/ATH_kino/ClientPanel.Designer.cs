namespace ATH_kino
{
    partial class clientPanel
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
            this.comboBoxFilmsList = new System.Windows.Forms.ComboBox();
            this.groupBoxFilmInfo = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxFilmDetails = new System.Windows.Forms.GroupBox();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelPremierePol = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelWriter = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelStarsSolid = new System.Windows.Forms.Label();
            this.labelPremierePolSolid = new System.Windows.Forms.Label();
            this.labelCountrySolid = new System.Windows.Forms.Label();
            this.labelWriterSolid = new System.Windows.Forms.Label();
            this.labelDirectorSolid = new System.Windows.Forms.Label();
            this.labelFilmNameSolid = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.groupBoxFilmInfo.SuspendLayout();
            this.groupBoxFilmDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilmsList
            // 
            this.comboBoxFilmsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxFilmsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFilmsList.FormattingEnabled = true;
            this.comboBoxFilmsList.Location = new System.Drawing.Point(212, 19);
            this.comboBoxFilmsList.Name = "comboBoxFilmsList";
            this.comboBoxFilmsList.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFilmsList.Sorted = true;
            this.comboBoxFilmsList.TabIndex = 3;
            this.comboBoxFilmsList.Text = "Wybierz film...";
            this.comboBoxFilmsList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmsList_SelectedIndexChanged);
            // 
            // groupBoxFilmInfo
            // 
            this.groupBoxFilmInfo.Controls.Add(this.richTextBox1);
            this.groupBoxFilmInfo.Controls.Add(this.button2);
            this.groupBoxFilmInfo.Controls.Add(this.groupBoxFilmDetails);
            this.groupBoxFilmInfo.Controls.Add(this.comboBoxFilmsList);
            this.groupBoxFilmInfo.Controls.Add(this.pictureBoxCover);
            this.groupBoxFilmInfo.Location = new System.Drawing.Point(10, 10);
            this.groupBoxFilmInfo.Name = "groupBoxFilmInfo";
            this.groupBoxFilmInfo.Size = new System.Drawing.Size(420, 327);
            this.groupBoxFilmInfo.TabIndex = 0;
            this.groupBoxFilmInfo.TabStop = false;
            this.groupBoxFilmInfo.Text = "Informacje o filmie";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 72);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pokaż seanse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxFilmDetails
            // 
            this.groupBoxFilmDetails.Controls.Add(this.labelStars);
            this.groupBoxFilmDetails.Controls.Add(this.labelPremierePol);
            this.groupBoxFilmDetails.Controls.Add(this.labelCountry);
            this.groupBoxFilmDetails.Controls.Add(this.labelWriter);
            this.groupBoxFilmDetails.Controls.Add(this.labelDirector);
            this.groupBoxFilmDetails.Controls.Add(this.labelFilmName);
            this.groupBoxFilmDetails.Controls.Add(this.labelStarsSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelPremierePolSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelCountrySolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelWriterSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelDirectorSolid);
            this.groupBoxFilmDetails.Controls.Add(this.labelFilmNameSolid);
            this.groupBoxFilmDetails.Location = new System.Drawing.Point(212, 46);
            this.groupBoxFilmDetails.Name = "groupBoxFilmDetails";
            this.groupBoxFilmDetails.Size = new System.Drawing.Size(200, 165);
            this.groupBoxFilmDetails.TabIndex = 6;
            this.groupBoxFilmDetails.TabStop = false;
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Location = new System.Drawing.Point(79, 103);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(34, 13);
            this.labelStars.TabIndex = 5;
            this.labelStars.Text = "(brak)";
            // 
            // labelPremierePol
            // 
            this.labelPremierePol.AutoSize = true;
            this.labelPremierePol.Location = new System.Drawing.Point(79, 85);
            this.labelPremierePol.Name = "labelPremierePol";
            this.labelPremierePol.Size = new System.Drawing.Size(34, 13);
            this.labelPremierePol.TabIndex = 5;
            this.labelPremierePol.Text = "(brak)";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(79, 67);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(34, 13);
            this.labelCountry.TabIndex = 5;
            this.labelCountry.Text = "(brak)";
            // 
            // labelWriter
            // 
            this.labelWriter.AutoSize = true;
            this.labelWriter.Location = new System.Drawing.Point(79, 49);
            this.labelWriter.Name = "labelWriter";
            this.labelWriter.Size = new System.Drawing.Size(34, 13);
            this.labelWriter.TabIndex = 5;
            this.labelWriter.Text = "(brak)";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(79, 31);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(34, 13);
            this.labelDirector.TabIndex = 5;
            this.labelDirector.Text = "(brak)";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(79, 13);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(34, 13);
            this.labelFilmName.TabIndex = 5;
            this.labelFilmName.Text = "(brak)";
            // 
            // labelStarsSolid
            // 
            this.labelStarsSolid.AutoSize = true;
            this.labelStarsSolid.Location = new System.Drawing.Point(6, 103);
            this.labelStarsSolid.Name = "labelStarsSolid";
            this.labelStarsSolid.Size = new System.Drawing.Size(60, 13);
            this.labelStarsSolid.TabIndex = 5;
            this.labelStarsSolid.Text = "Występują:";
            // 
            // labelPremierePolSolid
            // 
            this.labelPremierePolSolid.AutoSize = true;
            this.labelPremierePolSolid.Location = new System.Drawing.Point(6, 85);
            this.labelPremierePolSolid.Name = "labelPremierePolSolid";
            this.labelPremierePolSolid.Size = new System.Drawing.Size(75, 13);
            this.labelPremierePolSolid.TabIndex = 5;
            this.labelPremierePolSolid.Text = "Data premiery:";
            // 
            // labelCountrySolid
            // 
            this.labelCountrySolid.AutoSize = true;
            this.labelCountrySolid.Location = new System.Drawing.Point(6, 67);
            this.labelCountrySolid.Name = "labelCountrySolid";
            this.labelCountrySolid.Size = new System.Drawing.Size(58, 13);
            this.labelCountrySolid.TabIndex = 5;
            this.labelCountrySolid.Text = "Produkcja:";
            // 
            // labelWriterSolid
            // 
            this.labelWriterSolid.AutoSize = true;
            this.labelWriterSolid.Location = new System.Drawing.Point(6, 49);
            this.labelWriterSolid.Name = "labelWriterSolid";
            this.labelWriterSolid.Size = new System.Drawing.Size(68, 13);
            this.labelWriterSolid.TabIndex = 5;
            this.labelWriterSolid.Text = "Scenarzysta:";
            // 
            // labelDirectorSolid
            // 
            this.labelDirectorSolid.AutoSize = true;
            this.labelDirectorSolid.Location = new System.Drawing.Point(6, 31);
            this.labelDirectorSolid.Name = "labelDirectorSolid";
            this.labelDirectorSolid.Size = new System.Drawing.Size(48, 13);
            this.labelDirectorSolid.TabIndex = 5;
            this.labelDirectorSolid.Text = "Reżyser:";
            // 
            // labelFilmNameSolid
            // 
            this.labelFilmNameSolid.AutoSize = true;
            this.labelFilmNameSolid.Location = new System.Drawing.Point(6, 13);
            this.labelFilmNameSolid.Name = "labelFilmNameSolid";
            this.labelFilmNameSolid.Size = new System.Drawing.Size(43, 13);
            this.labelFilmNameSolid.TabIndex = 5;
            this.labelFilmNameSolid.Text = "Nazwa:";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Image = global::ATH_kino.Properties.Resources.blank1;
            this.pictureBoxCover.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxCover.TabIndex = 1;
            this.pictureBoxCover.TabStop = false;
            // 
            // clientPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(435, 343);
            this.Controls.Add(this.groupBoxFilmInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "clientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel klienta";
            this.groupBoxFilmInfo.ResumeLayout(false);
            this.groupBoxFilmDetails.ResumeLayout(false);
            this.groupBoxFilmDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxCover;
    private System.Windows.Forms.GroupBox groupBoxFilmInfo;
    private System.Windows.Forms.GroupBox groupBoxFilmDetails;
    private System.Windows.Forms.Label labelFilmNameSolid;
    private System.Windows.Forms.Label labelFilmName;
    private System.Windows.Forms.Label labelDirectorSolid;
    private System.Windows.Forms.Label labelDirector;
    private System.Windows.Forms.Label labelWriterSolid;
        private System.Windows.Forms.Label labelStarsSolid;
        private System.Windows.Forms.Label labelPremierePolSolid;
        private System.Windows.Forms.Label labelCountrySolid;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelPremierePol;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelWriter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxFilmsList;
    }
}

