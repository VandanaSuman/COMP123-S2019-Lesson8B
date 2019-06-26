namespace COMP123_S2019_Lesson8B
{
    partial class Lab8Form
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
            this.Titlelabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Titlelabel.Location = new System.Drawing.Point(39, 26);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(107, 37);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Lab08";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoGroupBox.Location = new System.Drawing.Point(46, 97);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(555, 191);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.NameLabel.Location = new System.Drawing.Point(7, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(177, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.NameTextBox.Location = new System.Drawing.Point(228, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(276, 38);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.AgeTextBox.Location = new System.Drawing.Point(228, 77);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(276, 38);
            this.AgeTextBox.TabIndex = 3;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.AgeLabel.Location = new System.Drawing.Point(7, 84);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(152, 31);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Enter Age:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SubmitButton.Location = new System.Drawing.Point(476, 335);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 50);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Outputlabel
            // 
            this.Outputlabel.AutoSize = true;
            this.Outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Outputlabel.Location = new System.Drawing.Point(73, 335);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(54, 31);
            this.Outputlabel.TabIndex = 3;
            this.Outputlabel.Text = "     ";
            // 
            // Lab8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Outputlabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.Titlelabel);
            this.MaximizeBox = false;
            this.Name = "Lab8Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Lab8Form_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label Outputlabel;
    }
}

