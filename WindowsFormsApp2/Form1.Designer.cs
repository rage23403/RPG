namespace WindowsFormsApp2
{
    partial class MainMenu
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
            this.create = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Start = new System.Windows.Forms.Button();
            this.characters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create.Location = new System.Drawing.Point(258, 377);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(183, 33);
            this.create.TabIndex = 0;
            this.create.Text = "Create character";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(492, 377);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(165, 33);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start campaign";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // characters
            // 
            this.characters.AccessibleName = "character_dropdown";
            this.characters.FormattingEnabled = true;
            this.characters.Location = new System.Drawing.Point(492, 294);
            this.characters.Name = "characters";
            this.characters.Size = new System.Drawing.Size(165, 21);
            this.characters.TabIndex = 3;
            this.characters.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.characters);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.create);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.ComboBox characters;
    }
}

