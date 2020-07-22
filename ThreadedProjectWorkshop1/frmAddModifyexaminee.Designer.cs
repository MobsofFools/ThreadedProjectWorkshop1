namespace ThreadedProjectWorkshop1
{
    partial class frmAddModifyexaminee
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
            System.Windows.Forms.Label examineeEmailLabel;
            System.Windows.Forms.Label examineeFirstnameLabel;
            System.Windows.Forms.Label examineeIDLabel;
            System.Windows.Forms.Label examineeLastnameLabel;
            this.examineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examineeEmailTextBox = new System.Windows.Forms.TextBox();
            this.examineeFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.examineeIDTextBox = new System.Windows.Forms.TextBox();
            this.examineeLastnameTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            examineeEmailLabel = new System.Windows.Forms.Label();
            examineeFirstnameLabel = new System.Windows.Forms.Label();
            examineeIDLabel = new System.Windows.Forms.Label();
            examineeLastnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // examineeBindingSource
            // 
            this.examineeBindingSource.DataSource = typeof(ThreadedProjectWorkshop1.Examinee);
            // 
            // examineeEmailLabel
            // 
            examineeEmailLabel.AutoSize = true;
            examineeEmailLabel.Location = new System.Drawing.Point(36, 147);
            examineeEmailLabel.Name = "examineeEmailLabel";
            examineeEmailLabel.Size = new System.Drawing.Size(111, 17);
            examineeEmailLabel.TabIndex = 1;
            examineeEmailLabel.Text = "Examinee Email:";
            // 
            // examineeEmailTextBox
            // 
            this.examineeEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeEmail", true));
            this.examineeEmailTextBox.Location = new System.Drawing.Point(181, 144);
            this.examineeEmailTextBox.Name = "examineeEmailTextBox";
            this.examineeEmailTextBox.Size = new System.Drawing.Size(220, 22);
            this.examineeEmailTextBox.TabIndex = 2;
            // 
            // examineeFirstnameLabel
            // 
            examineeFirstnameLabel.AutoSize = true;
            examineeFirstnameLabel.Location = new System.Drawing.Point(36, 68);
            examineeFirstnameLabel.Name = "examineeFirstnameLabel";
            examineeFirstnameLabel.Size = new System.Drawing.Size(139, 17);
            examineeFirstnameLabel.TabIndex = 3;
            examineeFirstnameLabel.Text = "Examinee Firstname:";
            // 
            // examineeFirstnameTextBox
            // 
            this.examineeFirstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeFirstname", true));
            this.examineeFirstnameTextBox.Location = new System.Drawing.Point(181, 65);
            this.examineeFirstnameTextBox.Name = "examineeFirstnameTextBox";
            this.examineeFirstnameTextBox.Size = new System.Drawing.Size(220, 22);
            this.examineeFirstnameTextBox.TabIndex = 4;
            // 
            // examineeIDLabel
            // 
            examineeIDLabel.AutoSize = true;
            examineeIDLabel.Location = new System.Drawing.Point(36, 31);
            examineeIDLabel.Name = "examineeIDLabel";
            examineeIDLabel.Size = new System.Drawing.Size(90, 17);
            examineeIDLabel.TabIndex = 5;
            examineeIDLabel.Text = "Examinee ID:";
            // 
            // examineeIDTextBox
            // 
            this.examineeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeID", true));
            this.examineeIDTextBox.Location = new System.Drawing.Point(181, 28);
            this.examineeIDTextBox.Name = "examineeIDTextBox";
            this.examineeIDTextBox.Size = new System.Drawing.Size(220, 22);
            this.examineeIDTextBox.TabIndex = 6;
            // 
            // examineeLastnameLabel
            // 
            examineeLastnameLabel.AutoSize = true;
            examineeLastnameLabel.Location = new System.Drawing.Point(36, 106);
            examineeLastnameLabel.Name = "examineeLastnameLabel";
            examineeLastnameLabel.Size = new System.Drawing.Size(139, 17);
            examineeLastnameLabel.TabIndex = 7;
            examineeLastnameLabel.Text = "Examinee Lastname:";
            // 
            // examineeLastnameTextBox
            // 
            this.examineeLastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examineeBindingSource, "ExamineeLastname", true));
            this.examineeLastnameTextBox.Location = new System.Drawing.Point(181, 103);
            this.examineeLastnameTextBox.Name = "examineeLastnameTextBox";
            this.examineeLastnameTextBox.Size = new System.Drawing.Size(220, 22);
            this.examineeLastnameTextBox.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddModifyexaminee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(examineeEmailLabel);
            this.Controls.Add(this.examineeEmailTextBox);
            this.Controls.Add(examineeFirstnameLabel);
            this.Controls.Add(this.examineeFirstnameTextBox);
            this.Controls.Add(examineeIDLabel);
            this.Controls.Add(this.examineeIDTextBox);
            this.Controls.Add(examineeLastnameLabel);
            this.Controls.Add(this.examineeLastnameTextBox);
            this.Name = "frmAddModifyexaminee";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmAddModifyexaminee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examineeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource examineeBindingSource;
        private System.Windows.Forms.TextBox examineeEmailTextBox;
        private System.Windows.Forms.TextBox examineeFirstnameTextBox;
        private System.Windows.Forms.TextBox examineeIDTextBox;
        private System.Windows.Forms.TextBox examineeLastnameTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}