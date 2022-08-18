namespace Peacesign__alpha_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboboxHands = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboboxEye = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboboxX3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboboxHands);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 70);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hand Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboboxHands
            // 
            this.comboboxHands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxHands.FormattingEnabled = true;
            this.comboboxHands.Items.AddRange(new object[] {
            "Fists",
            "Open",
            "Right Open",
            "Peace Sign",
            "Cap In Hand",
            "Wingcap In Hand"});
            this.comboboxHands.Location = new System.Drawing.Point(8, 28);
            this.comboboxHands.MaxDropDownItems = 6;
            this.comboboxHands.Name = "comboboxHands";
            this.comboboxHands.Size = new System.Drawing.Size(209, 23);
            this.comboboxHands.TabIndex = 10;
            this.comboboxHands.Text = "Fists";
            this.comboboxHands.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(12, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 25);
            this.button9.TabIndex = 6;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboboxEye);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eye Controls";
            // 
            // comboboxEye
            // 
            this.comboboxEye.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxEye.FormattingEnabled = true;
            this.comboboxEye.Items.AddRange(new object[] {
            "Blinking",
            "Open",
            "Half",
            "Closed",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.comboboxEye.Location = new System.Drawing.Point(8, 28);
            this.comboboxEye.Name = "comboboxEye";
            this.comboboxEye.Size = new System.Drawing.Size(312, 23);
            this.comboboxEye.TabIndex = 10;
            this.comboboxEye.Text = "Blinking";
            this.comboboxEye.SelectedIndexChanged += new System.EventHandler(this.comboboxEye_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboboxX3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X3 Controls (Exmo3)";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboboxX3
            // 
            this.comboboxX3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxX3.FormattingEnabled = true;
            this.comboboxX3.Items.AddRange(new object[] {
            "Default",
            "Expression 1",
            "Expression 2",
            "Expression 3"});
            this.comboboxX3.Location = new System.Drawing.Point(6, 28);
            this.comboboxX3.MaxDropDownItems = 6;
            this.comboboxX3.Name = "comboboxX3";
            this.comboboxX3.Size = new System.Drawing.Size(312, 23);
            this.comboboxX3.TabIndex = 10;
            this.comboboxX3.Text = "Default";
            this.comboboxX3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 60);
            this.label1.TabIndex = 13;
            this.label1.Text = "M64 Peace Sign\r\nMade with V64Core\r\nMade By Violet64 with help \r\nfrom Llennpie\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 60);
            this.label2.TabIndex = 14;
            this.label2.Text = "Note: \r\nExmo items like \r\nShyguys Spear is \r\n\"Cap In Hand\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "M64 Peace Sign";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Button button9;
        private ComboBox comboboxHands;
        private GroupBox groupBox2;
        private ComboBox comboboxEye;
        private GroupBox groupBox3;
        private ComboBox comboboxX3;
        private Label label1;
        private Label label2;
    }
}