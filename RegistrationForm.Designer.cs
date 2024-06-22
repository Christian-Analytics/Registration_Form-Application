namespace Castillo_4
{
    partial class RegistrationForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrantInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.registrantStatusComboBox = new System.Windows.Forms.ComboBox();
            this.registrantStatusLabel = new System.Windows.Forms.Label();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registrationInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.maximumSelectionsLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.numberOfClassesLabel = new System.Windows.Forms.Label();
            this.totalPriceLblLabel = new System.Windows.Forms.Label();
            this.pricePerClassLblLabel = new System.Windows.Forms.Label();
            this.numberOfClassesSelectedLblLabel = new System.Windows.Forms.Label();
            this.classListBox = new System.Windows.Forms.ListBox();
            this.classSelectionLabel = new System.Windows.Forms.Label();
            this.animationPriceLabel = new System.Windows.Forms.Label();
            this.liveActionPriceLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.classTypeLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailReceiptRequestedCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.registrantInformationGroupBox.SuspendLayout();
            this.registrationInformationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Tan;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleLabel.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(236, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 128);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Hopkins Film School";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.AutoSize = true;
            this.registrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDateLabel.Location = new System.Drawing.Point(89, 177);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(154, 22);
            this.registrationDateLabel.TabIndex = 2;
            this.registrationDateLabel.Text = "Registration Date:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(254, 175);
            this.dateMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(98, 26);
            this.dateMaskedTextBox.TabIndex = 3;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrantInformationGroupBox
            // 
            this.registrantInformationGroupBox.Controls.Add(this.registrantStatusComboBox);
            this.registrantInformationGroupBox.Controls.Add(this.registrantStatusLabel);
            this.registrantInformationGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registrantInformationGroupBox.Controls.Add(this.emailAddressTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.emailAddressLabel);
            this.registrantInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInformationGroupBox.Location = new System.Drawing.Point(2, 215);
            this.registrantInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrantInformationGroupBox.Name = "registrantInformationGroupBox";
            this.registrantInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrantInformationGroupBox.Size = new System.Drawing.Size(502, 141);
            this.registrantInformationGroupBox.TabIndex = 4;
            this.registrantInformationGroupBox.TabStop = false;
            this.registrantInformationGroupBox.Text = "Registrant Information";
            // 
            // registrantStatusComboBox
            // 
            this.registrantStatusComboBox.FormattingEnabled = true;
            this.registrantStatusComboBox.Location = new System.Drawing.Point(326, 103);
            this.registrantStatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrantStatusComboBox.Name = "registrantStatusComboBox";
            this.registrantStatusComboBox.Size = new System.Drawing.Size(163, 28);
            this.registrantStatusComboBox.TabIndex = 9;
            // 
            // registrantStatusLabel
            // 
            this.registrantStatusLabel.AutoSize = true;
            this.registrantStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrantStatusLabel.Location = new System.Drawing.Point(336, 74);
            this.registrantStatusLabel.Name = "registrantStatusLabel";
            this.registrantStatusLabel.Size = new System.Drawing.Size(148, 22);
            this.registrantStatusLabel.TabIndex = 8;
            this.registrantStatusLabel.Text = "Registrant Status";
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(207, 103);
            this.dateOfBirthMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(104, 26);
            this.dateOfBirthMaskedTextBox.TabIndex = 7;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(200, 76);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(110, 22);
            this.dateOfBirthLabel.TabIndex = 6;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(12, 103);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(180, 26);
            this.emailAddressTextBox.TabIndex = 5;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(34, 76);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(125, 22);
            this.emailAddressLabel.TabIndex = 4;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(352, 31);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(136, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 31);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(136, 26);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(249, 31);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 22);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(8, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 22);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // registrationInformationGroupBox
            // 
            this.registrationInformationGroupBox.Controls.Add(this.maximumSelectionsLabel);
            this.registrationInformationGroupBox.Controls.Add(this.totalPriceLabel);
            this.registrationInformationGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationInformationGroupBox.Controls.Add(this.numberOfClassesLabel);
            this.registrationInformationGroupBox.Controls.Add(this.totalPriceLblLabel);
            this.registrationInformationGroupBox.Controls.Add(this.pricePerClassLblLabel);
            this.registrationInformationGroupBox.Controls.Add(this.numberOfClassesSelectedLblLabel);
            this.registrationInformationGroupBox.Controls.Add(this.classListBox);
            this.registrationInformationGroupBox.Controls.Add(this.classSelectionLabel);
            this.registrationInformationGroupBox.Controls.Add(this.animationPriceLabel);
            this.registrationInformationGroupBox.Controls.Add(this.liveActionPriceLabel);
            this.registrationInformationGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationInformationGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationInformationGroupBox.Controls.Add(this.classTypeLabel);
            this.registrationInformationGroupBox.Location = new System.Drawing.Point(2, 366);
            this.registrationInformationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationInformationGroupBox.Name = "registrationInformationGroupBox";
            this.registrationInformationGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registrationInformationGroupBox.Size = new System.Drawing.Size(502, 274);
            this.registrationInformationGroupBox.TabIndex = 5;
            this.registrationInformationGroupBox.TabStop = false;
            this.registrationInformationGroupBox.Text = "Registration Information";
            // 
            // maximumSelectionsLabel
            // 
            this.maximumSelectionsLabel.Location = new System.Drawing.Point(312, 56);
            this.maximumSelectionsLabel.Name = "maximumSelectionsLabel";
            this.maximumSelectionsLabel.Size = new System.Drawing.Size(150, 25);
            this.maximumSelectionsLabel.TabIndex = 6;
            this.maximumSelectionsLabel.Text = "max. selections";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(202, 204);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(76, 24);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pricePerClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassLabel.Location = new System.Drawing.Point(202, 173);
            this.pricePerClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(76, 24);
            this.pricePerClassLabel.TabIndex = 11;
            this.pricePerClassLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numberOfClassesLabel
            // 
            this.numberOfClassesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numberOfClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfClassesLabel.Location = new System.Drawing.Point(202, 142);
            this.numberOfClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfClassesLabel.Name = "numberOfClassesLabel";
            this.numberOfClassesLabel.Size = new System.Drawing.Size(76, 24);
            this.numberOfClassesLabel.TabIndex = 9;
            this.numberOfClassesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalPriceLblLabel
            // 
            this.totalPriceLblLabel.AutoSize = true;
            this.totalPriceLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLblLabel.Location = new System.Drawing.Point(92, 202);
            this.totalPriceLblLabel.Name = "totalPriceLblLabel";
            this.totalPriceLblLabel.Size = new System.Drawing.Size(102, 22);
            this.totalPriceLblLabel.TabIndex = 12;
            this.totalPriceLblLabel.Text = "Total Price:";
            // 
            // pricePerClassLblLabel
            // 
            this.pricePerClassLblLabel.AutoSize = true;
            this.pricePerClassLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerClassLblLabel.Location = new System.Drawing.Point(56, 171);
            this.pricePerClassLblLabel.Name = "pricePerClassLblLabel";
            this.pricePerClassLblLabel.Size = new System.Drawing.Size(137, 22);
            this.pricePerClassLblLabel.TabIndex = 10;
            this.pricePerClassLblLabel.Text = "Price per Class:";
            // 
            // numberOfClassesSelectedLblLabel
            // 
            this.numberOfClassesSelectedLblLabel.AutoSize = true;
            this.numberOfClassesSelectedLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfClassesSelectedLblLabel.Location = new System.Drawing.Point(25, 144);
            this.numberOfClassesSelectedLblLabel.Name = "numberOfClassesSelectedLblLabel";
            this.numberOfClassesSelectedLblLabel.Size = new System.Drawing.Size(167, 22);
            this.numberOfClassesSelectedLblLabel.TabIndex = 8;
            this.numberOfClassesSelectedLblLabel.Text = "Number of Classes:";
            // 
            // classListBox
            // 
            this.classListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.classListBox.FormattingEnabled = true;
            this.classListBox.ItemHeight = 20;
            this.classListBox.Location = new System.Drawing.Point(316, 82);
            this.classListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classListBox.Name = "classListBox";
            this.classListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classListBox.Size = new System.Drawing.Size(150, 184);
            this.classListBox.Sorted = true;
            this.classListBox.TabIndex = 7;
            this.classListBox.SelectedIndexChanged += new System.EventHandler(this.classListBox_SelectedIndexChanged);
            // 
            // classSelectionLabel
            // 
            this.classSelectionLabel.AutoSize = true;
            this.classSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelectionLabel.Location = new System.Drawing.Point(312, 34);
            this.classSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classSelectionLabel.Name = "classSelectionLabel";
            this.classSelectionLabel.Size = new System.Drawing.Size(134, 22);
            this.classSelectionLabel.TabIndex = 5;
            this.classSelectionLabel.Text = "Class Selection";
            this.classSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animationPriceLabel
            // 
            this.animationPriceLabel.AutoSize = true;
            this.animationPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animationPriceLabel.Location = new System.Drawing.Point(214, 93);
            this.animationPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animationPriceLabel.Name = "animationPriceLabel";
            this.animationPriceLabel.Size = new System.Drawing.Size(27, 20);
            this.animationPriceLabel.TabIndex = 4;
            this.animationPriceLabel.Text = "$$";
            this.animationPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // liveActionPriceLabel
            // 
            this.liveActionPriceLabel.AutoSize = true;
            this.liveActionPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveActionPriceLabel.Location = new System.Drawing.Point(75, 93);
            this.liveActionPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liveActionPriceLabel.Name = "liveActionPriceLabel";
            this.liveActionPriceLabel.Size = new System.Drawing.Size(27, 20);
            this.liveActionPriceLabel.TabIndex = 2;
            this.liveActionPriceLabel.Text = "$$";
            this.liveActionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animationRadioButton.Location = new System.Drawing.Point(158, 65);
            this.animationRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(114, 26);
            this.animationRadioButton.TabIndex = 3;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Checked = true;
            this.liveActionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveActionRadioButton.Location = new System.Drawing.Point(9, 65);
            this.liveActionRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(123, 26);
            this.liveActionRadioButton.TabIndex = 1;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // classTypeLabel
            // 
            this.classTypeLabel.AutoSize = true;
            this.classTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTypeLabel.Location = new System.Drawing.Point(27, 34);
            this.classTypeLabel.Name = "classTypeLabel";
            this.classTypeLabel.Size = new System.Drawing.Size(101, 22);
            this.classTypeLabel.TabIndex = 0;
            this.classTypeLabel.Text = "Class Type";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(96, 645);
            this.paymentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(131, 22);
            this.paymentTypeLabel.TabIndex = 6;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRadioButton.Location = new System.Drawing.Point(236, 645);
            this.cashRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(77, 26);
            this.cashRadioButton.TabIndex = 7;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRadioButton.Location = new System.Drawing.Point(318, 645);
            this.checkRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(86, 26);
            this.checkRadioButton.TabIndex = 8;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailReceiptRequestedCheckBox
            // 
            this.emailReceiptRequestedCheckBox.AutoSize = true;
            this.emailReceiptRequestedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailReceiptRequestedCheckBox.Location = new System.Drawing.Point(100, 681);
            this.emailReceiptRequestedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailReceiptRequestedCheckBox.Name = "emailReceiptRequestedCheckBox";
            this.emailReceiptRequestedCheckBox.Size = new System.Drawing.Size(238, 26);
            this.emailReceiptRequestedCheckBox.TabIndex = 9;
            this.emailReceiptRequestedCheckBox.Text = "Email Receipt Requested";
            this.emailReceiptRequestedCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Displays a summary of registration and writes data to external file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "Clears the Form";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Closes the Program";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Displays copyright notice";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // filmPictureBox
            // 
            this.filmPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filmPictureBox.Image = global::Castillo_4.Properties.Resources.film_picture;
            this.filmPictureBox.Location = new System.Drawing.Point(0, 37);
            this.filmPictureBox.Name = "filmPictureBox";
            this.filmPictureBox.Size = new System.Drawing.Size(242, 128);
            this.filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmPictureBox.TabIndex = 0;
            this.filmPictureBox.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 730);
            this.Controls.Add(this.emailReceiptRequestedCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.registrationInformationGroupBox);
            this.Controls.Add(this.registrantInformationGroupBox);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.filmPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.registrantInformationGroupBox.ResumeLayout(false);
            this.registrantInformationGroupBox.PerformLayout();
            this.registrationInformationGroupBox.ResumeLayout(false);
            this.registrationInformationGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrantInformationGroupBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.ComboBox registrantStatusComboBox;
        private System.Windows.Forms.Label registrantStatusLabel;
        private System.Windows.Forms.GroupBox registrationInformationGroupBox;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label classTypeLabel;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.Label liveActionPriceLabel;
        private System.Windows.Forms.Label animationPriceLabel;
        private System.Windows.Forms.Label classSelectionLabel;
        private System.Windows.Forms.ListBox classListBox;
        private System.Windows.Forms.Label totalPriceLblLabel;
        private System.Windows.Forms.Label pricePerClassLblLabel;
        private System.Windows.Forms.Label numberOfClassesSelectedLblLabel;
        private System.Windows.Forms.Label numberOfClassesLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox emailReceiptRequestedCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label maximumSelectionsLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

