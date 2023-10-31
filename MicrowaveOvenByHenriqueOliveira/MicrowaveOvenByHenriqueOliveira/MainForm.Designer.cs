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
            bOpenDoor = new Button();
            bButton = new Button();
            bCloseDoor = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            lDoor = new Label();
            lHeater = new Label();
            label3 = new Label();
            lLight = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // bOpenDoor
            // 
            bOpenDoor.Dock = DockStyle.Fill;
            bOpenDoor.Location = new Point(3, 3);
            bOpenDoor.Name = "bOpenDoor";
            bOpenDoor.Size = new Size(245, 126);
            bOpenDoor.TabIndex = 0;
            bOpenDoor.Text = "Open Door";
            bOpenDoor.UseVisualStyleBackColor = true;
            bOpenDoor.Click += bOpenDoor_Click;
            // 
            // bButton
            // 
            bButton.Dock = DockStyle.Fill;
            bButton.Location = new Point(254, 3);
            bButton.Name = "bButton";
            bButton.Size = new Size(245, 126);
            bButton.TabIndex = 1;
            bButton.Text = "Button";
            bButton.UseVisualStyleBackColor = true;
            bButton.Click += bButton_Click;
            // 
            // bCloseDoor
            // 
            bCloseDoor.Dock = DockStyle.Fill;
            bCloseDoor.Location = new Point(3, 135);
            bCloseDoor.Name = "bCloseDoor";
            bCloseDoor.Size = new Size(245, 126);
            bCloseDoor.TabIndex = 2;
            bCloseDoor.Text = "Close Door";
            bCloseDoor.UseVisualStyleBackColor = true;
            bCloseDoor.Click += bCloseDoor_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(bButton, 1, 0);
            tableLayoutPanel1.Controls.Add(bCloseDoor, 0, 1);
            tableLayoutPanel1.Controls.Add(bOpenDoor, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 135);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(502, 264);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 4;
            label1.Text = "Light";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(lDoor, 0, 2);
            tableLayoutPanel2.Controls.Add(lHeater, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(lLight, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(15, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(245, 117);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 76);
            label6.Name = "label6";
            label6.Size = new Size(116, 41);
            label6.TabIndex = 9;
            label6.Text = "Door";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lDoor
            // 
            lDoor.AutoSize = true;
            lDoor.Dock = DockStyle.Fill;
            lDoor.Location = new Point(125, 76);
            lDoor.Name = "lDoor";
            lDoor.Size = new Size(117, 41);
            lDoor.TabIndex = 8;
            lDoor.Text = "Closed";
            lDoor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lHeater
            // 
            lHeater.AutoSize = true;
            lHeater.Dock = DockStyle.Fill;
            lHeater.Location = new Point(125, 38);
            lHeater.Name = "lHeater";
            lHeater.Size = new Size(117, 38);
            lHeater.TabIndex = 7;
            lHeater.Text = "OFF";
            lHeater.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 38);
            label3.Name = "label3";
            label3.Size = new Size(116, 38);
            label3.TabIndex = 6;
            label3.Text = "Heater";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lLight
            // 
            lLight.AutoSize = true;
            lLight.Dock = DockStyle.Fill;
            lLight.Location = new Point(125, 0);
            lLight.Name = "lLight";
            lLight.Size = new Size(117, 38);
            lLight.TabIndex = 5;
            lLight.Text = "OFF";
            lLight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 411);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bOpenDoor;
        private Button bButton;
        private Button bCloseDoor;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private Label lDoor;
        private Label lHeater;
        private Label label3;
        private Label lLight;
    }
}