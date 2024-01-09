namespace dvargasExamen.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btninicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;

        List<String> usuarios = new List<string>{ "estudiante2024","examen1","NombreEstudiante"};
        List<String> contrasenias = new List<string> { "uisrael2024", "parcial1", "2024" };

        string usuarioIngresado = txtUsuario.Text.ToLower();
        string contraseniaIngresada = txtContraseña.Text;

        bool credencialesValidas = false;

        for (int i = 0; i < usuarios.Count; i++)
        {
            if (usuarioIngresado == usuarios[i] && contraseniaIngresada == contrasenias[i])
            {
                credencialesValidas = true;
                break;
            }
        }
        if (credencialesValidas)
        {
            Navigation.PushAsync(new Vistas.Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Datos incorrectos", "Cancelar");
        }
    }

    private void btbacercade_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Desarrollador", "Daniel Vargas \nOctavo Semeste \nUisrael", "Cerrar");
    }
}