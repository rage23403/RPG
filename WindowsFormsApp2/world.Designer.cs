namespace WindowsFormsApp2
{
    partial class world
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
            this.PlayerStats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AdventureDialogue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.northButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerStats
            // 
            this.PlayerStats.Location = new System.Drawing.Point(12, 29);
            this.PlayerStats.Multiline = true;
            this.PlayerStats.Name = "PlayerStats";
            this.PlayerStats.ReadOnly = true;
            this.PlayerStats.Size = new System.Drawing.Size(188, 307);
            this.PlayerStats.TabIndex = 0;
            this.PlayerStats.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character stats";
            // 
            // SaveButton
            // 
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveButton.Location = new System.Drawing.Point(16, 420);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AdventureDialogue
            // 
            this.AdventureDialogue.Location = new System.Drawing.Point(339, 71);
            this.AdventureDialogue.Multiline = true;
            this.AdventureDialogue.Name = "AdventureDialogue";
            this.AdventureDialogue.ReadOnly = true;
            this.AdventureDialogue.Size = new System.Drawing.Size(225, 216);
            this.AdventureDialogue.TabIndex = 3;
            this.AdventureDialogue.TextChanged += new System.EventHandler(this.AdventureDialogue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adventure:";
            // 
            // northButton
            // 
            this.northButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.northButton.Location = new System.Drawing.Point(351, 325);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(43, 23);
            this.northButton.TabIndex = 5;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            // 
            // eastButton
            // 
            this.eastButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eastButton.Location = new System.Drawing.Point(394, 357);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(43, 23);
            this.eastButton.TabIndex = 6;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // westButton
            // 
            this.westButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.westButton.Location = new System.Drawing.Point(307, 357);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(43, 23);
            this.westButton.TabIndex = 7;
            this.westButton.Text = "West";
            this.westButton.UseVisualStyleBackColor = true;
            // 
            // southButton
            // 
            this.southButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.southButton.Location = new System.Drawing.Point(351, 389);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(43, 23);
            this.southButton.TabIndex = 8;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            // 
            // aButton
            // 
            this.aButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aButton.Location = new System.Drawing.Point(533, 350);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(51, 23);
            this.aButton.TabIndex = 9;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // bButton
            // 
            this.bButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bButton.Location = new System.Drawing.Point(533, 379);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(51, 23);
            this.bButton.TabIndex = 10;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.bButton_Click);
            // 
            // startButton
            // 
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(454, 329);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(51, 19);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectButton.Location = new System.Drawing.Point(454, 379);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(51, 19);
            this.selectButton.TabIndex = 12;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // world
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(615, 500);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdventureDialogue);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerStats);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "world";
            this.Text = "Adventure";
            this.Load += new System.EventHandler(this.world_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AdventureDialogue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button selectButton;
    }
}