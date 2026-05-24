namespace World_Cup___PresentaionTier
{
    partial class frmAddEditPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPlayer));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblKitNumber = new System.Windows.Forms.Label();
            this.nudKitNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNationalTeam = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.tbClub = new System.Windows.Forms.TextBox();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(29, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(56, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "الإسم:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(121, 12);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(103, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(121, 55);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(103, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(29, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 19);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "إسم العائلة:";
            // 
            // lblKitNumber
            // 
            this.lblKitNumber.AutoSize = true;
            this.lblKitNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitNumber.Location = new System.Drawing.Point(29, 90);
            this.lblKitNumber.Name = "lblKitNumber";
            this.lblKitNumber.Size = new System.Drawing.Size(86, 19);
            this.lblKitNumber.TabIndex = 4;
            this.lblKitNumber.Text = "رقم الغلالة:";
            // 
            // nudKitNumber
            // 
            this.nudKitNumber.Location = new System.Drawing.Point(121, 93);
            this.nudKitNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudKitNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKitNumber.Name = "nudKitNumber";
            this.nudKitNumber.Size = new System.Drawing.Size(103, 20);
            this.nudKitNumber.TabIndex = 6;
            this.nudKitNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNationalTeam
            // 
            this.lblNationalTeam.AutoSize = true;
            this.lblNationalTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalTeam.Location = new System.Drawing.Point(29, 130);
            this.lblNationalTeam.Name = "lblNationalTeam";
            this.lblNationalTeam.Size = new System.Drawing.Size(72, 19);
            this.lblNationalTeam.TabIndex = 7;
            this.lblNationalTeam.Text = "المنتخب:";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(122, 133);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(102, 21);
            this.cbTeams.TabIndex = 8;
            // 
            // tbClub
            // 
            this.tbClub.Location = new System.Drawing.Point(121, 173);
            this.tbClub.Name = "tbClub";
            this.tbClub.Size = new System.Drawing.Size(103, 20);
            this.tbClub.TabIndex = 10;
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(23, 171);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(56, 19);
            this.lblClub.TabIndex = 9;
            this.lblClub.Text = "النادي:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(23, 213);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(88, 19);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "مركز اللعب:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(122, 215);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(102, 21);
            this.cbPosition.TabIndex = 12;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(121, 255);
            this.nudAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(103, 20);
            this.nudAge.TabIndex = 14;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(29, 252);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 19);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = "العمر:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(46, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 51);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 394);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.tbClub);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.lblNationalTeam);
            this.Controls.Add(this.nudKitNumber);
            this.Controls.Add(this.lblKitNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddPlayer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة لاعب";
            this.Load += new System.EventHandler(this.frmAddPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKitNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblKitNumber;
        private System.Windows.Forms.NumericUpDown nudKitNumber;
        private System.Windows.Forms.Label lblNationalTeam;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.TextBox tbClub;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSave;
    }
}