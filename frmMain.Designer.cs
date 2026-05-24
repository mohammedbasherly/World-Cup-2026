namespace World_Cup___PresentaionTier
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.btnGetAllPlayers = new System.Windows.Forms.Button();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cbSearchByOprions = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.cmsPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(226, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كأس العالم 2026";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(12, 129);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(501, 309);
            this.dgvPlayers.TabIndex = 2;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(22, 91);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(129, 25);
            this.lblPlayers.TabIndex = 5;
            this.lblPlayers.Text = "قائمة اللاعبين:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(579, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "إضافة لاعب";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(580, 193);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(181, 21);
            this.cbTeams.TabIndex = 7;
            this.cbTeams.SelectionChangeCommitted += new System.EventHandler(this.cbTeams_SelectionChangeCommitted);
            // 
            // btnGetAllPlayers
            // 
            this.btnGetAllPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGetAllPlayers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllPlayers.ForeColor = System.Drawing.Color.White;
            this.btnGetAllPlayers.Location = new System.Drawing.Point(622, 220);
            this.btnGetAllPlayers.Name = "btnGetAllPlayers";
            this.btnGetAllPlayers.Size = new System.Drawing.Size(90, 29);
            this.btnGetAllPlayers.TabIndex = 8;
            this.btnGetAllPlayers.Text = "كل اللاعبين";
            this.btnGetAllPlayers.UseVisualStyleBackColor = false;
            this.btnGetAllPlayers.Click += new System.EventHandler(this.btnGetAllPlayers_Click);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(530, 273);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(122, 23);
            this.lblSearchBy.TabIndex = 9;
            this.lblSearchBy.Text = "البحث عن طريق:";
            // 
            // cbSearchByOprions
            // 
            this.cbSearchByOprions.FormattingEnabled = true;
            this.cbSearchByOprions.Location = new System.Drawing.Point(658, 278);
            this.cbSearchByOprions.Name = "cbSearchByOprions";
            this.cbSearchByOprions.Size = new System.Drawing.Size(121, 21);
            this.cbSearchByOprions.TabIndex = 10;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(561, 325);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 20);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.Text = "اسم, منتخب, نادي, مركز...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(580, 369);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "إبحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmsPlayer
            // 
            this.cmsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.حذفToolStripMenuItem});
            this.cmsPlayer.Name = "cmsPlayer";
            this.cmsPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsPlayer.Size = new System.Drawing.Size(104, 48);
            this.cmsPlayer.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPlayer_Opening);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(103, 22);
            this.tsmiEdit.Text = "تعديل";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbSearchByOprions);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.btnGetAllPlayers);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قوائم المنتخبات واللاعبين - كأس العالم 2026";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.cmsPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Button btnGetAllPlayers;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cbSearchByOprions;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip cmsPlayer;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}

