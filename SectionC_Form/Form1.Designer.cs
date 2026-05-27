namespace SectionC_Form
{
    partial class Form1
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
            lblOutput = new Label();
            lblCode = new Label();
            lblMake = new Label();
            lblQuantity = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(354, 26);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 0;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(254, 114);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(78, 15);
            lblCode.TabIndex = 1;
            lblCode.Text = "Mobile Code:";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(254, 178);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 2;
            lblMake.Text = "Make:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(254, 240);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(134, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(354, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(574, 376);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 6;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(394, 111);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(171, 23);
            txtCode.TabIndex = 7;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(394, 175);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(171, 23);
            txtMake.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(394, 237);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(171, 23);
            txtQuantity.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblQuantity);
            Controls.Add(lblMake);
            Controls.Add(lblCode);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label lblCode;
        private Label lblMake;
        private Label lblQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
    }
}
