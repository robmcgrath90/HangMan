namespace HangMan
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.GuessedLetters = new System.Windows.Forms.ListBox();
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 212);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(44, 23);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(62, 212);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(44, 23);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(112, 212);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(44, 23);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(212, 212);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(44, 23);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(-5, 241);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(44, 23);
            this.btnF.TabIndex = 4;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(162, 212);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(44, 23);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(45, 241);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(44, 23);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(95, 241);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(44, 23);
            this.btnH.TabIndex = 7;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(145, 241);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(44, 23);
            this.btnI.TabIndex = 8;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(195, 241);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(44, 23);
            this.btnJ.TabIndex = 9;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(245, 241);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(44, 23);
            this.btnK.TabIndex = 10;
            this.btnK.Text = "k";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(-5, 270);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(44, 23);
            this.btnL.TabIndex = 11;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(45, 270);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(44, 23);
            this.btnM.TabIndex = 12;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(95, 270);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(44, 23);
            this.btnN.TabIndex = 13;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(145, 270);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(44, 23);
            this.btnO.TabIndex = 14;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(195, 270);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(44, 23);
            this.btnP.TabIndex = 15;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(245, 270);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(44, 23);
            this.btnQ.TabIndex = 16;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(145, 299);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(44, 23);
            this.btnU.TabIndex = 17;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(-5, 299);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(44, 23);
            this.btnR.TabIndex = 18;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(45, 299);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(44, 23);
            this.btnS.TabIndex = 19;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(95, 299);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(44, 23);
            this.btnT.TabIndex = 20;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(195, 299);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(44, 23);
            this.btnV.TabIndex = 21;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(245, 299);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(44, 23);
            this.btnW.TabIndex = 22;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(25, 328);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(44, 23);
            this.btnX.TabIndex = 23;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(95, 328);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(44, 23);
            this.btnY.TabIndex = 24;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(162, 328);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(44, 23);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.Guessed_Click);
            // 
            // GuessedLetters
            // 
            this.GuessedLetters.FormattingEnabled = true;
            this.GuessedLetters.Location = new System.Drawing.Point(334, 241);
            this.GuessedLetters.Name = "GuessedLetters";
            this.GuessedLetters.Size = new System.Drawing.Size(120, 95);
            this.GuessedLetters.TabIndex = 27;
            this.GuessedLetters.SelectedIndexChanged += new System.EventHandler(this.GuessedLetters_SelectedIndexChanged);
            // 
            // hangImage
            // 
            this.hangImage.Image = global::HangMan.Properties.Resources.hangman1;
            this.hangImage.Location = new System.Drawing.Point(25, 1);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(300, 131);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 28;
            this.hangImage.TabStop = false;
            this.hangImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(340, 119);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Word";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(192, 175);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(26, 13);
            this.lblHint.TabIndex = 31;
            this.lblHint.Text = "Hint";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 431);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.hangImage);
            this.Controls.Add(this.GuessedLetters);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "Hang Man";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion     //gener

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.ListBox GuessedLetters;
        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHint;
    }
}

