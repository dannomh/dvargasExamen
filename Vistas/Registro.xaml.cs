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
        //
    }
}