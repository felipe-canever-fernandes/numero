namespace Numero
{
    partial class Main
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
            this.counterLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(0, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(181, 31);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "0";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(79, 43);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 1;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 81);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.counterLabel);
            this.Name = "Main";
            this.Text = "Numero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button plusButton;
    }
}

