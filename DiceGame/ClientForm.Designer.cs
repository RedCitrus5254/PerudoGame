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
            this.firstDicePictureBox = new System.Windows.Forms.PictureBox();
            this.secondDicePictureBox = new System.Windows.Forms.PictureBox();
            this.thirdDicePictureBox = new System.Windows.Forms.PictureBox();
            this.fourthDicePictureBox = new System.Windows.Forms.PictureBox();
            this.fifthDicePictureBox = new System.Windows.Forms.PictureBox();
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
            this.topPlayerPanel = new System.Windows.Forms.Panel();
            this.topDice1 = new System.Windows.Forms.PictureBox();
            this.topDice2 = new System.Windows.Forms.PictureBox();
            this.topDice3 = new System.Windows.Forms.PictureBox();
            this.topDice4 = new System.Windows.Forms.PictureBox();
            this.topDice5 = new System.Windows.Forms.PictureBox();
            this.rightPlayerPanel = new System.Windows.Forms.Panel();
            this.rightDice1 = new System.Windows.Forms.PictureBox();
            this.rightDice2 = new System.Windows.Forms.PictureBox();
            this.rightDice3 = new System.Windows.Forms.PictureBox();
            this.rightDice4 = new System.Windows.Forms.PictureBox();
            this.rightDice5 = new System.Windows.Forms.PictureBox();
            this.leftPlayerPanel = new System.Windows.Forms.Panel();
            this.leftDice1 = new System.Windows.Forms.PictureBox();
            this.leftDice2 = new System.Windows.Forms.PictureBox();
            this.leftDice3 = new System.Windows.Forms.PictureBox();
            this.leftDice4 = new System.Windows.Forms.PictureBox();
            this.leftDice5 = new System.Windows.Forms.PictureBox();
            this.NotificationBetPanel = new System.Windows.Forms.Panel();
            this.CountOfDicesLabel = new System.Windows.Forms.Label();
            this.diceValuePictureBox = new System.Windows.Forms.PictureBox();
            this.trustNotificationLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.correctnessLabel = new System.Windows.Forms.Label();
            this.dicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthDicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthDicePictureBox)).BeginInit();
            this.betPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDiceValuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notTrustHandPictureBox)).BeginInit();
            this.trustPanel.SuspendLayout();
            this.topPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice5)).BeginInit();
            this.rightPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice5)).BeginInit();
            this.leftPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice5)).BeginInit();
            this.NotificationBetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceValuePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player4NameLabel
            // 
            this.player4NameLabel.AutoSize = true;
            this.player4NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player4NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4NameLabel.Location = new System.Drawing.Point(947, 54);
            this.player4NameLabel.Name = "player4NameLabel";
            this.player4NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player4NameLabel.TabIndex = 0;
            this.player4NameLabel.Text = "player4";
            this.player4NameLabel.Visible = false;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.Location = new System.Drawing.Point(11, 58);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(76, 24);
            this.player2NameLabel.TabIndex = 1;
            this.player2NameLabel.Text = "player2";
            this.player2NameLabel.Visible = false;
            // 
            // player3NameLabel
            // 
            this.player3NameLabel.AutoSize = true;
            this.player3NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.player3NameLabel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3NameLabel.Location = new System.Drawing.Point(688, 9);
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
            this.dicesPanel.Controls.Add(this.firstDicePictureBox);
            this.dicesPanel.Controls.Add(this.secondDicePictureBox);
            this.dicesPanel.Controls.Add(this.thirdDicePictureBox);
            this.dicesPanel.Controls.Add(this.fourthDicePictureBox);
            this.dicesPanel.Controls.Add(this.fifthDicePictureBox);
            this.dicesPanel.Location = new System.Drawing.Point(382, 421);
            this.dicesPanel.Name = "dicesPanel";
            this.dicesPanel.Size = new System.Drawing.Size(300, 200);
            this.dicesPanel.TabIndex = 4;
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
            this.betPanel.Location = new System.Drawing.Point(404, 304);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(259, 111);
            this.betPanel.TabIndex = 7;
            this.betPanel.Visible = false;
            // 
            // currentDiceValuePictureBox
            // 
            this.currentDiceValuePictureBox.Image = global::DiceGame.Resource1._2_dots_removebg_preview;
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
            this.trustPanel.Visible = false;
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.Lime;
            this.readyButton.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.Location = new System.Drawing.Point(477, 256);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(109, 38);
            this.readyButton.TabIndex = 11;
            this.readyButton.Text = "Готов!";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // topPlayerPanel
            // 
            this.topPlayerPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPlayerPanel.Controls.Add(this.topDice1);
            this.topPlayerPanel.Controls.Add(this.topDice2);
            this.topPlayerPanel.Controls.Add(this.topDice3);
            this.topPlayerPanel.Controls.Add(this.topDice4);
            this.topPlayerPanel.Controls.Add(this.topDice5);
            this.topPlayerPanel.Location = new System.Drawing.Point(382, 0);
            this.topPlayerPanel.Name = "topPlayerPanel";
            this.topPlayerPanel.Size = new System.Drawing.Size(300, 193);
            this.topPlayerPanel.TabIndex = 12;
            // 
            // topDice1
            // 
            this.topDice1.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.topDice1.InitialImage = null;
            this.topDice1.Location = new System.Drawing.Point(0, 115);
            this.topDice1.Name = "topDice1";
            this.topDice1.Size = new System.Drawing.Size(75, 75);
            this.topDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topDice1.TabIndex = 18;
            this.topDice1.TabStop = false;
            // 
            // topDice2
            // 
            this.topDice2.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.topDice2.InitialImage = null;
            this.topDice2.Location = new System.Drawing.Point(58, 0);
            this.topDice2.Name = "topDice2";
            this.topDice2.Size = new System.Drawing.Size(75, 75);
            this.topDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topDice2.TabIndex = 21;
            this.topDice2.TabStop = false;
            // 
            // topDice3
            // 
            this.topDice3.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.topDice3.InitialImage = null;
            this.topDice3.Location = new System.Drawing.Point(113, 118);
            this.topDice3.Name = "topDice3";
            this.topDice3.Size = new System.Drawing.Size(75, 75);
            this.topDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topDice3.TabIndex = 19;
            this.topDice3.TabStop = false;
            // 
            // topDice4
            // 
            this.topDice4.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.topDice4.InitialImage = null;
            this.topDice4.Location = new System.Drawing.Point(167, 3);
            this.topDice4.Name = "topDice4";
            this.topDice4.Size = new System.Drawing.Size(75, 75);
            this.topDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topDice4.TabIndex = 22;
            this.topDice4.TabStop = false;
            // 
            // topDice5
            // 
            this.topDice5.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.topDice5.InitialImage = null;
            this.topDice5.Location = new System.Drawing.Point(225, 115);
            this.topDice5.Name = "topDice5";
            this.topDice5.Size = new System.Drawing.Size(75, 75);
            this.topDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topDice5.TabIndex = 20;
            this.topDice5.TabStop = false;
            // 
            // rightPlayerPanel
            // 
            this.rightPlayerPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPlayerPanel.Controls.Add(this.rightDice1);
            this.rightPlayerPanel.Controls.Add(this.rightDice2);
            this.rightPlayerPanel.Controls.Add(this.rightDice3);
            this.rightPlayerPanel.Controls.Add(this.rightDice4);
            this.rightPlayerPanel.Controls.Add(this.rightDice5);
            this.rightPlayerPanel.Location = new System.Drawing.Point(825, 85);
            this.rightPlayerPanel.Name = "rightPlayerPanel";
            this.rightPlayerPanel.Size = new System.Drawing.Size(225, 272);
            this.rightPlayerPanel.TabIndex = 13;
            // 
            // rightDice1
            // 
            this.rightDice1.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.rightDice1.InitialImage = null;
            this.rightDice1.Location = new System.Drawing.Point(22, 3);
            this.rightDice1.Name = "rightDice1";
            this.rightDice1.Size = new System.Drawing.Size(75, 75);
            this.rightDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDice1.TabIndex = 24;
            this.rightDice1.TabStop = false;
            // 
            // rightDice2
            // 
            this.rightDice2.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.rightDice2.InitialImage = null;
            this.rightDice2.Location = new System.Drawing.Point(138, 3);
            this.rightDice2.Name = "rightDice2";
            this.rightDice2.Size = new System.Drawing.Size(75, 75);
            this.rightDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDice2.TabIndex = 23;
            this.rightDice2.TabStop = false;
            // 
            // rightDice3
            // 
            this.rightDice3.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.rightDice3.InitialImage = null;
            this.rightDice3.Location = new System.Drawing.Point(22, 96);
            this.rightDice3.Name = "rightDice3";
            this.rightDice3.Size = new System.Drawing.Size(75, 75);
            this.rightDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDice3.TabIndex = 26;
            this.rightDice3.TabStop = false;
            // 
            // rightDice4
            // 
            this.rightDice4.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.rightDice4.InitialImage = null;
            this.rightDice4.Location = new System.Drawing.Point(138, 96);
            this.rightDice4.Name = "rightDice4";
            this.rightDice4.Size = new System.Drawing.Size(75, 75);
            this.rightDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDice4.TabIndex = 25;
            this.rightDice4.TabStop = false;
            // 
            // rightDice5
            // 
            this.rightDice5.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.rightDice5.InitialImage = null;
            this.rightDice5.Location = new System.Drawing.Point(79, 189);
            this.rightDice5.Name = "rightDice5";
            this.rightDice5.Size = new System.Drawing.Size(75, 75);
            this.rightDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightDice5.TabIndex = 27;
            this.rightDice5.TabStop = false;
            // 
            // leftPlayerPanel
            // 
            this.leftPlayerPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPlayerPanel.Controls.Add(this.leftDice1);
            this.leftPlayerPanel.Controls.Add(this.leftDice2);
            this.leftPlayerPanel.Controls.Add(this.leftDice3);
            this.leftPlayerPanel.Controls.Add(this.leftDice4);
            this.leftPlayerPanel.Controls.Add(this.leftDice5);
            this.leftPlayerPanel.Location = new System.Drawing.Point(12, 85);
            this.leftPlayerPanel.Name = "leftPlayerPanel";
            this.leftPlayerPanel.Size = new System.Drawing.Size(220, 272);
            this.leftPlayerPanel.TabIndex = 14;
            // 
            // leftDice1
            // 
            this.leftDice1.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.leftDice1.InitialImage = null;
            this.leftDice1.Location = new System.Drawing.Point(3, 3);
            this.leftDice1.Name = "leftDice1";
            this.leftDice1.Size = new System.Drawing.Size(75, 75);
            this.leftDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDice1.TabIndex = 13;
            this.leftDice1.TabStop = false;
            // 
            // leftDice2
            // 
            this.leftDice2.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.leftDice2.InitialImage = null;
            this.leftDice2.Location = new System.Drawing.Point(110, 3);
            this.leftDice2.Name = "leftDice2";
            this.leftDice2.Size = new System.Drawing.Size(75, 75);
            this.leftDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDice2.TabIndex = 14;
            this.leftDice2.TabStop = false;
            // 
            // leftDice3
            // 
            this.leftDice3.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.leftDice3.InitialImage = null;
            this.leftDice3.Location = new System.Drawing.Point(3, 96);
            this.leftDice3.Name = "leftDice3";
            this.leftDice3.Size = new System.Drawing.Size(75, 75);
            this.leftDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDice3.TabIndex = 15;
            this.leftDice3.TabStop = false;
            // 
            // leftDice4
            // 
            this.leftDice4.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.leftDice4.InitialImage = null;
            this.leftDice4.Location = new System.Drawing.Point(110, 96);
            this.leftDice4.Name = "leftDice4";
            this.leftDice4.Size = new System.Drawing.Size(75, 75);
            this.leftDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDice4.TabIndex = 16;
            this.leftDice4.TabStop = false;
            // 
            // leftDice5
            // 
            this.leftDice5.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.leftDice5.InitialImage = null;
            this.leftDice5.Location = new System.Drawing.Point(53, 189);
            this.leftDice5.Name = "leftDice5";
            this.leftDice5.Size = new System.Drawing.Size(75, 75);
            this.leftDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftDice5.TabIndex = 17;
            this.leftDice5.TabStop = false;
            // 
            // NotificationBetPanel
            // 
            this.NotificationBetPanel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationBetPanel.Controls.Add(this.CountOfDicesLabel);
            this.NotificationBetPanel.Controls.Add(this.diceValuePictureBox);
            this.NotificationBetPanel.Location = new System.Drawing.Point(250, 9);
            this.NotificationBetPanel.Name = "NotificationBetPanel";
            this.NotificationBetPanel.Size = new System.Drawing.Size(103, 59);
            this.NotificationBetPanel.TabIndex = 15;
            this.NotificationBetPanel.Visible = false;
            // 
            // CountOfDicesLabel
            // 
            this.CountOfDicesLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountOfDicesLabel.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfDicesLabel.Location = new System.Drawing.Point(12, 0);
            this.CountOfDicesLabel.Name = "CountOfDicesLabel";
            this.CountOfDicesLabel.Size = new System.Drawing.Size(34, 56);
            this.CountOfDicesLabel.TabIndex = 7;
            this.CountOfDicesLabel.Text = "1";
            this.CountOfDicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceValuePictureBox
            // 
            this.diceValuePictureBox.Image = global::DiceGame.Resource1._1_dots_removebg_preview;
            this.diceValuePictureBox.InitialImage = null;
            this.diceValuePictureBox.Location = new System.Drawing.Point(52, 5);
            this.diceValuePictureBox.Name = "diceValuePictureBox";
            this.diceValuePictureBox.Size = new System.Drawing.Size(48, 51);
            this.diceValuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceValuePictureBox.TabIndex = 13;
            this.diceValuePictureBox.TabStop = false;
            // 
            // trustNotificationLabel
            // 
            this.trustNotificationLabel.AutoSize = true;
            this.trustNotificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.trustNotificationLabel.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trustNotificationLabel.Location = new System.Drawing.Point(266, 88);
            this.trustNotificationLabel.Name = "trustNotificationLabel";
            this.trustNotificationLabel.Size = new System.Drawing.Size(82, 31);
            this.trustNotificationLabel.TabIndex = 17;
            this.trustNotificationLabel.Text = "Верю";
            this.trustNotificationLabel.Visible = false;
            // 
            // logLabel
            // 
            this.logLabel.Location = new System.Drawing.Point(12, 402);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(220, 219);
            this.logLabel.TabIndex = 18;
            this.logLabel.Text = "label1";
            // 
            // correctnessLabel
            // 
            this.correctnessLabel.AutoSize = true;
            this.correctnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctnessLabel.Location = new System.Drawing.Point(401, 288);
            this.correctnessLabel.Name = "correctnessLabel";
            this.correctnessLabel.Size = new System.Drawing.Size(35, 13);
            this.correctnessLabel.TabIndex = 19;
            this.correctnessLabel.Text = "label1";
            this.correctnessLabel.Visible = false;
            this.correctnessLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiceGame.Resource1.wood;
            this.ClientSize = new System.Drawing.Size(1050, 631);
            this.Controls.Add(this.correctnessLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.trustNotificationLabel);
            this.Controls.Add(this.NotificationBetPanel);
            this.Controls.Add(this.leftPlayerPanel);
            this.Controls.Add(this.rightPlayerPanel);
            this.Controls.Add(this.topPlayerPanel);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.trustPanel);
            this.Controls.Add(this.player4NameLabel);
            this.Controls.Add(this.player3NameLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.betPanel);
            this.Controls.Add(this.dicesPanel);
            this.Controls.Add(this.player1NameLabel);
            this.Name = "ClientForm";
            this.Text = "Dice game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.dicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthDicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthDicePictureBox)).EndInit();
            this.betPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentDiceValuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notTrustHandPictureBox)).EndInit();
            this.trustPanel.ResumeLayout(false);
            this.topPlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topDice5)).EndInit();
            this.rightPlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDice5)).EndInit();
            this.leftPlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDice5)).EndInit();
            this.NotificationBetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diceValuePictureBox)).EndInit();
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
        private Panel topPlayerPanel;
        private Panel rightPlayerPanel;
        private Panel leftPlayerPanel;
        private PictureBox leftDice5;
        private PictureBox leftDice4;
        private PictureBox leftDice3;
        private PictureBox leftDice2;
        private PictureBox leftDice1;
        private PictureBox topDice4;
        private PictureBox topDice2;
        private PictureBox topDice5;
        private PictureBox topDice3;
        private PictureBox topDice1;
        private PictureBox rightDice5;
        private PictureBox rightDice3;
        private PictureBox rightDice4;
        private PictureBox rightDice1;
        private PictureBox rightDice2;
        private Panel NotificationBetPanel;
        private Label CountOfDicesLabel;
        private PictureBox diceValuePictureBox;
        private Label trustNotificationLabel;
        private Label logLabel;
        private Label correctnessLabel;
    }
}

