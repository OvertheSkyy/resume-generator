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
            string[] filePathToString = Directory.GetFiles(@"E:\Desktop\minutes-generator\JSON files\");

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
                string jsonToTxtFile = @"E:\Desktop\minutes-generator\\TEXT Files\" + textBox1.Text + ".txt";

                StreamWriter outputFile = new StreamWriter(jsonToTxtFile);
                using (outputFile)
                {
                    outputFile.WriteLine(pdfInfo.date);
                    outputFile.WriteLine(pdfInfo.time);
                    outputFile.WriteLine(pdfInfo.platformOrLocation);
                    outputFile.WriteLine(pdfInfo.teamName);
                    outputFile.WriteLine(pdfInfo.calledBy);
                    outputFile.WriteLine(pdfInfo.type);
                    outputFile.WriteLine(pdfInfo.facilitator);
                    outputFile.WriteLine(pdfInfo.noteTaker);
                    outputFile.WriteLine(pdfInfo.timekeeper);
                    outputFile.WriteLine(pdfInfo.attendees);
                    outputFile.WriteLine(pdfInfo.pleaseRead);
                    outputFile.WriteLine(pdfInfo.pleaseBring);
                    outputFile.WriteLine(pdfInfo.agendaItem);
                    outputFile.WriteLine(pdfInfo.presenter);
                    outputFile.WriteLine(pdfInfo.actionItem1);
                    outputFile.WriteLine(pdfInfo.actionItem2);
                    outputFile.WriteLine(pdfInfo.actionItem3);
                    outputFile.WriteLine(pdfInfo.personResponsible1);
                    outputFile.WriteLine(pdfInfo.personResponsible2);
                    outputFile.WriteLine(pdfInfo.personResponsible3);
                    outputFile.WriteLine(pdfInfo.deadline1);
                    outputFile.WriteLine(pdfInfo.deadline2);
                    outputFile.WriteLine(pdfInfo.deadline3);
                    outputFile.WriteLine(pdfInfo.conclusion1);
                    outputFile.WriteLine(pdfInfo.conclusion2);
                    outputFile.WriteLine(pdfInfo.conclusion3);
                    outputFile.WriteLine(pdfInfo.observers);
                    outputFile.WriteLine(pdfInfo.resources);
                    outputFile.WriteLine(pdfInfo.specialNotes);

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
            Document pdfDocument = new Document(@"E:\Desktop\minutes-generator\TEMPLATE\meeting-minutes-template.pdf");

            //0
            TextFragmentAbsorber textFragmentAbsorber0 = new TextFragmentAbsorber("Date");

            
            pdfDocument.Pages.Accept(textFragmentAbsorber0);

            TextFragmentCollection textFragmentCollection0 = textFragmentAbsorber0.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection0)
            {
                textFragment.Text = storeJSONInfo[0]; 
            }

            //1
            TextFragmentAbsorber textFragmentAbsorber1 = new TextFragmentAbsorber("Time");

           
            pdfDocument.Pages.Accept(textFragmentAbsorber1);

            TextFragmentCollection textFragmentCollection1 = textFragmentAbsorber1.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection1)
            {
                textFragment.Text = storeJSONInfo[1];
            }

            //2
            TextFragmentAbsorber textFragmentAbsorber2 = new TextFragmentAbsorber("Location");


            pdfDocument.Pages.Accept(textFragmentAbsorber2);

            TextFragmentCollection textFragmentCollection2 = textFragmentAbsorber2.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection2)
            {
                textFragment.Text = storeJSONInfo[2];
            }

            //3
            TextFragmentAbsorber textFragmentAbsorber3 = new TextFragmentAbsorber("Team");


            pdfDocument.Pages.Accept(textFragmentAbsorber3);

            TextFragmentCollection textFragmentCollection3 = textFragmentAbsorber3.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection3)
            {
                textFragment.Text = storeJSONInfo[3];
            }

            //4
            TextFragmentAbsorber textFragmentAbsorber4 = new TextFragmentAbsorber("Enter meeting organizer here");


            pdfDocument.Pages.Accept(textFragmentAbsorber4);

            TextFragmentCollection textFragmentCollection4 = textFragmentAbsorber4.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection4)
            {
                textFragment.Text = storeJSONInfo[4];
            }

            //5
            TextFragmentAbsorber textFragmentAbsorber5 = new TextFragmentAbsorber("Enter meeting type here");


            pdfDocument.Pages.Accept(textFragmentAbsorber5);

            TextFragmentCollection textFragmentCollection5 = textFragmentAbsorber5.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection5)
            {
                textFragment.Text = storeJSONInfo[5];
            }

            //6
            TextFragmentAbsorber textFragmentAbsorber6 = new TextFragmentAbsorber("Enter meeting facilitator here");


            pdfDocument.Pages.Accept(textFragmentAbsorber6);

            TextFragmentCollection textFragmentCollection6 = textFragmentAbsorber6.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection6)
            {
                textFragment.Text = storeJSONInfo[6];
            }

            //7
            TextFragmentAbsorber textFragmentAbsorber7 = new TextFragmentAbsorber("Enter note taker here");


            pdfDocument.Pages.Accept(textFragmentAbsorber7);

            TextFragmentCollection textFragmentCollection7 = textFragmentAbsorber7.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection7)
            {
                textFragment.Text = storeJSONInfo[7];
            }

            //8
            TextFragmentAbsorber textFragmentAbsorber8= new TextFragmentAbsorber("Enter meeting timekeeper here");


            pdfDocument.Pages.Accept(textFragmentAbsorber8);

            TextFragmentCollection textFragmentCollection8 = textFragmentAbsorber8.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection8)
            {
                textFragment.Text = storeJSONInfo[8];
            }

            //9
            TextFragmentAbsorber textFragmentAbsorber9 = new TextFragmentAbsorber("Enter attendees here");


            pdfDocument.Pages.Accept(textFragmentAbsorber9);

            TextFragmentCollection textFragmentCollection9 = textFragmentAbsorber9.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection9)
            {
                textFragment.Text = storeJSONInfo[9];
            }

            //10
            TextFragmentAbsorber textFragmentAbsorber10 = new TextFragmentAbsorber("Enter reading list here");


            pdfDocument.Pages.Accept(textFragmentAbsorber10);

            TextFragmentCollection textFragmentCollection10 = textFragmentAbsorber10.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection10)
            {
                textFragment.Text = storeJSONInfo[10];
            }

            //11
            TextFragmentAbsorber textFragmentAbsorber11 = new TextFragmentAbsorber("Enter items to bring here");


            pdfDocument.Pages.Accept(textFragmentAbsorber11);

            TextFragmentCollection textFragmentCollection11 = textFragmentAbsorber11.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection11)
            {
                textFragment.Text = storeJSONInfo[11];
            }

            //12
            TextFragmentAbsorber textFragmentAbsorber12 = new TextFragmentAbsorber("Enter agenda item here");


            pdfDocument.Pages.Accept(textFragmentAbsorber12);

            TextFragmentCollection textFragmentCollection12 = textFragmentAbsorber12.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection12)
            {
                textFragment.Text = storeJSONInfo[12];
            }

            //13
            TextFragmentAbsorber textFragmentAbsorber13 = new TextFragmentAbsorber("Enter presenter here");


            pdfDocument.Pages.Accept(textFragmentAbsorber13);

            TextFragmentCollection textFragmentCollection13 = textFragmentAbsorber13.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection13)
            {
                textFragment.Text = storeJSONInfo[13];
            }

            //14
            TextFragmentAbsorber textFragmentAbsorber14 = new TextFragmentAbsorber("Enter action 1 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber1);

            TextFragmentCollection textFragmentCollection14 = textFragmentAbsorber14.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection14)
            {
                textFragment.Text = storeJSONInfo[14];
            }

            //15
            TextFragmentAbsorber textFragmentAbsorber15 = new TextFragmentAbsorber("Enter action 2 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber15);

            TextFragmentCollection textFragmentCollection15 = textFragmentAbsorber15.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection15)
            {
                textFragment.Text = storeJSONInfo[15];
            }

            //16

            TextFragmentAbsorber textFragmentAbsorber16 = new TextFragmentAbsorber("Enter action 3 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber16);

            TextFragmentCollection textFragmentCollection16 = textFragmentAbsorber16.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection16)
            {
                textFragment.Text = storeJSONInfo[16];
            }

            //17
            TextFragmentAbsorber textFragmentAbsorber17 = new TextFragmentAbsorber("Enter person respnsible 1 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber17);

            TextFragmentCollection textFragmentCollection17 = textFragmentAbsorber17.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection17)
            {
                textFragment.Text = storeJSONInfo[17];
            }

            //18
            TextFragmentAbsorber textFragmentAbsorber18 = new TextFragmentAbsorber("Enter person responsible 2 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber18);

            TextFragmentCollection textFragmentCollection18 = textFragmentAbsorber18.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection18)
            {
                textFragment.Text = storeJSONInfo[18];
            }

            //19
            TextFragmentAbsorber textFragmentAbsorber19 = new TextFragmentAbsorber("Enter person responsible 3 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber19);

            TextFragmentCollection textFragmentCollection19 = textFragmentAbsorber19.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection19)
            {
                textFragment.Text = storeJSONInfo[19];
            }

            //20
            TextFragmentAbsorber textFragmentAbsorber20 = new TextFragmentAbsorber("Enter deadline 1 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber20);

            TextFragmentCollection textFragmentCollection20 = textFragmentAbsorber20.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection20)
            {
                textFragment.Text = storeJSONInfo[20];
            }

            //21
            TextFragmentAbsorber textFragmentAbsorber21 = new TextFragmentAbsorber("Enter deadline 2 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber21);

            TextFragmentCollection textFragmentCollection21 = textFragmentAbsorber21.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection21)
            {
                textFragment.Text = storeJSONInfo[21];
            }

            //22
            TextFragmentAbsorber textFragmentAbsorber22 = new TextFragmentAbsorber("Enter deadline 3 here");


            pdfDocument.Pages.Accept(textFragmentAbsorber22);

            TextFragmentCollection textFragmentCollection22 = textFragmentAbsorber22.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection22)
            {
                textFragment.Text = storeJSONInfo[22];
            }

            //23
            TextFragmentAbsorber textFragmentAbsorber23 = new TextFragmentAbsorber("Enter conclusion 1 here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber23);

            TextFragmentCollection textFragmentCollection23 = textFragmentAbsorber23.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection23)
            {
                textFragment.Text = storeJSONInfo[23];
            }

            //24
            TextFragmentAbsorber textFragmentAbsorber24 = new TextFragmentAbsorber("Enter conclusion 2 here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber24);

            TextFragmentCollection textFragmentCollection24 = textFragmentAbsorber24.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection24)
            {
                textFragment.Text = storeJSONInfo[24];
            }

            //25
            TextFragmentAbsorber textFragmentAbsorber25 = new TextFragmentAbsorber("Enter conclusion 3 here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber25);

            TextFragmentCollection textFragmentCollection25 = textFragmentAbsorber25.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection25)
            {
                textFragment.Text = storeJSONInfo[25];
            }

            //26
            TextFragmentAbsorber textFragmentAbsorber26 = new TextFragmentAbsorber("Enter observers here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber26);

            TextFragmentCollection textFragmentCollection26 = textFragmentAbsorber26.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection26)
            {
                textFragment.Text = storeJSONInfo[26];
            }

            //27
            TextFragmentAbsorber textFragmentAbsorber27 = new TextFragmentAbsorber("Enter resources here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber27);

            TextFragmentCollection textFragmentCollection27 = textFragmentAbsorber27.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection27)
            {
                textFragment.Text = storeJSONInfo[27];
            }

            //28
            TextFragmentAbsorber textFragmentAbsorber28 = new TextFragmentAbsorber("Enter any special notes here.");


            pdfDocument.Pages.Accept(textFragmentAbsorber27);

            TextFragmentCollection textFragmentCollection28 = textFragmentAbsorber27.TextFragments;


            foreach (TextFragment textFragment in textFragmentCollection27)
            {
                textFragment.Text = storeJSONInfo[27];
            }

            pdfDocument.Save(@"E:\Desktop\minutes-generator\PDF Files\" + textBox1.Text + ".pdf");

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox1.Text)
            {
                seePersonInfoComboBox.Items.Clear();
                getJSONFile();
            }
        }
    }
}
