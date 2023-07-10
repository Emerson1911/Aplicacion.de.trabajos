namespace Menu.views;

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Total_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Platos.Text))
		{
			var dato1 = Convert.ToDouble(Platos.Text);

			if(dato1 >= 300)
			{

                Pago.Text = Convert.ToString(dato1 * 75);

            }
            else if(dato1 >=200)
			{

                Pago.Text = Convert.ToString(dato1 * 85);

            }
			else
			{

				Pago.Text =Convert.ToString (dato1 * 95);
			}
			
		}
		else
		{
			DisplayAlert("Error", "Escribe el numero de platos hombre", "adoptado");
		}
    }
}