namespace CS_DemoSerialization
{
    partial class frmPerson
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
            lblId = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            txtDateOfBirth = new TextBox();
            lblDob = new Label();
            groupBoxBinary = new GroupBox();
            btnBinaryDeserialize = new Button();
            btnBinarySerialize = new Button();
            txtAge = new TextBox();
            lblAge = new Label();
            groupBoxXml = new GroupBox();
            btnXmlDeserialize = new Button();
            btnXmlSerialize = new Button();
            groupBoxJson = new GroupBox();
            btnJsonDeserialize = new Button();
            btnJsonSerialize = new Button();
            groupBoxBinary.SuspendLayout();
            groupBoxXml.SuspendLayout();
            groupBoxJson.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(48, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(48, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(118, 102);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(100, 23);
            txtDateOfBirth.TabIndex = 5;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(48, 105);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(73, 15);
            lblDob.TabIndex = 4;
            lblDob.Text = "Date of Birth";
            // 
            // groupBoxBinary
            // 
            groupBoxBinary.Controls.Add(btnBinaryDeserialize);
            groupBoxBinary.Controls.Add(btnBinarySerialize);
            groupBoxBinary.Location = new Point(26, 183);
            groupBoxBinary.Name = "groupBoxBinary";
            groupBoxBinary.Size = new Size(223, 67);
            groupBoxBinary.TabIndex = 6;
            groupBoxBinary.TabStop = false;
            groupBoxBinary.Text = "Binary";
            // 
            // btnBinaryDeserialize
            // 
            btnBinaryDeserialize.Location = new Point(142, 22);
            btnBinaryDeserialize.Name = "btnBinaryDeserialize";
            btnBinaryDeserialize.Size = new Size(75, 23);
            btnBinaryDeserialize.TabIndex = 1;
            btnBinaryDeserialize.Text = "Desrialize";
            btnBinaryDeserialize.UseVisualStyleBackColor = true;
            btnBinaryDeserialize.Click += btnBinaryDeserialize_Click;
            // 
            // btnBinarySerialize
            // 
            btnBinarySerialize.Location = new Point(6, 22);
            btnBinarySerialize.Name = "btnBinarySerialize";
            btnBinarySerialize.Size = new Size(75, 23);
            btnBinarySerialize.TabIndex = 0;
            btnBinarySerialize.Text = "Serialize";
            btnBinarySerialize.UseVisualStyleBackColor = true;
            btnBinarySerialize.Click += btnBinarySerialize_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(118, 141);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(48, 144);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age";
            // 
            // groupBoxXml
            // 
            groupBoxXml.Controls.Add(btnXmlDeserialize);
            groupBoxXml.Controls.Add(btnXmlSerialize);
            groupBoxXml.Location = new Point(26, 266);
            groupBoxXml.Name = "groupBoxXml";
            groupBoxXml.Size = new Size(223, 67);
            groupBoxXml.TabIndex = 7;
            groupBoxXml.TabStop = false;
            groupBoxXml.Text = "Xml";
            // 
            // btnXmlDeserialize
            // 
            btnXmlDeserialize.Location = new Point(142, 22);
            btnXmlDeserialize.Name = "btnXmlDeserialize";
            btnXmlDeserialize.Size = new Size(75, 23);
            btnXmlDeserialize.TabIndex = 1;
            btnXmlDeserialize.Text = "Desrialize";
            btnXmlDeserialize.UseVisualStyleBackColor = true;
            btnXmlDeserialize.Click += btnXmlDeserialize_Click;
            // 
            // btnXmlSerialize
            // 
            btnXmlSerialize.Location = new Point(6, 22);
            btnXmlSerialize.Name = "btnXmlSerialize";
            btnXmlSerialize.Size = new Size(75, 23);
            btnXmlSerialize.TabIndex = 0;
            btnXmlSerialize.Text = "Serialize";
            btnXmlSerialize.UseVisualStyleBackColor = true;
            btnXmlSerialize.Click += btnXmlSerialize_Click;
            // 
            // groupBoxJson
            // 
            groupBoxJson.Controls.Add(btnJsonDeserialize);
            groupBoxJson.Controls.Add(btnJsonSerialize);
            groupBoxJson.Location = new Point(26, 352);
            groupBoxJson.Name = "groupBoxJson";
            groupBoxJson.Size = new Size(223, 67);
            groupBoxJson.TabIndex = 8;
            groupBoxJson.TabStop = false;
            groupBoxJson.Text = "Json";
            // 
            // btnJsonDeserialize
            // 
            btnJsonDeserialize.Location = new Point(142, 22);
            btnJsonDeserialize.Name = "btnJsonDeserialize";
            btnJsonDeserialize.Size = new Size(75, 23);
            btnJsonDeserialize.TabIndex = 1;
            btnJsonDeserialize.Text = "Desrialize";
            btnJsonDeserialize.UseVisualStyleBackColor = true;
            btnJsonDeserialize.Click += btnJsonDeserialize_Click;
            // 
            // btnJsonSerialize
            // 
            btnJsonSerialize.Location = new Point(6, 22);
            btnJsonSerialize.Name = "btnJsonSerialize";
            btnJsonSerialize.Size = new Size(75, 23);
            btnJsonSerialize.TabIndex = 0;
            btnJsonSerialize.Text = "Serialize";
            btnJsonSerialize.UseVisualStyleBackColor = true;
            btnJsonSerialize.Click += btnJsonSerialize_Click;
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 450);
            Controls.Add(groupBoxJson);
            Controls.Add(groupBoxXml);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(groupBoxBinary);
            Controls.Add(txtDateOfBirth);
            Controls.Add(lblDob);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "frmPerson";
            Text = "Serialization Demo";
            groupBoxBinary.ResumeLayout(false);
            groupBoxXml.ResumeLayout(false);
            groupBoxJson.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtDateOfBirth;
        private Label lblDob;
        private GroupBox groupBoxBinary;
        private Button btnBinaryDeserialize;
        private Button btnBinarySerialize;
        private TextBox txtAge;
        private Label lblAge;
        private GroupBox groupBoxXml;
        private Button btnXmlDeserialize;
        private Button btnXmlSerialize;
        private GroupBox groupBoxJson;
        private Button btnJsonDeserialize;
        private Button btnJsonSerialize;
    }
}
