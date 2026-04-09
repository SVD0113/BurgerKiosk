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

        // ==========================================================
        // ⭐ [핵심 새로 추가] 화면을 실시간으로 새로고침해주는 전용 함수
        // ==========================================================
        private void UpdateCart()
        {
            // 1. 계산을 다시 하기 위해 기존 영수증과 금액을 싹 비웁니다.
            lbOrders.Items.Clear();
            totalAmount = 0;

            // 2. 버거(라디오버튼) 체크 상태 확인 및 리스트 추가
            if (rdoBuger.Checked)
            {
                lbOrders.Items.Add("햄버거 5,000원");
                totalAmount += 5000;
            }
            else if (rdoBulgogiBuger.Checked)
            {
                lbOrders.Items.Add("불고기버거 4,000원");
                totalAmount += 4000;
            }
            else if (rdoChickenBuger.Checked)
            {
                lbOrders.Items.Add("치킨버거 3,000원");
                totalAmount += 3000;
            }

            // 3. 옵션(체크박스) 체크 상태 확인 및 리스트 추가
            if (chkPotato.Checked)
            {
                lbOrders.Items.Add("감자튀김 3,500원");
                totalAmount += 3500;
            }
            if (chkCola.Checked)
            {
                lbOrders.Items.Add("콜라 2,500원");
                totalAmount += 2500;
            }
            if (chkCheese.Checked)
            {
                lbOrders.Items.Add("치즈추가 1,500원");
                totalAmount += 1500;
            }
            if (chkSauce.Checked)
            {
                lbOrders.Items.Add("소스추가 500원");
                totalAmount += 500;
            }

            // 4. 총 금액 라벨 업데이트 (글씨색 검정색으로 복구 & 콤마 추가)
            lbTotalAmount.ForeColor = System.Drawing.Color.Black;
            lbTotalAmount.Text = $"총 금액 : {totalAmount:#,##0}원";
        }

        // ==========================================================
        // [이벤트 연결] 체크 상태가 변할 때마다 UpdateCart() 실행!
        // ==========================================================
        private void rdoBuger_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }
        private void rdoBulgogiBuger_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }
        private void rdoChickenBuger_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }

        private void chkPotato_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }
        private void chkCola_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }
        private void chkCheese_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }
        private void chkSauce_CheckedChanged(object sender, EventArgs e) { UpdateCart(); }


        // ==========================================================
        // 주문하기 버튼 (이제 실시간 계산되므로 누르면 결제 완료만 띄움)
        // ==========================================================
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (totalAmount == 0)
            {
                lbTotalAmount.ForeColor = System.Drawing.Color.Red;
                lbTotalAmount.Text = "※ 메뉴를 1개 이상 \n선택해주세요!";
            }
            else
            {
                MessageBox.Show($"총 {totalAmount:#,##0}원 결제가 완료되었습니다!", "주문 완료");
                btnClear_Click(null, null); // 결제 완료 후 깔끔하게 자동 초기화
            }
        }

        // ==========================================================
        // 초기화 버튼
        // ==========================================================
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

            // 모든 체크를 풀고 새로고침!
            UpdateCart();

            // 혹시 남았을 에러 메시지 초기화
            lbTotalAmount.ForeColor = System.Drawing.Color.Black;
            lbTotalAmount.Text = "총 금액 : 0원";
        }

        // 사용하지 않는 빈 이벤트들 (삭제해도 무방하지만 일단 둡니다)
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void lbTotalAmount_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}