namespace vfloresExamen.Vistas;

public partial class vResumen : ContentPage
{
	public vResumen(string nombre, string apellido, int edad, DateTime fecha, string pais, string ciudad, double montoInicial, double pagoMensual)
	{
		InitializeComponent();
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad.ToString();
        lblFecha.Text = fecha.ToString("dd/MM/yyyy");
        lblPais.Text = pais;
        lblCiudad.Text = ciudad;
        lblMontoInicial.Text = montoInicial.ToString();
        lblPagoMensual.Text = pagoMensual.ToString();
     
    }

  

    private void btnCerrarSession_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}