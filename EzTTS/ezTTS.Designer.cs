namespace EzTTS
{
    partial class ezTTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ezTTS));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            TB_SPEAK = new TextBox();
            BTN_SPEAK = new Button();
            Speedometer = new NumericUpDown();
            pictureBox1 = new PictureBox();
            Tag = new Label();
            pictureBox2 = new PictureBox();
            VoiceChanger = new ComboBox();
            BTN_RECORD = new Button();
            CB_SPEAK = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            TB_CMD = new TextBox();
            BTN_ADD = new Button();
            BTN_DEL = new Button();
            BTN_SPEAK_PRESET = new Button();
            Commands = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Speedometer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1284, 361);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.BackgroundImage = Properties.Resources.photo_1506318137071_a8e063b4bec0;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label1, 1, 5);
            tableLayoutPanel2.Controls.Add(TB_SPEAK, 1, 2);
            tableLayoutPanel2.Controls.Add(BTN_SPEAK, 2, 2);
            tableLayoutPanel2.Controls.Add(Speedometer, 2, 3);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 5);
            tableLayoutPanel2.Controls.Add(Tag, 1, 3);
            tableLayoutPanel2.Controls.Add(pictureBox2, 2, 1);
            tableLayoutPanel2.Controls.Add(VoiceChanger, 1, 1);
            tableLayoutPanel2.Controls.Add(BTN_RECORD, 2, 4);
            tableLayoutPanel2.Controls.Add(CB_SPEAK, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(636, 355);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 335);
            label1.Name = "label1";
            label1.Size = new Size(470, 20);
            label1.TabIndex = 9;
            label1.Text = "by Devaliuz";
            // 
            // TB_SPEAK
            // 
            TB_SPEAK.AcceptsReturn = true;
            TB_SPEAK.BackColor = Color.Black;
            TB_SPEAK.Dock = DockStyle.Fill;
            TB_SPEAK.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TB_SPEAK.ForeColor = SystemColors.Info;
            TB_SPEAK.Location = new Point(23, 149);
            TB_SPEAK.Multiline = true;
            TB_SPEAK.Name = "TB_SPEAK";
            TB_SPEAK.PlaceholderText = "Type custom command here!";
            TB_SPEAK.Size = new Size(470, 57);
            TB_SPEAK.TabIndex = 0;
            TB_SPEAK.KeyDown += TB_SPEAK_KeyDown;
            // 
            // BTN_SPEAK
            // 
            BTN_SPEAK.BackColor = Color.Black;
            BTN_SPEAK.Dock = DockStyle.Fill;
            BTN_SPEAK.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_SPEAK.ForeColor = SystemColors.Info;
            BTN_SPEAK.Location = new Point(499, 149);
            BTN_SPEAK.Name = "BTN_SPEAK";
            BTN_SPEAK.Size = new Size(113, 57);
            BTN_SPEAK.TabIndex = 1;
            BTN_SPEAK.Text = "Speak!";
            BTN_SPEAK.UseVisualStyleBackColor = false;
            BTN_SPEAK.Click += BTN_SPEAK_Click;
            // 
            // Speedometer
            // 
            Speedometer.BackColor = Color.Black;
            Speedometer.Dock = DockStyle.Top;
            Speedometer.ForeColor = Color.White;
            Speedometer.Location = new Point(499, 212);
            Speedometer.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Speedometer.Name = "Speedometer";
            Speedometer.Size = new Size(113, 23);
            Speedometer.TabIndex = 5;
            Speedometer.ValueChanged += Speedometer_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Devalien_FINISHEDminiHEAD;
            pictureBox1.Location = new Point(3, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 14);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Tag
            // 
            Tag.AutoSize = true;
            Tag.Dock = DockStyle.Right;
            Tag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Tag.ForeColor = Color.White;
            Tag.Location = new Point(440, 209);
            Tag.Name = "Tag";
            Tag.Size = new Size(53, 63);
            Tag.TabIndex = 7;
            Tag.Text = "Speed";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Smile;
            pictureBox2.Location = new Point(499, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // VoiceChanger
            // 
            VoiceChanger.BackColor = Color.Black;
            VoiceChanger.FlatStyle = FlatStyle.Popup;
            VoiceChanger.ForeColor = Color.White;
            VoiceChanger.FormattingEnabled = true;
            VoiceChanger.Location = new Point(23, 23);
            VoiceChanger.Name = "VoiceChanger";
            VoiceChanger.Size = new Size(121, 23);
            VoiceChanger.TabIndex = 10;
            VoiceChanger.SelectedIndexChanged += VoiceChanger_SelectedIndexChanged;
            VoiceChanger.KeyDown += VoiceChanger_KeyDown;
            // 
            // BTN_RECORD
            // 
            BTN_RECORD.BackColor = Color.Black;
            BTN_RECORD.Dock = DockStyle.Fill;
            BTN_RECORD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_RECORD.ForeColor = SystemColors.Info;
            BTN_RECORD.Location = new Point(499, 275);
            BTN_RECORD.Name = "BTN_RECORD";
            BTN_RECORD.Size = new Size(113, 57);
            BTN_RECORD.TabIndex = 11;
            BTN_RECORD.Text = "Speak and Remember!";
            BTN_RECORD.UseVisualStyleBackColor = false;
            BTN_RECORD.Click += BTN_RECORD_Click;
            // 
            // CB_SPEAK
            // 
            CB_SPEAK.AutoSize = true;
            CB_SPEAK.ForeColor = Color.White;
            CB_SPEAK.Location = new Point(23, 275);
            CB_SPEAK.Name = "CB_SPEAK";
            CB_SPEAK.Size = new Size(197, 19);
            CB_SPEAK.TabIndex = 12;
            CB_SPEAK.Text = "Just talk when I click on \"Speak!\"";
            CB_SPEAK.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackgroundImage = Properties.Resources.photo_1506318137071_a8e063b4bec0;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel3.Controls.Add(Commands, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(645, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(636, 355);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(TB_CMD, 0, 4);
            tableLayoutPanel4.Controls.Add(BTN_ADD, 0, 3);
            tableLayoutPanel4.Controls.Add(BTN_DEL, 0, 1);
            tableLayoutPanel4.Controls.Add(BTN_SPEAK_PRESET, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(380, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Size = new Size(232, 309);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // TB_CMD
            // 
            TB_CMD.BackColor = Color.Black;
            TB_CMD.Dock = DockStyle.Fill;
            TB_CMD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TB_CMD.ForeColor = SystemColors.Info;
            TB_CMD.Location = new Point(3, 264);
            TB_CMD.Name = "TB_CMD";
            TB_CMD.PlaceholderText = "\"Add new Command!\"";
            TB_CMD.Size = new Size(226, 39);
            TB_CMD.TabIndex = 0;
            TB_CMD.KeyDown += TB_CMD_KeyDown;
            // 
            // BTN_ADD
            // 
            BTN_ADD.BackColor = Color.Black;
            BTN_ADD.Dock = DockStyle.Fill;
            BTN_ADD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_ADD.ForeColor = SystemColors.Info;
            BTN_ADD.Location = new Point(3, 187);
            BTN_ADD.Name = "BTN_ADD";
            BTN_ADD.Size = new Size(226, 71);
            BTN_ADD.TabIndex = 1;
            BTN_ADD.Text = "Add!";
            BTN_ADD.UseVisualStyleBackColor = false;
            BTN_ADD.Click += BTN_ADD_Click;
            // 
            // BTN_DEL
            // 
            BTN_DEL.BackColor = Color.Black;
            BTN_DEL.Dock = DockStyle.Fill;
            BTN_DEL.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_DEL.ForeColor = SystemColors.Info;
            BTN_DEL.Location = new Point(3, 80);
            BTN_DEL.Name = "BTN_DEL";
            BTN_DEL.Size = new Size(226, 71);
            BTN_DEL.TabIndex = 2;
            BTN_DEL.Text = "Forget!";
            BTN_DEL.UseVisualStyleBackColor = false;
            BTN_DEL.Click += BTN_DEL_Click;
            // 
            // BTN_SPEAK_PRESET
            // 
            BTN_SPEAK_PRESET.BackColor = Color.Black;
            BTN_SPEAK_PRESET.Dock = DockStyle.Fill;
            BTN_SPEAK_PRESET.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_SPEAK_PRESET.ForeColor = SystemColors.Info;
            BTN_SPEAK_PRESET.Location = new Point(3, 3);
            BTN_SPEAK_PRESET.Name = "BTN_SPEAK_PRESET";
            BTN_SPEAK_PRESET.Size = new Size(226, 71);
            BTN_SPEAK_PRESET.TabIndex = 3;
            BTN_SPEAK_PRESET.Text = "Speak!";
            BTN_SPEAK_PRESET.UseVisualStyleBackColor = false;
            BTN_SPEAK_PRESET.Click += BTN_SPEAK_PRESET_Click;
            // 
            // Commands
            // 
            Commands.BackColor = Color.Black;
            Commands.Dock = DockStyle.Fill;
            Commands.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Commands.ForeColor = SystemColors.Info;
            Commands.FormattingEnabled = true;
            Commands.ItemHeight = 32;
            Commands.Location = new Point(23, 23);
            Commands.Name = "Commands";
            Commands.Size = new Size(351, 309);
            Commands.TabIndex = 1;
            // 
            // ezTTS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.photo_1506318137071_a8e063b4bec0;
            ClientSize = new Size(1284, 361);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 400);
            Name = "ezTTS";
            Text = "SpaceTTS";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Speedometer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TB_SPEAK;
        private Button BTN_SPEAK;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox TB_CMD;
        private Button BTN_ADD;
        private Button BTN_DEL;
        private Button BTN_SPEAK_PRESET;
        private ListBox Commands;
        private NumericUpDown Speedometer;
        private PictureBox pictureBox1;
        private Label Tag;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox VoiceChanger;
        private Button BTN_RECORD;
        private CheckBox CB_SPEAK;
    }
}