using GuevaraGExamenProg2.Repositories;
namespace GuevaraGExamenProg2.Views;

public partial class Chistes : ContentPage
{
    private ChistesRepository _context;

    public Chistes()
    {
        InitializeComponent();
        _context = new ChistesRepository();
    }

    private async Task OtroChisteButton_Clicked(object sender, EventArgs e)
    {
        ChisteLabel.Text = await _context.ObtenerChistesAsync();
    }
}