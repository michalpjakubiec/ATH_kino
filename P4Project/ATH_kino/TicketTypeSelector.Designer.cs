namespace ATH_kino
{
    partial class TicketTypeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketTypeSelector));
            this.groupBoxTicketSelectionDescription = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonSchool = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.groupBoxTicketSelectionDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTicketSelectionDescription
            // 
            this.groupBoxTicketSelectionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTicketSelectionDescription.Controls.Add(this.buttonCancel);
            this.groupBoxTicketSelectionDescription.Controls.Add(this.buttonOK);
            this.groupBoxTicketSelectionDescription.Controls.Add(this.radioButtonSenior);
            this.groupBoxTicketSelectionDescription.Controls.Add(this.radioButtonStudent);
            this.groupBoxTicketSelectionDescription.Controls.Add(this.radioButtonSchool);
            this.groupBoxTicketSelectionDescription.Controls.Add(this.radioButtonNormal);
            this.groupBoxTicketSelectionDescription.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTicketSelectionDescription.Name = "groupBoxTicketSelectionDescription";
            this.groupBoxTicketSelectionDescription.Size = new System.Drawing.Size(129, 157);
            this.groupBoxTicketSelectionDescription.TabIndex = 0;
            this.groupBoxTicketSelectionDescription.TabStop = false;
            this.groupBoxTicketSelectionDescription.Text = "Rodzaj biletu";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancel.Location = new System.Drawing.Point(68, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(55, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonOK.Location = new System.Drawing.Point(6, 117);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(55, 34);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(6, 88);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(68, 17);
            this.radioButtonSenior.TabIndex = 3;
            this.radioButtonSenior.TabStop = true;
            this.radioButtonSenior.Text = "Seniorski";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(6, 65);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(73, 17);
            this.radioButtonStudent.TabIndex = 2;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Studencki";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonSchool
            // 
            this.radioButtonSchool.AutoSize = true;
            this.radioButtonSchool.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSchool.Name = "radioButtonSchool";
            this.radioButtonSchool.Size = new System.Drawing.Size(62, 17);
            this.radioButtonSchool.TabIndex = 1;
            this.radioButtonSchool.TabStop = true;
            this.radioButtonSchool.Text = "Szkolny";
            this.radioButtonSchool.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(69, 17);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normalny";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // TicketTypeSelector
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(153, 181);
            this.Controls.Add(this.groupBoxTicketSelectionDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketTypeSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TicketTypeSelector";
            this.groupBoxTicketSelectionDescription.ResumeLayout(false);
            this.groupBoxTicketSelectionDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTicketSelectionDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioButtonSenior;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonSchool;
        private System.Windows.Forms.RadioButton radioButtonNormal;
    }
}