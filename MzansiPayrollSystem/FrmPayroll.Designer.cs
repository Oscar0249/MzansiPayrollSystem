using System;

namespace MzansiPayrollSystem
{
    partial class FrmPayroll
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.lblDependents = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtTotalDeductions = new System.Windows.Forms.TextBox();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.lblMembership = new System.Windows.Forms.Label();
            this.txtPAYE = new System.Windows.Forms.TextBox();
            this.lblPAYE = new System.Windows.Forms.Label();
            this.txtUIF = new System.Windows.Forms.TextBox();
            this.lblUIF = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtDependents);
            this.grpInput.Controls.Add(this.lblDependents);
            this.grpInput.Controls.Add(this.txtHoursWorked);
            this.grpInput.Controls.Add(this.lblHoursWorked);
            this.grpInput.Controls.Add(this.txtContractorName);
            this.grpInput.Controls.Add(this.lblContractorName);
            this.grpInput.Location = new System.Drawing.Point(20, 20);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(400, 180);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Contractor Details";
            // 
            // txtDependents
            // 
            this.txtDependents.Location = new System.Drawing.Point(130, 112);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(200, 22);
            this.txtDependents.TabIndex = 5;
            // 
            // lblDependents
            // 
            this.lblDependents.AutoSize = true;
            this.lblDependents.Location = new System.Drawing.Point(15, 112);
            this.lblDependents.Name = "lblDependents";
            this.lblDependents.Size = new System.Drawing.Size(81, 16);
            this.lblDependents.TabIndex = 4;
            this.lblDependents.Text = "Dependents";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(130, 73);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(200, 22);
            this.txtHoursWorked.TabIndex = 3;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(15, 73);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(94, 16);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(130, 37);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(200, 22);
            this.txtContractorName.TabIndex = 1;
            // 
            // lblContractorName
            // 
            this.lblContractorName.AutoSize = true;
            this.lblContractorName.Location = new System.Drawing.Point(15, 37);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(108, 16);
            this.lblContractorName.TabIndex = 0;
            this.lblContractorName.Text = "Contractor Name";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtNetPay);
            this.grpOutput.Controls.Add(this.lblNetPay);
            this.grpOutput.Controls.Add(this.txtTotalDeductions);
            this.grpOutput.Controls.Add(this.lblTotalDeductions);
            this.grpOutput.Controls.Add(this.txtMembership);
            this.grpOutput.Controls.Add(this.lblMembership);
            this.grpOutput.Controls.Add(this.txtPAYE);
            this.grpOutput.Controls.Add(this.lblPAYE);
            this.grpOutput.Controls.Add(this.txtUIF);
            this.grpOutput.Controls.Add(this.lblUIF);
            this.grpOutput.Controls.Add(this.txtGrossPay);
            this.grpOutput.Controls.Add(this.lblGrossPay);
            this.grpOutput.Location = new System.Drawing.Point(440, 20);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(380, 300);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Payroll Results";
            // 
            // txtNetPay
            // 
            this.txtNetPay.BackColor = System.Drawing.Color.White;
            this.txtNetPay.Location = new System.Drawing.Point(180, 211);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(180, 22);
            this.txtNetPay.TabIndex = 11;
            this.txtNetPay.TabStop = false;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(34, 211);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(55, 16);
            this.lblNetPay.TabIndex = 10;
            this.lblNetPay.Text = "Net Pay";
            // 
            // txtTotalDeductions
            // 
            this.txtTotalDeductions.BackColor = System.Drawing.Color.White;
            this.txtTotalDeductions.Location = new System.Drawing.Point(180, 174);
            this.txtTotalDeductions.Name = "txtTotalDeductions";
            this.txtTotalDeductions.ReadOnly = true;
            this.txtTotalDeductions.Size = new System.Drawing.Size(180, 22);
            this.txtTotalDeductions.TabIndex = 9;
            this.txtTotalDeductions.TabStop = false;
            // 
            // lblTotalDeductions
            // 
            this.lblTotalDeductions.AutoSize = true;
            this.lblTotalDeductions.Location = new System.Drawing.Point(28, 174);
            this.lblTotalDeductions.Name = "lblTotalDeductions";
            this.lblTotalDeductions.Size = new System.Drawing.Size(109, 16);
            this.lblTotalDeductions.TabIndex = 8;
            this.lblTotalDeductions.Text = "Total Deductions";
            // 
            // txtMembership
            // 
            this.txtMembership.BackColor = System.Drawing.Color.White;
            this.txtMembership.Location = new System.Drawing.Point(180, 141);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.ReadOnly = true;
            this.txtMembership.Size = new System.Drawing.Size(180, 22);
            this.txtMembership.TabIndex = 7;
            this.txtMembership.TabStop = false;
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(31, 141);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(109, 16);
            this.lblMembership.TabIndex = 6;
            this.lblMembership.Text = "Membership Fee";
            this.lblMembership.Click += new System.EventHandler(this.lblMembership_Click);
            // 
            // txtPAYE
            // 
            this.txtPAYE.BackColor = System.Drawing.Color.White;
            this.txtPAYE.Location = new System.Drawing.Point(180, 103);
            this.txtPAYE.Name = "txtPAYE";
            this.txtPAYE.ReadOnly = true;
            this.txtPAYE.Size = new System.Drawing.Size(170, 22);
            this.txtPAYE.TabIndex = 5;
            this.txtPAYE.TabStop = false;
            // 
            // lblPAYE
            // 
            this.lblPAYE.AutoSize = true;
            this.lblPAYE.Location = new System.Drawing.Point(28, 103);
            this.lblPAYE.Name = "lblPAYE";
            this.lblPAYE.Size = new System.Drawing.Size(107, 16);
            this.lblPAYE.TabIndex = 4;
            this.lblPAYE.Text = "PAYE Deduction";
            // 
            // txtUIF
            // 
            this.txtUIF.BackColor = System.Drawing.Color.White;
            this.txtUIF.Location = new System.Drawing.Point(180, 70);
            this.txtUIF.Name = "txtUIF";
            this.txtUIF.ReadOnly = true;
            this.txtUIF.Size = new System.Drawing.Size(170, 22);
            this.txtUIF.TabIndex = 3;
            this.txtUIF.TabStop = false;
            // 
            // lblUIF
            // 
            this.lblUIF.AutoSize = true;
            this.lblUIF.Location = new System.Drawing.Point(28, 71);
            this.lblUIF.Name = "lblUIF";
            this.lblUIF.Size = new System.Drawing.Size(92, 16);
            this.lblUIF.TabIndex = 2;
            this.lblUIF.Text = "UIF Deduction";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.BackColor = System.Drawing.Color.White;
            this.txtGrossPay.Location = new System.Drawing.Point(180, 30);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(170, 22);
            this.txtGrossPay.TabIndex = 1;
            this.txtGrossPay.TabStop = false;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(31, 36);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(70, 16);
            this.lblGrossPay.TabIndex = 0;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(150, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mzansi Tech Contractors Payroll System";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblPAYE;
        private System.Windows.Forms.TextBox txtUIF;
        private System.Windows.Forms.Label lblUIF;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtPAYE;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtTotalDeductions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private readonly EventHandler txtPAYE_Click;
    }
}