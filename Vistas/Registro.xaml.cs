namespace dvargasExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado " + usuario;
    }

    private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if (monto > 1500 || monto < 0)
            {
                DisplayAlert("Alerta", "Rango 0 - 1500", "Cancelar");
                txtMonto.Text = "";
            }
        }
        catch (Exception)
        {

        }
    }

    private void btbacercade_Clicked(object sender, EventArgs e)
    {
        double inicial = Convert.ToDouble(txtMonto.Text);

        double montofinalmensual = (1500 - inicial/4)+(0,4*500);
        txtPagoInicial.Text = montofinalmensual.ToString();
        
    }
}