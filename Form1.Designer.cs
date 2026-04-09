namespace BurgerKiosk
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
            lblAppName = new Label();
            lblTotalCost = new Label();
            btnOrder = new Button();
            btnInit = new Button();
            lstOrder = new ListBox();
            rdoHamburger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenu = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamburger = new PictureBox();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFrenchFries = new CheckBox();
            grpOrder = new GroupBox();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Bold);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(115, 64);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(890, 128);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(38, 399);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(275, 59);
            lblTotalCost.TabIndex = 2;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(128, 255, 128);
            btnOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            btnOrder.Location = new Point(1309, 740);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(212, 88);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.FromArgb(255, 128, 128);
            btnInit.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold);
            btnInit.Location = new Point(1565, 740);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(198, 88);
            btnInit.TabIndex = 4;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(28, 54);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(378, 328);
            lstOrder.TabIndex = 5;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.ForeColor = Color.Black;
            rdoHamburger.Location = new Point(27, 104);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(174, 58);
            rdoHamburger.TabIndex = 6;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "햄버거";
            rdoHamburger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(27, 284);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(254, 58);
            rdoBulgogiBurger.TabIndex = 7;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(27, 464);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(214, 58);
            rdoChickenBurger.TabIndex = 8;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamburger);
            grpMenu.Controls.Add(rdoHamburger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Font = new Font("맑은 고딕", 15F);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(115, 246);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(564, 582);
            grpMenu.TabIndex = 9;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(330, 412);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(210, 150);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 12;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(330, 233);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(210, 150);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 11;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamburger
            // 
            picHamburger.Image = (Image)resources.GetObject("picHamburger.Image");
            picHamburger.Location = new Point(330, 54);
            picHamburger.Name = "picHamburger";
            picHamburger.Size = new Size(210, 150);
            picHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamburger.TabIndex = 10;
            picHamburger.TabStop = false;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkFrenchFries);
            grpOption.Font = new Font("맑은 고딕", 15F);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(789, 246);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(400, 426);
            grpOption.TabIndex = 9;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(21, 357);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(229, 58);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(21, 258);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(229, 58);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(21, 159);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(135, 58);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkFrenchFries
            // 
            chkFrenchFries.AutoSize = true;
            chkFrenchFries.ForeColor = Color.Black;
            chkFrenchFries.Location = new Point(21, 60);
            chkFrenchFries.Name = "chkFrenchFries";
            chkFrenchFries.Size = new Size(215, 58);
            chkFrenchFries.TabIndex = 0;
            chkFrenchFries.Text = "감자튀김";
            chkFrenchFries.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Font = new Font("맑은 고딕", 15F);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(1309, 246);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(454, 478);
            grpOrder.TabIndex = 9;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1816, 858);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamburger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnInit;
        private ListBox lstOrder;
        private RadioButton rdoHamburger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFrenchFries;
        private GroupBox grpOrder;
        private PictureBox picHamburger;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
    }
}
