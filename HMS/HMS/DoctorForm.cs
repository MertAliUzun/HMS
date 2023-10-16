using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using FastReport;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace HMS
{
    public partial class DoctorForm : Form
    {
        AppointmentHandler ah = new AppointmentHandler();
        PatientHandler ph = new PatientHandler();
        SqlConnection connection = DataAccess.Connection;
        Appointment app = new Appointment();
        public static int doctorID = Form1.id;
        string dialog;
        public DoctorForm()
        {
            InitializeComponent();
            tabPage1.Text = "Medical Examinations";
            tabPage2.Text = "Statistics";
            buttonBackup.Enabled = false;
            buttonRestore.Enabled = false;
            FormClosing += DoctorForm_Closing;
            //chart1.DataSource = ph.GetAll();
            Series s1 = new Series();
            comboBoxDocAppo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDocAppo.Items.Clear();
            if (ah.GetByDoctorID(doctorID).Count <= 0)
            {
                comboBoxDocAppo.Items.Clear();
                if(this.Visible == true)
                {
                    MessageBox.Show("There are no available appointments for this doctor");
                }

            }
            else
            {
                foreach (var item in ah.GetByDoctorID(doctorID))
                {
                    foreach (var i in ph.GetByAppoID(item.patientID))
                    {
                        app.patientID = item.patientID;
                        app.date = item.date;
                        comboBoxPatID.Items.Add(item.patientID);
                        comboBoxDocAppo.Items.Add(i.patientName);
                        s1.Points.AddXY(i.clinic, i);
                        
                    }
                }
                comboBoxDocAppo.SelectedIndex = 0;

            }
            chart1.Series.Add(s1);
        }
        private void DoctorForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)  //To close all forms
        {
            Application.Exit();
        }
        private void buttonAppoRep_Click(object sender, EventArgs e)
        {
            Report report1 = new Report();
            string patID = comboBoxPatID.SelectedItem.ToString();
            string s = "select *from dbo.Appointments where patientID = "+patID;
            
            report1.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\Report.frx");
            report1.RegisterData(s, "dbo.Appointments");
            //report1.Design();
            report1.Show();
        }  //Opens report page to get pdf, print or mail the report

        private void buttonEndAppo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDocAppo.SelectedIndex >=0)
                {
                    dialog = textBoxAppDialog.Text;
                    app.doctorID = doctorID;
                    app.dialog = dialog;
                    app.notes = textBoxAppNotes.Text;
                    app.analysisReport = textBoxAppAnalysis.Text;
                    app.diagnosis = textBoxAppDiagnos.Text;
                    app.medicines = textBoxAppMed.Text;
                    ah.endAppo(app);

                }
                else
                {
                    MessageBox.Show("Please Select Appointment");

                }

            }
            catch
            {
                MessageBox.Show("Error While Updating Data");
            }
        }  //Ends the medical examination

        private void buttonMail_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ph.GetOne(Convert.ToInt32(comboBoxPatID.SelectedItem)))
                {
                    string mail = item.patientMail;
                    System.Diagnostics.Process.Start(mail + "?subject=" + dialog);
                }
            }
            catch
            {
                MessageBox.Show("Error While Sending mail. You can try to send mail by creating pdf file from report button.");
            }

        }  //Mails dialogue to patient

        private void comboBoxDocAppo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPatID.SelectedIndex = comboBoxDocAppo.SelectedIndex;
        }


        private void buttonBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxBackup.Text = dlg.SelectedPath;
                buttonBackup.Enabled = true;
            }
        } //Selects a location to backup

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try { connection.Close(); } catch { }
            connection.Open();
            string database = DataAccess.GetDataBaseName();
            if (textBoxBackup.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Yedekleme Yapacağınız Yeri Seçiniz.");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBoxBackup.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH--mm-ss") + ".bak'";
                DataAccess.ExecuteQuery(cmd);
                MessageBox.Show("Başarılı bir şekilde veritabanı yedeği alınmıştır");
                buttonBackup.Enabled = false;

            }
            try
            {
                connection.Close();
            }
            catch
            {

            }
        }  //Backups database to selected location

        private void buttonRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxRestore.Text = dlg.FileName;
                buttonRestore.Enabled = true;

            }
        } //Selects a location to restore

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try { connection.Close(); } catch { }
            connection.Open();
            string database = DataAccess.GetDataBaseName();
            try
            {
                string cmd = "RESTORE DATABASE [" + database + "] FROM DISK='" + textBoxRestore.Text + "'WITH REPLACE;";
                DataAccess.ExecuteQuery(cmd);

                MessageBox.Show("Veritabanınız başarılı bir şekilde yüklenmiştir");

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error While Restoring");
            }
        }  //Restores database from selected file
    }
}
