namespace Hasan.Badr_harjoitus_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LukuyksiTB = new TextBox();
            LukukaksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LukuyksiTB
            // 
            LukuyksiTB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LukuyksiTB.Location = new Point(12, 33);
            LukuyksiTB.Name = "LukuyksiTB";
            LukuyksiTB.Size = new Size(159, 39);
            LukuyksiTB.TabIndex = 0;
            // 
            // LukukaksiTB
            // 
            LukukaksiTB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LukukaksiTB.Location = new Point(295, 33);
            LukukaksiTB.Name = "LukukaksiTB";
            LukukaksiTB.Size = new Size(159, 39);
            LukukaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(177, 32);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(112, 40);
            LaskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(460, 36);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(496, 36);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(25, 32);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "x";
            VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LaskeBT.Location = new Point(553, 34);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(89, 37);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 158);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukukaksiTB);
            Controls.Add(LukuyksiTB);
            Name = "Form1";
            Text = "Yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuyksiTB;
        private TextBox LukukaksiTB;
        private ComboBox LaskutoimitusCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}