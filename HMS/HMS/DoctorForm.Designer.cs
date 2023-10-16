
namespace HMS
{
    partial class DoctorForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxAppDialog = new System.Windows.Forms.TextBox();
            this.textBoxAppAnalysis = new System.Windows.Forms.TextBox();
            this.textBoxAppNotes = new System.Windows.Forms.TextBox();
            this.textBoxAppDiagnos = new System.Windows.Forms.TextBox();
            this.textBoxAppMed = new System.Windows.Forms.TextBox();
            this.comboBoxDocAppo = new System.Windows.Forms.ComboBox();
            this.buttonEndAppo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxPatID = new System.Windows.Forms.ComboBox();
            this.buttonMail = new System.Windows.Forms.Button();
            this.buttonAppoRep = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonRestoreBrowse = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.buttonBackupBrowse = new System.Windows.Forms.Button();
            this.textBoxBackup = new System.Windows.Forms.TextBox();
            this.patisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDBDataSet = new HMS.HospitalDBDataSet();
            this.patisTableAdapter = new HMS.HospitalDBDataSetTableAdapters.PatisTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAppDialog
            // 
            this.textBoxAppDialog.Location = new System.Drawing.Point(8, 6);
            this.textBoxAppDialog.Multiline = true;
            this.textBoxAppDialog.Name = "textBoxAppDialog";
            this.textBoxAppDialog.Size = new System.Drawing.Size(533, 613);
            this.textBoxAppDialog.TabIndex = 0;
            this.textBoxAppDialog.Text = "Enter Dialogue Here";
            // 
            // textBoxAppAnalysis
            // 
            this.textBoxAppAnalysis.Location = new System.Drawing.Point(1007, 204);
            this.textBoxAppAnalysis.Multiline = true;
            this.textBoxAppAnalysis.Name = "textBoxAppAnalysis";
            this.textBoxAppAnalysis.Size = new System.Drawing.Size(306, 188);
            this.textBoxAppAnalysis.TabIndex = 4;
            this.textBoxAppAnalysis.Text = "Enter AnalysisReport Here";
            // 
            // textBoxAppNotes
            // 
            this.textBoxAppNotes.Location = new System.Drawing.Point(655, 204);
            this.textBoxAppNotes.Multiline = true;
            this.textBoxAppNotes.Name = "textBoxAppNotes";
            this.textBoxAppNotes.Size = new System.Drawing.Size(306, 188);
            this.textBoxAppNotes.TabIndex = 5;
            this.textBoxAppNotes.Text = "Enter Notes Here";
            // 
            // textBoxAppDiagnos
            // 
            this.textBoxAppDiagnos.Location = new System.Drawing.Point(655, 413);
            this.textBoxAppDiagnos.Multiline = true;
            this.textBoxAppDiagnos.Name = "textBoxAppDiagnos";
            this.textBoxAppDiagnos.Size = new System.Drawing.Size(306, 188);
            this.textBoxAppDiagnos.TabIndex = 6;
            this.textBoxAppDiagnos.Text = "Enter Diagnosis Here";
            // 
            // textBoxAppMed
            // 
            this.textBoxAppMed.Location = new System.Drawing.Point(1007, 413);
            this.textBoxAppMed.Multiline = true;
            this.textBoxAppMed.Name = "textBoxAppMed";
            this.textBoxAppMed.Size = new System.Drawing.Size(306, 188);
            this.textBoxAppMed.TabIndex = 7;
            this.textBoxAppMed.Text = "Enter Medicines Here";
            // 
            // comboBoxDocAppo
            // 
            this.comboBoxDocAppo.FormattingEnabled = true;
            this.comboBoxDocAppo.Location = new System.Drawing.Point(655, 57);
            this.comboBoxDocAppo.Name = "comboBoxDocAppo";
            this.comboBoxDocAppo.Size = new System.Drawing.Size(128, 24);
            this.comboBoxDocAppo.TabIndex = 8;
            this.comboBoxDocAppo.SelectedIndexChanged += new System.EventHandler(this.comboBoxDocAppo_SelectedIndexChanged);
            // 
            // buttonEndAppo
            // 
            this.buttonEndAppo.Location = new System.Drawing.Point(836, 36);
            this.buttonEndAppo.Name = "buttonEndAppo";
            this.buttonEndAppo.Size = new System.Drawing.Size(177, 64);
            this.buttonEndAppo.TabIndex = 9;
            this.buttonEndAppo.Text = "Add";
            this.buttonEndAppo.UseVisualStyleBackColor = true;
            this.buttonEndAppo.Click += new System.EventHandler(this.buttonEndAppo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1339, 654);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxPatID);
            this.tabPage1.Controls.Add(this.buttonMail);
            this.tabPage1.Controls.Add(this.buttonAppoRep);
            this.tabPage1.Controls.Add(this.textBoxAppDialog);
            this.tabPage1.Controls.Add(this.buttonEndAppo);
            this.tabPage1.Controls.Add(this.comboBoxDocAppo);
            this.tabPage1.Controls.Add(this.textBoxAppMed);
            this.tabPage1.Controls.Add(this.textBoxAppNotes);
            this.tabPage1.Controls.Add(this.textBoxAppAnalysis);
            this.tabPage1.Controls.Add(this.textBoxAppDiagnos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1331, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxPatID
            // 
            this.comboBoxPatID.FormattingEnabled = true;
            this.comboBoxPatID.Location = new System.Drawing.Point(655, 132);
            this.comboBoxPatID.Name = "comboBoxPatID";
            this.comboBoxPatID.Size = new System.Drawing.Size(128, 24);
            this.comboBoxPatID.TabIndex = 12;
            this.comboBoxPatID.Visible = false;
            // 
            // buttonMail
            // 
            this.buttonMail.Location = new System.Drawing.Point(950, 122);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(177, 64);
            this.buttonMail.TabIndex = 11;
            this.buttonMail.Text = "Mail";
            this.buttonMail.UseVisualStyleBackColor = true;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // buttonAppoRep
            // 
            this.buttonAppoRep.Location = new System.Drawing.Point(1059, 36);
            this.buttonAppoRep.Name = "buttonAppoRep";
            this.buttonAppoRep.Size = new System.Drawing.Size(177, 64);
            this.buttonAppoRep.TabIndex = 10;
            this.buttonAppoRep.Text = "Report";
            this.buttonAppoRep.UseVisualStyleBackColor = true;
            this.buttonAppoRep.Click += new System.EventHandler(this.buttonAppoRep_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.buttonRestore);
            this.tabPage2.Controls.Add(this.buttonRestoreBrowse);
            this.tabPage2.Controls.Add(this.buttonBackup);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.textBoxRestore);
            this.tabPage2.Controls.Add(this.buttonBackupBrowse);
            this.tabPage2.Controls.Add(this.textBoxBackup);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1331, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(991, 132);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(405, 408);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(134, 61);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonRestoreBrowse
            // 
            this.buttonRestoreBrowse.Location = new System.Drawing.Point(185, 408);
            this.buttonRestoreBrowse.Name = "buttonRestoreBrowse";
            this.buttonRestoreBrowse.Size = new System.Drawing.Size(134, 61);
            this.buttonRestoreBrowse.TabIndex = 5;
            this.buttonRestoreBrowse.Text = "Browse";
            this.buttonRestoreBrowse.UseVisualStyleBackColor = true;
            this.buttonRestoreBrowse.Click += new System.EventHandler(this.buttonRestoreBrowse_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(405, 185);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(134, 61);
            this.buttonBackup.TabIndex = 4;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(641, 132);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRestore.Location = new System.Drawing.Point(185, 347);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(354, 34);
            this.textBoxRestore.TabIndex = 2;
            // 
            // buttonBackupBrowse
            // 
            this.buttonBackupBrowse.Location = new System.Drawing.Point(185, 185);
            this.buttonBackupBrowse.Name = "buttonBackupBrowse";
            this.buttonBackupBrowse.Size = new System.Drawing.Size(134, 61);
            this.buttonBackupBrowse.TabIndex = 1;
            this.buttonBackupBrowse.Text = "Browse";
            this.buttonBackupBrowse.UseVisualStyleBackColor = true;
            this.buttonBackupBrowse.Click += new System.EventHandler(this.buttonBackupBrowse_Click);
            // 
            // textBoxBackup
            // 
            this.textBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBackup.Location = new System.Drawing.Point(185, 132);
            this.textBoxBackup.Name = "textBoxBackup";
            this.textBoxBackup.Size = new System.Drawing.Size(354, 34);
            this.textBoxBackup.TabIndex = 0;
            // 
            // patisBindingSource
            // 
            this.patisBindingSource.DataMember = "Patis";
            this.patisBindingSource.DataSource = this.hospitalDBDataSetBindingSource;
            // 
            // hospitalDBDataSetBindingSource
            // 
            this.hospitalDBDataSetBindingSource.DataSource = this.hospitalDBDataSet;
            this.hospitalDBDataSetBindingSource.Position = 0;
            // 
            // hospitalDBDataSet
            // 
            this.hospitalDBDataSet.DataSetName = "HospitalDBDataSet";
            this.hospitalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patisTableAdapter
            // 
            this.patisTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAppDialog;
        private System.Windows.Forms.TextBox textBoxAppAnalysis;
        private System.Windows.Forms.TextBox textBoxAppNotes;
        private System.Windows.Forms.TextBox textBoxAppDiagnos;
        private System.Windows.Forms.TextBox textBoxAppMed;
        private System.Windows.Forms.ComboBox comboBoxDocAppo;
        private System.Windows.Forms.Button buttonEndAppo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAppoRep;
        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.ComboBox comboBoxPatID;
        private System.Windows.Forms.BindingSource hospitalDBDataSetBindingSource;
        private HospitalDBDataSet hospitalDBDataSet;
        private System.Windows.Forms.BindingSource patisBindingSource;
        private HospitalDBDataSetTableAdapters.PatisTableAdapter patisTableAdapter;
        private System.Windows.Forms.Button buttonBackupBrowse;
        private System.Windows.Forms.TextBox textBoxBackup;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonRestoreBrowse;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxRestore;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}