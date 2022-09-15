namespace PlayGame
{
    partial class formLabel1
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
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.numberLabel2 = new System.Windows.Forms.Label();
            this.numberLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Green;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkMagenta;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(268, 307);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(236, 84);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.buttonLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(140, 137);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(515, 86);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Game Of Sounds";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel1
            // 
            this.numberLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel1.Location = new System.Drawing.Point(568, 361);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(87, 68);
            this.numberLabel1.TabIndex = 2;
            this.numberLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel2
            // 
            this.numberLabel2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel2.Location = new System.Drawing.Point(351, 31);
            this.numberLabel2.Name = "numberLabel2";
            this.numberLabel2.Size = new System.Drawing.Size(153, 68);
            this.numberLabel2.TabIndex = 3;
            this.numberLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel3
            // 
            this.numberLabel3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLabel3.Location = new System.Drawing.Point(106, 235);
            this.numberLabel3.Name = "numberLabel3";
            this.numberLabel3.Size = new System.Drawing.Size(87, 55);
            this.numberLabel3.TabIndex = 4;
            this.numberLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberLabel3.Click += new System.EventHandler(this.numberLabel3_Click);
            // 
            // formLabel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberLabel3);
            this.Controls.Add(this.numberLabel2);
            this.Controls.Add(this.numberLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Name = "formLabel1";
            this.Text = "Play Game";
            this.Load += new System.EventHandler(this.formLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private Label titleLabel;
        private Label numberLabel1;
        private Label numberLabel2;
        private Label numberLabel3;
    }
}