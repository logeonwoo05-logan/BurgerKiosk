namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 라디오버튼 자동 체크 해제 (스페이스바로만 선택되도록)
            rdoHamburger.AutoCheck = false;
            rdoBulgogiBurger.AutoCheck = false;
            rdoChickenBurger.AutoCheck = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // 처음 실행 시 어떤 컨트롤에도 포커스가 가지 않게 하여 '주문하기'에 시각적 선택이 남지 않도록 함
            this.ActiveControl = null;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Control activeControl = this.ActiveControl;

            // 처음 상태(포커스 없음)이거나 버튼에 포커스가 있는데 만지지 않은 상태에서 아래 방향키를 누르면 햄버거로 이동
            if (keyData == Keys.Down && (activeControl == null || activeControl == btnOrder || activeControl == btnInit))
            {
                rdoHamburger.Focus();
                return true;
            }

            // Tab으로 그룹 간 이동
            if (keyData == Keys.Tab)
            {
                if (activeControl == null)
                {
                    rdoHamburger.Focus();
                    return true;
                }
                else if (grpMenu.Contains(activeControl) || activeControl == grpMenu)
                {
                    chkFrenchFries.Focus();
                    return true;
                }
                else if (grpOption.Contains(activeControl) || activeControl == grpOption)
                {
                    lstOrder.Focus();
                    return true;
                }
                else if (grpOrder.Contains(activeControl) || activeControl == grpOrder || activeControl == lstOrder)
                {
                    btnOrder.Focus();
                    return true;
                }
                else if (activeControl == btnOrder || activeControl == btnInit)
                {
                    rdoHamburger.Focus();
                    return true;
                }
            }

            // Shift+Tab으로 그룹 간 역방향 이동
            if (keyData == (Keys.Tab | Keys.Shift))
            {
                if (activeControl == null || grpOption.Contains(activeControl) || activeControl == grpOption)
                {
                    rdoHamburger.Focus();
                    return true;
                }
                else if (grpOrder.Contains(activeControl) || activeControl == grpOrder || activeControl == lstOrder)
                {
                    chkFrenchFries.Focus();
                    return true;
                }
                else if (activeControl == btnOrder || activeControl == btnInit)
                {
                    lstOrder.Focus();
                    return true;
                }
                else if (grpMenu.Contains(activeControl) || activeControl == grpMenu)
                {
                    btnOrder.Focus();
                    return true;
                }
            }

            // 버튼 간 방향키 이동 (주문하기 <-> 초기화)
            if (activeControl == btnOrder && keyData == Keys.Right)
            {
                btnInit.Focus();
                return true;
            }
            if (activeControl == btnInit && keyData == Keys.Left)
            {
                btnOrder.Focus();
                return true;
            }

            // 라디오버튼 (메뉴 선택) 위/아래 방향키 명시적 조작
            if (activeControl == rdoHamburger && keyData == Keys.Down) { rdoBulgogiBurger.Focus(); return true; }
            if (activeControl == rdoBulgogiBurger && keyData == Keys.Down) { rdoChickenBurger.Focus(); return true; }
            if (activeControl == rdoChickenBurger && keyData == Keys.Up) { rdoBulgogiBurger.Focus(); return true; }
            if (activeControl == rdoBulgogiBurger && keyData == Keys.Up) { rdoHamburger.Focus(); return true; }

            // 체크박스 (추가 옵션) 영역에서만 자동 이동되도록 제한
            if (activeControl != null && activeControl is CheckBox &&
                (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right))
            {
                bool forward = keyData == Keys.Down || keyData == Keys.Right;
                activeControl.Parent.SelectNextControl(activeControl, forward, true, false, true);
                return true;
            }

            // 스페이스바로 아이템 선택하기
            if (keyData == Keys.Space)
            {
                if (activeControl is CheckBox chk)
                {
                    chk.Checked = !chk.Checked;
                    return true;
                }
                else if (activeControl is RadioButton rdo)
                {
                    // 수동 동작
                    rdoHamburger.Checked = false;
                    rdoBulgogiBurger.Checked = false;
                    rdoChickenBurger.Checked = false;

                    rdo.Checked = true;
                    return true;
                }
            }

            // Enter key acts as button click 
            if (keyData == Keys.Enter)
            {
                if (activeControl == btnInit)
                {
                    btnInit.PerformClick();
                }
                else
                {
                    btnOrder.PerformClick();
                }
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        int totalcost = 0;



        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamburger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked &&
                !chkFrenchFries.Checked && !chkCola.Checked && !chkCheese.Checked && !chkSauce.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
                lblTotalCost.Text = "주문할 메뉴를 선택해주세요.";
                return;
            }

            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular);

            if (rdoHamburger.Checked)
            {
                totalcost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalcost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalcost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkFrenchFries.Checked)
            {
                totalcost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalcost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalcost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalcost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.Text = "총 금액: " + totalcost.ToString("N0") + "원";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamburger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkFrenchFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular);
            lblTotalCost.Text = "총 금액 : 0원";
            totalcost = 0;
            this.ActiveControl = null; // 포커스 초기화
        }

        private void grpOrder_Enter(object sender, EventArgs e)
        {

        }
    }
}
