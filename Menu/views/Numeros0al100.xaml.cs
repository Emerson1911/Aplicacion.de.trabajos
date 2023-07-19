namespace Menu.views;

public partial class Numeros0al100 : ContentPage
{
    /// <summary>
    /// Esto lo hizo Erika
    /// </summary>
    public Numeros0al100()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(pares.Text))
		{
			var dato1 = Convert.ToInt32(pares.Text);
			while (dato1 <= 100)
			{
                if (dato1 % 2 != 0)
                {
                    respuesta.Text = Convert.ToString(dato1);
                }
                dato1++;
            }
			
		}
		else
		{
			DisplayAlert("Error", "Escribe el numero ciego", "Adoptado");
		}
    }
}