using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class SecretaryForm : Form
    {
        PatientHandler ph = new PatientHandler();
        DoctorHandler dh = new DoctorHandler();
        SecretaryHandler sh = new SecretaryHandler();
        AppointmentHandler ah = new AppointmentHandler();
        string[] clinics = { "Cardiology", "Dermatology", "Neurology", "Plastic Surgery", "General Surgery", "Urology", "Gynecology", "Pediatrics" };
        string[] bloodTypes = { "0+", "0-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
        public SecretaryForm()
        {
            InitializeComponent();
            PatientDefault();
            DoctorDefault();
            SecretaryDefault();
            AppointmentDefault();
            tabPage1.Text = "Patients";
            tabPage2.Text = "Doctors";
            tabPageSecPw.Text = "Secretaries";
            tabPage3.Text = "Appointments";
            FormClosing += SecretaryForm_Closing;

        }
        private void  SecretaryForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)  //To close all forms
        {
            Application.Exit();
        }

        //Defaults for tabs
        void AppointmentDefault()
        {
            dateTimePickerAppo.MinDate = DateTime.Now;
            dataGridViewPatAppo.DataSource = ph.GetAll();
            dataGridViewAppo.DataSource = ah.getAbstract();
            comboBoxAppoDoc.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        void SecretaryDefault()
        {
            textBoxSecTc.MaxLength = 11;
            textBoxSecPhone.MaxLength = 11;
            textBoxSecAge.MaxLength = 3;
            textBoxSecPw.MaxLength = 4;
            dataGridViewSec.DataSource = sh.GetAll();
        }
        void DoctorDefault()
        {
            comboBoxDocClinic.Items.AddRange(clinics);
            comboBoxDocClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDocClinic.SelectedIndex = 0;
            comboBoxBlood.SelectedIndex = 0;
            textBoxDocTc.MaxLength = 11;
            textBoxDocPhone.MaxLength = 11;
            textBoxDocAge.MaxLength = 3;
            textBoxDocPw.MaxLength = 4;
            dataGridViewDoctor.DataSource = dh.GetAll();
        }
        void PatientDefault()
        {
            comboBoxPatClinic.Items.AddRange(clinics);
            comboBoxBlood.Items.AddRange(bloodTypes);
            comboBoxPatClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBlood.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatClinic.SelectedIndex = 0;
            comboBoxBlood.SelectedIndex = 0;
            textBoxPatTc.MaxLength = 11;
            textBoxPatPhone.MaxLength = 11;
            textBoxPatAge.MaxLength = 3;
            dataGridViewPatient.DataSource = ph.GetAll();
        }
        //Takes the data from table to show them at where you are supposed to enter them from
        private void dataGridViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = dataGridViewPatient.CurrentRow.Cells[0].Value.ToString();
            textBoxPatName.Text = dataGridViewPatient.CurrentRow.Cells[1].Value.ToString();
            textBoxPatMail.Text = dataGridViewPatient.CurrentRow.Cells[2].Value.ToString();
            comboBoxPatClinic.SelectedItem = dataGridViewPatient.CurrentRow.Cells[3].Value.ToString();
            if (dataGridViewPatient.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (dataGridViewPatient.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            comboBoxBlood.SelectedItem = dataGridViewPatient.CurrentRow.Cells[5].Value.ToString();
            textBoxPatAge.Text = dataGridViewPatient.CurrentRow.Cells[6].Value.ToString();
            textBoxPatPhone.Text = dataGridViewPatient.CurrentRow.Cells[7].Value.ToString();
            textBoxPatTc.Text = dataGridViewPatient.CurrentRow.Cells[8].Value.ToString();

        }
        private void dataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridViewDoctor.CurrentRow.Cells[0].Value.ToString();
            textBoxDocName.Text = dataGridViewDoctor.CurrentRow.Cells[1].Value.ToString();
            textBoxDocMail.Text = dataGridViewDoctor.CurrentRow.Cells[2].Value.ToString();
            comboBoxDocClinic.SelectedItem = dataGridViewDoctor.CurrentRow.Cells[3].Value.ToString();
            if (dataGridViewDoctor.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (dataGridViewDoctor.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }

            textBoxDocAge.Text = dataGridViewDoctor.CurrentRow.Cells[5].Value.ToString();
            textBoxDocPhone.Text = dataGridViewDoctor.CurrentRow.Cells[6].Value.ToString();
            textBoxDocTc.Text = dataGridViewDoctor.CurrentRow.Cells[7].Value.ToString();
            textBoxDocPw.Text = dataGridViewDoctor.CurrentRow.Cells[8].Value.ToString();
            
        }
        private void dataGridViewSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label20.Text = dataGridViewSec.CurrentRow.Cells[0].Value.ToString();
            textBoxSecName.Text = dataGridViewSec.CurrentRow.Cells[1].Value.ToString();
            if (dataGridViewSec.CurrentRow.Cells[2].Value.ToString() == "Male")
            {
                radioButtonSecMale.Checked = true;
            }
            else if (dataGridViewSec.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                radioButtonSecFemale.Checked = true;
            }

            textBoxSecAge.Text = dataGridViewSec.CurrentRow.Cells[2].Value.ToString();
            textBoxSecPhone.Text = dataGridViewSec.CurrentRow.Cells[3].Value.ToString();
            textBoxSecTc.Text = dataGridViewSec.CurrentRow.Cells[4].Value.ToString();
            textBoxSecPw.Text = dataGridViewSec.CurrentRow.Cells[5].Value.ToString();
        }
        private void dataGridViewPatAppo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoctorHandler dh = new DoctorHandler();
            comboBoxAppoDoc.Items.Clear();
            string clinic = dataGridViewPatAppo.CurrentRow.Cells[3].Value.ToString();
            if (dh.GetByClinic(clinic).Count <= 0)
            {
                comboBoxAppoDoc.Items.Clear();
                MessageBox.Show("There are no available doctors for this appointment");
            }
            else
            {
                foreach (var item in dh.GetByClinic(clinic))
                {
                    comboBoxAppoDoc.Items.Add(item.doctorName);
                    comboBoxDocID.Items.Add(item.doctorID);

                }
                comboBoxAppoDoc.SelectedIndex = 0;
            }


        }

        //Patient CRUD
        private void buttonPatAdd_Click(object sender, EventArgs e)
        {
            Pati pat = new Pati();
            try
            {
                pat.patientName = textBoxPatName.Text;
                pat.patientMail = textBoxPatMail.Text;
                pat.clinic = comboBoxPatClinic.SelectedItem.ToString();
                if (radioButtonMale.Checked)
                {
                    pat.patientGender = "Male";
                }
                else
                {
                    pat.patientGender = "Female";
                }
                pat.patientBlood = comboBoxBlood.SelectedItem.ToString();
                pat.patientAge = int.Parse(textBoxPatAge.Text);
                pat.patientPhone = textBoxPatPhone.Text.ToString();
                pat.patientTCNO = textBoxPatTc.Text.ToString();
                ph.addPatient(pat, textBoxPatMail, textBoxPatAge, textBoxPatPhone, textBoxPatTc);
                dataGridViewPatient.DataSource = ph.GetAll();
                dataGridViewPatAppo.DataSource = ph.GetAll();
            }
            catch
            {
                MessageBox.Show("Please Enter All Information to Add to Table");
            }


            
        }
        private void buttonPatDel_Click(object sender, EventArgs e)
        {
            try
            {
                string delID = label9.Text;
                ph.delPatient(int.Parse(delID));
                label9.Text = "Select ID";
                dataGridViewPatient.DataSource = ph.GetAll();
                dataGridViewPatAppo.DataSource = ph.GetAll();
            }           
            catch
            {
                MessageBox.Show("Please Select From Table to Delete");
            }

        }

        private void buttonPatUpdate_Click(object sender, EventArgs e)
        {
            Pati pat = new Pati();          
            try
            {
                if(label9.Text =="Select ID")
                {
                    MessageBox.Show("Please Select Patient");
                }
                else
                {
                    pat.patientID = int.Parse(label9.Text);
                    pat.patientName = textBoxPatName.Text;
                    pat.patientMail = textBoxPatMail.Text;
                    pat.clinic = comboBoxPatClinic.SelectedItem.ToString();
                    if (radioButtonMale.Checked)
                    {
                        pat.patientGender = "Male";
                    }
                    else
                    {
                        pat.patientGender = "Female";
                    }
                    pat.patientBlood = comboBoxBlood.SelectedItem.ToString();
                    pat.patientAge = int.Parse(textBoxPatAge.Text);
                    pat.patientPhone = textBoxPatPhone.Text.ToString();
                    pat.patientTCNO = textBoxPatTc.Text.ToString();
                    ph.updPatient(pat, textBoxPatMail, textBoxPatAge, textBoxPatPhone, textBoxPatTc);
                    dataGridViewPatient.DataSource = ph.GetAll();
                    dataGridViewPatAppo.DataSource = ph.GetAll();
                    label9.Text = "Select ID";
                }
            }
            catch
            {
                MessageBox.Show("Error While Updating Data");
            }
        }
        //Doctor CRUD
        private void buttonDocAdd_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            try
            {
                doc.doctorName = textBoxDocName.Text;
                doc.doctorMail = textBoxDocMail.Text;
                doc.clinic = comboBoxDocClinic.SelectedItem.ToString();
                if (radioButtonDocMale.Checked)
                {
                    doc.doctorGender = "Male";
                }
                else
                {
                    doc.doctorGender = "Female";
                }
                doc.password = textBoxDocPw.Text.ToString();
                doc.doctorAge = int.Parse(textBoxDocAge.Text);
                doc.doctorPhone = textBoxDocPhone.Text.ToString();
                doc.doctorTCNO = textBoxDocTc.Text.ToString();
                dh.addDoctor(doc, textBoxDocMail, textBoxDocAge, textBoxDocPhone, textBoxDocTc);
                dataGridViewDoctor.DataSource = dh.GetAll();
            }
            catch
            {
                MessageBox.Show("Please Enter All Information to Add to Table");
            }


        }
        private void buttonDocUpdate_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            try
            {
                if (label10.Text == "Select ID")
                {
                    MessageBox.Show("Please Select Patient");
                }
                else
                {
                    doc.doctorID = int.Parse(label10.Text);
                    doc.doctorName = textBoxDocName.Text;
                    doc.doctorMail = textBoxDocMail.Text;
                    doc.clinic = comboBoxDocClinic.SelectedItem.ToString();
                    if (radioButtonDocMale.Checked)
                    {
                        doc.doctorGender = "Male";
                    }
                    else
                    {
                        doc.doctorGender = "Female";
                    }
                    doc.password = textBoxDocPw.Text.ToString();
                    doc.doctorAge = int.Parse(textBoxDocAge.Text);
                    doc.doctorPhone = textBoxDocPhone.Text.ToString();
                    doc.doctorTCNO = textBoxDocTc.Text.ToString();
                    dh.updDoctor(doc, textBoxDocMail, textBoxDocAge, textBoxDocPhone, textBoxDocTc);
                    dataGridViewDoctor.DataSource = dh.GetAll();
                    label10.Text = "Select ID";
                }

            }
            catch
            {
                MessageBox.Show("Error While Updating Data");
            }
        }
        private void buttonDocDel_Click(object sender, EventArgs e)
        {
            try
            {
                string delID = label10.Text;
                dh.delDoctor(int.Parse(delID));
                label10.Text = "Select ID";
                dataGridViewDoctor.DataSource = dh.GetAll();
            }
            catch
            {
                MessageBox.Show("Please Select From Table to Delete");
            }
        }
        //Secretary CRUD
        private void buttonSecAdd_Click(object sender, EventArgs e)
        {
            Secretary sec = new Secretary();
            try
            {
                sec.secName = textBoxSecName.Text;
                if (radioButtonSecMale.Checked)
                {
                    sec.secGender = "Male";
                }
                else
                {
                    sec.secGender = "Female";
                }
                sec.password = textBoxSecPw.Text.ToString();
                sec.secAge = int.Parse(textBoxSecAge.Text);
                sec.secPhone = textBoxSecPhone.Text.ToString();
                sec.secTCNO = textBoxSecTc.Text.ToString();
                sh.addSecretary(sec, textBoxSecAge, textBoxSecPhone, textBoxSecTc);
                dataGridViewSec.DataSource = sh.GetAll();
            }
            catch
            {
                MessageBox.Show("Please Enter All Information to Add to Table");
            }
        }

        private void buttonSecDel_Click(object sender, EventArgs e)
        {
            try
            {
                string delID = label20.Text;
                sh.delSecretary(int.Parse(delID));
                label20.Text = "Select ID";
                dataGridViewSec.DataSource = dh.GetAll();
            }
            catch
            {
                MessageBox.Show("Please Select From Table to Delete");
            }
        }

        private void buttonSecUpd_Click(object sender, EventArgs e)
        {
            Secretary sec = new Secretary();
            try
            {
                if (label20.Text == "Select ID")
                {
                    MessageBox.Show("Please Select Patient");
                }
                else
                {
                    sec.secName = textBoxSecName.Text;
                    if (radioButtonSecMale.Checked)
                    {
                        sec.secGender = "Male";
                    }
                    else
                    {
                        sec.secGender = "Female";
                    }
                    sec.password = textBoxSecPw.Text.ToString();
                    sec.secAge = int.Parse(textBoxSecAge.Text);
                    sec.secPhone = textBoxSecPhone.Text.ToString();
                    sec.secTCNO = textBoxSecTc.Text.ToString();
                    sh.updSecretary(sec, textBoxSecAge, textBoxSecPhone, textBoxSecTc);
                    dataGridViewSec.DataSource = sh.GetAll();
                    label20.Text = "Select ID";
                }

            }
            catch
            {
                MessageBox.Show("Error While Updating Data");
            }
        }

        //Appointment CRUD
        private void buttonCreateAppo_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            try
            {
                app.doctorID = Convert.ToInt32(comboBoxDocID.SelectedItem);
                app.patientID =Convert.ToInt32(dataGridViewPatient.CurrentRow.Cells[0].Value);
                app.date = dateTimePickerAppo.Value;
                app.analysisReport = "";
                app.diagnosis = "";
                app.dialog = "";
                app.medicines = "";
                app.notes = "";
                ah.addAppo(app);
                dataGridViewAppo.DataSource = ah.getAbstract();
            }
            catch
            {
                MessageBox.Show("Please Enter All Information to Add to Table");
            }
        }


        private void buttonUpdAppo_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            try
            {
                if (Convert.ToInt32(dataGridViewAppo.CurrentRow.Cells[0].Value) <=0)
                {
                    MessageBox.Show("Please Select Appointment");
                }
                else
                {
                    app.doctorID = Convert.ToInt32(comboBoxDocID.SelectedItem);
                    app.patientID = Convert.ToInt32(dataGridViewPatient.CurrentRow.Cells[0].Value);
                    app.date = dateTimePickerAppo.Value;
                    ah.updAppo(app);
                    dataGridViewAppo.DataSource = ah.getAbstract();
                }

            }
            catch
            {
                MessageBox.Show("Error While Updating Data");
            }
        }

        private void buttonDelAppo_Click(object sender, EventArgs e)
        {
            try
            {
                string delID = dataGridViewAppo.CurrentRow.Cells[0].Value.ToString();
                ah.delAppo(int.Parse(delID));
                dataGridViewAppo.DataSource = ah.getAbstract();
                MessageBox.Show("Succesfully Deleted Appointment");
            }
            catch
            {
                MessageBox.Show("Please Select From Table to Delete");
            }
        }


        private void comboBoxAppoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDocID.SelectedIndex = comboBoxAppoDoc.SelectedIndex;
        }
    }
}
