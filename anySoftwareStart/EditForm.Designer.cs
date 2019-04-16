namespace anySoftwareStart
{
    partial class EditForm
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
            this.PathListBox = new System.Windows.Forms.ListBox();
            this.NewPath = new System.Windows.Forms.Button();
            this.DeletePath = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // PathListBox
            // 
            this.PathListBox.FormattingEnabled = true;
            this.PathListBox.ItemHeight = 12;
            this.PathListBox.Location = new System.Drawing.Point(12, 12);
            this.PathListBox.Name = "PathListBox";
            this.PathListBox.Size = new System.Drawing.Size(350, 400);
            this.PathListBox.TabIndex = 0;
            // 
            // NewPath
            // 
            this.NewPath.Location = new System.Drawing.Point(369, 13);
            this.NewPath.Name = "NewPath";
            this.NewPath.Size = new System.Drawing.Size(103, 23);
            this.NewPath.TabIndex = 1;
            this.NewPath.Text = "新　規";
            this.NewPath.UseVisualStyleBackColor = true;
            this.NewPath.Click += new System.EventHandler(this.NewPath_Click);
            // 
            // DeletePath
            // 
            this.DeletePath.Location = new System.Drawing.Point(369, 43);
            this.DeletePath.Name = "DeletePath";
            this.DeletePath.Size = new System.Drawing.Size(103, 23);
            this.DeletePath.TabIndex = 2;
            this.DeletePath.Text = "消　去";
            this.DeletePath.UseVisualStyleBackColor = true;
            this.DeletePath.Click += new System.EventHandler(this.DeletePath_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(369, 426);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(103, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(260, 426);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(103, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "O　K";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "実行ファイル(*.exe;*.EXE)|*.exe;*.EXE|すべてのファイル(*.*)|*.*";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DeletePath);
            this.Controls.Add(this.NewPath);
            this.Controls.Add(this.PathListBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PathListBox;
        private System.Windows.Forms.Button NewPath;
        private System.Windows.Forms.Button DeletePath;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}