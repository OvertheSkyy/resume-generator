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

        private void getJSONFile()
        {
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\resume-generator\resume-generator\JSON files\");

            foreach (string filePath in filePathToString)
            {
                seePersonInfoComboBox.Items.Remove(filePath);
                seePersonInfoComboBox.Items.Add(filePath);
            }
        }

        private void seePersonInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string personFilePath = seePersonInfoComboBox.SelectedItem as string;
                string jsonFile = File.ReadAllText(personFilePath);

                JSON pdfInfo = JsonConvert.DeserializeObject<JSON>(jsonFile);
                string jsonToTxtFile = @"E:\Desktop\resume-generator\resume-generator\TEXT Files\" + lastNameTextBox.Text + "_" + firstNameTextBox.Text + ".txt";

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
                    outputFile.WriteLine(pdfInfo.dateOfWork2);
                    outputFile.WriteLine(pdfInfo.position2);
                    outputFile.WriteLine(pdfInfo.companyName2);
                    outputFile.WriteLine(pdfInfo.work2CompanySkill1);
                    outputFile.WriteLine(pdfInfo.work2CompanySkill2);
                    outputFile.WriteLine(pdfInfo.dateOfWork3);
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
            catch
            {

            }
        }

        private void saveAsPDF_Click(object sender, EventArgs e)
        {
            string[] storeJSONInfo = savedInfoRichTextBox.Lines;
            Document pdfDocument = new Document(@"E:\Desktop\resume-generator\resume-generator\TEMPLATE\resume-template.pdf");

            //0
            TextFragmentAbsorber textFragmentAbsorber0 = new TextFragmentAbsorber("Your Name");

            
            pdfDocument.Pages.Accept(textFragmentAbsorber0);

            TextFragmentCollection textFragmentCollection0 = textFragmentAbsorber0.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection0)
            {
                textFragment.Text = storeJSONInfo[0]; 
            }

            //1
            TextFragmentAbsorber textFragmentAbsorber1 = new TextFragmentAbsorber("Your Phone");

           
            pdfDocument.Pages.Accept(textFragmentAbsorber1);

            TextFragmentCollection textFragmentCollection1 = textFragmentAbsorber1.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection1)
            {
                textFragment.Text = storeJSONInfo[1];
            }

            //2
            TextFragmentAbsorber textFragmentAbsorber2 = new TextFragmentAbsorber("Your Email");


            pdfDocument.Pages.Accept(textFragmentAbsorber2);

            TextFragmentCollection textFragmentCollection2 = textFragmentAbsorber2.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection2)
            {
                textFragment.Text = storeJSONInfo[2];
            }

            //3
            TextFragmentAbsorber textFragmentAbsorber3 = new TextFragmentAbsorber("Your Address");


            pdfDocument.Pages.Accept(textFragmentAbsorber3);

            TextFragmentCollection textFragmentCollection3 = textFragmentAbsorber3.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection3)
            {
                textFragment.Text = storeJSONInfo[3];
            }

            //4
            TextFragmentAbsorber textFragmentAbsorber4 = new TextFragmentAbsorber("Your Website URL");


            pdfDocument.Pages.Accept(textFragmentAbsorber4);

            TextFragmentCollection textFragmentCollection4 = textFragmentAbsorber4.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection4)
            {
                textFragment.Text = storeJSONInfo[4];
            }

            //5
            TextFragmentAbsorber textFragmentAbsorber5 = new TextFragmentAbsorber("Skill 1");


            pdfDocument.Pages.Accept(textFragmentAbsorber5);

            TextFragmentCollection textFragmentCollection5 = textFragmentAbsorber5.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection5)
            {
                textFragment.Text = storeJSONInfo[5];
            }

            //6
            TextFragmentAbsorber textFragmentAbsorber6 = new TextFragmentAbsorber("Skill 2");


            pdfDocument.Pages.Accept(textFragmentAbsorber6);

            TextFragmentCollection textFragmentCollection6 = textFragmentAbsorber6.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection6)
            {
                textFragment.Text = storeJSONInfo[6];
            }

            //7
            TextFragmentAbsorber textFragmentAbsorber7 = new TextFragmentAbsorber("Skill 3");


            pdfDocument.Pages.Accept(textFragmentAbsorber7);

            TextFragmentCollection textFragmentCollection7 = textFragmentAbsorber7.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection7)
            {
                textFragment.Text = storeJSONInfo[7];
            }

            //8
            TextFragmentAbsorber textFragmentAbsorber8= new TextFragmentAbsorber("Skill 4");


            pdfDocument.Pages.Accept(textFragmentAbsorber8);

            TextFragmentCollection textFragmentCollection8 = textFragmentAbsorber8.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection8)
            {
                textFragment.Text = storeJSONInfo[8];
            }

            //9
            TextFragmentAbsorber textFragmentAbsorber9 = new TextFragmentAbsorber("Date of Work 1");


            pdfDocument.Pages.Accept(textFragmentAbsorber9);

            TextFragmentCollection textFragmentCollection9 = textFragmentAbsorber9.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection9)
            {
                textFragment.Text = storeJSONInfo[9];
            }

            //10
            TextFragmentAbsorber textFragmentAbsorber10 = new TextFragmentAbsorber("Position 1");


            pdfDocument.Pages.Accept(textFragmentAbsorber10);

            TextFragmentCollection textFragmentCollection10 = textFragmentAbsorber10.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection10)
            {
                textFragment.Text = storeJSONInfo[10];
            }

            //11
            TextFragmentAbsorber textFragmentAbsorber11 = new TextFragmentAbsorber("Company Name 1");


            pdfDocument.Pages.Accept(textFragmentAbsorber11);

            TextFragmentCollection textFragmentCollection11 = textFragmentAbsorber11.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection11)
            {
                textFragment.Text = storeJSONInfo[11];
            }

            //12
            TextFragmentAbsorber textFragmentAbsorber12 = new TextFragmentAbsorber("Work1CompanySkill1");


            pdfDocument.Pages.Accept(textFragmentAbsorber12);

            TextFragmentCollection textFragmentCollection12 = textFragmentAbsorber12.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection12)
            {
                textFragment.Text = storeJSONInfo[12];
            }

            //13
            TextFragmentAbsorber textFragmentAbsorber13 = new TextFragmentAbsorber("Work1CompanySkill2");


            pdfDocument.Pages.Accept(textFragmentAbsorber13);

            TextFragmentCollection textFragmentCollection13 = textFragmentAbsorber13.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection13)
            {
                textFragment.Text = storeJSONInfo[13];
            }

            //14
            TextFragmentAbsorber textFragmentAbsorber14 = new TextFragmentAbsorber("Date Of Work 2");


            pdfDocument.Pages.Accept(textFragmentAbsorber1);

            TextFragmentCollection textFragmentCollection14 = textFragmentAbsorber14.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection14)
            {
                textFragment.Text = storeJSONInfo[14];
            }

            //15
            TextFragmentAbsorber textFragmentAbsorber15 = new TextFragmentAbsorber("Position 2");


            pdfDocument.Pages.Accept(textFragmentAbsorber15);

            TextFragmentCollection textFragmentCollection15 = textFragmentAbsorber15.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection15)
            {
                textFragment.Text = storeJSONInfo[15];
            }

            //16

            TextFragmentAbsorber textFragmentAbsorber16 = new TextFragmentAbsorber("Company Name 2");


            pdfDocument.Pages.Accept(textFragmentAbsorber16);

            TextFragmentCollection textFragmentCollection16 = textFragmentAbsorber16.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection16)
            {
                textFragment.Text = storeJSONInfo[16];
            }

            //17
            TextFragmentAbsorber textFragmentAbsorber17 = new TextFragmentAbsorber("Work2CompanySkill1");


            pdfDocument.Pages.Accept(textFragmentAbsorber17);

            TextFragmentCollection textFragmentCollection17 = textFragmentAbsorber17.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection17)
            {
                textFragment.Text = storeJSONInfo[17];
            }

            //18
            TextFragmentAbsorber textFragmentAbsorber18 = new TextFragmentAbsorber("Work2CompanySkill2");


            pdfDocument.Pages.Accept(textFragmentAbsorber18);

            TextFragmentCollection textFragmentCollection18 = textFragmentAbsorber18.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection18)
            {
                textFragment.Text = storeJSONInfo[18];
            }

            //19
            TextFragmentAbsorber textFragmentAbsorber19 = new TextFragmentAbsorber("Date of Work 3");


            pdfDocument.Pages.Accept(textFragmentAbsorber19);

            TextFragmentCollection textFragmentCollection19 = textFragmentAbsorber19.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection19)
            {
                textFragment.Text = storeJSONInfo[19];
            }

            //20
            TextFragmentAbsorber textFragmentAbsorber20 = new TextFragmentAbsorber("Position 3");


            pdfDocument.Pages.Accept(textFragmentAbsorber20);

            TextFragmentCollection textFragmentCollection20 = textFragmentAbsorber20.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection20)
            {
                textFragment.Text = storeJSONInfo[20];
            }

            //21
            TextFragmentAbsorber textFragmentAbsorber21 = new TextFragmentAbsorber("Company Name 3");


            pdfDocument.Pages.Accept(textFragmentAbsorber21);

            TextFragmentCollection textFragmentCollection21 = textFragmentAbsorber21.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection21)
            {
                textFragment.Text = storeJSONInfo[21];
            }

            //22
            TextFragmentAbsorber textFragmentAbsorber22 = new TextFragmentAbsorber("Work3CompanySkill1");


            pdfDocument.Pages.Accept(textFragmentAbsorber22);

            TextFragmentCollection textFragmentCollection22 = textFragmentAbsorber22.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection22)
            {
                textFragment.Text = storeJSONInfo[22];
            }

            //23
            TextFragmentAbsorber textFragmentAbsorber23 = new TextFragmentAbsorber("Work3CompanySkill2");


            pdfDocument.Pages.Accept(textFragmentAbsorber23);

            TextFragmentCollection textFragmentCollection23 = textFragmentAbsorber23.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection23)
            {
                textFragment.Text = storeJSONInfo[23];
            }

            //24
            TextFragmentAbsorber textFragmentAbsorber24 = new TextFragmentAbsorber("College Location");


            pdfDocument.Pages.Accept(textFragmentAbsorber24);

            TextFragmentCollection textFragmentCollection24 = textFragmentAbsorber24.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection24)
            {
                textFragment.Text = storeJSONInfo[24];
            }

            //25
            TextFragmentAbsorber textFragmentAbsorber25 = new TextFragmentAbsorber("College name");


            pdfDocument.Pages.Accept(textFragmentAbsorber25);

            TextFragmentCollection textFragmentCollection25 = textFragmentAbsorber25.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection25)
            {
                textFragment.Text = storeJSONInfo[25];
            }

            //26
            TextFragmentAbsorber textFragmentAbsorber26 = new TextFragmentAbsorber("Degree obtained");


            pdfDocument.Pages.Accept(textFragmentAbsorber26);

            TextFragmentCollection textFragmentCollection26 = textFragmentAbsorber26.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection26)
            {
                textFragment.Text = storeJSONInfo[26];
            }

            //27
            TextFragmentAbsorber textFragmentAbsorber27 = new TextFragmentAbsorber("SHS Location");


            pdfDocument.Pages.Accept(textFragmentAbsorber27);

            TextFragmentCollection textFragmentCollection27 = textFragmentAbsorber27.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection27)
            {
                textFragment.Text = storeJSONInfo[27];
            }

            //28
            TextFragmentAbsorber textFragmentAbsorber28 = new TextFragmentAbsorber("SHS name");


            pdfDocument.Pages.Accept(textFragmentAbsorber1);

            TextFragmentCollection textFragmentCollection28 = textFragmentAbsorber28.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection28)
            {
                textFragment.Text = storeJSONInfo[28];
            }

            //29
            TextFragmentAbsorber textFragmentAbsorber29 = new TextFragmentAbsorber("Strand");


            pdfDocument.Pages.Accept(textFragmentAbsorber29);

            TextFragmentCollection textFragmentCollection29 = textFragmentAbsorber29.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection29)
            {
                textFragment.Text = storeJSONInfo[29];
            }

            //30
            TextFragmentAbsorber textFragmentAbsorber30 = new TextFragmentAbsorber("JHS Location");


            pdfDocument.Pages.Accept(textFragmentAbsorber30);

            TextFragmentCollection textFragmentCollection30 = textFragmentAbsorber30.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection30)
            {
                textFragment.Text = storeJSONInfo[30];
            }

            //31
            TextFragmentAbsorber textFragmentAbsorber31 = new TextFragmentAbsorber("JHS name");


            pdfDocument.Pages.Accept(textFragmentAbsorber31);

            TextFragmentCollection textFragmentCollection31 = textFragmentAbsorber31.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection31)
            {
                textFragment.Text = storeJSONInfo[31];
            }

            //32
            TextFragmentAbsorber textFragmentAbsorber32 = new TextFragmentAbsorber("Certificate 1");


            pdfDocument.Pages.Accept(textFragmentAbsorber32);

            TextFragmentCollection textFragmentCollection32 = textFragmentAbsorber32.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection32)
            {
                textFragment.Text = storeJSONInfo[32];
            }

            //33
            TextFragmentAbsorber textFragmentAbsorber33 = new TextFragmentAbsorber("Certificate 2");


            pdfDocument.Pages.Accept(textFragmentAbsorber33);

            TextFragmentCollection textFragmentCollection33 = textFragmentAbsorber33.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection33)
            {
                textFragment.Text = storeJSONInfo[33];
            }

            //34
            TextFragmentAbsorber textFragmentAbsorber34 = new TextFragmentAbsorber("Certificate 3");


            pdfDocument.Pages.Accept(textFragmentAbsorber34);

            TextFragmentCollection textFragmentCollection34 = textFragmentAbsorber34.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection34)
            {
                textFragment.Text = storeJSONInfo[34];
            }

            pdfDocument.Save(@"E:\Desktop\resume-generator\resume-generator\PDF Files\" + lastNameTextBox.Text + "_" + firstNameTextBox.Text + ".pdf");
        }

        private void generateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData personInfo = QR.CreateQrCode(savedInfoRichTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(personInfo);
            generatedQRPictureBox.Image = code.GetGraphic(3);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == lastNameTextBox.Text)
            {
                seePersonInfoComboBox.Items.Clear();
                getJSONFile();
            }
        }
    }
}
