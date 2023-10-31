namespace Wayne.MicrowaveOven
{
    partial class MainForm
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
            this.bOpenDoor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lLight = new System.Windows.Forms.Label();
            this.lHeater = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lDoor = new System.Windows.Forms.Label();
            this.bCloseDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bOpenDoor
            // 
            this.bOpenDoor.Location = new System.Drawing.Point(11, 108);
            this.bOpenDoor.Name = "bOpenDoor";
            this.bOpenDoor.Size = new System.Drawing.Size(123, 43);
            this.bOpenDoor.TabIndex = 0;
            this.bOpenDoor.Text = "Open Door";
            this.bOpenDoor.UseVisualStyleBackColor = true;
            this.bOpenDoor.Click += new System.EventHandler(this.bOpenDoor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Light";
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(140, 108);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(123, 43);
            this.bButton.TabIndex = 0;
            this.bButton.Text = "Button";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.bButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heater";
            // 
            // lLight
            // 
            this.lLight.AutoSize = true;
            this.lLight.Location = new System.Drawing.Point(57, 24);
            this.lLight.Name = "lLight";
            this.lLight.Size = new System.Drawing.Size(21, 13);
            this.lLight.TabIndex = 1;
            this.lLight.Text = "Off";
            // 
            // lHeater
            // 
            this.lHeater.AutoSize = true;
            this.lHeater.Location = new System.Drawing.Point(57, 46);
            this.lHeater.Name = "lHeater";
            this.lHeater.Size = new System.Drawing.Size(21, 13);
            this.lHeater.TabIndex = 1;
            this.lHeater.Text = "Off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Door";
            // 
            // lDoor
            // 
            this.lDoor.AutoSize = true;
            this.lDoor.Location = new System.Drawing.Point(57, 72);
            this.lDoor.Name = "lDoor";
            this.lDoor.Size = new System.Drawing.Size(39, 13);
            this.lDoor.TabIndex = 1;
            this.lDoor.Text = "Closed";
            // 
            // bCloseDoor
            // 
            this.bCloseDoor.Location = new System.Drawing.Point(11, 157);
            this.bCloseDoor.Name = "bCloseDoor";
            this.bCloseDoor.Size = new System.Drawing.Size(123, 43);
            this.bCloseDoor.TabIndex = 0;
            this.bCloseDoor.Text = "Close Door";
            this.bCloseDoor.UseVisualStyleBackColor = true;
            this.bCloseDoor.Click += new System.EventHandler(this.bCloseDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 234);
            this.Controls.Add(this.lDoor);
            this.Controls.Add(this.lHeater);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.bCloseDoor);
            this.Controls.Add(this.bOpenDoor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpenDoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLight;
        private System.Windows.Forms.Label lHeater;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lDoor;
        private System.Windows.Forms.Button bCloseDoor;
    }
}

