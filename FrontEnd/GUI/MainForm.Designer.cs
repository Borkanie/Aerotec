// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            INFORMATI = new GroupBox();
            DataANRTextBox = new TextBox();
            DataBTIDTextBox = new TextBox();
            DataControllerIdTextBox = new TextBox();
            SignatureTextBox = new TextBox();
            DataHTZTextBox = new TextBox();
            groupBox2 = new GroupBox();
            LabelRotatie = new Label();
            ComboBoxRotation = new ComboBox();
            label9 = new Label();
            ComboBoxMachine = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ControllerIdTextBox = new TextBox();
            ControllerTextBox = new TextBox();
            ComandaDeLucruBox = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BTIDTextBox = new TextBox();
            HTZTextBox = new TextBox();
            ANRTextBox = new TextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            label10 = new Label();
            DelayTextBox = new TextBox();
            ButtonDecreaseCurrentCount = new Button();
            ButtonIncreaseCurrentCount = new Button();
            label8 = new Label();
            CurrentQuantityTextBox = new TextBox();
            SizeComboBox = new ComboBox();
            ExpectedQuantityTxtBox = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            StartStopButton = new Button();
            ContactButton = new Button();
            AdvancedOptionsBox = new GroupBox();
            label16 = new Label();
            EncoderResolutionTexbBox = new TextBox();
            advancedoptionsButton = new Button();
            INFORMATI.SuspendLayout();
            groupBox2.SuspendLayout();
            ComandaDeLucruBox.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            AdvancedOptionsBox.SuspendLayout();
            SuspendLayout();
            // 
            // INFORMATI
            // 
            INFORMATI.Anchor = AnchorStyles.Top;
            INFORMATI.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            INFORMATI.Controls.Add(DataANRTextBox);
            INFORMATI.Controls.Add(DataBTIDTextBox);
            INFORMATI.Controls.Add(DataControllerIdTextBox);
            INFORMATI.Controls.Add(SignatureTextBox);
            INFORMATI.Controls.Add(DataHTZTextBox);
            INFORMATI.Location = new Point(24, 10);
            INFORMATI.Margin = new Padding(3, 2, 3, 2);
            INFORMATI.Name = "INFORMATI";
            INFORMATI.Padding = new Padding(3, 2, 3, 2);
            INFORMATI.Size = new Size(290, 79);
            INFORMATI.TabIndex = 0;
            INFORMATI.TabStop = false;
            INFORMATI.Text = "PREVIZUALIZARE:";
            // 
            // DataANRTextBox
            // 
            DataANRTextBox.Location = new Point(12, 47);
            DataANRTextBox.Margin = new Padding(3, 2, 3, 2);
            DataANRTextBox.Name = "DataANRTextBox";
            DataANRTextBox.ReadOnly = true;
            DataANRTextBox.Size = new Size(101, 23);
            DataANRTextBox.TabIndex = 5;
            DataANRTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataBTIDTextBox
            // 
            DataBTIDTextBox.Location = new Point(118, 47);
            DataBTIDTextBox.Margin = new Padding(3, 2, 3, 2);
            DataBTIDTextBox.Name = "DataBTIDTextBox";
            DataBTIDTextBox.ReadOnly = true;
            DataBTIDTextBox.Size = new Size(64, 23);
            DataBTIDTextBox.TabIndex = 4;
            DataBTIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataControllerIdTextBox
            // 
            DataControllerIdTextBox.Location = new Point(187, 47);
            DataControllerIdTextBox.Margin = new Padding(3, 2, 3, 2);
            DataControllerIdTextBox.Name = "DataControllerIdTextBox";
            DataControllerIdTextBox.ReadOnly = true;
            DataControllerIdTextBox.Size = new Size(98, 23);
            DataControllerIdTextBox.TabIndex = 3;
            DataControllerIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SignatureTextBox
            // 
            SignatureTextBox.Location = new Point(187, 17);
            SignatureTextBox.Margin = new Padding(3, 2, 3, 2);
            SignatureTextBox.Name = "SignatureTextBox";
            SignatureTextBox.ReadOnly = true;
            SignatureTextBox.Size = new Size(98, 23);
            SignatureTextBox.TabIndex = 2;
            SignatureTextBox.Text = "A-D";
            SignatureTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DataHTZTextBox
            // 
            DataHTZTextBox.Location = new Point(12, 17);
            DataHTZTextBox.Margin = new Padding(3, 2, 3, 2);
            DataHTZTextBox.Name = "DataHTZTextBox";
            DataHTZTextBox.ReadOnly = true;
            DataHTZTextBox.Size = new Size(170, 23);
            DataHTZTextBox.TabIndex = 0;
            DataHTZTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(LabelRotatie);
            groupBox2.Controls.Add(ComboBoxRotation);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(ComboBoxMachine);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ControllerIdTextBox);
            groupBox2.Controls.Add(ControllerTextBox);
            groupBox2.Location = new Point(24, 93);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(290, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "UTILIZATOR";
            // 
            // LabelRotatie
            // 
            LabelRotatie.Anchor = AnchorStyles.Left;
            LabelRotatie.AutoSize = true;
            LabelRotatie.Location = new Point(54, 26);
            LabelRotatie.Name = "LabelRotatie";
            LabelRotatie.Size = new Size(52, 15);
            LabelRotatie.TabIndex = 12;
            LabelRotatie.Text = "ROTATIE:";
            // 
            // ComboBoxRotation
            // 
            ComboBoxRotation.Anchor = AnchorStyles.Right;
            ComboBoxRotation.FormattingEnabled = true;
            ComboBoxRotation.Location = new Point(147, 20);
            ComboBoxRotation.Margin = new Padding(3, 2, 3, 2);
            ComboBoxRotation.Name = "ComboBoxRotation";
            ComboBoxRotation.Size = new Size(139, 23);
            ComboBoxRotation.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(53, 54);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 10;
            label9.Text = "CERNEALA:";
            // 
            // ComboBoxMachine
            // 
            ComboBoxMachine.Anchor = AnchorStyles.Right;
            ComboBoxMachine.FormattingEnabled = true;
            ComboBoxMachine.Location = new Point(147, 48);
            ComboBoxMachine.Margin = new Padding(3, 2, 3, 2);
            ComboBoxMachine.Name = "ComboBoxMachine";
            ComboBoxMachine.Size = new Size(139, 23);
            ComboBoxMachine.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(89, 105);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(28, 79);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "CONTROLOR:";
            // 
            // ControllerIdTextBox
            // 
            ControllerIdTextBox.Anchor = AnchorStyles.Left;
            ControllerIdTextBox.Location = new Point(147, 100);
            ControllerIdTextBox.Margin = new Padding(3, 2, 3, 2);
            ControllerIdTextBox.Name = "ControllerIdTextBox";
            ControllerIdTextBox.ReadOnly = true;
            ControllerIdTextBox.Size = new Size(139, 23);
            ControllerIdTextBox.TabIndex = 4;
            // 
            // ControllerTextBox
            // 
            ControllerTextBox.Anchor = AnchorStyles.Left;
            ControllerTextBox.Location = new Point(147, 74);
            ControllerTextBox.Margin = new Padding(3, 2, 3, 2);
            ControllerTextBox.Name = "ControllerTextBox";
            ControllerTextBox.ReadOnly = true;
            ControllerTextBox.Size = new Size(139, 23);
            ControllerTextBox.TabIndex = 3;
            // 
            // ComandaDeLucruBox
            // 
            ComandaDeLucruBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ComandaDeLucruBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ComandaDeLucruBox.Controls.Add(label5);
            ComandaDeLucruBox.Controls.Add(label4);
            ComandaDeLucruBox.Controls.Add(label3);
            ComandaDeLucruBox.Controls.Add(BTIDTextBox);
            ComandaDeLucruBox.Controls.Add(HTZTextBox);
            ComandaDeLucruBox.Controls.Add(ANRTextBox);
            ComandaDeLucruBox.Location = new Point(24, 224);
            ComandaDeLucruBox.Margin = new Padding(3, 2, 3, 2);
            ComandaDeLucruBox.Name = "ComandaDeLucruBox";
            ComandaDeLucruBox.Padding = new Padding(3, 2, 3, 2);
            ComandaDeLucruBox.Size = new Size(290, 104);
            ComandaDeLucruBox.TabIndex = 2;
            ComandaDeLucruBox.TabStop = false;
            ComandaDeLucruBox.Text = "COMANDA DE LUCRU";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(23, 79);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 9;
            label5.Text = "INDEX COMANDA:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(110, 54);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "HTZ:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 30);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 7;
            label3.Text = "NUMAR COMADA:";
            // 
            // BTIDTextBox
            // 
            BTIDTextBox.Anchor = AnchorStyles.Bottom;
            BTIDTextBox.Location = new Point(147, 76);
            BTIDTextBox.Margin = new Padding(3, 2, 3, 2);
            BTIDTextBox.Name = "BTIDTextBox";
            BTIDTextBox.Size = new Size(139, 23);
            BTIDTextBox.TabIndex = 6;
            // 
            // HTZTextBox
            // 
            HTZTextBox.Anchor = AnchorStyles.Bottom;
            HTZTextBox.Location = new Point(147, 52);
            HTZTextBox.Margin = new Padding(3, 2, 3, 2);
            HTZTextBox.Name = "HTZTextBox";
            HTZTextBox.Size = new Size(139, 23);
            HTZTextBox.TabIndex = 5;
            // 
            // ANRTextBox
            // 
            ANRTextBox.Anchor = AnchorStyles.Right;
            ANRTextBox.Location = new Point(147, 27);
            ANRTextBox.Margin = new Padding(3, 2, 3, 2);
            ANRTextBox.Name = "ANRTextBox";
            ANRTextBox.Size = new Size(139, 23);
            ANRTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(8, 50);
            label6.Name = "label6";
            label6.Size = new Size(172, 15);
            label6.TabIndex = 3;
            label6.Text = "SELECTATI MARIMEA DORITA:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Right;
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(DelayTextBox);
            groupBox4.Controls.Add(ButtonDecreaseCurrentCount);
            groupBox4.Controls.Add(ButtonIncreaseCurrentCount);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(CurrentQuantityTextBox);
            groupBox4.Controls.Add(SizeComboBox);
            groupBox4.Controls.Add(ExpectedQuantityTxtBox);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(344, 106);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(346, 157);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "MARIMEA SI CANTITATE";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F);
            label10.Location = new Point(74, 23);
            label10.Name = "label10";
            label10.Size = new Size(114, 15);
            label10.TabIndex = 14;
            label10.Text = "DELAY(micrometri):";
            // 
            // DelayTextBox
            // 
            DelayTextBox.Anchor = AnchorStyles.Right;
            DelayTextBox.Location = new Point(208, 20);
            DelayTextBox.Margin = new Padding(3, 2, 3, 2);
            DelayTextBox.Name = "DelayTextBox";
            DelayTextBox.Size = new Size(133, 23);
            DelayTextBox.TabIndex = 13;
            DelayTextBox.Text = "2000";
            DelayTextBox.TextChanged += DelayTextBox_TextChanged;
            // 
            // ButtonDecreaseCurrentCount
            // 
            ButtonDecreaseCurrentCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDecreaseCurrentCount.Location = new Point(301, 124);
            ButtonDecreaseCurrentCount.Margin = new Padding(3, 2, 3, 2);
            ButtonDecreaseCurrentCount.Name = "ButtonDecreaseCurrentCount";
            ButtonDecreaseCurrentCount.Size = new Size(23, 19);
            ButtonDecreaseCurrentCount.TabIndex = 12;
            ButtonDecreaseCurrentCount.Text = "-";
            ButtonDecreaseCurrentCount.UseVisualStyleBackColor = true;
            ButtonDecreaseCurrentCount.Click += DecreaseCurrentCount_Click;
            // 
            // ButtonIncreaseCurrentCount
            // 
            ButtonIncreaseCurrentCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonIncreaseCurrentCount.Location = new Point(236, 124);
            ButtonIncreaseCurrentCount.Margin = new Padding(3, 2, 3, 2);
            ButtonIncreaseCurrentCount.Name = "ButtonIncreaseCurrentCount";
            ButtonIncreaseCurrentCount.Size = new Size(23, 19);
            ButtonIncreaseCurrentCount.TabIndex = 11;
            ButtonIncreaseCurrentCount.Text = "+";
            ButtonIncreaseCurrentCount.UseVisualStyleBackColor = true;
            ButtonIncreaseCurrentCount.Click += IncreaseCurrentCount_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F);
            label8.Location = new Point(37, 76);
            label8.Name = "label8";
            label8.Size = new Size(146, 15);
            label8.TabIndex = 10;
            label8.Text = "TOTAL PIESE COMANDA:";
            // 
            // CurrentQuantityTextBox
            // 
            CurrentQuantityTextBox.Anchor = AnchorStyles.Right;
            CurrentQuantityTextBox.Location = new Point(208, 100);
            CurrentQuantityTextBox.Margin = new Padding(3, 2, 3, 2);
            CurrentQuantityTextBox.Name = "CurrentQuantityTextBox";
            CurrentQuantityTextBox.Size = new Size(133, 23);
            CurrentQuantityTextBox.TabIndex = 9;
            CurrentQuantityTextBox.Text = "0";
            // 
            // SizeComboBox
            // 
            SizeComboBox.Anchor = AnchorStyles.Right;
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Location = new Point(208, 46);
            SizeComboBox.Margin = new Padding(3, 2, 3, 2);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(133, 23);
            SizeComboBox.TabIndex = 8;
            // 
            // ExpectedQuantityTxtBox
            // 
            ExpectedQuantityTxtBox.Anchor = AnchorStyles.Right;
            ExpectedQuantityTxtBox.Location = new Point(208, 72);
            ExpectedQuantityTxtBox.Margin = new Padding(3, 2, 3, 2);
            ExpectedQuantityTxtBox.Name = "ExpectedQuantityTxtBox";
            ExpectedQuantityTxtBox.Size = new Size(133, 23);
            ExpectedQuantityTxtBox.TabIndex = 7;
            ExpectedQuantityTxtBox.Text = "0";
            ExpectedQuantityTxtBox.KeyPress += ExpectedQuantityTxtBox_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F);
            label7.Location = new Point(83, 107);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 6;
            label7.Text = "PIESE MARCATE:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(600, 268);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(344, 18);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(346, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // StartStopButton
            // 
            StartStopButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartStopButton.Location = new Point(344, 281);
            StartStopButton.Margin = new Padding(3, 2, 3, 2);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(137, 47);
            StartStopButton.TabIndex = 7;
            StartStopButton.Text = "START";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // ContactButton
            // 
            ContactButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ContactButton.Location = new Point(508, 278);
            ContactButton.Margin = new Padding(3, 2, 3, 2);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(75, 47);
            ContactButton.TabIndex = 8;
            ContactButton.Text = "CONTACT";
            ContactButton.UseVisualStyleBackColor = true;
            ContactButton.Click += ContactButton_Click;
            // 
            // AdvancedOptionsBox
            // 
            AdvancedOptionsBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AdvancedOptionsBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AdvancedOptionsBox.Controls.Add(label16);
            AdvancedOptionsBox.Controls.Add(EncoderResolutionTexbBox);
            AdvancedOptionsBox.Location = new Point(24, 224);
            AdvancedOptionsBox.Margin = new Padding(3, 2, 3, 2);
            AdvancedOptionsBox.Name = "AdvancedOptionsBox";
            AdvancedOptionsBox.Padding = new Padding(3, 2, 3, 2);
            AdvancedOptionsBox.Size = new Size(307, 116);
            AdvancedOptionsBox.TabIndex = 10;
            AdvancedOptionsBox.TabStop = false;
            AdvancedOptionsBox.Text = "Optiuni Avansate";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(12, 46);
            label16.Name = "label16";
            label16.Size = new Size(129, 15);
            label16.TabIndex = 7;
            label16.Text = "RESOLUTIE ENCODER:";
            // 
            // EncoderResolutionTexbBox
            // 
            EncoderResolutionTexbBox.Anchor = AnchorStyles.Right;
            EncoderResolutionTexbBox.Location = new Point(170, 44);
            EncoderResolutionTexbBox.Margin = new Padding(3, 2, 3, 2);
            EncoderResolutionTexbBox.Name = "EncoderResolutionTexbBox";
            EncoderResolutionTexbBox.Size = new Size(117, 23);
            EncoderResolutionTexbBox.TabIndex = 4;
            EncoderResolutionTexbBox.Text = "30";
            // 
            // advancedoptionsButton
            // 
            advancedoptionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            advancedoptionsButton.Location = new Point(0, 238);
            advancedoptionsButton.Margin = new Padding(3, 2, 3, 2);
            advancedoptionsButton.Name = "advancedoptionsButton";
            advancedoptionsButton.Size = new Size(25, 26);
            advancedoptionsButton.TabIndex = 11;
            advancedoptionsButton.Text = "+";
            advancedoptionsButton.UseVisualStyleBackColor = true;
            advancedoptionsButton.Click += advancedoptionsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 344);
            Controls.Add(advancedoptionsButton);
            Controls.Add(AdvancedOptionsBox);
            Controls.Add(ContactButton);
            Controls.Add(StartStopButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(ComandaDeLucruBox);
            Controls.Add(groupBox2);
            Controls.Add(INFORMATI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Interfata Jet3Up";
            INFORMATI.ResumeLayout(false);
            INFORMATI.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ComandaDeLucruBox.ResumeLayout(false);
            ComandaDeLucruBox.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            AdvancedOptionsBox.ResumeLayout(false);
            AdvancedOptionsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox INFORMATI;
        private TextBox DataANRTextBox;
        private TextBox DataBTIDTextBox;
        private TextBox DataControllerIdTextBox;
        private TextBox SignatureTextBox;
        private TextBox DataHTZTextBox;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox ControllerIdTextBox;
        private TextBox ControllerTextBox;
        private GroupBox ComandaDeLucruBox;
        private TextBox ANRTextBox;
        private Label label3;
        private TextBox BTIDTextBox;
        private TextBox HTZTextBox;
        private Label label5;
        private Label label4;
        private Label label6;
        private GroupBox groupBox4;
        private ComboBox SizeComboBox;
        private TextBox ExpectedQuantityTxtBox;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button StartStopButton;
        private Button ContactButton;
        private Label label8;
        private TextBox CurrentQuantityTextBox;
        private Label label9;
        private ComboBox ComboBoxMachine;
        private Label LabelRotatie;
        private ComboBox ComboBoxRotation;
        private Button ButtonDecreaseCurrentCount;
        private Button ButtonIncreaseCurrentCount;
        private Label label10;
        private TextBox DelayTextBox;
        private GroupBox AdvancedOptionsBox;
        private Label label16;
        private TextBox EncoderResolutionTexbBox;
        private Button advancedoptionsButton;
    }
}