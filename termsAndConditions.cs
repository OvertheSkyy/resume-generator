﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace contact_tracing
{
    public partial class termsAndConditions : Form
    {
        Thread thread;
        public termsAndConditions()
        {
            InitializeComponent();
        }

        private void backToLoginForm()
        {
            Application.Run(new loginForm());
        }

        private void returnHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(backToLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
