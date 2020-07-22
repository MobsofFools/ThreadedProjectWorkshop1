namespace ThreadedProjectWorkshop1
{
    partial class frmSearch
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
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.examineeDataGridView = new System.Windows.Forms.DataGridView();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleterecord = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(990, 23);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(77, 17);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By:";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Examinee ID",
            "Exam ID",
            "Session ID"});
            this.cbSearchBy.Location = new System.Drawing.Point(1073, 23);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(121, 24);
            this.cbSearchBy.TabIndex = 1;
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.Location = new System.Drawing.Point(1345, 23);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBy.TabIndex = 2;
            this.btnSearchBy.Text = "Search";
            this.btnSearchBy.UseVisualStyleBackColor = true;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // examineeDataGridView
            // 
            this.examineeDataGridView.AllowUserToResizeRows = false;
            this.examineeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.examineeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examineeDataGridView.Location = new System.Drawing.Point(37, 73);
            this.examineeDataGridView.Name = "examineeDataGridView";
            this.examineeDataGridView.RowHeadersWidth = 51;
            this.examineeDataGridView.RowTemplate.Height = 24;
            this.examineeDataGridView.Size = new System.Drawing.Size(519, 584);
            this.examineeDataGridView.TabIndex = 3;
            this.examineeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.examineeDataGridView_CellClick);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(583, 73);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(837, 584);
            this.searchDataGridView.TabIndex = 4;
            // 
            // btnDeleterecord
            // 
            this.btnDeleterecord.Location = new System.Drawing.Point(258, 682);
            this.btnDeleterecord.Name = "btnDeleterecord";
            this.btnDeleterecord.Size = new System.Drawing.Size(75, 23);
            this.btnDeleterecord.TabIndex = 13;
            this.btnDeleterecord.Text = "Delete Record";
            this.btnDeleterecord.UseVisualStyleBackColor = true;
            this.btnDeleterecord.Click += new System.EventHandler(this.btnDeleterecord_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(144, 682);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 23);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify Record";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 682);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1239, 682);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1345, 682);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Location = new System.Drawing.Point(1211, 23);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(121, 22);
            this.txtSearchBy.TabIndex = 16;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 735);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleterecord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.examineeDataGridView);
            this.Controls.Add(this.btnSearchBy);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Name = "frmSearch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examineeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.DataGridView examineeDataGridView;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Button btnDeleterecord;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearchBy;
    }
}

