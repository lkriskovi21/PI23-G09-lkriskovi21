namespace Evaluation_Manager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Aktivnost = new System.Windows.Forms.Label();
            this.uvjetPotp = new System.Windows.Forms.Label();
            this.uvjetOcj = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.ocjenjivac = new System.Windows.Forms.Label();
            this.datumEval = new System.Windows.Forms.Label();
            this.bodovi = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // Aktivnost
            // 
            this.Aktivnost.AccessibleName = "";
            this.Aktivnost.AutoSize = true;
            this.Aktivnost.Location = new System.Drawing.Point(44, 65);
            this.Aktivnost.Name = "Aktivnost";
            this.Aktivnost.Size = new System.Drawing.Size(54, 13);
            this.Aktivnost.TabIndex = 0;
            this.Aktivnost.Text = "Aktivnost:";
            this.Aktivnost.Click += new System.EventHandler(this.label1_Click);
            // 
            // uvjetPotp
            // 
            this.uvjetPotp.AutoSize = true;
            this.uvjetPotp.Location = new System.Drawing.Point(304, 65);
            this.uvjetPotp.Name = "uvjetPotp";
            this.uvjetPotp.Size = new System.Drawing.Size(80, 13);
            this.uvjetPotp.TabIndex = 1;
            this.uvjetPotp.Text = "Uvjet za potpis:";
            // 
            // uvjetOcj
            // 
            this.uvjetOcj.AutoSize = true;
            this.uvjetOcj.Location = new System.Drawing.Point(546, 65);
            this.uvjetOcj.Name = "uvjetOcj";
            this.uvjetOcj.Size = new System.Drawing.Size(84, 13);
            this.uvjetOcj.TabIndex = 2;
            this.uvjetOcj.Text = "Uvjet za ocjenu:";
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(47, 90);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(254, 21);
            this.cboActivities.TabIndex = 3;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(307, 91);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(236, 20);
            this.txtMinForSignature.TabIndex = 4;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(549, 91);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(210, 20);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(47, 127);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(712, 182);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // ocjenjivac
            // 
            this.ocjenjivac.AutoSize = true;
            this.ocjenjivac.Location = new System.Drawing.Point(374, 336);
            this.ocjenjivac.Name = "ocjenjivac";
            this.ocjenjivac.Size = new System.Drawing.Size(60, 13);
            this.ocjenjivac.TabIndex = 7;
            this.ocjenjivac.Text = "Ocjenjivač:";
            // 
            // datumEval
            // 
            this.datumEval.AutoSize = true;
            this.datumEval.Location = new System.Drawing.Point(536, 336);
            this.datumEval.Name = "datumEval";
            this.datumEval.Size = new System.Drawing.Size(92, 13);
            this.datumEval.TabIndex = 8;
            this.datumEval.Text = "Datum evaluacije:";
            // 
            // bodovi
            // 
            this.bodovi.AutoSize = true;
            this.bodovi.Location = new System.Drawing.Point(672, 336);
            this.bodovi.Name = "bodovi";
            this.bodovi.Size = new System.Drawing.Size(43, 13);
            this.bodovi.TabIndex = 9;
            this.bodovi.Text = "Bodovi:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(377, 360);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(156, 20);
            this.txtTeacher.TabIndex = 10;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(539, 360);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(130, 20);
            this.txtEvaluationDate.TabIndex = 11;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(675, 361);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(84, 20);
            this.numPoints.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(675, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.bodovi);
            this.Controls.Add(this.datumEval);
            this.Controls.Add(this.ocjenjivac);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.uvjetOcj);
            this.Controls.Add(this.uvjetPotp);
            this.Controls.Add(this.Aktivnost);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aktivnost;
        private System.Windows.Forms.Label uvjetPotp;
        private System.Windows.Forms.Label uvjetOcj;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label ocjenjivac;
        private System.Windows.Forms.Label datumEval;
        private System.Windows.Forms.Label bodovi;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}