namespace Practice1
{
    partial class PraticeCalcu
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
            btnCalculate = new Button();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            panel1 = new Panel();
            txtOperator = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnCA = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnCalculate.Location = new Point(63, 366);
            btnCalculate.Margin = new Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(65, 46);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(63, 75);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(350, 26);
            txtFirstNumber.TabIndex = 1;
            txtFirstNumber.TextChanged += txtFirstNumber_TextChanged;
            txtFirstNumber.KeyPress += txtFirstNumber_KeyPress;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(63, 203);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(350, 26);
            txtSecondNumber.TabIndex = 2;
            txtSecondNumber.KeyPress += txtSecondNumber_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 54);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 3;
            label1.Text = "First Number: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 182);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 4;
            label2.Text = "Second Number: ";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.Location = new Point(25, 13);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(22, 24);
            lblResult.TabIndex = 6;
            lblResult.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(lblResult);
            panel1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(63, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 44);
            panel1.TabIndex = 7;
            // 
            // txtOperator
            // 
            txtOperator.BackColor = SystemColors.ControlDark;
            txtOperator.BorderStyle = BorderStyle.FixedSingle;
            txtOperator.Cursor = Cursors.No;
            txtOperator.Location = new Point(176, 131);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(115, 26);
            txtOperator.TabIndex = 9;
            txtOperator.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnAdd.Location = new Point(63, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 47);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnSub.Location = new Point(134, 312);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(65, 47);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnMulti.Location = new Point(205, 312);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(65, 47);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnDiv.Location = new Point(277, 312);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(65, 47);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(209, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(65, 46);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCA
            // 
            btnCA.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnCA.Location = new Point(138, 365);
            btnCA.Name = "btnCA";
            btnCA.Size = new Size(65, 47);
            btnCA.TabIndex = 15;
            btnCA.Text = "CA";
            btnCA.UseVisualStyleBackColor = true;
            btnCA.Click += btnCA_Click;
            // 
            // PraticeCalcu
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(471, 458);
            Controls.Add(btnCA);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtOperator);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(btnCalculate);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PraticeCalcu";
            Text = "Form1";
            Load += PraticeCalcu_Load;
            KeyPress += PraticeCalcu_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Panel panel1;
        private TextBox txtOperator;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMulti;
        private Button btnDiv;
        private Button btnClear;
        private Button btnCA;
    }
}
