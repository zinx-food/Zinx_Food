using System;

namespace Zinx_food.view
{
    public partial class CaixaView : DevExpress.XtraEditors.XtraForm
    {
        public CaixaView()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_AbrirCaixa_Click(object sender, EventArgs e)
        {
            CaixaAbertoView cxAberto = new CaixaAbertoView();

            cxAberto.TopLevel = false;
            cxAberto.AutoScroll = true;
            PanelCaixa.Controls.Add(cxAberto);

            cxAberto.Show();
        }
    }
}
