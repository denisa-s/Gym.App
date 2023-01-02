using Proiect1.ViewModel;

namespace Proiect1.Views;

public partial class GymPage : ContentPage
{
    GymPageViewModel productPageViewModel;
    public GymPage()
    {
        InitializeComponent();
        productPageViewModel = new GymPageViewModel(this.Navigation);
        BindingContext = productPageViewModel;
    }
    int count = 0;

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}