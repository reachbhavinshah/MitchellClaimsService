namespace ClaimsService.Client
{
    partial class Claims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Claims));
            this.lblStartDate = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGetClaims = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClaimXML = new System.Windows.Forms.Label();
            this.txtClaimXML = new System.Windows.Forms.TextBox();
            this.btnCreateClaim = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnGetClaim = new System.Windows.Forms.Button();
            this.txtClaimNumber = new System.Windows.Forms.TextBox();
            this.lblClaimNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(17, 26);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(98, 21);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(199, 20);
            this.startDatePicker.TabIndex = 3;
            this.startDatePicker.Value = new System.DateTime(2014, 7, 2, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(17, 60);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(98, 54);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 5;
            // 
            // btnGetClaims
            // 
            this.btnGetClaims.Location = new System.Drawing.Point(361, 33);
            this.btnGetClaims.Name = "btnGetClaims";
            this.btnGetClaims.Size = new System.Drawing.Size(75, 23);
            this.btnGetClaims.TabIndex = 7;
            this.btnGetClaims.Text = "Get Claims";
            this.btnGetClaims.UseVisualStyleBackColor = true;
            this.btnGetClaims.Click += new System.EventHandler(this.btnGetClaims_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result";
            // 
            // lblClaimXML
            // 
            this.lblClaimXML.AutoSize = true;
            this.lblClaimXML.Location = new System.Drawing.Point(19, 25);
            this.lblClaimXML.Name = "lblClaimXML";
            this.lblClaimXML.Size = new System.Drawing.Size(57, 13);
            this.lblClaimXML.TabIndex = 10;
            this.lblClaimXML.Text = "Claim XML";
            // 
            // txtClaimXML
            // 
            this.txtClaimXML.Location = new System.Drawing.Point(22, 41);
            this.txtClaimXML.Multiline = true;
            this.txtClaimXML.Name = "txtClaimXML";
            this.txtClaimXML.Size = new System.Drawing.Size(401, 128);
            this.txtClaimXML.TabIndex = 11;
            this.txtClaimXML.Text = resources.GetString("txtClaimXML.Text");
            // 
            // btnCreateClaim
            // 
            this.btnCreateClaim.Location = new System.Drawing.Point(429, 87);
            this.btnCreateClaim.Name = "btnCreateClaim";
            this.btnCreateClaim.Size = new System.Drawing.Size(75, 23);
            this.btnCreateClaim.TabIndex = 12;
            this.btnCreateClaim.Text = "Create Claim";
            this.btnCreateClaim.UseVisualStyleBackColor = true;
            this.btnCreateClaim.Click += new System.EventHandler(this.btnCreateClaim_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(35, 220);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1000, 229);
            this.txtResult.TabIndex = 13;
            this.txtResult.Text = "";
            // 
            // btnGetClaim
            // 
            this.btnGetClaim.Location = new System.Drawing.Point(361, 25);
            this.btnGetClaim.Name = "btnGetClaim";
            this.btnGetClaim.Size = new System.Drawing.Size(75, 23);
            this.btnGetClaim.TabIndex = 6;
            this.btnGetClaim.Text = "Get Claim";
            this.btnGetClaim.UseVisualStyleBackColor = true;
            this.btnGetClaim.Click += new System.EventHandler(this.btnGetClaim_Click);
            // 
            // txtClaimNumber
            // 
            this.txtClaimNumber.Location = new System.Drawing.Point(98, 25);
            this.txtClaimNumber.Name = "txtClaimNumber";
            this.txtClaimNumber.Size = new System.Drawing.Size(257, 20);
            this.txtClaimNumber.TabIndex = 1;
            this.txtClaimNumber.Text = "22c9c23bac142856018ce14a26b6c299";
            // 
            // lblClaimNumber
            // 
            this.lblClaimNumber.AutoSize = true;
            this.lblClaimNumber.Location = new System.Drawing.Point(17, 28);
            this.lblClaimNumber.Name = "lblClaimNumber";
            this.lblClaimNumber.Size = new System.Drawing.Size(72, 13);
            this.lblClaimNumber.TabIndex = 0;
            this.lblClaimNumber.Text = "Claim Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClaimNumber);
            this.groupBox1.Controls.Add(this.txtClaimNumber);
            this.groupBox1.Controls.Add(this.btnGetClaim);
            this.groupBox1.Location = new System.Drawing.Point(35, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 65);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Claim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStartDate);
            this.groupBox2.Controls.Add(this.startDatePicker);
            this.groupBox2.Controls.Add(this.btnGetClaims);
            this.groupBox2.Controls.Add(this.lblEndDate);
            this.groupBox2.Controls.Add(this.endDatePicker);
            this.groupBox2.Location = new System.Drawing.Point(35, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 88);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Multiple Claims";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblClaimXML);
            this.groupBox3.Controls.Add(this.txtClaimXML);
            this.groupBox3.Controls.Add(this.btnCreateClaim);
            this.groupBox3.Location = new System.Drawing.Point(525, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 175);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Claim";
            // 
            // Claims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Name = "Claims";
            this.Text = "Claims Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button btnGetClaims;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClaimXML;
        private System.Windows.Forms.TextBox txtClaimXML;
        private System.Windows.Forms.Button btnCreateClaim;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnGetClaim;
        private System.Windows.Forms.TextBox txtClaimNumber;
        private System.Windows.Forms.Label lblClaimNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

