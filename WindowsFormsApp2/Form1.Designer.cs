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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.create = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Start = new System.Windows.Forms.Button();
            this.characters = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.create.Location = new System.Drawing.Point(263, 314);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(176, 30);
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
            this.characters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characters.FormattingEnabled = true;
            this.characters.Location = new System.Drawing.Point(492, 350);
            this.characters.Name = "characters";
            this.characters.Size = new System.Drawing.Size(165, 21);
            this.characters.TabIndex = 3;
            this.characters.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(492, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "delete character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "New?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Continue?";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.characters);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.create);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

