using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadgePrinter
{
    public partial class Badgeprinter : Form
    {
        private string photoPath = string.Empty;

        public Badgeprinter()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "\\\\DEPLOYMENT\\Company_Photos";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "JPEG Only|*.jpg;*.jpeg";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("BadgeSheet", 450, 825);
                pd.PrintPage += new PrintPageEventHandler(PrintPage);
                PrintDialog pdi = new PrintDialog();
                pdi.Document = pd;
                if (pdi.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred", ex.Message);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap badgeImage = new Bitmap(badgePanel.Width, badgePanel.Height, badgePanel.CreateGraphics());
            badgePanel.DrawToBitmap(badgeImage, new Rectangle(0, 0, badgePanel.Width, badgePanel.Height));
            RectangleF bounds = new RectangleF(60, 105, badgeImage.Width, badgeImage.Height);
            float factor = ((float)badgeImage.Height / badgeImage.Width);

            e.Graphics.DrawImage(badgeImage, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void photoBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDialog1.FileName;
            }
        }

        private void makeBadgeButton_Click(object sender, EventArgs e)
        {
            if ((employeeNameTextBox.Text == string.Empty || employeeNameTextBox.Text == null)
                || (employeeTitleTextBox.Text == string.Empty || employeeTitleTextBox.Text == null)
                || (employeeLocationTextBox.Text == string.Empty || employeeLocationTextBox.Text == null)
                || (photoPath == string.Empty || !System.IO.File.Exists(photoPath)))
            {
                MessageBox.Show("All fields must be filled in, or you did not pick a valid photo path.",
                    "Note Enough Info", MessageBoxButtons.OK);
                return;
            }

            employeeNameLabel.Text = employeeNameTextBox.Text;
            employeeTitleLabel.Text = employeeTitleTextBox.Text;
            employeeLocationLabel.Text = employeeLocationTextBox.Text;
            employeePhoto.ImageLocation = photoPath;

            NameLabelFont(employeeNameLabel);
            TitleLabelFont(employeeTitleLabel);
            LocationLabelFont(employeeLocationLabel);

            badgePanel.Visible = true;
            printButton.Visible = true;
            backButton.Visible = true;
            makeBadgeButton.Visible = false;
            employeeInfoPanel.Visible = false;
        }

        private void NameLabelFont(Label label)
        {
            // Only bother if there's text.
            string txt = label.Text;
            if (txt.Length > 0)
            {
                int name_best_size = 26;

                // See how much room we have, allowing a bit
                // for the Label's internal margin.
                int wid = label.DisplayRectangle.Width - 5;
                int hgt = label.DisplayRectangle.Height - 5;

                // Make a Graphics object to measure the text.
                using (Graphics gr = label.CreateGraphics())
                {
                    for (int i = 1; i <= 26; i++)
                    {
                        using (Font test_font = new Font(label.Font.FontFamily, i))
                        {
                            // See how much space the text would
                            // need, specifying a maximum width.
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Width >= wid) || (text_size.Height >= hgt))
                            {
                                name_best_size = i - 1;
                                break;
                            }
                        }
                    }
                }


                // Use that font size.
                label.Font = new Font(label.Font.FontFamily, name_best_size);
                label.AutoSize = false;
            }
        }

        private void LocationLabelFont(Label label)
        {
            // Only bother if there's text.
            string txt = label.Text;
            if (txt.Length > 0)
            {
                int loc_best_size = 16;

                // See how much room we have, allowing a bit
                // for the Label's internal margin.
                int wid = label.DisplayRectangle.Width - 5;
                int hgt = label.DisplayRectangle.Height - 5;

                // Make a Graphics object to measure the text.
                using (Graphics gr = label.CreateGraphics())
                {
                    for (int i = 1; i <= 16; i++)
                    {
                        using (Font test_font = new Font(label.Font.FontFamily, i))
                        {
                            // See how much space the text would
                            // need, specifying a maximum width.
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Width >= wid) || (text_size.Height >= hgt))
                            {
                                loc_best_size = i - 1;
                                break;
                            }
                        }
                    }
                }

                // Use that font size.
                label.Font = new Font(label.Font.FontFamily, loc_best_size);
                label.AutoSize = false;
            }
        }


        private void TitleLabelFont(Label label)
        {
            // Only bother if there's text.
            string txt = label.Text;
            if (txt.Length > 0)
            {
                int title_best_size = 12;

                // See how much room we have, allowing a bit
                // for the Label's internal margin.
                int wid = label.DisplayRectangle.Width - 5;
                int hgt = label.DisplayRectangle.Height - 5;

                // Make a Graphics object to measure the text.
                using (Graphics gr = label.CreateGraphics())
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        using (Font test_font = new Font(label.Font.FontFamily, i))
                        {
                            // See how much space the text would
                            // need, specifying a maximum width.
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Width >= wid) || (text_size.Height >= hgt))
                            {
                                title_best_size = i - 1;
                                break;
                            }
                        }
                    }
                }

                // Use that font size.
                label.Font = new Font(label.Font.FontFamily, title_best_size);
                label.AutoSize = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            badgePanel.Visible = false;
            printButton.Visible = false;
            backButton.Visible = false;
            makeBadgeButton.Visible = true;
            employeeInfoPanel.Visible = true;
        }

        private void Badgeprinter_Load(object sender, EventArgs e)
        {

        }

        private void employeeTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeLocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}