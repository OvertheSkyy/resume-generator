using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QRCoder;
using Newtonsoft.Json;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace contact_tracing
{
    public partial class seeFilesForm : Form
    {
        public bool UseShellExecute { get; private set; }

        public seeFilesForm()
        {
            InitializeComponent();
        }

        private void checkInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void dateOfCreation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateOfCreation.Text == "2019")
                {
                    seePersonInfoComboBox.Items.Clear();
                    dateOfCreationyr2019();
                }
            }
            catch
            {

            }   
        }

        private void dateOfCreationyr2019()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\C#-resume-generator\JSON Files\2019\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Remove(filePath);
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void seePersonInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var personFilePath = seePersonInfoComboBox.SelectedItem as string;
            string jsonFile = File.ReadAllText(personFilePath);

            JSON pdfInfo = JsonConvert.DeserializeObject<JSON>(jsonFile);
            string jsonToTxtFile = @"E:\Desktop\C#-resume-generator\TEXT Files\2019\" + lastNameTextBox.Text + "_" + firstNameTextBox.Text + ".txt";

            StreamWriter outputFile = new StreamWriter(jsonToTxtFile);
            using (outputFile)
            {

                outputFile.WriteLine(pdfInfo.yourName);
                outputFile.WriteLine(pdfInfo.yourPhone);
                outputFile.WriteLine(pdfInfo.yourEmail);
                outputFile.WriteLine(pdfInfo.yourAddress);
                outputFile.WriteLine(pdfInfo.yourWebsite);
                outputFile.WriteLine(pdfInfo.skill1);
                outputFile.WriteLine(pdfInfo.skill2);
                outputFile.WriteLine(pdfInfo.skill3);
                outputFile.WriteLine(pdfInfo.skill4);
                outputFile.WriteLine(pdfInfo.dateOfWork1);
                outputFile.WriteLine(pdfInfo.position1);
                outputFile.WriteLine(pdfInfo.companyName1);
                outputFile.WriteLine(pdfInfo.work1CompanySkill1);
                outputFile.WriteLine(pdfInfo.work1CompanySkill2);
                outputFile.WriteLine(pdfInfo.dateOfwork2);
                outputFile.WriteLine(pdfInfo.position2);
                outputFile.WriteLine(pdfInfo.companyName2);
                outputFile.WriteLine(pdfInfo.work2CompanySkill1);
                outputFile.WriteLine(pdfInfo.work2CompanySkill2);
                outputFile.WriteLine(pdfInfo.dateOfwork3);
                outputFile.WriteLine(pdfInfo.position3);
                outputFile.WriteLine(pdfInfo.companyName3);
                outputFile.WriteLine(pdfInfo.work3CompanySkill1);
                outputFile.WriteLine(pdfInfo.work3CompanySkill2);
                outputFile.WriteLine(pdfInfo.collegeLocation);
                outputFile.WriteLine(pdfInfo.collegeName);
                outputFile.WriteLine(pdfInfo.degreeObtained);
                outputFile.WriteLine(pdfInfo.SHSLocation);
                outputFile.WriteLine(pdfInfo.SHSName);
                outputFile.WriteLine(pdfInfo.strand);
                outputFile.WriteLine(pdfInfo.JHSLocation);
                outputFile.WriteLine(pdfInfo.JHSName);
                outputFile.WriteLine(pdfInfo.certificate1);
                outputFile.WriteLine(pdfInfo.certificate2);
                outputFile.WriteLine(pdfInfo.certificate3);


                outputFile.Close();
            }

            StreamReader streamReader = new StreamReader(jsonToTxtFile);

            savedInfoRichTextBox.Text = streamReader.ReadToEnd();
        }

        private void saveAsPDF_Click(object sender, EventArgs e)
        {
            string[] storeJSONInfo = savedInfoRichTextBox.Lines;
            // Open document
            Document pdfDocument = new Document(@"E:\Desktop\C#-resume-generator\TEMPLATE\Gaeus Caskie Fabro-resume.pdf");

            // Create TextAbsorber object to find all instances of the input search phrase
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("Education Level");

            // Accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber);

            // Get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

            // Loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                // Update text and other properties
                textFragment.Text = storeJSONInfo[0];
                textFragment.TextState.Font = FontRepository.FindFont("Verdana");
                textFragment.TextState.FontSize = 22;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
            }

            // Save resulting PDF document.
            pdfDocument.Save(@"E:\Desktop\C#-resume-generator\PDF Files\" + lastNameTextBox.Text + "_" + firstNameTextBox.Text + ".pdf");
        }

        private void generateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData personInfo = QR.CreateQrCode(savedInfoRichTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(personInfo);
            generatedQRPictureBox.Image = code.GetGraphic(3);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
