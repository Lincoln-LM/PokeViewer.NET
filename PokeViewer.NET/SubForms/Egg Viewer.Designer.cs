﻿namespace PokeViewer.NET.SubForms
{
    partial class Egg_Viewer
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
            PokeSpriteBox = new PictureBox();
            PokeStats = new TextBox();
            FetchButton = new Button();
            BallBox = new PictureBox();
            HardStopButton = new Button();
            EatOnStart = new CheckBox();
            Item1Value = new TextBox();
            Item1Label = new Label();
            Item2Label = new Label();
            Item2Value = new TextBox();
            EatAgain = new CheckBox();
            Item3Label = new Label();
            Item3Value = new TextBox();
            DUPItem1Check = new CheckBox();
            DUPItem2Check = new CheckBox();
            DUPItem3Check = new CheckBox();
            SandwichCount = new Label();
            ShinyFoundLabel = new Label();
            NextSanwichLabel = new Label();
            HoldIngredients = new CheckBox();
            NumberOfFillings = new NumericUpDown();
            label1 = new Label();
            HoldTimeToFillings = new Label();
            FillingHoldTime = new TextBox();
            StopConditionsButton = new Button();
            DisplayPartyCheck = new CheckBox();
            UptimeLabel = new Label();
            SquareStarCount = new Label();
            HidePIDEC = new CheckBox();
            ScreenshotButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            BasketCount = new Label();
            ForceDumpCheck = new CheckBox();
            CollectEggsCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)PokeSpriteBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BallBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfFillings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // PokeSpriteBox
            // 
            PokeSpriteBox.BackColor = Color.WhiteSmoke;
            PokeSpriteBox.BorderStyle = BorderStyle.FixedSingle;
            PokeSpriteBox.Location = new Point(96, 43);
            PokeSpriteBox.Name = "PokeSpriteBox";
            PokeSpriteBox.Size = new Size(94, 72);
            PokeSpriteBox.SizeMode = PictureBoxSizeMode.Zoom;
            PokeSpriteBox.TabIndex = 0;
            PokeSpriteBox.TabStop = false;
            // 
            // PokeStats
            // 
            PokeStats.Location = new Point(96, 121);
            PokeStats.Multiline = true;
            PokeStats.Name = "PokeStats";
            PokeStats.ReadOnly = true;
            PokeStats.Size = new Size(146, 124);
            PokeStats.TabIndex = 1;
            PokeStats.TextAlign = HorizontalAlignment.Center;
            // 
            // FetchButton
            // 
            FetchButton.BackColor = Color.Transparent;
            FetchButton.Location = new Point(96, 254);
            FetchButton.Name = "FetchButton";
            FetchButton.Size = new Size(75, 23);
            FetchButton.TabIndex = 2;
            FetchButton.Text = "Fetch";
            FetchButton.UseVisualStyleBackColor = false;
            FetchButton.Click += button1_Click;
            // 
            // BallBox
            // 
            BallBox.BackColor = Color.WhiteSmoke;
            BallBox.BorderStyle = BorderStyle.FixedSingle;
            BallBox.Location = new Point(196, 78);
            BallBox.Name = "BallBox";
            BallBox.Size = new Size(46, 37);
            BallBox.SizeMode = PictureBoxSizeMode.CenterImage;
            BallBox.TabIndex = 4;
            BallBox.TabStop = false;
            // 
            // HardStopButton
            // 
            HardStopButton.BackColor = Color.Transparent;
            HardStopButton.Location = new Point(177, 254);
            HardStopButton.Name = "HardStopButton";
            HardStopButton.Size = new Size(65, 23);
            HardStopButton.TabIndex = 5;
            HardStopButton.Text = "HardStop";
            HardStopButton.UseVisualStyleBackColor = false;
            HardStopButton.Click += HardStopButton_Click;
            // 
            // EatOnStart
            // 
            EatOnStart.AutoSize = true;
            EatOnStart.Location = new Point(263, 53);
            EatOnStart.Name = "EatOnStart";
            EatOnStart.Size = new Size(93, 19);
            EatOnStart.TabIndex = 13;
            EatOnStart.Text = "Eat On Start?";
            EatOnStart.UseVisualStyleBackColor = true;
            // 
            // Item1Value
            // 
            Item1Value.BackColor = SystemColors.Control;
            Item1Value.Location = new Point(313, 144);
            Item1Value.Name = "Item1Value";
            Item1Value.Size = new Size(32, 23);
            Item1Value.TabIndex = 14;
            Item1Value.Text = "0";
            Item1Value.TextAlign = HorizontalAlignment.Center;
            // 
            // Item1Label
            // 
            Item1Label.AutoSize = true;
            Item1Label.Location = new Point(260, 147);
            Item1Label.Name = "Item1Label";
            Item1Label.Size = new Size(40, 15);
            Item1Label.TabIndex = 15;
            Item1Label.Text = "Item 1";
            // 
            // Item2Label
            // 
            Item2Label.AutoSize = true;
            Item2Label.Location = new Point(260, 175);
            Item2Label.Name = "Item2Label";
            Item2Label.Size = new Size(40, 15);
            Item2Label.TabIndex = 16;
            Item2Label.Text = "Item 2";
            // 
            // Item2Value
            // 
            Item2Value.BackColor = SystemColors.Control;
            Item2Value.Location = new Point(313, 172);
            Item2Value.Name = "Item2Value";
            Item2Value.Size = new Size(32, 23);
            Item2Value.TabIndex = 17;
            Item2Value.Text = "4";
            Item2Value.TextAlign = HorizontalAlignment.Center;
            // 
            // EatAgain
            // 
            EatAgain.AutoSize = true;
            EatAgain.BackColor = Color.Transparent;
            EatAgain.Location = new Point(263, 75);
            EatAgain.Name = "EatAgain";
            EatAgain.Size = new Size(81, 19);
            EatAgain.TabIndex = 18;
            EatAgain.Text = "Eat Again?";
            EatAgain.UseVisualStyleBackColor = false;
            // 
            // Item3Label
            // 
            Item3Label.AutoSize = true;
            Item3Label.Location = new Point(260, 203);
            Item3Label.Name = "Item3Label";
            Item3Label.Size = new Size(40, 15);
            Item3Label.TabIndex = 19;
            Item3Label.Text = "Item 3";
            // 
            // Item3Value
            // 
            Item3Value.BackColor = SystemColors.Control;
            Item3Value.Location = new Point(313, 200);
            Item3Value.Name = "Item3Value";
            Item3Value.Size = new Size(32, 23);
            Item3Value.TabIndex = 20;
            Item3Value.Text = "1";
            Item3Value.TextAlign = HorizontalAlignment.Center;
            // 
            // DUPItem1Check
            // 
            DUPItem1Check.AutoSize = true;
            DUPItem1Check.Location = new Point(362, 146);
            DUPItem1Check.Name = "DUPItem1Check";
            DUPItem1Check.Size = new Size(49, 19);
            DUPItem1Check.TabIndex = 21;
            DUPItem1Check.Text = "DUP";
            DUPItem1Check.UseVisualStyleBackColor = true;
            // 
            // DUPItem2Check
            // 
            DUPItem2Check.AutoSize = true;
            DUPItem2Check.Checked = true;
            DUPItem2Check.CheckState = CheckState.Checked;
            DUPItem2Check.Location = new Point(362, 174);
            DUPItem2Check.Name = "DUPItem2Check";
            DUPItem2Check.Size = new Size(49, 19);
            DUPItem2Check.TabIndex = 22;
            DUPItem2Check.Text = "DUP";
            DUPItem2Check.UseVisualStyleBackColor = true;
            // 
            // DUPItem3Check
            // 
            DUPItem3Check.AutoSize = true;
            DUPItem3Check.Checked = true;
            DUPItem3Check.CheckState = CheckState.Checked;
            DUPItem3Check.Location = new Point(362, 202);
            DUPItem3Check.Name = "DUPItem3Check";
            DUPItem3Check.Size = new Size(49, 19);
            DUPItem3Check.TabIndex = 23;
            DUPItem3Check.Text = "DUP";
            DUPItem3Check.UseVisualStyleBackColor = true;
            // 
            // SandwichCount
            // 
            SandwichCount.AutoSize = true;
            SandwichCount.Location = new Point(93, 285);
            SandwichCount.Name = "SandwichCount";
            SandwichCount.Size = new Size(108, 15);
            SandwichCount.TabIndex = 28;
            SandwichCount.Text = "Sandwiches Made: ";
            // 
            // ShinyFoundLabel
            // 
            ShinyFoundLabel.AutoSize = true;
            ShinyFoundLabel.Location = new Point(257, 304);
            ShinyFoundLabel.Name = "ShinyFoundLabel";
            ShinyFoundLabel.Size = new Size(87, 15);
            ShinyFoundLabel.TabIndex = 29;
            ShinyFoundLabel.Text = "Shinies Found: ";
            // 
            // NextSanwichLabel
            // 
            NextSanwichLabel.AutoSize = true;
            NextSanwichLabel.Location = new Point(93, 304);
            NextSanwichLabel.Name = "NextSanwichLabel";
            NextSanwichLabel.Size = new Size(89, 15);
            NextSanwichLabel.TabIndex = 31;
            NextSanwichLabel.Text = "Next Sandwich:";
            // 
            // HoldIngredients
            // 
            HoldIngredients.AutoSize = true;
            HoldIngredients.Location = new Point(263, 97);
            HoldIngredients.Name = "HoldIngredients";
            HoldIngredients.Size = new Size(97, 19);
            HoldIngredients.TabIndex = 32;
            HoldIngredients.Text = "Hold Fillings?";
            HoldIngredients.UseVisualStyleBackColor = true;
            // 
            // NumberOfFillings
            // 
            NumberOfFillings.BackColor = SystemColors.Control;
            NumberOfFillings.Location = new Point(355, 232);
            NumberOfFillings.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumberOfFillings.Name = "NumberOfFillings";
            NumberOfFillings.Size = new Size(49, 23);
            NumberOfFillings.TabIndex = 33;
            NumberOfFillings.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 235);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 34;
            label1.Text = "Fillings Count?";
            // 
            // HoldTimeToFillings
            // 
            HoldTimeToFillings.AutoSize = true;
            HoldTimeToFillings.Location = new Point(258, 264);
            HoldTimeToFillings.Name = "HoldTimeToFillings";
            HoldTimeToFillings.Size = new Size(108, 15);
            HoldTimeToFillings.TabIndex = 35;
            HoldTimeToFillings.Text = "Fillings HOLD Time";
            // 
            // FillingHoldTime
            // 
            FillingHoldTime.BackColor = SystemColors.Control;
            FillingHoldTime.Location = new Point(371, 262);
            FillingHoldTime.Name = "FillingHoldTime";
            FillingHoldTime.Size = new Size(33, 23);
            FillingHoldTime.TabIndex = 36;
            FillingHoldTime.Text = "690";
            // 
            // StopConditionsButton
            // 
            StopConditionsButton.BackColor = Color.Transparent;
            StopConditionsButton.Location = new Point(92, 343);
            StopConditionsButton.Name = "StopConditionsButton";
            StopConditionsButton.Size = new Size(105, 23);
            StopConditionsButton.TabIndex = 63;
            StopConditionsButton.Text = "Stop Conditions";
            StopConditionsButton.UseVisualStyleBackColor = false;
            StopConditionsButton.Click += StopConditionsButton_Click;
            // 
            // DisplayPartyCheck
            // 
            DisplayPartyCheck.AutoSize = true;
            DisplayPartyCheck.Location = new Point(263, 118);
            DisplayPartyCheck.Name = "DisplayPartyCheck";
            DisplayPartyCheck.Size = new Size(99, 19);
            DisplayPartyCheck.TabIndex = 64;
            DisplayPartyCheck.Text = "Display Party?";
            DisplayPartyCheck.UseVisualStyleBackColor = true;
            // 
            // UptimeLabel
            // 
            UptimeLabel.AutoSize = true;
            UptimeLabel.Location = new Point(93, 324);
            UptimeLabel.Name = "UptimeLabel";
            UptimeLabel.Size = new Size(52, 15);
            UptimeLabel.TabIndex = 65;
            UptimeLabel.Text = "Uptime: ";
            // 
            // SquareStarCount
            // 
            SquareStarCount.AutoSize = true;
            SquareStarCount.Location = new Point(257, 324);
            SquareStarCount.Name = "SquareStarCount";
            SquareStarCount.Size = new Size(70, 15);
            SquareStarCount.TabIndex = 66;
            SquareStarCount.Text = "■ - 0 | ★ - 0";
            // 
            // HidePIDEC
            // 
            HidePIDEC.AutoSize = true;
            HidePIDEC.Location = new Point(263, 32);
            HidePIDEC.Name = "HidePIDEC";
            HidePIDEC.Size = new Size(129, 19);
            HidePIDEC.TabIndex = 67;
            HidePIDEC.Text = "Hide Sensitive Info?";
            HidePIDEC.UseVisualStyleBackColor = true;
            // 
            // ScreenshotButton
            // 
            ScreenshotButton.BackColor = Color.Transparent;
            ScreenshotButton.Location = new Point(259, 343);
            ScreenshotButton.Name = "ScreenshotButton";
            ScreenshotButton.Size = new Size(105, 23);
            ScreenshotButton.TabIndex = 68;
            ScreenshotButton.Text = "Screenshot";
            ScreenshotButton.UseVisualStyleBackColor = false;
            ScreenshotButton.Click += ScreenshotButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(77, 372);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(131, 372);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(185, 372);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(239, 372);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 72;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(293, 372);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 73;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(348, 372);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.TabIndex = 74;
            pictureBox6.TabStop = false;
            // 
            // BasketCount
            // 
            BasketCount.AutoSize = true;
            BasketCount.Location = new Point(257, 285);
            BasketCount.Name = "BasketCount";
            BasketCount.Size = new Size(80, 15);
            BasketCount.TabIndex = 78;
            BasketCount.Text = "Basket Count:";
            // 
            // ForceDumpCheck
            // 
            ForceDumpCheck.AutoSize = true;
            ForceDumpCheck.Location = new Point(362, 118);
            ForceDumpCheck.Name = "ForceDumpCheck";
            ForceDumpCheck.Size = new Size(46, 19);
            ForceDumpCheck.TabIndex = 79;
            ForceDumpCheck.Text = "👻 ?";
            ForceDumpCheck.UseVisualStyleBackColor = true;
            ForceDumpCheck.CheckedChanged += ForceEgg_CheckedChanged;
            // 
            // CollectEggsCheck
            // 
            CollectEggsCheck.AutoSize = true;
            CollectEggsCheck.Location = new Point(263, 12);
            CollectEggsCheck.Name = "CollectEggsCheck";
            CollectEggsCheck.Size = new Size(96, 19);
            CollectEggsCheck.TabIndex = 80;
            CollectEggsCheck.Text = "Collect Eggs?";
            CollectEggsCheck.UseVisualStyleBackColor = true;
            CollectEggsCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Egg_Viewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(426, 404);
            Controls.Add(CollectEggsCheck);
            Controls.Add(ForceDumpCheck);
            Controls.Add(BasketCount);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ScreenshotButton);
            Controls.Add(HidePIDEC);
            Controls.Add(SquareStarCount);
            Controls.Add(UptimeLabel);
            Controls.Add(DisplayPartyCheck);
            Controls.Add(StopConditionsButton);
            Controls.Add(FillingHoldTime);
            Controls.Add(HoldTimeToFillings);
            Controls.Add(label1);
            Controls.Add(NumberOfFillings);
            Controls.Add(HoldIngredients);
            Controls.Add(NextSanwichLabel);
            Controls.Add(ShinyFoundLabel);
            Controls.Add(SandwichCount);
            Controls.Add(DUPItem3Check);
            Controls.Add(DUPItem2Check);
            Controls.Add(DUPItem1Check);
            Controls.Add(Item3Value);
            Controls.Add(Item3Label);
            Controls.Add(EatAgain);
            Controls.Add(Item2Value);
            Controls.Add(Item2Label);
            Controls.Add(Item1Label);
            Controls.Add(Item1Value);
            Controls.Add(EatOnStart);
            Controls.Add(HardStopButton);
            Controls.Add(BallBox);
            Controls.Add(FetchButton);
            Controls.Add(PokeStats);
            Controls.Add(PokeSpriteBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Egg_Viewer";
            Text = "Egg Viewer";
            ((System.ComponentModel.ISupportInitialize)PokeSpriteBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BallBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfFillings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PokeSpriteBox;
        private TextBox PokeStats;
        private Button FetchButton;
        private PictureBox BallBox;
        private Button HardStopButton;
        private CheckBox EatOnStart;
        private TextBox Item1Value;
        private Label Item1Label;
        private Label Item2Label;
        private TextBox Item2Value;
        private CheckBox EatAgain;
        private Label Item3Label;
        private TextBox Item3Value;
        private CheckBox DUPItem1Check;
        private CheckBox DUPItem2Check;
        private CheckBox DUPItem3Check;
        private Label SandwichCount;
        private Label ShinyFoundLabel;
        private Label NextSanwichLabel;
        private CheckBox HoldIngredients;
        private NumericUpDown NumberOfFillings;
        private Label label1;
        private Label HoldTimeToFillings;
        private TextBox FillingHoldTime;
        private Button StopConditionsButton;
        private CheckBox DisplayPartyCheck;
        private Label UptimeLabel;
        private Label SquareStarCount;
        private CheckBox HidePIDEC;
        private Button ScreenshotButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label BasketCount;
        private CheckBox ForceDumpCheck;
        private CheckBox CollectEggsCheck;
    }
}