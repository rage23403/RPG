namespace WindowsFormsApp2
{
    partial class Form_rpg
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
            this.text_name = new System.Windows.Forms.Label();
            this.char_name = new System.Windows.Forms.TextBox();
            this.charClasses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.charCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.AutoSize = true;
            this.text_name.Location = new System.Drawing.Point(28, 26);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(38, 13);
            this.text_name.TabIndex = 0;
            this.text_name.Text = "Name:";
            this.text_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // char_name
            // 
            this.char_name.Location = new System.Drawing.Point(69, 23);
            this.char_name.Name = "char_name";
            this.char_name.Size = new System.Drawing.Size(100, 20);
            this.char_name.TabIndex = 1;
            // 
            // charClasses
            // 
            this.charClasses.FormattingEnabled = true;
            this.charClasses.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Ranger",
            "Necromancer",
            "Rogue",
            "Healer"});
            this.charClasses.Location = new System.Drawing.Point(69, 69);
            this.charClasses.Name = "charClasses";
            this.charClasses.Size = new System.Drawing.Size(121, 21);
            this.charClasses.TabIndex = 3;
            this.charClasses.SelectedIndexChanged += new System.EventHandler(this.charClasses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class:";
            // 
            // charCreate
            // 
            this.charCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.charCreate.Location = new System.Drawing.Point(69, 217);
            this.charCreate.Name = "charCreate";
            this.charCreate.Size = new System.Drawing.Size(75, 23);
            this.charCreate.TabIndex = 5;
            this.charCreate.Text = "Create";
            this.charCreate.UseVisualStyleBackColor = true;
            this.charCreate.Click += new System.EventHandler(this.charCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOTE: the character can only have at maximum 10 character in it\'s name";
            // 
            // Form_rpg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(620, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.charCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charClasses);
            this.Controls.Add(this.char_name);
            this.Controls.Add(this.text_name);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form_rpg";
            this.Text = "character creator";
            this.Load += new System.EventHandler(this.Form_rpg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_name;
        private System.Windows.Forms.TextBox char_name;
        private System.Windows.Forms.ComboBox charClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button charCreate;
        private System.Windows.Forms.Label label2;
    }
}