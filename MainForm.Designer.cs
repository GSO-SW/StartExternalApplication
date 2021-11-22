namespace StartExternalApplication
{
    partial class MainForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.SelectApplicationOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectedApplicationLabel = new System.Windows.Forms.Label();
            this.ApplicationPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectApplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(932, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(194, 29);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Application!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SelectApplicationOpenFileDialog
            // 
            this.SelectApplicationOpenFileDialog.Filter = "Ausführbare Dateien|*.exe";
            // 
            // SelectedApplicationLabel
            // 
            this.SelectedApplicationLabel.AutoSize = true;
            this.SelectedApplicationLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectedApplicationLabel.Name = "SelectedApplicationLabel";
            this.SelectedApplicationLabel.Size = new System.Drawing.Size(148, 20);
            this.SelectedApplicationLabel.TabIndex = 1;
            this.SelectedApplicationLabel.Text = "Selected application:";
            // 
            // ApplicationPathTextBox
            // 
            this.ApplicationPathTextBox.Enabled = false;
            this.ApplicationPathTextBox.Location = new System.Drawing.Point(162, 9);
            this.ApplicationPathTextBox.Name = "ApplicationPathTextBox";
            this.ApplicationPathTextBox.Size = new System.Drawing.Size(729, 27);
            this.ApplicationPathTextBox.TabIndex = 2;
            // 
            // SelectApplicationButton
            // 
            this.SelectApplicationButton.Location = new System.Drawing.Point(897, 9);
            this.SelectApplicationButton.Name = "SelectApplicationButton";
            this.SelectApplicationButton.Size = new System.Drawing.Size(29, 29);
            this.SelectApplicationButton.TabIndex = 3;
            this.SelectApplicationButton.Text = "...";
            this.SelectApplicationButton.UseVisualStyleBackColor = true;
            this.SelectApplicationButton.Click += new System.EventHandler(this.SelectApplicationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 48);
            this.Controls.Add(this.SelectApplicationButton);
            this.Controls.Add(this.ApplicationPathTextBox);
            this.Controls.Add(this.SelectedApplicationLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "Application Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private OpenFileDialog SelectApplicationOpenFileDialog;
        private Label SelectedApplicationLabel;
        private TextBox ApplicationPathTextBox;
        private Button SelectApplicationButton;
    }
}