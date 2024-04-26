namespace vfloresExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Bienvenido ", usuario, "Aceptar");
        lblusuario.Text= "Usuario Conectado: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double monto = Convert.ToDouble(txtmonto.Text);
        double residuo = 1500 - monto;
        double cuota = residuo / 4;
        double valorfinal = cuota + (1500 * 0.04);
        double valorTotal = monto + (valorfinal * 4);

        txtfin.Text = valorfinal.ToString();
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        int edad = Convert.ToInt32(txtedad.Text);
        DateTime fecha = dpDate.Date;
        string pais = pkPais.SelectedItem.ToString();
        string ciudad = pkCiudad.SelectedItem.ToString();
        double montoInicial = Convert.ToDouble(txtmonto.Text);
        double pagoMensual = Convert.ToDouble(txtfin.Text);

        Navigation.PushAsync(new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual));

    }
}