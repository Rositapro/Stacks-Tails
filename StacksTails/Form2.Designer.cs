namespace StacksTails
{
    partial class FormTail
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
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnShow = new Button();
            txtNumber = new TextBox();
            label1 = new Label();
            lstTail = new ListBox();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(221, 47);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(221, 76);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 1;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(221, 105);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(102, 47);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter a number";
            // 
            // lstTail
            // 
            lstTail.FormattingEnabled = true;
            lstTail.ItemHeight = 15;
            lstTail.Location = new Point(320, 47);
            lstTail.Name = "lstTail";
            lstTail.Size = new Size(120, 94);
            lstTail.TabIndex = 5;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 172);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // FormTail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(lstTail);
            Controls.Add(label1);
            Controls.Add(txtNumber);
            Controls.Add(btnShow);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Name = "FormTail";
            Text = "FormTail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnShow;
        private TextBox txtNumber;
        private Label label1;
        private ListBox lstTail;
        private Button btnReturn;
    }
}