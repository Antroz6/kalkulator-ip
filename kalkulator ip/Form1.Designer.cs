
namespace kalkulator_ip
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IpTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PierwszyUzytecznyText = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OstatniUzytecznyText = new System.Windows.Forms.MaskedTextBox();
            this.ipOctet1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ipOctet2 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet3 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cidrText = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrText)).BeginInit();
            this.SuspendLayout();
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(138, 61);
            this.IpTextBox.Mask = "###\\.###\\.###\\.###";
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(88, 20);
            this.IpTextBox.TabIndex = 0;
            this.IpTextBox.Text = "255255255255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(138, 87);
            this.MaskTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(88, 20);
            this.MaskTextBox.TabIndex = 2;
            this.MaskTextBox.Text = "255255255255";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(232, 61);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(119, 150);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Policz ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(138, 113);
            this.networkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(88, 20);
            this.networkAddressTextBox.TabIndex = 5;
            this.networkAddressTextBox.Text = "255255255255";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(138, 139);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(88, 20);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "255255255255";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres rozgloszeniowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pierwszy użyteczny adres:";
            // 
            // PierwszyUzytecznyText
            // 
            this.PierwszyUzytecznyText.Location = new System.Drawing.Point(138, 165);
            this.PierwszyUzytecznyText.Mask = "###\\.###\\.###\\.###";
            this.PierwszyUzytecznyText.Name = "PierwszyUzytecznyText";
            this.PierwszyUzytecznyText.ReadOnly = true;
            this.PierwszyUzytecznyText.Size = new System.Drawing.Size(88, 20);
            this.PierwszyUzytecznyText.TabIndex = 9;
            this.PierwszyUzytecznyText.Text = "255255255255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ostatni użyteczny adres:";
            // 
            // OstatniUzytecznyText
            // 
            this.OstatniUzytecznyText.Location = new System.Drawing.Point(138, 191);
            this.OstatniUzytecznyText.Mask = "###\\.###\\.###\\.###";
            this.OstatniUzytecznyText.Name = "OstatniUzytecznyText";
            this.OstatniUzytecznyText.ReadOnly = true;
            this.OstatniUzytecznyText.Size = new System.Drawing.Size(88, 20);
            this.OstatniUzytecznyText.TabIndex = 11;
            this.OstatniUzytecznyText.Text = "255255255255";
            // 
            // ipOctet1
            // 
            this.ipOctet1.Location = new System.Drawing.Point(74, 8);
            this.ipOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet1.Name = "ipOctet1";
            this.ipOctet1.Size = new System.Drawing.Size(39, 20);
            this.ipOctet1.TabIndex = 13;
            this.ipOctet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres sieci:";
            // 
            // ipOctet2
            // 
            this.ipOctet2.Location = new System.Drawing.Point(119, 8);
            this.ipOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet2.Name = "ipOctet2";
            this.ipOctet2.Size = new System.Drawing.Size(39, 20);
            this.ipOctet2.TabIndex = 15;
            this.ipOctet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet3
            // 
            this.ipOctet3.Location = new System.Drawing.Point(164, 8);
            this.ipOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet3.Name = "ipOctet3";
            this.ipOctet3.Size = new System.Drawing.Size(39, 20);
            this.ipOctet3.TabIndex = 16;
            this.ipOctet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet4
            // 
            this.ipOctet4.Location = new System.Drawing.Point(209, 8);
            this.ipOctet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet4.Name = "ipOctet4";
            this.ipOctet4.Size = new System.Drawing.Size(39, 20);
            this.ipOctet4.TabIndex = 17;
            this.ipOctet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maska:";
            // 
            // cidrText
            // 
            this.cidrText.Location = new System.Drawing.Point(301, 8);
            this.cidrText.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cidrText.Name = "cidrText";
            this.cidrText.Size = new System.Drawing.Size(39, 20);
            this.cidrText.TabIndex = 19;
            this.cidrText.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidrText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ipOctet4);
            this.Controls.Add(this.ipOctet3);
            this.Controls.Add(this.ipOctet2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ipOctet1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OstatniUzytecznyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PierwszyUzytecznyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox networkAddressTextBox;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox PierwszyUzytecznyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox OstatniUzytecznyText;
        private System.Windows.Forms.NumericUpDown ipOctet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ipOctet2;
        private System.Windows.Forms.NumericUpDown ipOctet3;
        private System.Windows.Forms.NumericUpDown ipOctet4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cidrText;
        private System.Windows.Forms.Button button1;
    }
}

