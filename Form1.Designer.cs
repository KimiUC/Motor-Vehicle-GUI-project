namespace DMV_GUI
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
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.dateOfProdLabel = new System.Windows.Forms.Label();
            this.noOfWheelsLabel = new System.Windows.Forms.Label();
            this.noOfSeatsLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NoOfWheels = new System.Windows.Forms.NumericUpDown();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonMotorcycle = new System.Windows.Forms.RadioButton();
            this.radioButtonTaxi = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.radioButtonTruck = new System.Windows.Forms.RadioButton();
            this.buttonRegVeh = new System.Windows.Forms.Button();
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).BeginInit();
            this.vehicleTypeGroupBox.SuspendLayout();
            this.groupBoxVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.Location = new System.Drawing.Point(6, 29);
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(192, 20);
            this.textBoxVIN.TabIndex = 0;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(6, 66);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(192, 20);
            this.textBoxMake.TabIndex = 1;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(7, 105);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(191, 20);
            this.textBoxModel.TabIndex = 2;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(173, 13);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(25, 13);
            this.VINLabel.TabIndex = 6;
            this.VINLabel.Text = "VIN";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(169, 52);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(34, 13);
            this.MakeLabel.TabIndex = 7;
            this.MakeLabel.Text = "Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(167, 89);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.Click += new System.EventHandler(this.Model_Click);
            // 
            // dateOfProdLabel
            // 
            this.dateOfProdLabel.AutoSize = true;
            this.dateOfProdLabel.Location = new System.Drawing.Point(107, 128);
            this.dateOfProdLabel.Name = "dateOfProdLabel";
            this.dateOfProdLabel.Size = new System.Drawing.Size(96, 13);
            this.dateOfProdLabel.TabIndex = 9;
            this.dateOfProdLabel.Text = "Date of Production";
            // 
            // noOfWheelsLabel
            // 
            this.noOfWheelsLabel.AutoSize = true;
            this.noOfWheelsLabel.Location = new System.Drawing.Point(108, 167);
            this.noOfWheelsLabel.Name = "noOfWheelsLabel";
            this.noOfWheelsLabel.Size = new System.Drawing.Size(95, 13);
            this.noOfWheelsLabel.TabIndex = 10;
            this.noOfWheelsLabel.Text = "Number of Wheels";
            // 
            // noOfSeatsLabel
            // 
            this.noOfSeatsLabel.AutoSize = true;
            this.noOfSeatsLabel.Location = new System.Drawing.Point(117, 206);
            this.noOfSeatsLabel.Name = "noOfSeatsLabel";
            this.noOfSeatsLabel.Size = new System.Drawing.Size(86, 13);
            this.noOfSeatsLabel.TabIndex = 11;
            this.noOfSeatsLabel.Text = "Number of Seats";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.NoOfSeats);
            this.propertiesGroupBox.Controls.Add(this.dateTimePicker1);
            this.propertiesGroupBox.Controls.Add(this.NoOfWheels);
            this.propertiesGroupBox.Controls.Add(this.radioButtonNo);
            this.propertiesGroupBox.Controls.Add(this.radioButtonYes);
            this.propertiesGroupBox.Controls.Add(this.label3);
            this.propertiesGroupBox.Controls.Add(this.label2);
            this.propertiesGroupBox.Controls.Add(this.label1);
            this.propertiesGroupBox.Controls.Add(this.textBox2);
            this.propertiesGroupBox.Controls.Add(this.textBox1);
            this.propertiesGroupBox.Controls.Add(this.textBoxVIN);
            this.propertiesGroupBox.Controls.Add(this.noOfSeatsLabel);
            this.propertiesGroupBox.Controls.Add(this.VINLabel);
            this.propertiesGroupBox.Controls.Add(this.noOfWheelsLabel);
            this.propertiesGroupBox.Controls.Add(this.textBoxMake);
            this.propertiesGroupBox.Controls.Add(this.dateOfProdLabel);
            this.propertiesGroupBox.Controls.Add(this.MakeLabel);
            this.propertiesGroupBox.Controls.Add(this.ModelLabel);
            this.propertiesGroupBox.Controls.Add(this.textBoxModel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(209, 396);
            this.propertiesGroupBox.TabIndex = 12;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "PROPERTIES";
            // 
            // NoOfSeats
            // 
            this.NoOfSeats.Location = new System.Drawing.Point(7, 222);
            this.NoOfSeats.Name = "NoOfSeats";
            this.NoOfSeats.Size = new System.Drawing.Size(191, 20);
            this.NoOfSeats.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // NoOfWheels
            // 
            this.NoOfWheels.Location = new System.Drawing.Point(6, 183);
            this.NoOfWheels.Name = "NoOfWheels";
            this.NoOfWheels.Size = new System.Drawing.Size(192, 20);
            this.NoOfWheels.TabIndex = 17;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(100, 348);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNo.TabIndex = 24;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "NO";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.Visible = false;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(48, 348);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(46, 17);
            this.radioButtonYes.TabIndex = 23;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "YES";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.Visible = false;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.radioButtonYes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // vehicleTypeGroupBox
            // 
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonMotorcycle);
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonTaxi);
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonCar);
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonBus);
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonTruck);
            this.vehicleTypeGroupBox.Location = new System.Drawing.Point(227, 12);
            this.vehicleTypeGroupBox.Name = "vehicleTypeGroupBox";
            this.vehicleTypeGroupBox.Size = new System.Drawing.Size(96, 125);
            this.vehicleTypeGroupBox.TabIndex = 13;
            this.vehicleTypeGroupBox.TabStop = false;
            this.vehicleTypeGroupBox.Text = "VEHICLE TYPE";
            // 
            // radioButtonMotorcycle
            // 
            this.radioButtonMotorcycle.AutoSize = true;
            this.radioButtonMotorcycle.Location = new System.Drawing.Point(6, 102);
            this.radioButtonMotorcycle.Name = "radioButtonMotorcycle";
            this.radioButtonMotorcycle.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMotorcycle.TabIndex = 4;
            this.radioButtonMotorcycle.TabStop = true;
            this.radioButtonMotorcycle.Text = "Motorcycle";
            this.radioButtonMotorcycle.UseVisualStyleBackColor = true;
            // 
            // radioButtonTaxi
            // 
            this.radioButtonTaxi.AutoSize = true;
            this.radioButtonTaxi.Location = new System.Drawing.Point(6, 85);
            this.radioButtonTaxi.Name = "radioButtonTaxi";
            this.radioButtonTaxi.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTaxi.TabIndex = 3;
            this.radioButtonTaxi.TabStop = true;
            this.radioButtonTaxi.Text = "Taxi";
            this.radioButtonTaxi.UseVisualStyleBackColor = true;
            this.radioButtonTaxi.CheckedChanged += new System.EventHandler(this.radioButtonTaxi_CheckedChanged);
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Location = new System.Drawing.Point(6, 66);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(41, 17);
            this.radioButtonCar.TabIndex = 2;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(6, 48);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBus.TabIndex = 1;
            this.radioButtonBus.TabStop = true;
            this.radioButtonBus.Text = "Bus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            this.radioButtonBus.CheckedChanged += new System.EventHandler(this.radioButtonBus_CheckedChanged);
            // 
            // radioButtonTruck
            // 
            this.radioButtonTruck.AutoSize = true;
            this.radioButtonTruck.Location = new System.Drawing.Point(6, 29);
            this.radioButtonTruck.Name = "radioButtonTruck";
            this.radioButtonTruck.Size = new System.Drawing.Size(53, 17);
            this.radioButtonTruck.TabIndex = 0;
            this.radioButtonTruck.TabStop = true;
            this.radioButtonTruck.Text = "Truck";
            this.radioButtonTruck.UseVisualStyleBackColor = true;
            this.radioButtonTruck.CheckedChanged += new System.EventHandler(this.radioButtonTruck_CheckedChanged);
            // 
            // buttonRegVeh
            // 
            this.buttonRegVeh.Location = new System.Drawing.Point(228, 144);
            this.buttonRegVeh.Name = "buttonRegVeh";
            this.buttonRegVeh.Size = new System.Drawing.Size(95, 132);
            this.buttonRegVeh.TabIndex = 14;
            this.buttonRegVeh.Text = "REGISTER VEHICLE";
            this.buttonRegVeh.UseVisualStyleBackColor = true;
            this.buttonRegVeh.Click += new System.EventHandler(this.buttonRegVeh_Click);
            // 
            // groupBoxVehicleInfo
            // 
            this.groupBoxVehicleInfo.Controls.Add(this.richTextBox1);
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(329, 12);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(376, 264);
            this.groupBoxVehicleInfo.TabIndex = 16;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "VEHICLE INFORMATION";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 239);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 424);
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Controls.Add(this.buttonRegVeh);
            this.Controls.Add(this.vehicleTypeGroupBox);
            this.Controls.Add(this.propertiesGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).EndInit();
            this.vehicleTypeGroupBox.ResumeLayout(false);
            this.vehicleTypeGroupBox.PerformLayout();
            this.groupBoxVehicleInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVIN;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label dateOfProdLabel;
        private System.Windows.Forms.Label noOfWheelsLabel;
        private System.Windows.Forms.Label noOfSeatsLabel;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.GroupBox vehicleTypeGroupBox;
        private System.Windows.Forms.RadioButton radioButtonTaxi;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.RadioButton radioButtonTruck;
        private System.Windows.Forms.RadioButton radioButtonMotorcycle;
        private System.Windows.Forms.Button buttonRegVeh;
        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown NoOfSeats;
        private System.Windows.Forms.NumericUpDown NoOfWheels;
    }
}

