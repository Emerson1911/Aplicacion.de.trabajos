using System.Linq;

namespace Menu.views;

public partial class Numeros1al10 : ContentPage
{
	//<sumary>
	//Esto lo hizo Hillary
	//</sumary>
	public Numeros1al10()
	{
		InitializeComponent();
	}

    private void calcular_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Tabla.Text))
		{
			var dato1 = Convert.ToInt32(Tabla.Text);
			while ((dato1 <= 0) || (dato1 > 10)) ;
			for(int i=1; i<=10; i++)
			{
			 respuesta.Text=Convert.ToString(dato1+"x"+i+"="+(dato1*i));
			}
			
		}
		else
		{
			DisplayAlert("Error", "Escribe el numero de la tabla Ciego", "Adoptado");
		}
    }
}