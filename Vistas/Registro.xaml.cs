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

    public void btbacercade_Clicked(object sender, EventArgs e)
    {
        double inicial = Convert.ToDouble(txtMonto.Text);


        double montofinalmensual = (1500 - inicial) / 4 + 0.04 * 1500;

        if(inicial == 1500)
        {
            double montocero  = 1500 - inicial;
            txtPagoInicial.Text = montocero.ToString();
        }
        else
        {
            txtPagoInicial.Text = montofinalmensual.ToString();
        }
       
        
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        double monto = Convert.ToDouble(txtMonto.Text);
        double inicial = Convert.ToDouble(txtMonto.Text);

        double montofinalmensual = (1500 - inicial) / 4 + 0.04 * 1500;
        double pagototal = inicial + montofinalmensual * 4;
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = dpFechas.Date.ToString();
        string ciudad = dpciudad.Items[dpciudad.SelectedIndex].ToString();
        string pais = dppaises.Items[dppaises.SelectedIndex].ToString();
        DisplayAlert("Alerta", "Nombre: "+nombre.ToString()+"\nApellido: "+ apellido.ToString()+ "\nEdad: "+ edad.ToString()
            +"\nFecha"+fecha.ToString()+"\nCiudad: "+ciudad.ToString()+"\nPais:"+pais.ToString()+ "\nMonto: "+ monto.ToString()+
            "\nMensual: "+ montofinalmensual.ToString()+"\nPago Total: "+pagototal.ToString(), "Cancelar");
    }
}