namespace Menu.views;

public partial class Mexicano : ContentPage
{
	public Mexicano()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Dinero.Text))
		{
			var dato1 = Convert.ToDouble(Dinero.Text);

			var dato2 = (dato1 * 1) / 8.75;

			cantidad.Text = Convert.ToString(dato2);
		}
    }
}