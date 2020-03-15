using System.Windows.Forms;

namespace DiceGame
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.player4NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player3NameLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.dicesPanel = new System.Windows.Forms.Panel();
            this.fifthDicePictureBox = new System.Windows.Forms.PictureBox();
            this.fourthDicePictureBox = new System.Windows.Forms.PictureBox();
            this.thirdDicePictureBox = new System.Windows.Forms.PictureBox();
            this.secondDicePictureBox = new System.Windows.Forms.PictureBox();
            this.firstDicePictureBox = new System.Windows.Forms.PictureBox();
            this.trustButton = new System.Windows.Forms.Button();
            this.noTrustButton = new System.Windows.Forms.Button();
            this.betPanel = new System.Windows.Forms.Panel();
            this.currentDiceValuePictureBox = new System.Windows.Forms.PictureBox();
            this.currentCountOfDicesLabel = new System.Windows.Forms.Label();
            this.makeBetButton = new System.Windows.Forms.Button();
            this.decreaseDiceValueButton = new System.Windows.Forms.Button();
            this.decreaseDiceCountButton = new System.Windows.Forms.Button();
            this.increaseDiceValueButton = new System.Windows.Forms.Button();
            this.increaseDiceCountButton = new System.Windows.Forms.Button();
            this.TrustHandPictureBox = new System.Windows.Forms.PictureBox();
            this.notTrustHandPictureBox = new System.Windows.Forms.PictureBox();
            this.trustPanel = new System.Windows.Forms.Panel();
            this.readyButton = new System.Windows.Forms.Button();
            this.dicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fifthDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDicePictureBox)).BeginInit();
            this.betPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDiceValuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notTrustHandPictureBox)).BeginInit();
            this.trustPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player4NameLabel
            // 
            this.player4NameLabel.AutoSize = true;
            this.player4NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player4NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4NameLabel.Location = new System.Drawing.Point(962, 95);
            this.player4NameLabel.Name = "player4NameLabel";
            this.player4NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player4NameLabel.TabIndex = 0;
            this.player4NameLabel.Text = "player4";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.Location = new System.Drawing.Point(12, 95);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player2NameLabel.TabIndex = 1;
            this.player2NameLabel.Text = "player2";
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.AutoSize = true;
            this.player3NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player3NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3NameLabel.Location = new System.Drawing.Point(749, 9);
            this.player3NameLabel.Name = "player3NameLabel";
            this.player3NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player3NameLabel.TabIndex = 2;
            this.player3NameLabel.Text = "player3";
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLabel.Location = new System.Drawing.Point(263, 597);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player1NameLabel.TabIndex = 3;
            this.player1NameLabel.Text = "player1";
            // 
            // dicesPanel
            // 
            this.dicesPanel.BackColor = System.Drawing.Color.Transparent;
            this.dicesPanel.Controls.Add(this.fifthDicePictureBox);
            this.dicesPanel.Controls.Add(this.fourthDicePictureBox);
            this.dicesPanel.Controls.Add(this.thirdDicePictureBox);
            this.dicesPanel.Controls.Add(this.secondDicePictureBox);
            this.dicesPanel.Controls.Add(this.firstDicePictureBox);
            this.dicesPanel.Location = new System.Drawing.Point(382, 421);
            this.dicesPanel.Name = "dicesPanel";
            this.dicesPanel.Size = new System.Drawing.Size(300, 200);
            this.dicesPanel.TabIndex = 4;
            // 
            // fifthDicePictureBox
            // 
            this.fifthDicePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.fifthDicePictureBox.Location = new System.Drawing.Point(167, 125);
            this.fifthDicePictureBox.Name = "fifthDicePictureBox";
            this.fifthDicePictureBox.Size = new System.Drawing.Size(75, 75);
            this.fifthDicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fifthDicePictureBox.TabIndex = 12;
            this.fifthDicePictureBox.TabStop = false;
            // 
            // fourthDicePictureBox
            // 
            this.fourthDicePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.fourthDicePictureBox.Location = new System.Drawing.Point(58, 125);
            this.fourthDicePictureBox.Name = "fourthDicePictureBox";
            this.fourthDicePictureBox.Size = new System.Drawing.Size(75, 75);
            this.fourthDicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourthDicePictureBox.TabIndex = 10;
            this.fourthDicePictureBox.TabStop = false;
            // 
            // thirdDicePictureBox
            // 
            this.thirdDicePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.thirdDicePictureBox.Location = new System.Drawing.Point(225, 0);
            this.thirdDicePictureBox.Name = "thirdDicePictureBox";
            this.thirdDicePictureBox.Size = new System.Drawing.Size(75, 75);
            this.thirdDicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdDicePictureBox.TabIndex = 9;
            this.thirdDicePictureBox.TabStop = false;
            // 
            // secondDicePictureBox
            // 
            this.secondDicePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.secondDicePictureBox.Location = new System.Drawing.Point(113, 0);
            this.secondDicePictureBox.Name = "secondDicePictureBox";
            this.secondDicePictureBox.Size = new System.Drawing.Size(75, 75);
            this.secondDicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondDicePictureBox.TabIndex = 8;
            this.secondDicePictureBox.TabStop = false;
            // 
            // firstDicePictureBox
            // 
            this.firstDicePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.firstDicePictureBox.InitialImage = null;
            this.firstDicePictureBox.Location = new System.Drawing.Point(0, 0);
            this.firstDicePictureBox.Name = "firstDicePictureBox";
            this.firstDicePictureBox.Size = new System.Drawing.Size(75, 75);
            this.firstDicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstDicePictureBox.TabIndex = 7;
            this.firstDicePictureBox.TabStop = false;
            // 
            // trustButton
            // 
            this.trustButton.BackColor = System.Drawing.Color.Lime;
            this.trustButton.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trustButton.Location = new System.Drawing.Point(189, 3);
            this.trustButton.Name = "trustButton";
            this.trustButton.Size = new System.Drawing.Size(104, 47);
            this.trustButton.TabIndex = 5;
            this.trustButton.Text = "Верю";
            this.trustButton.UseVisualStyleBackColor = false;
            this.trustButton.Click += new System.EventHandler(this.TrustButton_Click);
            // 
            // noTrustButton
            // 
            this.noTrustButton.BackColor = System.Drawing.Color.Red;
            this.noTrustButton.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTrustButton.Location = new System.Drawing.Point(9, 3);
            this.noTrustButton.Name = "noTrustButton";
            this.noTrustButton.Size = new System.Drawing.Size(137, 47);
            this.noTrustButton.TabIndex = 6;
            this.noTrustButton.Text = "Не верю";
            this.noTrustButton.UseVisualStyleBackColor = false;
            this.noTrustButton.Click += new System.EventHandler(this.NoTrustButton_Click);
            // 
            // betPanel
            // 
            this.betPanel.BackColor = System.Drawing.Color.Transparent;
            this.betPanel.Controls.Add(this.currentDiceValuePictureBox);
            this.betPanel.Controls.Add(this.currentCountOfDicesLabel);
            this.betPanel.Controls.Add(this.makeBetButton);
            this.betPanel.Controls.Add(this.decreaseDiceValueButton);
            this.betPanel.Controls.Add(this.decreaseDiceCountButton);
            this.betPanel.Controls.Add(this.increaseDiceValueButton);
            this.betPanel.Controls.Add(this.increaseDiceCountButton);
            this.betPanel.Location = new System.Drawing.Point(404, 301);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(259, 114);
            this.betPanel.TabIndex = 7;
            // 
            // currentDiceValuePictureBox
            // 
            this.currentDiceValuePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.currentDiceValuePictureBox.Location = new System.Drawing.Point(108, 29);
            this.currentDiceValuePictureBox.Name = "currentDiceValuePictureBox";
            this.currentDiceValuePictureBox.Size = new System.Drawing.Size(55, 55);
            this.currentDiceValuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentDiceValuePictureBox.TabIndex = 6;
            this.currentDiceValuePictureBox.TabStop = false;
            // 
            // currentCountOfDicesLabel
            // 
            this.currentCountOfDicesLabel.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCountOfDicesLabel.Location = new System.Drawing.Point(3, 29);
            this.currentCountOfDicesLabel.Name = "currentCountOfDicesLabel";
            this.currentCountOfDicesLabel.Size = new System.Drawing.Size(84, 56);
            this.currentCountOfDicesLabel.TabIndex = 5;
            this.currentCountOfDicesLabel.Text = "1";
            this.currentCountOfDicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeBetButton
            // 
            this.makeBetButton.Location = new System.Drawing.Point(174, 45);
            this.makeBetButton.Name = "makeBetButton";
            this.makeBetButton.Size = new System.Drawing.Size(82, 23);
            this.makeBetButton.TabIndex = 4;
            this.makeBetButton.Text = "Ставка";
            this.makeBetButton.UseVisualStyleBackColor = true;
            this.makeBetButton.Click += new System.EventHandler(this.MakeBetButton_Click);
            // 
            // decreaseDiceValueButton
            // 
            this.decreaseDiceValueButton.Location = new System.Drawing.Point(108, 88);
            this.decreaseDiceValueButton.Name = "decreaseDiceValueButton";
            this.decreaseDiceValueButton.Size = new System.Drawing.Size(58, 23);
            this.decreaseDiceValueButton.TabIndex = 3;
            this.decreaseDiceValueButton.Text = "вниз";
            this.decreaseDiceValueButton.UseVisualStyleBackColor = true;
            this.decreaseDiceValueButton.Click += new System.EventHandler(this.DecreaseDiceValueButton_Click);
            // 
            // decreaseDiceCountButton
            // 
            this.decreaseDiceCountButton.Location = new System.Drawing.Point(16, 88);
            this.decreaseDiceCountButton.Name = "decreaseDiceCountButton";
            this.decreaseDiceCountButton.Size = new System.Drawing.Size(58, 23);
            this.decreaseDiceCountButton.TabIndex = 2;
            this.decreaseDiceCountButton.Text = "вниз";
            this.decreaseDiceCountButton.UseVisualStyleBackColor = true;
            this.decreaseDiceCountButton.Click += new System.EventHandler(this.DecreaseDiceCountButton_Click);
            // 
            // increaseDiceValueButton
            // 
            this.increaseDiceValueButton.Location = new System.Drawing.Point(108, 3);
            this.increaseDiceValueButton.Name = "increaseDiceValueButton";
            this.increaseDiceValueButton.Size = new System.Drawing.Size(58, 23);
            this.increaseDiceValueButton.TabIndex = 1;
            this.increaseDiceValueButton.Text = "вверх";
            this.increaseDiceValueButton.UseVisualStyleBackColor = true;
            this.increaseDiceValueButton.Click += new System.EventHandler(this.IncreaseDiceValueButton_Click);
            // 
            // increaseDiceCountButton
            // 
            this.increaseDiceCountButton.Location = new System.Drawing.Point(16, 3);
            this.increaseDiceCountButton.Name = "increaseDiceCountButton";
            this.increaseDiceCountButton.Size = new System.Drawing.Size(58, 23);
            this.increaseDiceCountButton.TabIndex = 0;
            this.increaseDiceCountButton.Text = "вверх";
            this.increaseDiceCountButton.UseVisualStyleBackColor = true;
            this.increaseDiceCountButton.Click += new System.EventHandler(this.IncreaseDiceCountButton_Click);
            // 
            // TrustHandPictureBox
            // 
            this.TrustHandPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TrustHandPictureBox.Image = global::DiceGame.Resource1.TrustHand_removebg_preview;
            this.TrustHandPictureBox.Location = new System.Drawing.Point(192, 74);
            this.TrustHandPictureBox.Name = "TrustHandPictureBox";
            this.TrustHandPictureBox.Size = new System.Drawing.Size(101, 176);
            this.TrustHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrustHandPictureBox.TabIndex = 8;
            this.TrustHandPictureBox.TabStop = false;
            // 
            // notTrustHandPictureBox
            // 
            this.notTrustHandPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.notTrustHandPictureBox.Image = global::DiceGame.Resource1.notTrustHand_removebg_preview;
            this.notTrustHandPictureBox.Location = new System.Drawing.Point(9, 74);
            this.notTrustHandPictureBox.Name = "notTrustHandPictureBox";
            this.notTrustHandPictureBox.Size = new System.Drawing.Size(128, 176);
            this.notTrustHandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notTrustHandPictureBox.TabIndex = 9;
            this.notTrustHandPictureBox.TabStop = false;
            // 
            // trustPanel
            // 
            this.trustPanel.BackColor = System.Drawing.Color.Transparent;
            this.trustPanel.Controls.Add(this.noTrustButton);
            this.trustPanel.Controls.Add(this.TrustHandPictureBox);
            this.trustPanel.Controls.Add(this.notTrustHandPictureBox);
            this.trustPanel.Controls.Add(this.trustButton);
            this.trustPanel.Location = new System.Drawing.Point(712, 399);
            this.trustPanel.Name = "trustPanel";
            this.trustPanel.Size = new System.Drawing.Size(300, 248);
            this.trustPanel.TabIndex = 10;
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.Lime;
            this.readyButton.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.Location = new System.Drawing.Point(486, 257);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(109, 38);
            this.readyButton.TabIndex = 11;
            this.readyButton.Text = "Готов!";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiceGame.Resource1.wood;
            this.ClientSize = new System.Drawing.Size(1050, 639);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.trustPanel);
            this.Controls.Add(this.betPanel);
            this.Controls.Add(this.dicesPanel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player4NameLabel);
            this.Name = "ClientForm";
            this.Text = "Dice game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.dicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fifthDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDicePictureBox)).EndInit();
            this.betPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentDiceValuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notTrustHandPictureBox)).EndInit();
            this.trustPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player4NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player3NameLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Panel dicesPanel;
        private System.Windows.Forms.Button trustButton;
        private System.Windows.Forms.Button noTrustButton;
        private PictureBox fifthDicePictureBox;
        private PictureBox fourthDicePictureBox;
        private PictureBox thirdDicePictureBox;
        private PictureBox secondDicePictureBox;
        private PictureBox firstDicePictureBox;
        private Panel betPanel;
        private PictureBox currentDiceValuePictureBox;
        private Label currentCountOfDicesLabel;
        private Button makeBetButton;
        private Button decreaseDiceValueButton;
        private Button decreaseDiceCountButton;
        private Button increaseDiceValueButton;
        private Button increaseDiceCountButton;
        private PictureBox TrustHandPictureBox;
        private PictureBox notTrustHandPictureBox;
        private Panel trustPanel;
        private Button readyButton;
    }
}

