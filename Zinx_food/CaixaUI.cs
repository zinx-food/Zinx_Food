using System;

namespace Zinx_food.view
{
    public partial class CaixaUI : DevExpress.XtraEditors.XtraForm
    {
        public CaixaUI()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_AbrirCaixa_Click(object sender, EventArgs e)
        {
            CaixaAbertoUI cxAberto = new CaixaAbertoUI();

            cxAberto.TopLevel = false;
            cxAberto.AutoScroll = true;
            PanelCaixa.Controls.Add(cxAberto);

            cxAberto.Show();
        }
    }
}
