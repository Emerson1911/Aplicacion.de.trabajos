namespace Menu.views;

public partial class Sueldo : ContentPage
{
	//<sumary>
	//Esto lo hizo Hillary
	//</sumary>
	public Sueldo()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {

		if(!string.IsNullOrEmpty(ueldo.Text) && !string.IsNullOrEmpty(Horas.Text))
		{
			var dato1 = Convert.ToDouble(ueldo.Text);
			var dato2 = Convert.ToDouble(Horas.Text);
			var dato3 = dato1 * dato2;
			Pago.Text = Convert.ToString(dato3);
		}
		else
		{
			DisplayAlert("Error", "Escribe el sueldo o las horas animal", "Adoptado");
		}
    }
}