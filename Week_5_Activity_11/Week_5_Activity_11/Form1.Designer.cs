namespace Week_5_Activity_11
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.diceImageList = new System.Windows.Forms.ImageList(this.components);
            this.diceOnePictureBox = new System.Windows.Forms.PictureBox();
            this.diceTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.rollDice = new System.Windows.Forms.Button();
            this.closeGameProgram = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.winner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Try Your Luck! Hit the Roll Dice Button and Roll Snake Eyes!";
            // 
            // diceImageList
            // 
            this.diceImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("diceImageList.ImageStream")));
            this.diceImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.diceImageList.Images.SetKeyName(0, "dice-clipart-one.png");
            this.diceImageList.Images.SetKeyName(1, "dice-clipart-three.png");
            this.diceImageList.Images.SetKeyName(2, "dice-clipart-two.png");
            this.diceImageList.Images.SetKeyName(3, "dice-clipart-four.png");
            this.diceImageList.Images.SetKeyName(4, "dice-clipart-five.png");
            this.diceImageList.Images.SetKeyName(5, "dice-clipart-six.png");
            // 
            // diceOnePictureBox
            // 
            this.diceOnePictureBox.Location = new System.Drawing.Point(23, 19);
            this.diceOnePictureBox.Name = "diceOnePictureBox";
            this.diceOnePictureBox.Size = new System.Drawing.Size(221, 209);
            this.diceOnePictureBox.TabIndex = 3;
            this.diceOnePictureBox.TabStop = false;
            // 
            // diceTwoPictureBox
            // 
            this.diceTwoPictureBox.Location = new System.Drawing.Point(24, 21);
            this.diceTwoPictureBox.Name = "diceTwoPictureBox";
            this.diceTwoPictureBox.Size = new System.Drawing.Size(221, 209);
            this.diceTwoPictureBox.TabIndex = 4;
            this.diceTwoPictureBox.TabStop = false;
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(171, 387);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(130, 54);
            this.rollDice.TabIndex = 5;
            this.rollDice.Text = "Roll Dice!";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // closeGameProgram
            // 
            this.closeGameProgram.Location = new System.Drawing.Point(356, 387);
            this.closeGameProgram.Name = "closeGameProgram";
            this.closeGameProgram.Size = new System.Drawing.Size(130, 54);
            this.closeGameProgram.TabIndex = 7;
            this.closeGameProgram.Text = "Close Game";
            this.closeGameProgram.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diceOnePictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice One";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diceTwoPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 237);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dice Two";
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(574, 108);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(0, 16);
            this.winner.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(845, 479);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeGameProgram);
            this.Controls.Add(this.rollDice);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snake Eyes - The Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList diceImageList;
        private System.Windows.Forms.PictureBox diceOnePictureBox;
        private System.Windows.Forms.PictureBox diceTwoPictureBox;
        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.Button closeGameProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label winner;
    }
}

