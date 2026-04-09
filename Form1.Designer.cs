namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAppName = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.rdoBuger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdoChickenBuger = new System.Windows.Forms.RadioButton();
            this.rdoBulgogiBuger = new System.Windows.Forms.RadioButton();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.chkPotato = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.Font = new System.Drawing.Font("굴림", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAppName.ForeColor = System.Drawing.Color.Blue;
            this.lbAppName.Location = new System.Drawing.Point(13, 22);
            this.lbAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(510, 56);
            this.lbAppName.TabIndex = 0;
            this.lbAppName.Text = "버거 주문 키오스크";
            this.lbAppName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Lime;
            this.btnOrder.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(626, 440);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(136, 47);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(782, 440);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 47);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.Blue;
            this.lbTotalAmount.Location = new System.Drawing.Point(8, 335);
            this.lbTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(356, 72);
            this.lbTotalAmount.TabIndex = 3;
            this.lbTotalAmount.Text = "총금액: 0원";
            this.lbTotalAmount.Click += new System.EventHandler(this.lbTotalAmount_Click);
            // 
            // rdoBuger
            // 
            this.rdoBuger.AutoSize = true;
            this.rdoBuger.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoBuger.ForeColor = System.Drawing.Color.Black;
            this.rdoBuger.Location = new System.Drawing.Point(0, 64);
            this.rdoBuger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoBuger.Name = "rdoBuger";
            this.rdoBuger.Size = new System.Drawing.Size(103, 28);
            this.rdoBuger.TabIndex = 4;
            this.rdoBuger.TabStop = true;
            this.rdoBuger.Text = "햄버거";
            this.rdoBuger.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.rdoBuger);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rdoChickenBuger);
            this.groupBox1.Controls.Add(this.rdoBulgogiBuger);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(330, 369);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴 선택";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BurgerKiosk.Properties.Resources.햄버거;
            this.pictureBox2.Location = new System.Drawing.Point(154, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BurgerKiosk.Properties.Resources.치킨버거;
            this.pictureBox3.Location = new System.Drawing.Point(154, 261);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BurgerKiosk.Properties.Resources.불고기버거;
            this.pictureBox1.Location = new System.Drawing.Point(154, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rdoChickenBuger
            // 
            this.rdoChickenBuger.AutoSize = true;
            this.rdoChickenBuger.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoChickenBuger.ForeColor = System.Drawing.Color.Black;
            this.rdoChickenBuger.Location = new System.Drawing.Point(6, 293);
            this.rdoChickenBuger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoChickenBuger.Name = "rdoChickenBuger";
            this.rdoChickenBuger.Size = new System.Drawing.Size(128, 28);
            this.rdoChickenBuger.TabIndex = 9;
            this.rdoChickenBuger.TabStop = true;
            this.rdoChickenBuger.Text = "치킨버거";
            this.rdoChickenBuger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBuger
            // 
            this.rdoBulgogiBuger.AutoSize = true;
            this.rdoBulgogiBuger.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoBulgogiBuger.ForeColor = System.Drawing.Color.Black;
            this.rdoBulgogiBuger.Location = new System.Drawing.Point(6, 174);
            this.rdoBulgogiBuger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoBulgogiBuger.Name = "rdoBulgogiBuger";
            this.rdoBulgogiBuger.Size = new System.Drawing.Size(153, 28);
            this.rdoBulgogiBuger.TabIndex = 8;
            this.rdoBulgogiBuger.TabStop = true;
            this.rdoBulgogiBuger.Text = "불고기버거";
            this.rdoBulgogiBuger.UseVisualStyleBackColor = true;
            // 
            // lbOrders
            // 
            this.lbOrders.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 27;
            this.lbOrders.Location = new System.Drawing.Point(4, 31);
            this.lbOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(400, 301);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chkPotato
            // 
            this.chkPotato.AutoSize = true;
            this.chkPotato.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkPotato.ForeColor = System.Drawing.Color.Black;
            this.chkPotato.Location = new System.Drawing.Point(15, 46);
            this.chkPotato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPotato.Name = "chkPotato";
            this.chkPotato.Size = new System.Drawing.Size(129, 28);
            this.chkPotato.TabIndex = 7;
            this.chkPotato.Text = "감자튀김";
            this.chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCola.ForeColor = System.Drawing.Color.Black;
            this.chkCola.Location = new System.Drawing.Point(15, 103);
            this.chkCola.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(79, 28);
            this.chkCola.TabIndex = 12;
            this.chkCola.Text = "콜라";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCheese.ForeColor = System.Drawing.Color.Black;
            this.chkCheese.Location = new System.Drawing.Point(15, 160);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(154, 28);
            this.chkCheese.TabIndex = 13;
            this.chkCheese.Text = "치즈　추가";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkSauce.ForeColor = System.Drawing.Color.Black;
            this.chkSauce.Location = new System.Drawing.Point(15, 214);
            this.chkSauce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(154, 28);
            this.chkSauce.TabIndex = 14;
            this.chkSauce.Text = "소스　추가";
            this.chkSauce.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPotato);
            this.groupBox2.Controls.Add(this.chkSauce);
            this.groupBox2.Controls.Add(this.chkCola);
            this.groupBox2.Controls.Add(this.chkCheese);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(335, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(192, 260);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "추가 옵션";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbOrders);
            this.groupBox3.Controls.Add(this.lbTotalAmount);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(531, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(404, 410);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주문 내역";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbAppName);
            this.Font = new System.Drawing.Font("바탕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Buger Kiosk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.RadioButton rdoBuger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.CheckBox chkPotato;
        private System.Windows.Forms.RadioButton rdoBulgogiBuger;
        private System.Windows.Forms.RadioButton rdoChickenBuger;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

