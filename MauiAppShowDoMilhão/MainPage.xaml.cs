namespace MauiAppShowDoMilhão
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRadowPerguntaFacil();
        }

        private async void Button_Clicked_Proxima(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)) alt0.Value){
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }


        }
    }

}
