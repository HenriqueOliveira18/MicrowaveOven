namespace Wayne.MicrowaveOven
{
    partial class Manager
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
            bStart = new Button();
            SuspendLayout();
            // 
            // bStart
            // 
            bStart.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            bStart.Location = new Point(117, 161);
            bStart.Name = "bStart";
            bStart.Size = new Size(308, 134);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 411);
            Controls.Add(bStart);
            Name = "Manager";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bStart;
    }
}