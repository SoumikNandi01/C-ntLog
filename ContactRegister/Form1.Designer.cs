namespace ContactRegister
{
    partial class basicForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contactRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developedBySoumikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorBox = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.addrText = new System.Windows.Forms.TextBox();
            this.contactText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.databaseView = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactRegisterToolStripMenuItem,
            this.developedBySoumikToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // contactRegisterToolStripMenuItem
            // 
            this.contactRegisterToolStripMenuItem.Name = "contactRegisterToolStripMenuItem";
            this.contactRegisterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.contactRegisterToolStripMenuItem.Text = "ContactRegister";
            // 
            // developedBySoumikToolStripMenuItem
            // 
            this.developedBySoumikToolStripMenuItem.Name = "developedBySoumikToolStripMenuItem";
            this.developedBySoumikToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.developedBySoumikToolStripMenuItem.Text = "Developed by Soumik";
            // 
            // authorBox
            // 
            this.authorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorBox.AutoSize = true;
            this.authorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorBox.Location = new System.Drawing.Point(287, 19);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(188, 25);
            this.authorBox.TabIndex = 2;
            this.authorBox.Text = "Contact Register";
            this.authorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authorBox.Click += new System.EventHandler(this.authorBox_Click);
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(35, 80);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(86, 17);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(138, 79);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(220, 20);
            this.firstNameText.TabIndex = 4;
            // 
            // addrText
            // 
            this.addrText.Location = new System.Drawing.Point(138, 228);
            this.addrText.Multiline = true;
            this.addrText.Name = "addrText";
            this.addrText.Size = new System.Drawing.Size(220, 103);
            this.addrText.TabIndex = 5;
            // 
            // contactText
            // 
            this.contactText.Location = new System.Drawing.Point(138, 175);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(220, 20);
            this.contactText.TabIndex = 6;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(138, 125);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(220, 20);
            this.lastNameText.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(35, 125);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(85, 17);
            this.lastName.TabIndex = 11;
            this.lastName.Text = "Last Name";
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(36, 175);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(88, 17);
            this.Contact.TabIndex = 12;
            this.Contact.Text = "Contact No";
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(36, 229);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(67, 17);
            this.Address.TabIndex = 13;
            this.Address.Text = "Address";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gender";
            // 
            // genderText
            // 
            this.genderText.FormattingEnabled = true;
            this.genderText.Location = new System.Drawing.Point(138, 362);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(220, 21);
            this.genderText.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(150, 413);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 36);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(403, 413);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 36);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Yellow;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(277, 413);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 36);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Aqua;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(536, 413);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 36);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // databaseView
            // 
            this.databaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseView.Location = new System.Drawing.Point(419, 125);
            this.databaseView.Name = "databaseView";
            this.databaseView.Size = new System.Drawing.Size(341, 258);
            this.databaseView.TabIndex = 20;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(479, 82);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(281, 20);
            this.searchText.TabIndex = 21;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(414, 82);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(59, 17);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // basicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.databaseView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.addrText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.authorBox);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "basicForm";
            this.Text = "ContactRegister";
            this.Load += new System.EventHandler(this.basicForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developedBySoumikToolStripMenuItem;
        private System.Windows.Forms.Label authorBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox addrText;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genderText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView databaseView;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label search;
    }
}

