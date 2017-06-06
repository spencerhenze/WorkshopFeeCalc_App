namespace Homework_3
{
    partial class Form1
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
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.registrationDisplayLabel = new System.Windows.Forms.Label();
            this.lodgingDisplayLabel = new System.Windows.Forms.Label();
            this.grandTotDisplayLabel = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.selWkshpLabel = new System.Windows.Forms.Label();
            this.selLocLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.wkshpComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(421, 144);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(66, 13);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Registration:";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Location = new System.Drawing.Point(439, 182);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(48, 13);
            this.lodgingLabel.TabIndex = 1;
            this.lodgingLabel.Text = "Lodging:";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(453, 228);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(34, 13);
            this.grandTotalLabel.TabIndex = 2;
            this.grandTotalLabel.Text = "Total:";
            // 
            // registrationDisplayLabel
            // 
            this.registrationDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registrationDisplayLabel.Location = new System.Drawing.Point(509, 144);
            this.registrationDisplayLabel.Name = "registrationDisplayLabel";
            this.registrationDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.registrationDisplayLabel.TabIndex = 3;
            // 
            // lodgingDisplayLabel
            // 
            this.lodgingDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lodgingDisplayLabel.Location = new System.Drawing.Point(509, 181);
            this.lodgingDisplayLabel.Name = "lodgingDisplayLabel";
            this.lodgingDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.lodgingDisplayLabel.TabIndex = 4;
            // 
            // grandTotDisplayLabel
            // 
            this.grandTotDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grandTotDisplayLabel.Location = new System.Drawing.Point(509, 219);
            this.grandTotDisplayLabel.Name = "grandTotDisplayLabel";
            this.grandTotDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.grandTotDisplayLabel.TabIndex = 5;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(203, 334);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(93, 47);
            this.calculateTotalButton.TabIndex = 6;
            this.calculateTotalButton.Text = "Calculate";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(319, 333);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 47);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(430, 333);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 47);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selWkshpLabel
            // 
            this.selWkshpLabel.AutoSize = true;
            this.selWkshpLabel.Location = new System.Drawing.Point(88, 144);
            this.selWkshpLabel.Name = "selWkshpLabel";
            this.selWkshpLabel.Size = new System.Drawing.Size(92, 13);
            this.selWkshpLabel.TabIndex = 9;
            this.selWkshpLabel.Text = "Select Workshop:";
            // 
            // selLocLabel
            // 
            this.selLocLabel.AutoSize = true;
            this.selLocLabel.Location = new System.Drawing.Point(88, 220);
            this.selLocLabel.Name = "selLocLabel";
            this.selLocLabel.Size = new System.Drawing.Size(84, 13);
            this.selLocLabel.TabIndex = 10;
            this.selLocLabel.Text = "Select Location:";
            // 
            // locationComboBox
            // 
            this.locationComboBox.AllowDrop = true;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationComboBox.Location = new System.Drawing.Point(200, 217);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(121, 21);
            this.locationComboBox.TabIndex = 12;
            this.locationComboBox.Text = "(Select One)";
            // 
            // wkshpComboBox
            // 
            this.wkshpComboBox.AllowDrop = true;
            this.wkshpComboBox.FormattingEnabled = true;
            this.wkshpComboBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.wkshpComboBox.Location = new System.Drawing.Point(200, 144);
            this.wkshpComboBox.Name = "wkshpComboBox";
            this.wkshpComboBox.Size = new System.Drawing.Size(121, 21);
            this.wkshpComboBox.TabIndex = 11;
            this.wkshpComboBox.Text = "(Select One)";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 179);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workshop Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Workshop Fee Calculator 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.wkshpComboBox);
            this.Controls.Add(this.selLocLabel);
            this.Controls.Add(this.selWkshpLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.grandTotDisplayLabel);
            this.Controls.Add(this.lodgingDisplayLabel);
            this.Controls.Add(this.registrationDisplayLabel);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Workshop Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label registrationDisplayLabel;
        private System.Windows.Forms.Label lodgingDisplayLabel;
        private System.Windows.Forms.Label grandTotDisplayLabel;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label selWkshpLabel;
        private System.Windows.Forms.Label selLocLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox wkshpComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

