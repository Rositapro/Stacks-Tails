namespace StacksTails
{
    partial class Menu
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
            btnStack = new Button();
            btnTail = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStack
            // 
            btnStack.Location = new Point(181, 128);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(75, 23);
            btnStack.TabIndex = 0;
            btnStack.Text = "Stack";
            btnStack.UseVisualStyleBackColor = true;
            btnStack.Click += btnStack_Click;
            // 
            // btnTail
            // 
            btnTail.Location = new Point(181, 157);
            btnTail.Name = "btnTail";
            btnTail.Size = new Size(75, 23);
            btnTail.TabIndex = 1;
            btnTail.Text = "Tail";
            btnTail.UseVisualStyleBackColor = true;
            btnTail.Click += btnTail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 89);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 2;
            label1.Text = "Choose the option you want";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 311);
            Controls.Add(label1);
            Controls.Add(btnTail);
            Controls.Add(btnStack);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStack;
        private Button btnTail;
        private Label label1;
    }
}