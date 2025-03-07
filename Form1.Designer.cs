using System;

namespace Telephone_Book
{
    partial class PhoneBook
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
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.lastnametextbox = new System.Windows.Forms.TextBox();
            this.phonenumtextbox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loadbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.emaillabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.phonenumlabel = new System.Windows.Forms.Label();
            this.contactsdatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(127, 38);
            this.firstnametextbox.Multiline = true;
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(544, 30);
            this.firstnametextbox.TabIndex = 1;
            this.firstnametextbox.TextChanged += new System.EventHandler(GetTextBox1_TextChanged());
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.Location = new System.Drawing.Point(0, 38);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(127, 37);
            this.firstnamelabel.TabIndex = 2;
            this.firstnamelabel.Text = "First Name:";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(127, 110);
            this.emailtextbox.Multiline = true;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(544, 30);
            this.emailtextbox.TabIndex = 3;
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.Location = new System.Drawing.Point(127, 74);
            this.lastnametextbox.Multiline = true;
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(544, 30);
            this.lastnametextbox.TabIndex = 4;
            this.lastnametextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // phonenumtextbox
            // 
            this.phonenumtextbox.Location = new System.Drawing.Point(127, 146);
            this.phonenumtextbox.Multiline = true;
            this.phonenumtextbox.Name = "phonenumtextbox";
            this.phonenumtextbox.Size = new System.Drawing.Size(544, 30);
            this.phonenumtextbox.TabIndex = 6;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebutton.Location = new System.Drawing.Point(686, 146);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(97, 32);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebuttonclick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(686, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.newButton_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loadbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadbutton.Location = new System.Drawing.Point(686, 72);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(97, 32);
            this.loadbutton.TabIndex = 13;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = false;
            this.loadbutton.Click += new System.EventHandler(this.laodbuttonclick);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.savebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebutton.Location = new System.Drawing.Point(686, 108);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(97, 32);
            this.savebutton.TabIndex = 14;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebuttonclick);
            // 
            // emaillabel
            // 
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(0, 113);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(112, 37);
            this.emaillabel.TabIndex = 17;
            this.emaillabel.Text = "Email:";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.Location = new System.Drawing.Point(0, 75);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(112, 38);
            this.lastnamelabel.TabIndex = 18;
            this.lastnamelabel.Text = "Last Name:";
            this.lastnamelabel.Click += new System.EventHandler(this.lastnamelabel_Click);
            // 
            // phonenumlabel
            // 
            this.phonenumlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumlabel.Location = new System.Drawing.Point(0, 150);
            this.phonenumlabel.Name = "phonenumlabel";
            this.phonenumlabel.Size = new System.Drawing.Size(112, 37);
            this.phonenumlabel.TabIndex = 19;
            this.phonenumlabel.Text = "Phone Num:";
            this.phonenumlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // contactsdatagrid
            // 
            this.contactsdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsdatagrid.Location = new System.Drawing.Point(12, 190);
            this.contactsdatagrid.Name = "contactsdatagrid";
            this.contactsdatagrid.RowHeadersWidth = 51;
            this.contactsdatagrid.RowTemplate.Height = 24;
            this.contactsdatagrid.Size = new System.Drawing.Size(847, 301);
            this.contactsdatagrid.TabIndex = 20;
            this.contactsdatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsdatagrid_CellDoubleClick);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 503);
            this.Controls.Add(this.contactsdatagrid);
            this.Controls.Add(this.phonenumlabel);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.phonenumtextbox);
            this.Controls.Add(this.lastnametextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.firstnametextbox);
            this.Name = "PhoneBook";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.PhoneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private object GetTextBox1_TextChanged()
        {
            return this.textBox1_TextChanged;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox lastnametextbox;
        private System.Windows.Forms.TextBox phonenumtextbox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label phonenumlabel;
        private System.Windows.Forms.DataGridView contactsdatagrid;
        private EventHandler lastnamelabel_Click;
        private object textBox1_TextChanged;
    }
}

