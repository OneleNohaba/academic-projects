namespace INF154Pract10u21507628
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lboRolls = new ListBox();
            btnDiceRoll = new Button();
            groupBox2 = new GroupBox();
            rtbDisplay = new RichTextBox();
            radAvg = new RadioButton();
            radGroupRolls = new RadioButton();
            radSumRolls = new RadioButton();
            btnDisplay = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lboRolls);
            groupBox1.Controls.Add(btnDiceRoll);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dice";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 10);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 3;
            label1.Text = "Record of previous rolls";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lboRolls
            // 
            lboRolls.Enabled = false;
            lboRolls.FormattingEnabled = true;
            lboRolls.ItemHeight = 15;
            lboRolls.Location = new Point(156, 38);
            lboRolls.Name = "lboRolls";
            lboRolls.Size = new Size(158, 154);
            lboRolls.TabIndex = 1;
            // 
            // btnDiceRoll
            // 
            btnDiceRoll.Location = new Point(18, 22);
            btnDiceRoll.Name = "btnDiceRoll";
            btnDiceRoll.Size = new Size(123, 23);
            btnDiceRoll.TabIndex = 0;
            btnDiceRoll.Text = "Roll the Dice";
            btnDiceRoll.UseVisualStyleBackColor = true;
            btnDiceRoll.Click += btnDiceRoll_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbDisplay);
            groupBox2.Controls.Add(radAvg);
            groupBox2.Controls.Add(radGroupRolls);
            groupBox2.Controls.Add(radSumRolls);
            groupBox2.Controls.Add(btnDisplay);
            groupBox2.Location = new Point(386, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 199);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Analysis";
            // 
            // rtbDisplay
            // 
            rtbDisplay.Location = new Point(140, 13);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.ReadOnly = true;
            rtbDisplay.Size = new Size(190, 179);
            rtbDisplay.TabIndex = 4;
            rtbDisplay.Text = "";
            // 
            // radAvg
            // 
            radAvg.AutoSize = true;
            radAvg.Location = new Point(20, 65);
            radAvg.Name = "radAvg";
            radAvg.Size = new Size(107, 19);
            radAvg.TabIndex = 2;
            radAvg.TabStop = true;
            radAvg.Text = "Average of rolls";
            radAvg.UseVisualStyleBackColor = true;
            // 
            // radGroupRolls
            // 
            radGroupRolls.AutoSize = true;
            radGroupRolls.Location = new Point(20, 90);
            radGroupRolls.Name = "radGroupRolls";
            radGroupRolls.Size = new Size(114, 19);
            radGroupRolls.TabIndex = 3;
            radGroupRolls.TabStop = true;
            radGroupRolls.Text = "Grouping of rolls";
            radGroupRolls.UseVisualStyleBackColor = true;
            // 
            // radSumRolls
            // 
            radSumRolls.AutoSize = true;
            radSumRolls.Location = new Point(20, 38);
            radSumRolls.Name = "radSumRolls";
            radSumRolls.Size = new Size(88, 19);
            radSumRolls.TabIndex = 1;
            radSumRolls.TabStop = true;
            radSumRolls.Text = "Sum of rolls";
            radSumRolls.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(20, 147);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(114, 29);
            btnDisplay.TabIndex = 1;
            btnDisplay.Text = "Display the data";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "1.png");
            imageList1.Images.SetKeyName(1, "2.png");
            imageList1.Images.SetKeyName(2, "3.png");
            imageList1.Images.SetKeyName(3, "4.png");
            imageList1.Images.SetKeyName(4, "5.png");
            imageList1.Images.SetKeyName(5, "6.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 9);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 1;
            label2.Text = "Dice Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 252);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dice Game";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lboRolls;
        private Button btnDiceRoll;
        private GroupBox groupBox2;
        private RichTextBox rtbDisplay;
        private RadioButton radAvg;
        private RadioButton radGroupRolls;
        private RadioButton radSumRolls;
        private Button btnDisplay;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}