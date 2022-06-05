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

namespace Zinx_food.view
{
    public partial class PrincipalView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AbrirFechar_Caixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            CaixaView cx = new CaixaView();

            cx.ShowDialog();
        }

        private void Historico_Caixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            HistoricoCaixaView cxHist = new HistoricoCaixaView();

            cxHist.TopLevel = false;
            cxHist.AutoScroll = true;
            PanelPrincipal.Controls.Add(cxHist);

            cxHist.Show();
        }

        private void PedidoCaixa_Vendas_ItemClick(object sender, ItemClickEventArgs e)
        {
            PedidoView ped = new PedidoView();
            ped.ShowDialog();
        }
    }
}