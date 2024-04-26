namespace vfloresExamen.Vistas;

public partial class vLogin : ContentPage
{

    string[] usuarios = { "estudiante2024", "examen1" };
    string[] claves = { "uisrael2024", "parcial1"};
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {

        string usuario = this.txtUsuario.Text;
        string clave = this.txtClave.Text;

        bool vCoincidencia = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuario && claves[i] == clave)
            {
                vCoincidencia = true;
                break;
            }
        }
        if (vCoincidencia)
        {
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario/Contraseña Incorrecta", "Cerrar");
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

    }


}