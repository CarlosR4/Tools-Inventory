namespace Tools_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.viewRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.wattsLabel = new System.Windows.Forms.Label();
            this.wattsTextBox = new System.Windows.Forms.TextBox();
            this.voltsLabel = new System.Windows.Forms.Label();
            this.voltsTextBox = new System.Windows.Forms.TextBox();
            this.ampsLabel = new System.Windows.Forms.Label();
            this.ampsTextBox = new System.Windows.Forms.TextBox();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.mufflerPresentLabel = new System.Windows.Forms.Label();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.mufflerTextBox = new System.Windows.Forms.TextBox();
            this.handButton = new System.Windows.Forms.Button();
            this.pneumaticButton = new System.Windows.Forms.Button();
            this.electricButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.editRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(35, 31);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(316, 381);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Make:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weight:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(422, 54);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 8;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(422, 80);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(422, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(422, 132);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 11;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(422, 163);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 12;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(422, 196);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 13;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(422, 229);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 14;
            // 
            // viewRadioButton
            // 
            this.viewRadioButton.AutoSize = true;
            this.viewRadioButton.Checked = true;
            this.viewRadioButton.Location = new System.Drawing.Point(367, 31);
            this.viewRadioButton.Name = "viewRadioButton";
            this.viewRadioButton.Size = new System.Drawing.Size(78, 17);
            this.viewRadioButton.TabIndex = 15;
            this.viewRadioButton.TabStop = true;
            this.viewRadioButton.Text = "View Mode";
            this.viewRadioButton.UseVisualStyleBackColor = true;
            this.viewRadioButton.CheckedChanged += new System.EventHandler(this.viewRadioButton_CheckedChanged);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Location = new System.Drawing.Point(451, 31);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(74, 17);
            this.addRadioButton.TabIndex = 16;
            this.addRadioButton.Text = "Add Mode";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(482, 376);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 47);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // wattsLabel
            // 
            this.wattsLabel.AutoSize = true;
            this.wattsLabel.Location = new System.Drawing.Point(378, 265);
            this.wattsLabel.Name = "wattsLabel";
            this.wattsLabel.Size = new System.Drawing.Size(38, 13);
            this.wattsLabel.TabIndex = 18;
            this.wattsLabel.Text = "Watts:";
            this.wattsLabel.Visible = false;
            // 
            // wattsTextBox
            // 
            this.wattsTextBox.Location = new System.Drawing.Point(422, 262);
            this.wattsTextBox.Name = "wattsTextBox";
            this.wattsTextBox.Size = new System.Drawing.Size(100, 20);
            this.wattsTextBox.TabIndex = 19;
            this.wattsTextBox.Visible = false;
            // 
            // voltsLabel
            // 
            this.voltsLabel.AutoSize = true;
            this.voltsLabel.Location = new System.Drawing.Point(382, 294);
            this.voltsLabel.Name = "voltsLabel";
            this.voltsLabel.Size = new System.Drawing.Size(33, 13);
            this.voltsLabel.TabIndex = 20;
            this.voltsLabel.Text = "Volts:";
            this.voltsLabel.Visible = false;
            // 
            // voltsTextBox
            // 
            this.voltsTextBox.Location = new System.Drawing.Point(422, 291);
            this.voltsTextBox.Name = "voltsTextBox";
            this.voltsTextBox.Size = new System.Drawing.Size(100, 20);
            this.voltsTextBox.TabIndex = 21;
            this.voltsTextBox.Visible = false;
            // 
            // ampsLabel
            // 
            this.ampsLabel.AutoSize = true;
            this.ampsLabel.Location = new System.Drawing.Point(380, 319);
            this.ampsLabel.Name = "ampsLabel";
            this.ampsLabel.Size = new System.Drawing.Size(36, 13);
            this.ampsLabel.TabIndex = 22;
            this.ampsLabel.Text = "Amps:";
            this.ampsLabel.Visible = false;
            // 
            // ampsTextBox
            // 
            this.ampsTextBox.Location = new System.Drawing.Point(422, 316);
            this.ampsTextBox.Name = "ampsTextBox";
            this.ampsTextBox.ReadOnly = true;
            this.ampsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ampsTextBox.TabIndex = 23;
            this.ampsTextBox.Visible = false;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(364, 265);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(51, 13);
            this.pressureLabel.TabIndex = 24;
            this.pressureLabel.Text = "Pressure:";
            this.pressureLabel.Visible = false;
            // 
            // mufflerPresentLabel
            // 
            this.mufflerPresentLabel.AutoSize = true;
            this.mufflerPresentLabel.Location = new System.Drawing.Point(369, 294);
            this.mufflerPresentLabel.Name = "mufflerPresentLabel";
            this.mufflerPresentLabel.Size = new System.Drawing.Size(42, 13);
            this.mufflerPresentLabel.TabIndex = 25;
            this.mufflerPresentLabel.Text = "Muffler:";
            this.mufflerPresentLabel.Visible = false;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(422, 262);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.pressureTextBox.TabIndex = 26;
            this.pressureTextBox.Visible = false;
            // 
            // mufflerTextBox
            // 
            this.mufflerTextBox.Location = new System.Drawing.Point(422, 291);
            this.mufflerTextBox.Name = "mufflerTextBox";
            this.mufflerTextBox.Size = new System.Drawing.Size(100, 20);
            this.mufflerTextBox.TabIndex = 27;
            this.mufflerTextBox.Visible = false;
            // 
            // handButton
            // 
            this.handButton.Location = new System.Drawing.Point(552, 54);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(75, 23);
            this.handButton.TabIndex = 28;
            this.handButton.Text = "Hand";
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Visible = false;
            this.handButton.Click += new System.EventHandler(this.handButton_Click);
            // 
            // pneumaticButton
            // 
            this.pneumaticButton.Location = new System.Drawing.Point(633, 54);
            this.pneumaticButton.Name = "pneumaticButton";
            this.pneumaticButton.Size = new System.Drawing.Size(75, 23);
            this.pneumaticButton.TabIndex = 29;
            this.pneumaticButton.Text = "Pneumatic";
            this.pneumaticButton.UseVisualStyleBackColor = true;
            this.pneumaticButton.Visible = false;
            this.pneumaticButton.Click += new System.EventHandler(this.pneumaticButton_Click);
            // 
            // electricButton
            // 
            this.electricButton.Location = new System.Drawing.Point(714, 54);
            this.electricButton.Name = "electricButton";
            this.electricButton.Size = new System.Drawing.Size(75, 23);
            this.electricButton.TabIndex = 30;
            this.electricButton.Text = "Electric";
            this.electricButton.UseVisualStyleBackColor = true;
            this.electricButton.Visible = false;
            this.electricButton.Click += new System.EventHandler(this.electricButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(602, 347);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(186, 76);
            this.CloseButton.TabIndex = 31;
            this.CloseButton.Text = "Close and Save";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(367, 376);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 47);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editRadioButton
            // 
            this.editRadioButton.AutoSize = true;
            this.editRadioButton.Location = new System.Drawing.Point(531, 31);
            this.editRadioButton.Name = "editRadioButton";
            this.editRadioButton.Size = new System.Drawing.Size(73, 17);
            this.editRadioButton.TabIndex = 33;
            this.editRadioButton.TabStop = true;
            this.editRadioButton.Text = "Edit Mode";
            this.editRadioButton.UseVisualStyleBackColor = true;
            this.editRadioButton.CheckedChanged += new System.EventHandler(this.editRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tool Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editRadioButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.electricButton);
            this.Controls.Add(this.pneumaticButton);
            this.Controls.Add(this.handButton);
            this.Controls.Add(this.mufflerTextBox);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.mufflerPresentLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.ampsTextBox);
            this.Controls.Add(this.ampsLabel);
            this.Controls.Add(this.voltsTextBox);
            this.Controls.Add(this.voltsLabel);
            this.Controls.Add(this.wattsTextBox);
            this.Controls.Add(this.wattsLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addRadioButton);
            this.Controls.Add(this.viewRadioButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inventoryListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tool Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.RadioButton viewRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label wattsLabel;
        private System.Windows.Forms.TextBox wattsTextBox;
        private System.Windows.Forms.Label voltsLabel;
        private System.Windows.Forms.TextBox voltsTextBox;
        private System.Windows.Forms.Label ampsLabel;
        private System.Windows.Forms.TextBox ampsTextBox;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label mufflerPresentLabel;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox mufflerTextBox;
        private System.Windows.Forms.Button handButton;
        private System.Windows.Forms.Button pneumaticButton;
        private System.Windows.Forms.Button electricButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.RadioButton editRadioButton;
        private System.Windows.Forms.Label label8;
    }
}

