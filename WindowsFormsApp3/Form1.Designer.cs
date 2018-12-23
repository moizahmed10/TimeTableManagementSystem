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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchTeacherBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.matchTeacherBatchToolStripMenuItem});
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
            this.byTeacherToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.byTeacherToolStripMenuItem.Text = "By Teacher";
            this.byTeacherToolStripMenuItem.Click += new System.EventHandler(this.byTeacherToolStripMenuItem_Click);
            // 
            // byCourseToolStripMenuItem
            // 
            this.byCourseToolStripMenuItem.Name = "byCourseToolStripMenuItem";
            this.byCourseToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.byCourseToolStripMenuItem.Text = "By Course";
            this.byCourseToolStripMenuItem.Click += new System.EventHandler(this.byCourseToolStripMenuItem_Click);
            // 
            // byBatchToolStripMenuItem
            // 
            this.byBatchToolStripMenuItem.Name = "byBatchToolStripMenuItem";
            this.byBatchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.byBatchToolStripMenuItem.Text = "By Batch";
            this.byBatchToolStripMenuItem.Click += new System.EventHandler(this.byBatchToolStripMenuItem_Click);
            // 
            // matchTeacherBatchToolStripMenuItem
            // 
            this.matchTeacherBatchToolStripMenuItem.Name = "matchTeacherBatchToolStripMenuItem";
            this.matchTeacherBatchToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.matchTeacherBatchToolStripMenuItem.Text = "Match Teacher & Batch";
            this.matchTeacherBatchToolStripMenuItem.Click += new System.EventHandler(this.matchTeacherBatchToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScheduleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openScheduleToolStripMenuItem
            // 
            this.openScheduleToolStripMenuItem.Name = "openScheduleToolStripMenuItem";
            this.openScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openScheduleToolStripMenuItem.Text = "Open Schedule...";
            this.openScheduleToolStripMenuItem.Click += new System.EventHandler(this.openScheduleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "IIUI - Timetable Application";
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchTeacherBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

