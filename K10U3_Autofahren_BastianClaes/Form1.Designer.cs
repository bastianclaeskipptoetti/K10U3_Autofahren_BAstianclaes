namespace K10U3
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
            this.strassePanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.langsamerButton = new System.Windows.Forms.Button();
            this.schnellerButton = new System.Windows.Forms.Button();
            this.fahrenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // strassePanel
            //
            this.strassePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.strassePanel.Location = new System.Drawing.Point(12, 12);
            this.strassePanel.Name = "strassePanel";
            this.strassePanel.Size = new System.Drawing.Size(913, 31);
            this.strassePanel.TabIndex = 0;
            //
            // startButton
            //
            this.startButton.Location = new System.Drawing.Point(12, 50);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            //
            // endButton
            //
            this.endButton.Location = new System.Drawing.Point(850, 50);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 2;
            this.endButton.Text = "Beenden";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            //
            // langsamerButton
            //
            this.langsamerButton.Enabled = false;
            this.langsamerButton.Location = new System.Drawing.Point(413, 49);
            this.langsamerButton.Name = "langsamerButton";
            this.langsamerButton.Size = new System.Drawing.Size(75, 23);
            this.langsamerButton.TabIndex = 4;
            this.langsamerButton.Text = "Langsamer";
            this.langsamerButton.UseVisualStyleBackColor = true;
            this.langsamerButton.Click += new System.EventHandler(this.slowerButton_Click);
            //
            // schnellerButton
            //
            this.schnellerButton.Enabled = false;
            this.schnellerButton.Location = new System.Drawing.Point(494, 49);
            this.schnellerButton.Name = "schnellerButton";
            this.schnellerButton.Size = new System.Drawing.Size(75, 23);
            this.schnellerButton.TabIndex = 5;
            this.schnellerButton.Text = "Schneller";
            this.schnellerButton.UseVisualStyleBackColor = true;
            this.schnellerButton.Click += new System.EventHandler(this.fasterButton_Click);
            //
            // fahrenButton
            //
            this.fahrenButton.Enabled = false;
            this.fahrenButton.Location = new System.Drawing.Point(332, 49);
            this.fahrenButton.Name = "fahrenButton";
            this.fahrenButton.Size = new System.Drawing.Size(75, 23);
            this.fahrenButton.TabIndex = 6;
            this.fahrenButton.Text = "Fahren";
            this.fahrenButton.UseVisualStyleBackColor = true;
            this.fahrenButton.Click += new System.EventHandler(this.fahrenButton_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 89);
            this.Controls.Add(this.fahrenButton);
            this.Controls.Add(this.schnellerButton);
            this.Controls.Add(this.langsamerButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.strassePanel);
            this.Name = "Form1";
            this.Text = "Geschwindigkeit: ?";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button langsamerButton;
        private System.Windows.Forms.Button schnellerButton;

        private System.Windows.Forms.Panel strassePanel;

        private System.Windows.Forms.Button fahrenButton;

        private System.Windows.Forms.Button endButton;

        private System.Windows.Forms.Button startButton;

        #endregion
    }
}
