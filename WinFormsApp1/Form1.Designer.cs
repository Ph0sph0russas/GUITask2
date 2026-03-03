namespace WinFormsApp1
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
            firstWordLabel = new TextBox();
            secondWordLabel = new TextBox();
            checkSameElementsButton = new Button();
            SuspendLayout();
            // 
            // firstWordLabel
            // 
            firstWordLabel.Location = new Point(76, 58);
            firstWordLabel.Name = "firstWordLabel";
            firstWordLabel.Size = new Size(100, 23);
            firstWordLabel.TabIndex = 0;
            firstWordLabel.Text = "Первое слово";
            // 
            // secondWordLabel
            // 
            secondWordLabel.Location = new Point(76, 87);
            secondWordLabel.Name = "secondWordLabel";
            secondWordLabel.Size = new Size(100, 23);
            secondWordLabel.TabIndex = 1;
            secondWordLabel.Text = "Второе слово";
            // 
            // checkSameElementsButton
            // 
            checkSameElementsButton.Location = new Point(48, 116);
            checkSameElementsButton.Name = "checkSameElementsButton";
            checkSameElementsButton.Size = new Size(161, 23);
            checkSameElementsButton.TabIndex = 2;
            checkSameElementsButton.Text = "Проверить схожие буквы";
            checkSameElementsButton.UseVisualStyleBackColor = true;
            checkSameElementsButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 209);
            Controls.Add(checkSameElementsButton);
            Controls.Add(secondWordLabel);
            Controls.Add(firstWordLabel);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstWordLabel;
        private TextBox secondWordLabel;
        private Button checkSameElementsButton;
    }
}
