namespace CS_DemoFileIO
{
    partial class frmFiles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtData = new TextBox();
            groupBoxBinaryFiles = new GroupBox();
            btnBinaryRead = new Button();
            btnBinaryWrite = new Button();
            groupBoxTextFiles = new GroupBox();
            btnTextRead = new Button();
            btnTextWrite = new Button();
            groupBoxBinaryFiles.SuspendLayout();
            groupBoxTextFiles.SuspendLayout();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Location = new Point(0, 0);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.ScrollBars = ScrollBars.Both;
            txtData.Size = new Size(799, 203);
            txtData.TabIndex = 0;
            // 
            // groupBoxBinaryFiles
            // 
            groupBoxBinaryFiles.Controls.Add(btnBinaryRead);
            groupBoxBinaryFiles.Controls.Add(btnBinaryWrite);
            groupBoxBinaryFiles.Location = new Point(0, 209);
            groupBoxBinaryFiles.Name = "groupBoxBinaryFiles";
            groupBoxBinaryFiles.Size = new Size(388, 244);
            groupBoxBinaryFiles.TabIndex = 1;
            groupBoxBinaryFiles.TabStop = false;
            groupBoxBinaryFiles.Text = "Binary Files";
            // 
            // btnBinaryRead
            // 
            btnBinaryRead.Location = new Point(249, 91);
            btnBinaryRead.Name = "btnBinaryRead";
            btnBinaryRead.Size = new Size(75, 23);
            btnBinaryRead.TabIndex = 1;
            btnBinaryRead.Text = "Read";
            btnBinaryRead.UseVisualStyleBackColor = true;
            btnBinaryRead.Click += btnBinaryRead_Click;
            // 
            // btnBinaryWrite
            // 
            btnBinaryWrite.Location = new Point(48, 91);
            btnBinaryWrite.Name = "btnBinaryWrite";
            btnBinaryWrite.Size = new Size(75, 23);
            btnBinaryWrite.TabIndex = 0;
            btnBinaryWrite.Text = "Write";
            btnBinaryWrite.UseVisualStyleBackColor = true;
            btnBinaryWrite.Click += btnBinaryWrite_Click;
            // 
            // groupBoxTextFiles
            // 
            groupBoxTextFiles.Controls.Add(btnTextRead);
            groupBoxTextFiles.Controls.Add(btnTextWrite);
            groupBoxTextFiles.Location = new Point(411, 209);
            groupBoxTextFiles.Name = "groupBoxTextFiles";
            groupBoxTextFiles.Size = new Size(388, 244);
            groupBoxTextFiles.TabIndex = 2;
            groupBoxTextFiles.TabStop = false;
            groupBoxTextFiles.Text = "Text Files";
            // 
            // btnTextRead
            // 
            btnTextRead.Location = new Point(249, 91);
            btnTextRead.Name = "btnTextRead";
            btnTextRead.Size = new Size(75, 23);
            btnTextRead.TabIndex = 1;
            btnTextRead.Text = "Read";
            btnTextRead.UseVisualStyleBackColor = true;
            btnTextRead.Click += btnTextRead_Click;
            // 
            // btnTextWrite
            // 
            btnTextWrite.Location = new Point(48, 91);
            btnTextWrite.Name = "btnTextWrite";
            btnTextWrite.Size = new Size(75, 23);
            btnTextWrite.TabIndex = 0;
            btnTextWrite.Text = "Write";
            btnTextWrite.UseVisualStyleBackColor = true;
            btnTextWrite.Click += btnTextWrite_Click;
            // 
            // frmFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTextFiles);
            Controls.Add(groupBoxBinaryFiles);
            Controls.Add(txtData);
            Name = "frmFiles";
            Text = "FileIO Demo";
            groupBoxBinaryFiles.ResumeLayout(false);
            groupBoxTextFiles.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtData;
        private GroupBox groupBoxBinaryFiles;
        private Button btnBinaryRead;
        private Button btnBinaryWrite;
        private GroupBox groupBoxTextFiles;
        private Button btnTextRead;
        private Button btnTextWrite;
    }
}
