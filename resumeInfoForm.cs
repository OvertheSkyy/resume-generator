using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace contact_tracing
{
    public partial class resumeInfoForm : Form
    {
        Thread thread;

        public resumeInfoForm()
        {
            InitializeComponent();
        }

        private void nameOfCamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void infoOfQRCodeRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {

            JSON resumeInfo = new JSON
            {
                yourName = firstNameTextBox.Text + " " + middleInitialTextBox.Text + " " + lastNameTextBox.Text,
                yourPhone = mobileNumberTextBox.Text,
                yourEmail = emailTextBox.Text,
                yourAddress = addressTextBox.Text,
                yourWebsite = websiteURLTextBox.Text,
                skill1 = skill1TextBox.Text,
                skill2 = skill2TextBox.Text,
                skill3 = skill3TextBox.Text,
                skill4 = skill4TextBox.Text,
                dateOfWork1 = dateOfWork1TextBox.Text,
                position1 = work1PositionTextBox.Text,
                companyName1 = companyName1TextBox.Text,
                work1CompanySkill1 = work1CompanySkill1TB.Text,
                work1CompanySkill2 = work1CompanySkill2TB.Text,
                dateOfWork2 = dateOfWork2TextBox.Text,
                position2 = work2PositionTextBox.Text,
                companyName2 = companyName2TextBox.Text,
                work2CompanySkill1 = work2CompanySkill1TB.Text,
                work2CompanySkill2 = work2CompanySkill2TB.Text,
                dateOfWork3 = dateOfWork3TextBox.Text,
                position3 = work3PositionTextBox.Text,
                companyName3 = companyName3TextBox.Text,
                work3CompanySkill1 = work3CompanySkill1TB.Text,
                work3CompanySkill2 = work3CompanySkill2TB.Text,
                collegeLocation = collegeLocationTextBox.Text,
                collegeName = collegeNameTextBox.Text,
                degreeObtained = degreeObtainedTextBox.Text,
                SHSLocation = SHSLocationTextBox.Text,
                SHSName = SHSNameTextBox.Text,
                strand = strandTextBox.Text,
                JHSLocation = JHSLocationTextBox.Text,
                JHSName = JHSNameTextBox.Text,
                certificate1 = certificate1TextBox.Text,
                certificate2 = certificate2TextBox.Text,
                certificate3 = certificate3TextBox.Text,
              };

                string JsonOutput = JsonConvert.SerializeObject(resumeInfo);
                File.WriteAllText(@"E:\Desktop\resume-generator\resume-generator\JSON files\" + lastNameTextBox.Text + "_" + firstNameTextBox.Text + ".json", JsonOutput);
            
        }

        private void checkInfoBtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(openNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void openNewForm()
        {
            Application.Run(new seeFilesForm());
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {

            firstNameTextBox.Text = "";
            middleInitialTextBox.Text = "";
            lastNameTextBox.Text = "";
            mobileNumberTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            websiteURLTextBox.Text = "";
            skill1TextBox.Text = "";
            skill2TextBox.Text = "";
            skill3TextBox.Text = "";
            skill4TextBox.Text = "";
            dateOfWork1TextBox.Text = "";
            work1PositionTextBox.Text = "";
            companyName1TextBox.Text = "";
            work1CompanySkill1TB.Text = "";
            work1CompanySkill2TB.Text = "";
            dateOfWork2TextBox.Text = "";
            work2PositionTextBox.Text = "";
            companyName2TextBox.Text = "";
            work2CompanySkill1TB.Text = "";
            work2CompanySkill2TB.Text = "";
            dateOfWork3TextBox.Text = "";
            work3PositionTextBox.Text = "";
            companyName3TextBox.Text = "";
            work3CompanySkill1TB.Text = "";
            work3CompanySkill2TB.Text = "";
            collegeLocationTextBox.Text = "";
            collegeNameTextBox.Text = "";
            degreeObtainedTextBox.Text = "";
            SHSLocationTextBox.Text = "";
            SHSNameTextBox.Text = "";
            strandTextBox.Text = "";
            JHSLocationTextBox.Text = "";
            JHSNameTextBox.Text = "";
            certificate1TextBox.Text = "";
            certificate2TextBox.Text = "";
            certificate3TextBox.Text = "";

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(backToLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void backToLoginForm()
        {
            Application.Run(new loginForm());
        }

    }
}
