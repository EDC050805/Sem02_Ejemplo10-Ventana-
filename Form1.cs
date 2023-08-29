namespace Sem02_Ejemplo10__Ventana_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDeterminar_Click(object sender, EventArgs e)
        {
            double precioConsumo, impuesto, descuento, subTotal;

            precioConsumo = double.Parse(TxtPrecioInicial.Text);

            descuento = 0;
            subTotal = 0;
            if (precioConsumo <= 100 && precioConsumo > 0)
            {
                descuento = 0.1 * precioConsumo;
                subTotal = precioConsumo - descuento;
            }
            if (precioConsumo > 100)
            {
                descuento = 0.2 * precioConsumo;
                subTotal = precioConsumo - descuento;
            }
            impuesto = 0.18 * subTotal;
            precioConsumo = subTotal + impuesto;

            TxtDescuento.Text = descuento.ToString("N2");
            TxtSubTotal.Text = subTotal.ToString("N2");
            TxtImpuesto.Text = impuesto.ToString("N2");
            TxtImporte.Text = precioConsumo.ToString("N2");
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            TxtPrecioInicial.Clear();
            TxtDescuento.Clear();
            TxtSubTotal.Clear();
            TxtImpuesto.Clear();
            TxtImporte.Clear();
        }
    }
}