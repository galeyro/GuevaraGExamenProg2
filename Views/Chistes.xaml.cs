namespace GuevaraGExamenProg2.Views;
using GuevaraGExamenProg2.Repositories;

public partial class Chistes : ContentPage
{
    private ChistesRepository _context;
    
    _context = new ChistesRepository();


    public Chistes()
	{
		InitializeComponent();

	}

    private void OtroChisteButton_Clicked(object sender, EventArgs e)
    {

    }
}