namespace AdressBokAdoNet
{
    partial class AddressBookForm
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
            this.kontakterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookDataSet = new AdressBokAdoNet.AddressBookDataSet();
            this.kontakterTableAdapter = new AdressBokAdoNet.AddressBookDataSetTableAdapters.KontakterTableAdapter();
            this.AddressBookDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteAddressButton = new System.Windows.Forms.Button();
            this.UpdateAddressButton = new System.Windows.Forms.Button();
            this.CreateContactButton = new System.Windows.Forms.Button();
            this.ContactTypeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ContactTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kontakterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kontakterBindingSource
            // 
            this.kontakterBindingSource.DataMember = "Kontakter";
            this.kontakterBindingSource.DataSource = this.addressBookDataSet;
            // 
            // addressBookDataSet
            // 
            this.addressBookDataSet.DataSetName = "AddressBookDataSet";
            this.addressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontakterTableAdapter
            // 
            this.kontakterTableAdapter.ClearBeforeFill = true;
            // 
            // AddressBookDataGridView
            // 
            this.AddressBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressBookDataGridView.Location = new System.Drawing.Point(422, 22);
            this.AddressBookDataGridView.Name = "AddressBookDataGridView";
            this.AddressBookDataGridView.ReadOnly = true;
            this.AddressBookDataGridView.RowTemplate.Height = 24;
            this.AddressBookDataGridView.Size = new System.Drawing.Size(1024, 405);
            this.AddressBookDataGridView.TabIndex = 131;
            this.AddressBookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressBookDataGridView_CellContentClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(322, 371);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(77, 56);
            this.SearchButton.TabIndex = 130;
            this.SearchButton.Text = "Sök";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // DeleteAddressButton
            // 
            this.DeleteAddressButton.Location = new System.Drawing.Point(216, 371);
            this.DeleteAddressButton.Name = "DeleteAddressButton";
            this.DeleteAddressButton.Size = new System.Drawing.Size(96, 56);
            this.DeleteAddressButton.TabIndex = 129;
            this.DeleteAddressButton.Text = "Radera Adress";
            this.DeleteAddressButton.UseVisualStyleBackColor = true;
            this.DeleteAddressButton.Click += new System.EventHandler(this.DeleteAddressButton_Click_1);
            // 
            // UpdateAddressButton
            // 
            this.UpdateAddressButton.Location = new System.Drawing.Point(108, 371);
            this.UpdateAddressButton.Name = "UpdateAddressButton";
            this.UpdateAddressButton.Size = new System.Drawing.Size(102, 56);
            this.UpdateAddressButton.TabIndex = 128;
            this.UpdateAddressButton.Text = "Updatera Adress";
            this.UpdateAddressButton.UseVisualStyleBackColor = true;
            this.UpdateAddressButton.Click += new System.EventHandler(this.UpdateAddressButton_Click);
            // 
            // CreateContactButton
            // 
            this.CreateContactButton.Location = new System.Drawing.Point(21, 371);
            this.CreateContactButton.Name = "CreateContactButton";
            this.CreateContactButton.Size = new System.Drawing.Size(81, 56);
            this.CreateContactButton.TabIndex = 127;
            this.CreateContactButton.Text = "Skapa Kontakt";
            this.CreateContactButton.UseVisualStyleBackColor = true;
            this.CreateContactButton.Click += new System.EventHandler(this.CreateContactButton_Click);
            // 
            // ContactTypeLabel
            // 
            this.ContactTypeLabel.AutoSize = true;
            this.ContactTypeLabel.Location = new System.Drawing.Point(18, 315);
            this.ContactTypeLabel.Name = "ContactTypeLabel";
            this.ContactTypeLabel.Size = new System.Drawing.Size(79, 17);
            this.ContactTypeLabel.TabIndex = 126;
            this.ContactTypeLabel.Text = "Kontakt typ";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(18, 262);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 17);
            this.EmailLabel.TabIndex = 125;
            this.EmailLabel.Text = "Epost";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Location = new System.Drawing.Point(18, 217);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(56, 17);
            this.TelephoneLabel.TabIndex = 124;
            this.TelephoneLabel.Text = "Telefon";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(18, 169);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(53, 17);
            this.CityLabel.TabIndex = 123;
            this.CityLabel.Text = "Postort";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(18, 114);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(87, 17);
            this.PostalCodeLabel.TabIndex = 122;
            this.PostalCodeLabel.Text = "Postnummer";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(18, 69);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 17);
            this.AddressLabel.TabIndex = 121;
            this.AddressLabel.Text = "Adress";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(18, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 120;
            this.NameLabel.Text = "Namn";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(135, 262);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(202, 22);
            this.EmailTextBox.TabIndex = 118;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(135, 217);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(113, 22);
            this.TelephoneTextBox.TabIndex = 117;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(135, 169);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(202, 22);
            this.CityTextBox.TabIndex = 116;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(135, 114);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(76, 22);
            this.PostalCodeTextBox.TabIndex = 115;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(135, 69);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(202, 22);
            this.AddressTextBox.TabIndex = 114;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(135, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(202, 22);
            this.NameTextBox.TabIndex = 113;
            // 
            // ContactTypeComboBox
            // 
            this.ContactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContactTypeComboBox.FormattingEnabled = true;
            this.ContactTypeComboBox.Location = new System.Drawing.Point(135, 315);
            this.ContactTypeComboBox.Name = "ContactTypeComboBox";
            this.ContactTypeComboBox.Size = new System.Drawing.Size(155, 24);
            this.ContactTypeComboBox.TabIndex = 119;
            // 
            // AddressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 445);
            this.Controls.Add(this.AddressBookDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteAddressButton);
            this.Controls.Add(this.UpdateAddressButton);
            this.Controls.Add(this.CreateContactButton);
            this.Controls.Add(this.ContactTypeLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ContactTypeComboBox);
            this.Name = "AddressBookForm";
            this.Text = "Adressbok";
            this.Load += new System.EventHandler(this.AddressBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontakterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AddressBookDataSet addressBookDataSet;
        private System.Windows.Forms.BindingSource kontakterBindingSource;
        private AddressBookDataSetTableAdapters.KontakterTableAdapter kontakterTableAdapter;
        private System.Windows.Forms.DataGridView AddressBookDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteAddressButton;
        private System.Windows.Forms.Button UpdateAddressButton;
        private System.Windows.Forms.Button CreateContactButton;
        private System.Windows.Forms.Label ContactTypeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox ContactTypeComboBox;
    }
}

