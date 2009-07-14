namespace CompileSomething
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
            this.sourceCodeTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.errorsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sourceCodeTextBox
            // 
            this.sourceCodeTextBox.Location = new System.Drawing.Point(13, 13);
            this.sourceCodeTextBox.Multiline = true;
            this.sourceCodeTextBox.Name = "sourceCodeTextBox";
            this.sourceCodeTextBox.Size = new System.Drawing.Size(729, 169);
            this.sourceCodeTextBox.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(667, 188);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // errorsBox
            // 
            this.errorsBox.Location = new System.Drawing.Point(13, 218);
            this.errorsBox.Multiline = true;
            this.errorsBox.Name = "errorsBox";
            this.errorsBox.Size = new System.Drawing.Size(728, 188);
            this.errorsBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 418);
            this.Controls.Add(this.errorsBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.sourceCodeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceCodeTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox errorsBox;
    }
}

