namespace WindowsFormsApp3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSearcchTeacher = new System.Windows.Forms.Button();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSearcchTeacher
            // 
            this.btnSearcchTeacher.Location = new System.Drawing.Point(216, 31);
            this.btnSearcchTeacher.Name = "btnSearcchTeacher";
            this.btnSearcchTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnSearcchTeacher.TabIndex = 3;
            this.btnSearcchTeacher.Text = "Search";
            this.btnSearcchTeacher.UseVisualStyleBackColor = true;
            this.btnSearcchTeacher.Click += new System.EventHandler(this.btnSearcchTeacher_Click);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(105, 32);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(100, 20);
            this.txtTeacherName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher Name:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byTeacherToolStripMenuItem,
            this.byCourseToolStripMenuItem,
            this.byBatchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byTeacherToolStripMenuItem
            // 
            this.byTeacherToolStripMenuItem.Name = "byTeacherToolStripMenuItem";
            this.byTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byTeacherToolStripMenuItem.Text = "By Teacher";
            this.byTeacherToolStripMenuItem.Click += new System.EventHandler(this.byTeacherToolStripMenuItem_Click);
            // 
            // byCourseToolStripMenuItem
            // 
            this.byCourseToolStripMenuItem.Name = "byCourseToolStripMenuItem";
            this.byCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byCourseToolStripMenuItem.Text = "By Course";
            this.byCourseToolStripMenuItem.Click += new System.EventHandler(this.byCourseToolStripMenuItem_Click);
            // 
            // byBatchToolStripMenuItem
            // 
            this.byBatchToolStripMenuItem.Name = "byBatchToolStripMenuItem";
            this.byBatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byBatchToolStripMenuItem.Text = "By Batch";
            this.byBatchToolStripMenuItem.Click += new System.EventHandler(this.byBatchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.btnSearcchTeacher);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSearcchTeacher;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBatchToolStripMenuItem;
    }
}

