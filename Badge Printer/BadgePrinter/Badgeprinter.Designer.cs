using System;
using System.ComponentModel;

namespace BadgePrinter
{
    partial class Badgeprinter
    
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Badgeprinter));
            this.printButton = new System.Windows.Forms.Button();
            this.badgePanel = new System.Windows.Forms.Panel();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.employeeTitleLabel = new System.Windows.Forms.Label();
            this.employeeLocationLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeInfoPanel = new System.Windows.Forms.Panel();
            this.photoBrowseButton = new System.Windows.Forms.Button();
            this.makeBadgeButton = new System.Windows.Forms.Button();
            this.employeeLocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backButton = new System.Windows.Forms.Button();
            this.badgePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.employeeInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(208, 229);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(119, 37);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Visible = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // badgePanel
            // 
            this.badgePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.badgePanel.Controls.Add(this.employeePhoto);
            this.badgePanel.Controls.Add(this.employeeTitleLabel);
            this.badgePanel.Controls.Add(this.employeeLocationLabel);
            this.badgePanel.Controls.Add(this.employeeNameLabel);
            this.badgePanel.Location = new System.Drawing.Point(32, 12);
            this.badgePanel.Name = "badgePanel";
            this.badgePanel.Size = new System.Drawing.Size(315, 198);
            this.badgePanel.TabIndex = 3;
            this.badgePanel.Visible = false;
            // 
            // employeePhoto
            // 
            this.employeePhoto.Image = global::BadgePrinter.Properties.Resources.Parrott__Russell2528___PhotoShare;
            this.employeePhoto.Location = new System.Drawing.Point(8, 9);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Padding = new System.Windows.Forms.Padding(5);
            this.employeePhoto.Size = new System.Drawing.Size(99, 131);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePhoto.TabIndex = 8;
            this.employeePhoto.TabStop = false;
            // 
            // employeeTitleLabel
            // 
            this.employeeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeTitleLabel.Font = new System.Drawing.Font("Comfortaa", 10F);
            this.employeeTitleLabel.Location = new System.Drawing.Point(115, 121);
            this.employeeTitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeTitleLabel.MaximumSize = new System.Drawing.Size(180, 52);
            this.employeeTitleLabel.MinimumSize = new System.Drawing.Size(180, 26);
            this.employeeTitleLabel.Name = "employeeTitleLabel";
            this.employeeTitleLabel.Size = new System.Drawing.Size(180, 26);
            this.employeeTitleLabel.TabIndex = 7;
            this.employeeTitleLabel.Text = "Programmer";
            this.employeeTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.employeeTitleLabel.Click += new System.EventHandler(this.employeeTitleLabel_Click);
            // 
            // employeeLocationLabel
            // 
            this.employeeLocationLabel.AllowDrop = true;
            this.employeeLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeLocationLabel.AutoEllipsis = true;
            this.employeeLocationLabel.Font = new System.Drawing.Font("Comfortaa", 14F);
            this.employeeLocationLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeeLocationLabel.Location = new System.Drawing.Point(115, 84);
            this.employeeLocationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.employeeLocationLabel.MaximumSize = new System.Drawing.Size(180, 52);
            this.employeeLocationLabel.MinimumSize = new System.Drawing.Size(180, 26);
            this.employeeLocationLabel.Name = "employeeLocationLabel";
            this.employeeLocationLabel.Size = new System.Drawing.Size(180, 31);
            this.employeeLocationLabel.TabIndex = 6;
            this.employeeLocationLabel.Text = "Admin";
            this.employeeLocationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeeLocationLabel.Click += new System.EventHandler(this.employeeLocationLabel_Click);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeNameLabel.Font = new System.Drawing.Font("Comfortaa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.Location = new System.Drawing.Point(0, 150);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(315, 48);
            this.employeeNameLabel.TabIndex = 3;
            this.employeeNameLabel.Text = "Russell Parrott";
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeInfoPanel
            // 
            this.employeeInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeInfoPanel.Controls.Add(this.photoBrowseButton);
            this.employeeInfoPanel.Controls.Add(this.makeBadgeButton);
            this.employeeInfoPanel.Controls.Add(this.employeeLocationTextBox);
            this.employeeInfoPanel.Controls.Add(this.label3);
            this.employeeInfoPanel.Controls.Add(this.employeeTitleTextBox);
            this.employeeInfoPanel.Controls.Add(this.label2);
            this.employeeInfoPanel.Controls.Add(this.label1);
            this.employeeInfoPanel.Controls.Add(this.employeeNameTextBox);
            this.employeeInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.employeeInfoPanel.Location = new System.Drawing.Point(0, -1);
            this.employeeInfoPanel.Name = "employeeInfoPanel";
            this.employeeInfoPanel.Size = new System.Drawing.Size(381, 280);
            this.employeeInfoPanel.TabIndex = 4;
            this.employeeInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.employeeInfoPanel_Paint);
            // 
            // photoBrowseButton
            // 
            this.photoBrowseButton.Location = new System.Drawing.Point(134, 155);
            this.photoBrowseButton.Name = "photoBrowseButton";
            this.photoBrowseButton.Size = new System.Drawing.Size(119, 30);
            this.photoBrowseButton.TabIndex = 6;
            this.photoBrowseButton.Text = "Browse for Photo";
            this.photoBrowseButton.UseVisualStyleBackColor = true;
            this.photoBrowseButton.Click += new System.EventHandler(this.photoBrowseButton_Click);
            // 
            // makeBadgeButton
            // 
            this.makeBadgeButton.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBadgeButton.Location = new System.Drawing.Point(133, 207);
            this.makeBadgeButton.Name = "makeBadgeButton";
            this.makeBadgeButton.Size = new System.Drawing.Size(119, 37);
            this.makeBadgeButton.TabIndex = 5;
            this.makeBadgeButton.Text = "Make Badge";
            this.makeBadgeButton.UseVisualStyleBackColor = true;
            this.makeBadgeButton.Click += new System.EventHandler(this.makeBadgeButton_Click);
            // 
            // employeeLocationTextBox
            // 
            this.employeeLocationTextBox.BackColor = System.Drawing.Color.White;
            this.employeeLocationTextBox.HideSelection = false;
            this.employeeLocationTextBox.Location = new System.Drawing.Point(117, 99);
            this.employeeLocationTextBox.Name = "employeeLocationTextBox";
            this.employeeLocationTextBox.Size = new System.Drawing.Size(248, 20);
            this.employeeLocationTextBox.TabIndex = 5;
            this.employeeLocationTextBox.TextChanged += new System.EventHandler(this.employeeLocationTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Location";
            // 
            // employeeTitleTextBox
            // 
            this.employeeTitleTextBox.BackColor = System.Drawing.Color.White;
            this.employeeTitleTextBox.Location = new System.Drawing.Point(117, 65);
            this.employeeTitleTextBox.Name = "employeeTitleTextBox";
            this.employeeTitleTextBox.Size = new System.Drawing.Size(248, 20);
            this.employeeTitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.BackColor = System.Drawing.Color.White;
            this.employeeNameTextBox.Location = new System.Drawing.Point(117, 30);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.employeeNameTextBox.TabIndex = 0;
            this.employeeNameTextBox.TextChanged += new System.EventHandler(this.employeeNameTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(53, 229);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 37);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Badgeprinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 278);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employeeInfoPanel);
            this.Controls.Add(this.badgePanel);
            this.Controls.Add(this.printButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Badgeprinter";
            this.Text = "Communicare Badgeprinter";
            this.TransparencyKey = System.Drawing.Color.DarkOrange;
            this.Load += new System.EventHandler(this.Badgeprinter_Load);
            this.badgePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.employeeInfoPanel.ResumeLayout(false);
            this.employeeInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            /* throw new NotImplementedException(); */

        }

        private void employeeLocationTextBox_TextChanged(object sender, EventArgs e)
        {
       /* throw new NotImplementedException(); */
        }

        #endregion
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel badgePanel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeLocationLabel;
        private System.Windows.Forms.Label employeeTitleLabel;
        private System.Windows.Forms.PictureBox employeePhoto;
        private System.Windows.Forms.Panel employeeInfoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeLocationTextBox;
        private System.Windows.Forms.Button makeBadgeButton;
        private System.Windows.Forms.Button photoBrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button backButton;

    }
}

