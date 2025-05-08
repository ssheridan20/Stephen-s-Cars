namespace Stephen_s_Cars
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
            lblType = new Label();
            lblName = new Label();
            lblMPG = new Label();
            txtName = new TextBox();
            cboTypes = new ComboBox();
            btnAdd = new Button();
            cboMPG = new ComboBox();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(62, 35);
            lblType.Name = "lblType";
            lblType.Size = new Size(52, 15);
            lblType.TabIndex = 0;
            lblType.Text = "Car Type";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(54, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Car Name";
            // 
            // lblMPG
            // 
            lblMPG.AutoSize = true;
            lblMPG.Location = new Point(81, 110);
            lblMPG.Name = "lblMPG";
            lblMPG.Size = new Size(33, 15);
            lblMPG.TabIndex = 2;
            lblMPG.Text = "MPG";
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 3;
            // 
            // cboTypes
            // 
            cboTypes.FormattingEnabled = true;
            cboTypes.Location = new Point(145, 32);
            cboTypes.Name = "cboTypes";
            cboTypes.Size = new Size(121, 23);
            cboTypes.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(110, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboMPG
            // 
            cboMPG.FormattingEnabled = true;
            cboMPG.Location = new Point(145, 107);
            cboMPG.Name = "cboMPG";
            cboMPG.Size = new Size(121, 23);
            cboMPG.TabIndex = 8;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(54, 181);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(212, 154);
            lstOut.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 347);
            Controls.Add(lstOut);
            Controls.Add(cboMPG);
            Controls.Add(btnAdd);
            Controls.Add(cboTypes);
            Controls.Add(txtName);
            Controls.Add(lblMPG);
            Controls.Add(lblName);
            Controls.Add(lblType);
            Name = "Form1";
            Text = "Sheridan's Cars";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private Label lblName;
        private Label lblMPG;
        private TextBox txtName;
        private ComboBox cboTypes;
        private Button btnAdd;
        private ComboBox cboMPG;
        private ListBox lstOut;
    }
}