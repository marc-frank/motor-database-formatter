namespace Motor_Database_Formatter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblImage = new Label();
            txtImage = new TextBox();
            txtManufacturer = new TextBox();
            lblManufacturer = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtStatorDiameter = new TextBox();
            lblStatorDiameter = new Label();
            txtStatorHeight = new TextBox();
            lblStatorHeight = new Label();
            txtStatorConfiguration = new TextBox();
            lblStatorConfiguration = new Label();
            txtFluxDirection = new TextBox();
            lblFluxDirection = new Label();
            txtKV = new TextBox();
            lblKV = new Label();
            txtInternalResistance = new TextBox();
            lblInternalResistance = new Label();
            txtEnamelType = new TextBox();
            lblEnamelType = new Label();
            txtEfficiency = new TextBox();
            lblEfficiency = new Label();
            txtRatedTorque = new TextBox();
            lblRatedTorque = new Label();
            txtWeightInclCable = new TextBox();
            lblWeightInclCable = new Label();
            txtWeightExclCable = new TextBox();
            lblWeightExclCable = new Label();
            txtMountingScrewThread = new TextBox();
            lblMountingScrewThread = new Label();
            txtMaximumOperatingTemperature = new TextBox();
            lblMaximumOperatingTemperature = new Label();
            txtCoolingMethod = new TextBox();
            lblCoolingMethod = new Label();
            txtIPRating = new TextBox();
            lblIPRating = new Label();
            txtLink = new TextBox();
            lblLink = new Label();
            txtNumberOfMountingScrews = new TextBox();
            lblNumberOfMountingScrews = new Label();
            txtMountingCircle = new TextBox();
            lblMountingCircle = new Label();
            txtMagnetType = new TextBox();
            lblMagnetType = new Label();
            txtBearingType = new TextBox();
            lblBearingType = new Label();
            txtShaftRetention = new TextBox();
            lblShaftRetention = new Label();
            txtShaftDiameterInternal = new TextBox();
            lblShaftDiameterInternal = new Label();
            txtShaftDiameterExternal = new TextBox();
            lblShaftDiameterExternal = new Label();
            txtConnector = new TextBox();
            lblConnector = new Label();
            txtCableGauge = new TextBox();
            lblCableGauge = new Label();
            txtCableLength = new TextBox();
            lblCableLength = new Label();
            txtHTML = new RichTextBox();
            SuspendLayout();
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(12, 9);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(40, 15);
            lblImage.TabIndex = 0;
            lblImage.Text = "Image";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(12, 27);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(211, 23);
            txtImage.TabIndex = 1;
            txtImage.TextChanged += TextBox_TextChanged;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 71);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(211, 23);
            txtManufacturer.TabIndex = 3;
            txtManufacturer.TextChanged += TextBox_TextChanged;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(12, 53);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 2;
            lblManufacturer.Text = "Manufacturer";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 23);
            txtName.TabIndex = 5;
            txtName.TextChanged += TextBox_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 159);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(211, 23);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += TextBox_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 141);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price [$]";
            // 
            // txtStatorDiameter
            // 
            txtStatorDiameter.Location = new Point(12, 203);
            txtStatorDiameter.Name = "txtStatorDiameter";
            txtStatorDiameter.Size = new Size(211, 23);
            txtStatorDiameter.TabIndex = 9;
            txtStatorDiameter.TextChanged += TextBox_TextChanged;
            // 
            // lblStatorDiameter
            // 
            lblStatorDiameter.AutoSize = true;
            lblStatorDiameter.Location = new Point(12, 185);
            lblStatorDiameter.Name = "lblStatorDiameter";
            lblStatorDiameter.Size = new Size(122, 15);
            lblStatorDiameter.TabIndex = 8;
            lblStatorDiameter.Text = "Stator Diameter [mm]";
            // 
            // txtStatorHeight
            // 
            txtStatorHeight.Location = new Point(12, 247);
            txtStatorHeight.Name = "txtStatorHeight";
            txtStatorHeight.Size = new Size(211, 23);
            txtStatorHeight.TabIndex = 11;
            txtStatorHeight.TextChanged += TextBox_TextChanged;
            // 
            // lblStatorHeight
            // 
            lblStatorHeight.AutoSize = true;
            lblStatorHeight.Location = new Point(12, 229);
            lblStatorHeight.Name = "lblStatorHeight";
            lblStatorHeight.Size = new Size(110, 15);
            lblStatorHeight.TabIndex = 10;
            lblStatorHeight.Text = "Stator Height [mm]";
            // 
            // txtStatorConfiguration
            // 
            txtStatorConfiguration.Location = new Point(12, 291);
            txtStatorConfiguration.Name = "txtStatorConfiguration";
            txtStatorConfiguration.Size = new Size(211, 23);
            txtStatorConfiguration.TabIndex = 13;
            txtStatorConfiguration.TextChanged += TextBox_TextChanged;
            // 
            // lblStatorConfiguration
            // 
            lblStatorConfiguration.AutoSize = true;
            lblStatorConfiguration.Location = new Point(12, 273);
            lblStatorConfiguration.Name = "lblStatorConfiguration";
            lblStatorConfiguration.Size = new Size(115, 15);
            lblStatorConfiguration.TabIndex = 12;
            lblStatorConfiguration.Text = "Stator Configuration";
            // 
            // txtFluxDirection
            // 
            txtFluxDirection.Location = new Point(12, 335);
            txtFluxDirection.Name = "txtFluxDirection";
            txtFluxDirection.Size = new Size(211, 23);
            txtFluxDirection.TabIndex = 15;
            txtFluxDirection.TextChanged += TextBox_TextChanged;
            // 
            // lblFluxDirection
            // 
            lblFluxDirection.AutoSize = true;
            lblFluxDirection.Location = new Point(12, 317);
            lblFluxDirection.Name = "lblFluxDirection";
            lblFluxDirection.Size = new Size(80, 15);
            lblFluxDirection.TabIndex = 14;
            lblFluxDirection.Text = "Flux Direction";
            // 
            // txtKV
            // 
            txtKV.Location = new Point(12, 379);
            txtKV.Name = "txtKV";
            txtKV.Size = new Size(211, 23);
            txtKV.TabIndex = 17;
            txtKV.TextChanged += TextBox_TextChanged;
            // 
            // lblKV
            // 
            lblKV.AutoSize = true;
            lblKV.Location = new Point(12, 361);
            lblKV.Name = "lblKV";
            lblKV.Size = new Size(69, 15);
            lblKV.TabIndex = 16;
            lblKV.Text = "KV [RPM/V]";
            // 
            // txtInternalResistance
            // 
            txtInternalResistance.Location = new Point(12, 423);
            txtInternalResistance.Name = "txtInternalResistance";
            txtInternalResistance.Size = new Size(211, 23);
            txtInternalResistance.TabIndex = 19;
            txtInternalResistance.TextChanged += TextBox_TextChanged;
            // 
            // lblInternalResistance
            // 
            lblInternalResistance.AutoSize = true;
            lblInternalResistance.Location = new Point(12, 405);
            lblInternalResistance.Name = "lblInternalResistance";
            lblInternalResistance.Size = new Size(136, 15);
            lblInternalResistance.TabIndex = 18;
            lblInternalResistance.Text = "Internal Resistance [mΩ]";
            // 
            // txtEnamelType
            // 
            txtEnamelType.Location = new Point(12, 467);
            txtEnamelType.Name = "txtEnamelType";
            txtEnamelType.Size = new Size(211, 23);
            txtEnamelType.TabIndex = 21;
            txtEnamelType.TextChanged += TextBox_TextChanged;
            // 
            // lblEnamelType
            // 
            lblEnamelType.AutoSize = true;
            lblEnamelType.Location = new Point(12, 449);
            lblEnamelType.Name = "lblEnamelType";
            lblEnamelType.Size = new Size(73, 15);
            lblEnamelType.TabIndex = 38;
            lblEnamelType.Text = "Enamel Type";
            // 
            // txtEfficiency
            // 
            txtEfficiency.Location = new Point(12, 511);
            txtEfficiency.Name = "txtEfficiency";
            txtEfficiency.Size = new Size(211, 23);
            txtEfficiency.TabIndex = 23;
            txtEfficiency.TextChanged += TextBox_TextChanged;
            // 
            // lblEfficiency
            // 
            lblEfficiency.AutoSize = true;
            lblEfficiency.Location = new Point(12, 493);
            lblEfficiency.Name = "lblEfficiency";
            lblEfficiency.Size = new Size(79, 15);
            lblEfficiency.TabIndex = 36;
            lblEfficiency.Text = "Efficiency [%]";
            // 
            // txtRatedTorque
            // 
            txtRatedTorque.Location = new Point(12, 555);
            txtRatedTorque.Name = "txtRatedTorque";
            txtRatedTorque.Size = new Size(211, 23);
            txtRatedTorque.TabIndex = 25;
            txtRatedTorque.TextChanged += TextBox_TextChanged;
            // 
            // lblRatedTorque
            // 
            lblRatedTorque.AutoSize = true;
            lblRatedTorque.Location = new Point(12, 537);
            lblRatedTorque.Name = "lblRatedTorque";
            lblRatedTorque.Size = new Size(107, 15);
            lblRatedTorque.TabIndex = 34;
            lblRatedTorque.Text = "Rated Torque [Nm]";
            // 
            // txtWeightInclCable
            // 
            txtWeightInclCable.Location = new Point(12, 599);
            txtWeightInclCable.Name = "txtWeightInclCable";
            txtWeightInclCable.Size = new Size(211, 23);
            txtWeightInclCable.TabIndex = 27;
            txtWeightInclCable.TextChanged += TextBox_TextChanged;
            // 
            // lblWeightInclCable
            // 
            lblWeightInclCable.AutoSize = true;
            lblWeightInclCable.Location = new Point(12, 581);
            lblWeightInclCable.Name = "lblWeightInclCable";
            lblWeightInclCable.Size = new Size(129, 15);
            lblWeightInclCable.TabIndex = 32;
            lblWeightInclCable.Text = "Weight (incl. Cable) [g]";
            // 
            // txtWeightExclCable
            // 
            txtWeightExclCable.Location = new Point(12, 643);
            txtWeightExclCable.Name = "txtWeightExclCable";
            txtWeightExclCable.Size = new Size(211, 23);
            txtWeightExclCable.TabIndex = 29;
            txtWeightExclCable.TextChanged += TextBox_TextChanged;
            // 
            // lblWeightExclCable
            // 
            lblWeightExclCable.AutoSize = true;
            lblWeightExclCable.Location = new Point(12, 625);
            lblWeightExclCable.Name = "lblWeightExclCable";
            lblWeightExclCable.Size = new Size(131, 15);
            lblWeightExclCable.TabIndex = 30;
            lblWeightExclCable.Text = "Weight (excl. Cable) [g]";
            // 
            // txtMountingScrewThread
            // 
            txtMountingScrewThread.Location = new Point(229, 467);
            txtMountingScrewThread.Name = "txtMountingScrewThread";
            txtMountingScrewThread.Size = new Size(211, 23);
            txtMountingScrewThread.TabIndex = 51;
            txtMountingScrewThread.TextChanged += TextBox_TextChanged;
            // 
            // lblMountingScrewThread
            // 
            lblMountingScrewThread.AutoSize = true;
            lblMountingScrewThread.Location = new Point(229, 449);
            lblMountingScrewThread.Name = "lblMountingScrewThread";
            lblMountingScrewThread.Size = new Size(133, 15);
            lblMountingScrewThread.TabIndex = 68;
            lblMountingScrewThread.Text = "Mounting Screw Thread";
            // 
            // txtMaximumOperatingTemperature
            // 
            txtMaximumOperatingTemperature.Location = new Point(229, 511);
            txtMaximumOperatingTemperature.Name = "txtMaximumOperatingTemperature";
            txtMaximumOperatingTemperature.Size = new Size(211, 23);
            txtMaximumOperatingTemperature.TabIndex = 53;
            txtMaximumOperatingTemperature.TextChanged += TextBox_TextChanged;
            // 
            // lblMaximumOperatingTemperature
            // 
            lblMaximumOperatingTemperature.AutoSize = true;
            lblMaximumOperatingTemperature.Location = new Point(229, 493);
            lblMaximumOperatingTemperature.Name = "lblMaximumOperatingTemperature";
            lblMaximumOperatingTemperature.Size = new Size(211, 15);
            lblMaximumOperatingTemperature.TabIndex = 66;
            lblMaximumOperatingTemperature.Text = "Maximum Operating Temperature [°C]";
            // 
            // txtCoolingMethod
            // 
            txtCoolingMethod.Location = new Point(229, 555);
            txtCoolingMethod.Name = "txtCoolingMethod";
            txtCoolingMethod.Size = new Size(211, 23);
            txtCoolingMethod.TabIndex = 55;
            txtCoolingMethod.TextChanged += TextBox_TextChanged;
            // 
            // lblCoolingMethod
            // 
            lblCoolingMethod.AutoSize = true;
            lblCoolingMethod.Location = new Point(229, 537);
            lblCoolingMethod.Name = "lblCoolingMethod";
            lblCoolingMethod.Size = new Size(94, 15);
            lblCoolingMethod.TabIndex = 64;
            lblCoolingMethod.Text = "Cooling Method";
            // 
            // txtIPRating
            // 
            txtIPRating.Location = new Point(229, 599);
            txtIPRating.Name = "txtIPRating";
            txtIPRating.Size = new Size(211, 23);
            txtIPRating.TabIndex = 57;
            txtIPRating.TextChanged += TextBox_TextChanged;
            // 
            // lblIPRating
            // 
            lblIPRating.AutoSize = true;
            lblIPRating.Location = new Point(229, 581);
            lblIPRating.Name = "lblIPRating";
            lblIPRating.Size = new Size(54, 15);
            lblIPRating.TabIndex = 62;
            lblIPRating.Text = "IP Rating";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(229, 643);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(211, 23);
            txtLink.TabIndex = 59;
            txtLink.TextChanged += TextBox_TextChanged;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(229, 625);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(29, 15);
            lblLink.TabIndex = 60;
            lblLink.Text = "Link";
            // 
            // txtNumberOfMountingScrews
            // 
            txtNumberOfMountingScrews.Location = new Point(229, 423);
            txtNumberOfMountingScrews.Name = "txtNumberOfMountingScrews";
            txtNumberOfMountingScrews.Size = new Size(211, 23);
            txtNumberOfMountingScrews.TabIndex = 49;
            txtNumberOfMountingScrews.TextChanged += TextBox_TextChanged;
            // 
            // lblNumberOfMountingScrews
            // 
            lblNumberOfMountingScrews.AutoSize = true;
            lblNumberOfMountingScrews.Location = new Point(229, 405);
            lblNumberOfMountingScrews.Name = "lblNumberOfMountingScrews";
            lblNumberOfMountingScrews.Size = new Size(160, 15);
            lblNumberOfMountingScrews.TabIndex = 58;
            lblNumberOfMountingScrews.Text = "Number of Mounting Screws";
            // 
            // txtMountingCircle
            // 
            txtMountingCircle.Location = new Point(229, 379);
            txtMountingCircle.Name = "txtMountingCircle";
            txtMountingCircle.Size = new Size(211, 23);
            txtMountingCircle.TabIndex = 47;
            txtMountingCircle.TextChanged += TextBox_TextChanged;
            // 
            // lblMountingCircle
            // 
            lblMountingCircle.AutoSize = true;
            lblMountingCircle.Location = new Point(229, 361);
            lblMountingCircle.Name = "lblMountingCircle";
            lblMountingCircle.Size = new Size(126, 15);
            lblMountingCircle.TabIndex = 56;
            lblMountingCircle.Text = "Mounting Circle [mm]";
            // 
            // txtMagnetType
            // 
            txtMagnetType.Location = new Point(229, 335);
            txtMagnetType.Name = "txtMagnetType";
            txtMagnetType.Size = new Size(211, 23);
            txtMagnetType.TabIndex = 45;
            txtMagnetType.TextChanged += TextBox_TextChanged;
            // 
            // lblMagnetType
            // 
            lblMagnetType.AutoSize = true;
            lblMagnetType.Location = new Point(229, 317);
            lblMagnetType.Name = "lblMagnetType";
            lblMagnetType.Size = new Size(75, 15);
            lblMagnetType.TabIndex = 54;
            lblMagnetType.Text = "Magnet Type";
            // 
            // txtBearingType
            // 
            txtBearingType.Location = new Point(229, 291);
            txtBearingType.Name = "txtBearingType";
            txtBearingType.Size = new Size(211, 23);
            txtBearingType.TabIndex = 43;
            txtBearingType.TextChanged += TextBox_TextChanged;
            // 
            // lblBearingType
            // 
            lblBearingType.AutoSize = true;
            lblBearingType.Location = new Point(229, 273);
            lblBearingType.Name = "lblBearingType";
            lblBearingType.Size = new Size(74, 15);
            lblBearingType.TabIndex = 52;
            lblBearingType.Text = "Bearing Type";
            // 
            // txtShaftRetention
            // 
            txtShaftRetention.Location = new Point(229, 247);
            txtShaftRetention.Name = "txtShaftRetention";
            txtShaftRetention.Size = new Size(211, 23);
            txtShaftRetention.TabIndex = 41;
            txtShaftRetention.TextChanged += TextBox_TextChanged;
            // 
            // lblShaftRetention
            // 
            lblShaftRetention.AutoSize = true;
            lblShaftRetention.Location = new Point(229, 229);
            lblShaftRetention.Name = "lblShaftRetention";
            lblShaftRetention.Size = new Size(88, 15);
            lblShaftRetention.TabIndex = 50;
            lblShaftRetention.Text = "Shaft Retention";
            // 
            // txtShaftDiameterInternal
            // 
            txtShaftDiameterInternal.Location = new Point(229, 203);
            txtShaftDiameterInternal.Name = "txtShaftDiameterInternal";
            txtShaftDiameterInternal.Size = new Size(211, 23);
            txtShaftDiameterInternal.TabIndex = 39;
            txtShaftDiameterInternal.TextChanged += TextBox_TextChanged;
            // 
            // lblShaftDiameterInternal
            // 
            lblShaftDiameterInternal.AutoSize = true;
            lblShaftDiameterInternal.Location = new Point(229, 185);
            lblShaftDiameterInternal.Name = "lblShaftDiameterInternal";
            lblShaftDiameterInternal.Size = new Size(169, 15);
            lblShaftDiameterInternal.TabIndex = 48;
            lblShaftDiameterInternal.Text = "Shaft Diameter (internal) [mm]";
            // 
            // txtShaftDiameterExternal
            // 
            txtShaftDiameterExternal.Location = new Point(229, 159);
            txtShaftDiameterExternal.Name = "txtShaftDiameterExternal";
            txtShaftDiameterExternal.Size = new Size(211, 23);
            txtShaftDiameterExternal.TabIndex = 37;
            txtShaftDiameterExternal.TextChanged += TextBox_TextChanged;
            // 
            // lblShaftDiameterExternal
            // 
            lblShaftDiameterExternal.AutoSize = true;
            lblShaftDiameterExternal.Location = new Point(229, 141);
            lblShaftDiameterExternal.Name = "lblShaftDiameterExternal";
            lblShaftDiameterExternal.Size = new Size(171, 15);
            lblShaftDiameterExternal.TabIndex = 46;
            lblShaftDiameterExternal.Text = "Shaft Diameter (external) [mm]";
            // 
            // txtConnector
            // 
            txtConnector.Location = new Point(229, 115);
            txtConnector.Name = "txtConnector";
            txtConnector.Size = new Size(211, 23);
            txtConnector.TabIndex = 35;
            txtConnector.TextChanged += TextBox_TextChanged;
            // 
            // lblConnector
            // 
            lblConnector.AutoSize = true;
            lblConnector.Location = new Point(229, 97);
            lblConnector.Name = "lblConnector";
            lblConnector.Size = new Size(63, 15);
            lblConnector.TabIndex = 44;
            lblConnector.Text = "Connector";
            // 
            // txtCableGauge
            // 
            txtCableGauge.Location = new Point(229, 71);
            txtCableGauge.Name = "txtCableGauge";
            txtCableGauge.Size = new Size(211, 23);
            txtCableGauge.TabIndex = 33;
            txtCableGauge.TextChanged += TextBox_TextChanged;
            // 
            // lblCableGauge
            // 
            lblCableGauge.AutoSize = true;
            lblCableGauge.Location = new Point(229, 53);
            lblCableGauge.Name = "lblCableGauge";
            lblCableGauge.Size = new Size(111, 15);
            lblCableGauge.TabIndex = 42;
            lblCableGauge.Text = "Cable Gauge [AWG]";
            // 
            // txtCableLength
            // 
            txtCableLength.Location = new Point(229, 27);
            txtCableLength.Name = "txtCableLength";
            txtCableLength.Size = new Size(211, 23);
            txtCableLength.TabIndex = 31;
            txtCableLength.TextChanged += TextBox_TextChanged;
            // 
            // lblCableLength
            // 
            lblCableLength.AutoSize = true;
            lblCableLength.Location = new Point(229, 9);
            lblCableLength.Name = "lblCableLength";
            lblCableLength.Size = new Size(107, 15);
            lblCableLength.TabIndex = 40;
            lblCableLength.Text = "Cable length [mm]";
            // 
            // txtHTML
            // 
            txtHTML.Location = new Point(446, 12);
            txtHTML.Name = "txtHTML";
            txtHTML.ReadOnly = true;
            txtHTML.Size = new Size(562, 654);
            txtHTML.TabIndex = 61;
            txtHTML.TabStop = false;
            txtHTML.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 678);
            Controls.Add(txtHTML);
            Controls.Add(txtMountingScrewThread);
            Controls.Add(lblMountingScrewThread);
            Controls.Add(txtMaximumOperatingTemperature);
            Controls.Add(lblMaximumOperatingTemperature);
            Controls.Add(txtCoolingMethod);
            Controls.Add(lblCoolingMethod);
            Controls.Add(txtIPRating);
            Controls.Add(lblIPRating);
            Controls.Add(txtLink);
            Controls.Add(lblLink);
            Controls.Add(txtNumberOfMountingScrews);
            Controls.Add(lblNumberOfMountingScrews);
            Controls.Add(txtMountingCircle);
            Controls.Add(lblMountingCircle);
            Controls.Add(txtMagnetType);
            Controls.Add(lblMagnetType);
            Controls.Add(txtBearingType);
            Controls.Add(lblBearingType);
            Controls.Add(txtShaftRetention);
            Controls.Add(lblShaftRetention);
            Controls.Add(txtShaftDiameterInternal);
            Controls.Add(lblShaftDiameterInternal);
            Controls.Add(txtShaftDiameterExternal);
            Controls.Add(lblShaftDiameterExternal);
            Controls.Add(txtConnector);
            Controls.Add(lblConnector);
            Controls.Add(txtCableGauge);
            Controls.Add(lblCableGauge);
            Controls.Add(txtCableLength);
            Controls.Add(lblCableLength);
            Controls.Add(txtEnamelType);
            Controls.Add(lblEnamelType);
            Controls.Add(txtEfficiency);
            Controls.Add(lblEfficiency);
            Controls.Add(txtRatedTorque);
            Controls.Add(lblRatedTorque);
            Controls.Add(txtWeightInclCable);
            Controls.Add(lblWeightInclCable);
            Controls.Add(txtWeightExclCable);
            Controls.Add(lblWeightExclCable);
            Controls.Add(txtInternalResistance);
            Controls.Add(lblInternalResistance);
            Controls.Add(txtKV);
            Controls.Add(lblKV);
            Controls.Add(txtFluxDirection);
            Controls.Add(lblFluxDirection);
            Controls.Add(txtStatorConfiguration);
            Controls.Add(lblStatorConfiguration);
            Controls.Add(txtStatorHeight);
            Controls.Add(lblStatorHeight);
            Controls.Add(txtStatorDiameter);
            Controls.Add(lblStatorDiameter);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtManufacturer);
            Controls.Add(lblManufacturer);
            Controls.Add(txtImage);
            Controls.Add(lblImage);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Motor Database Formatter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImage;
        private TextBox txtImage;
        private TextBox txtManufacturer;
        private Label lblManufacturer;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtStatorDiameter;
        private Label lblStatorDiameter;
        private TextBox txtStatorHeight;
        private Label lblStatorHeight;
        private TextBox txtStatorConfiguration;
        private Label lblStatorConfiguration;
        private TextBox txtFluxDirection;
        private Label lblFluxDirection;
        private TextBox txtKV;
        private Label lblKV;
        private TextBox txtInternalResistance;
        private Label lblInternalResistance;
        private TextBox txtEnamelType;
        private Label lblEnamelType;
        private TextBox txtEfficiency;
        private Label lblEfficiency;
        private TextBox txtRatedTorque;
        private Label lblRatedTorque;
        private TextBox txtWeightInclCable;
        private Label lblWeightInclCable;
        private TextBox txtWeightExclCable;
        private Label lblWeightExclCable;
        private TextBox txtMountingScrewThread;
        private Label lblMountingScrewThread;
        private TextBox txtMaximumOperatingTemperature;
        private Label lblMaximumOperatingTemperature;
        private TextBox txtCoolingMethod;
        private Label lblCoolingMethod;
        private TextBox txtIPRating;
        private Label lblIPRating;
        private TextBox txtLink;
        private Label lblLink;
        private TextBox txtNumberOfMountingScrews;
        private Label lblNumberOfMountingScrews;
        private TextBox txtMountingCircle;
        private Label lblMountingCircle;
        private TextBox txtMagnetType;
        private Label lblMagnetType;
        private TextBox txtBearingType;
        private Label lblBearingType;
        private TextBox txtShaftRetention;
        private Label lblShaftRetention;
        private TextBox txtShaftDiameterInternal;
        private Label lblShaftDiameterInternal;
        private TextBox txtShaftDiameterExternal;
        private Label lblShaftDiameterExternal;
        private TextBox txtConnector;
        private Label lblConnector;
        private TextBox txtCableGauge;
        private Label lblCableGauge;
        private TextBox txtCableLength;
        private Label lblCableLength;
        private RichTextBox txtHTML;
    }
}