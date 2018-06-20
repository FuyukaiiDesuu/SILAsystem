namespace MainSystem
{
    partial class frmAccount
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.grpStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(641, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(878, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtStudentName);
            this.grpStudentDetails.Controls.Add(this.lblStudentName);
            this.grpStudentDetails.Controls.Add(this.txtID);
            this.grpStudentDetails.Controls.Add(this.lblID);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 274);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(940, 106);
            this.grpStudentDetails.TabIndex = 4;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(16, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(115, 66);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(180, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(16, 66);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(93, 16);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 683);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Management";
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
    }
}