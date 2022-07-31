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
                date = textBox1.Text,
                time = textBox2.Text,
                platformOrLocation = textBox3.Text,
                teamName = textBox4.Text,
                calledBy = textBox5.Text,
                type = textBox6.Text,
                facilitator = textBox7.Text,
                noteTaker = textBox28.Text,
                timekeeper = textBox8.Text,
                attendees = textBox9.Text,
                pleaseRead = textBox10.Text,
                pleaseBring = textBox11.Text,
                agendaItem = textBox12.Text,
                presenter = textBox13.Text,
                actionItem1 = textBox14.Text,
                actionItem2 = textBox15.Text,
                actionItem3 = textBox16.Text,
                personResponsible1 = textBox17.Text,
                personResponsible2 = textBox18.Text,
                personResponsible3 = textBox19.Text,
                deadline1 = textBox20.Text,
                deadline2 = textBox21.Text,
                deadline3 = textBox21.Text,
                conclusion1 = textBox22.Text,
                conclusion2 = textBox23.Text,
                conclusion3 = textBox24.Text,
                observers = textBox25.Text,
                resources = textBox26.Text,
                specialNotes = textBox27.Text,

            };

                string JsonOutput = JsonConvert.SerializeObject(resumeInfo);
                File.WriteAllText(@"E:\Desktop\minutes-generator\JSON files\" + textBox1.Text + ".json", JsonOutput);
            
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
