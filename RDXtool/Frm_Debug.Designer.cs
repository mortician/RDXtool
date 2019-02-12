namespace RDXtool
{
    partial class Frm_Debug
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
            this.Lst_Result = new System.Windows.Forms.ListBox();
            this.Btn_Test = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lst_Result
            // 
            this.Lst_Result.FormattingEnabled = true;
            this.Lst_Result.Location = new System.Drawing.Point(13, 13);
            this.Lst_Result.Name = "Lst_Result";
            this.Lst_Result.Size = new System.Drawing.Size(608, 628);
            this.Lst_Result.TabIndex = 0;
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(1341, 13);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(75, 23);
            this.Btn_Test.TabIndex = 1;
            this.Btn_Test.Text = "button1";
            this.Btn_Test.UseVisualStyleBackColor = true;
            this.Btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(627, 13);
            this.Txt_Result.Multiline = true;
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Result.Size = new System.Drawing.Size(578, 628);
            this.Txt_Result.TabIndex = 2;
            // 
            // Frm_Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 647);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.Lst_Result);
            this.Name = "Frm_Debug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_Result;
        private System.Windows.Forms.Button Btn_Test;
        private System.Windows.Forms.TextBox Txt_Result;
    }
}