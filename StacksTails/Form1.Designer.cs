namespace StacksTails
{
    partial class FormStack
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
            label1 = new Label();
            lstStack = new ListBox();
            txtNumber = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            btnShow = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 64);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a number";
            // 
            // lstStack
            // 
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 15;
            lstStack.Location = new Point(280, 60);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(120, 94);
            lstStack.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(93, 60);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 3;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(199, 60);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(199, 89);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 4;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(199, 118);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 163);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FormStack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnShow);
            Controls.Add(btnPop);
            Controls.Add(txtNumber);
            Controls.Add(btnPush);
            Controls.Add(lstStack);
            Controls.Add(label1);
            Name = "FormStack";
            Text = "FormStack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstStack;
        private TextBox txtNumber;
        private Button btnPush;
        private Button btnPop;
        private Button btnShow;
        private Button btnReturn;
    }
}
