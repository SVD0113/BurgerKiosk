using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string selectedMenu = "";
            int currentOrderPrice = 0;

            // 1-1. 버거(라디오버튼) 선택 확인 및 가격 합산
            if (rdoBuger.Checked)
            {
                selectedMenu = "햄버거";
                currentOrderPrice += 5000;
            }
            else if (rdoBulgogiBuger.Checked)
            {
                selectedMenu = "불고기버거";
                currentOrderPrice += 4000;
            }
            else if (rdoChickenBuger.Checked)
            {
                selectedMenu = "치킨버거";
                currentOrderPrice += 3000;
            }
            else
            {
                // 아무 버거도 선택하지 않은 경우 방어 로직
                lbTotalAmount.ForeColor = System.Drawing.Color.Red; // 글씨를 빨간색으로 눈에 띄게 변경
                lbTotalAmount.Text = "※ 버거 메뉴를 1개 \n이상 선택해주세요!";
                return;
            }

            // 1-2. 옵션(체크박스) 선택 확인 및 가격 합산
            lbOrders.Items.Add($"🍔 {selectedMenu}");

            // 1-3. 옵션(체크박스) 하나씩 확인하면서, 체크된 건 바로바로 다음 줄로 출력!
            if (chkPotato.Checked)
            {
                lbOrders.Items.Add("   ㄴ 감자튀김");
                currentOrderPrice += 3500;
            }
            if (chkCola.Checked)
            {
                lbOrders.Items.Add("   ㄴ 콜라");
                currentOrderPrice += 2500;
            }
            if (chkCheese.Checked)
            {
                lbOrders.Items.Add("   ㄴ 치즈추가");
                currentOrderPrice += 1500;
            }
            if (chkSauce.Checked)
            {
                lbOrders.Items.Add("   ㄴ 소스추가");
                currentOrderPrice += 500;
            }

            // 1-4. 마지막으로 개별 금액 찍어주고 마무리 구분선 추가
            lbOrders.Items.Add($"   금액: {currentOrderPrice}원");
            lbOrders.Items.Add("--------------------------------");

            // 전체 누적 총 금액 업데이트
            totalAmount += currentOrderPrice;
            lbTotalAmount.Text = $"총금액: {totalAmount}원";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // 라디오버튼 체크 해제
            rdoBuger.Checked = false;
            rdoBulgogiBuger.Checked = false;
            rdoChickenBuger.Checked = false;

            // 체크박스 체크 해제
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 리스트박스 및 총 금액 데이터 초기화
            lbOrders.Items.Clear();
            totalAmount = 0;
            lbTotalAmount.Text = "총금액: 0원";
        }
    }
}
