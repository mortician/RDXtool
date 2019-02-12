namespace RDXtool
{
    partial class Frm_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Mnu_Main = new System.Windows.Forms.MenuStrip();
            this.Mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_File_Dummy_0 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_File_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Bar_Tool = new System.Windows.Forms.ToolStrip();
            this.Bar_Status = new System.Windows.Forms.StatusStrip();
            this.Lbl_Size = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_File = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dlg_Open_Files = new System.Windows.Forms.OpenFileDialog();
            this.Tab_Strip = new System.Windows.Forms.TabControl();
            this.Tab_Header = new System.Windows.Forms.TabPage();
            this.Lst_Header = new System.Windows.Forms.ListView();
            this.Clm_Header_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tab_TEX = new System.Windows.Forms.TabPage();
            this.Lst_TEX = new System.Windows.Forms.ListView();
            this.Clm_Idx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_TEX_Offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_TEX_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_TEX_Format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tab_MDL = new System.Windows.Forms.TabPage();
            this.Lst_MDL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lst_Log = new System.Windows.Forms.ListBox();
            this.Dlg_Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_Open_File = new System.Windows.Forms.ToolStripButton();
            this.Clm_Header_Offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Header_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Header_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mnu_Main.SuspendLayout();
            this.Bar_Tool.SuspendLayout();
            this.Bar_Status.SuspendLayout();
            this.Tab_Strip.SuspendLayout();
            this.Tab_Header.SuspendLayout();
            this.Tab_TEX.SuspendLayout();
            this.Tab_MDL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Main
            // 
            this.Mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File});
            this.Mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Main.Name = "Mnu_Main";
            this.Mnu_Main.Size = new System.Drawing.Size(1110, 24);
            this.Mnu_Main.TabIndex = 2;
            this.Mnu_Main.Text = "menuStrip1";
            // 
            // Mnu_File
            // 
            this.Mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File_Open,
            this.Mnu_File_Dummy_0,
            this.Mnu_File_Quit});
            this.Mnu_File.Name = "Mnu_File";
            this.Mnu_File.Size = new System.Drawing.Size(35, 20);
            this.Mnu_File.Text = "File";
            // 
            // Mnu_File_Open
            // 
            this.Mnu_File_Open.Image = ((System.Drawing.Image)(resources.GetObject("Mnu_File_Open.Image")));
            this.Mnu_File_Open.Name = "Mnu_File_Open";
            this.Mnu_File_Open.Size = new System.Drawing.Size(152, 22);
            this.Mnu_File_Open.Text = "Open...";
            // 
            // Mnu_File_Dummy_0
            // 
            this.Mnu_File_Dummy_0.Name = "Mnu_File_Dummy_0";
            this.Mnu_File_Dummy_0.Size = new System.Drawing.Size(149, 6);
            // 
            // Mnu_File_Quit
            // 
            this.Mnu_File_Quit.Name = "Mnu_File_Quit";
            this.Mnu_File_Quit.Size = new System.Drawing.Size(152, 22);
            this.Mnu_File_Quit.Text = "Quit";
            // 
            // Bar_Tool
            // 
            this.Bar_Tool.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Bar_Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Open_File});
            this.Bar_Tool.Location = new System.Drawing.Point(0, 24);
            this.Bar_Tool.Name = "Bar_Tool";
            this.Bar_Tool.Size = new System.Drawing.Size(1110, 31);
            this.Bar_Tool.TabIndex = 3;
            this.Bar_Tool.Text = "toolStrip1";
            // 
            // Bar_Status
            // 
            this.Bar_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Size,
            this.Lbl_File});
            this.Bar_Status.Location = new System.Drawing.Point(0, 622);
            this.Bar_Status.Name = "Bar_Status";
            this.Bar_Status.ShowItemToolTips = true;
            this.Bar_Status.Size = new System.Drawing.Size(1110, 24);
            this.Bar_Status.SizingGrip = false;
            this.Bar_Status.TabIndex = 6;
            this.Bar_Status.Text = "statusStrip1";
            // 
            // Lbl_Size
            // 
            this.Lbl_Size.AutoSize = false;
            this.Lbl_Size.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Lbl_Size.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.Lbl_Size.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Size.Name = "Lbl_Size";
            this.Lbl_Size.Size = new System.Drawing.Size(67, 19);
            this.Lbl_Size.ToolTipText = "Filesize";
            // 
            // Lbl_File
            // 
            this.Lbl_File.AutoSize = false;
            this.Lbl_File.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Lbl_File.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.Lbl_File.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_File.Name = "Lbl_File";
            this.Lbl_File.Size = new System.Drawing.Size(600, 19);
            this.Lbl_File.ToolTipText = "Filepath";
            // 
            // Dlg_Open_Files
            // 
            this.Dlg_Open_Files.Filter = "RDX Files |*.*";
            // 
            // Tab_Strip
            // 
            this.Tab_Strip.Controls.Add(this.Tab_Header);
            this.Tab_Strip.Controls.Add(this.Tab_TEX);
            this.Tab_Strip.Controls.Add(this.Tab_MDL);
            this.Tab_Strip.Location = new System.Drawing.Point(4, 61);
            this.Tab_Strip.Name = "Tab_Strip";
            this.Tab_Strip.SelectedIndex = 0;
            this.Tab_Strip.Size = new System.Drawing.Size(659, 558);
            this.Tab_Strip.TabIndex = 7;
            // 
            // Tab_Header
            // 
            this.Tab_Header.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_Header.Controls.Add(this.Lst_Header);
            this.Tab_Header.Location = new System.Drawing.Point(4, 22);
            this.Tab_Header.Name = "Tab_Header";
            this.Tab_Header.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Header.Size = new System.Drawing.Size(651, 532);
            this.Tab_Header.TabIndex = 0;
            this.Tab_Header.Text = "Header";
            // 
            // Lst_Header
            // 
            this.Lst_Header.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clm_Header_Offset,
            this.Clm_Header_Name,
            this.Clm_Header_Value,
            this.Clm_Header_Count});
            this.Lst_Header.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Header.GridLines = true;
            this.Lst_Header.Location = new System.Drawing.Point(6, 6);
            this.Lst_Header.Name = "Lst_Header";
            this.Lst_Header.Size = new System.Drawing.Size(543, 520);
            this.Lst_Header.TabIndex = 2;
            this.Lst_Header.UseCompatibleStateImageBehavior = false;
            this.Lst_Header.View = System.Windows.Forms.View.Details;
            // 
            // Clm_Header_Name
            // 
            this.Clm_Header_Name.Text = "Data";
            this.Clm_Header_Name.Width = 96;
            // 
            // Tab_TEX
            // 
            this.Tab_TEX.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_TEX.Controls.Add(this.Lst_TEX);
            this.Tab_TEX.Location = new System.Drawing.Point(4, 22);
            this.Tab_TEX.Name = "Tab_TEX";
            this.Tab_TEX.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_TEX.Size = new System.Drawing.Size(651, 426);
            this.Tab_TEX.TabIndex = 1;
            this.Tab_TEX.Text = "Textures";
            // 
            // Lst_TEX
            // 
            this.Lst_TEX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clm_Idx,
            this.Clm_TEX_Offset,
            this.Clm_TEX_Size,
            this.Clm_TEX_Format});
            this.Lst_TEX.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_TEX.GridLines = true;
            this.Lst_TEX.Location = new System.Drawing.Point(6, 6);
            this.Lst_TEX.Name = "Lst_TEX";
            this.Lst_TEX.Size = new System.Drawing.Size(289, 417);
            this.Lst_TEX.TabIndex = 3;
            this.Lst_TEX.UseCompatibleStateImageBehavior = false;
            this.Lst_TEX.View = System.Windows.Forms.View.Details;
            // 
            // Clm_Idx
            // 
            this.Clm_Idx.Text = "Index";
            // 
            // Clm_TEX_Offset
            // 
            this.Clm_TEX_Offset.Text = "Offset";
            this.Clm_TEX_Offset.Width = 80;
            // 
            // Clm_TEX_Size
            // 
            this.Clm_TEX_Size.Text = "Size";
            this.Clm_TEX_Size.Width = 80;
            // 
            // Clm_TEX_Format
            // 
            this.Clm_TEX_Format.Text = "Format";
            // 
            // Tab_MDL
            // 
            this.Tab_MDL.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_MDL.Controls.Add(this.Lst_MDL);
            this.Tab_MDL.Location = new System.Drawing.Point(4, 22);
            this.Tab_MDL.Name = "Tab_MDL";
            this.Tab_MDL.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_MDL.Size = new System.Drawing.Size(299, 426);
            this.Tab_MDL.TabIndex = 2;
            this.Tab_MDL.Text = "Models";
            // 
            // Lst_MDL
            // 
            this.Lst_MDL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lst_MDL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_MDL.GridLines = true;
            this.Lst_MDL.Location = new System.Drawing.Point(6, 6);
            this.Lst_MDL.Name = "Lst_MDL";
            this.Lst_MDL.Size = new System.Drawing.Size(289, 417);
            this.Lst_MDL.TabIndex = 4;
            this.Lst_MDL.UseCompatibleStateImageBehavior = false;
            this.Lst_MDL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Offset";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Format";
            // 
            // Lst_Log
            // 
            this.Lst_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Lst_Log.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Log.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lst_Log.FormattingEnabled = true;
            this.Lst_Log.ItemHeight = 14;
            this.Lst_Log.Location = new System.Drawing.Point(757, 52);
            this.Lst_Log.Name = "Lst_Log";
            this.Lst_Log.Size = new System.Drawing.Size(341, 452);
            this.Lst_Log.TabIndex = 8;
            // 
            // Btn_Open_File
            // 
            this.Btn_Open_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Open_File.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Open_File.Image")));
            this.Btn_Open_File.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Open_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Open_File.Name = "Btn_Open_File";
            this.Btn_Open_File.Size = new System.Drawing.Size(28, 28);
            this.Btn_Open_File.Text = "toolStripButton1";
            this.Btn_Open_File.Click += new System.EventHandler(this.Btn_Open_File_Click);
            // 
            // Clm_Header_Offset
            // 
            this.Clm_Header_Offset.Text = "Offset";
            this.Clm_Header_Offset.Width = 64;
            // 
            // Clm_Header_Value
            // 
            this.Clm_Header_Value.Text = "Value";
            this.Clm_Header_Value.Width = 96;
            // 
            // Clm_Header_Count
            // 
            this.Clm_Header_Count.Text = "Objects";
            this.Clm_Header_Count.Width = 96;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 646);
            this.Controls.Add(this.Lst_Log);
            this.Controls.Add(this.Tab_Strip);
            this.Controls.Add(this.Bar_Status);
            this.Controls.Add(this.Bar_Tool);
            this.Controls.Add(this.Mnu_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mnu_Main;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDXtool";
            this.Mnu_Main.ResumeLayout(false);
            this.Mnu_Main.PerformLayout();
            this.Bar_Tool.ResumeLayout(false);
            this.Bar_Tool.PerformLayout();
            this.Bar_Status.ResumeLayout(false);
            this.Bar_Status.PerformLayout();
            this.Tab_Strip.ResumeLayout(false);
            this.Tab_Header.ResumeLayout(false);
            this.Tab_TEX.ResumeLayout(false);
            this.Tab_MDL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Main;
        private System.Windows.Forms.ToolStrip Bar_Tool;
        private System.Windows.Forms.StatusStrip Bar_Status;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Open;
        private System.Windows.Forms.OpenFileDialog Dlg_Open_Files;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Size;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_File;
        private System.Windows.Forms.ToolStripSeparator Mnu_File_Dummy_0;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File_Quit;
        private System.Windows.Forms.TabControl Tab_Strip;
        private System.Windows.Forms.TabPage Tab_Header;
        private System.Windows.Forms.TabPage Tab_TEX;
        private System.Windows.Forms.ListView Lst_TEX;
        private System.Windows.Forms.ColumnHeader Clm_Idx;
        private System.Windows.Forms.ColumnHeader Clm_TEX_Offset;
        private System.Windows.Forms.ColumnHeader Clm_TEX_Size;
        private System.Windows.Forms.ListView Lst_Header;
        private System.Windows.Forms.ColumnHeader Clm_Header_Name;
        private System.Windows.Forms.ListBox Lst_Log;
        private System.Windows.Forms.ColumnHeader Clm_TEX_Format;
        private System.Windows.Forms.TabPage Tab_MDL;
        private System.Windows.Forms.ListView Lst_MDL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FolderBrowserDialog Dlg_Folder;
        private System.Windows.Forms.ToolStripButton Btn_Open_File;
        private System.Windows.Forms.ColumnHeader Clm_Header_Offset;
        private System.Windows.Forms.ColumnHeader Clm_Header_Value;
        private System.Windows.Forms.ColumnHeader Clm_Header_Count;
    }
}

