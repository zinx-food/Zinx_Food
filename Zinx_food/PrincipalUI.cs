using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Caixa;
using UI.Pedidos;

namespace UI
{
    public partial class PrincipalUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrincipalUI()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AbrirFechar_Caixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            CaixaUI cx = new CaixaUI();

            cx.ShowDialog();
        }

        private void Historico_Caixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            HistoricoCaixaUI cxHist = new HistoricoCaixaUI();

            cxHist.TopLevel = false;
            cxHist.AutoScroll = true;
            PanelPrincipal.Controls.Add(cxHist);

            cxHist.Show();
        }

        private void PedidoCaixa_Vendas_ItemClick(object sender, ItemClickEventArgs e)
        {
            PedidoUI ped = new PedidoUI();
            ped.ShowDialog();
        }
    }
}