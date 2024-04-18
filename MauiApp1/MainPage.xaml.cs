namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void Oblicz_Sume(object sender, EventArgs e)
        {
            int a, b=11, w;

            if( Int32.TryParse(liczba_a.Text, out a) && Int32.TryParse(liczba_b.Text, out b))
            {
                a = Convert.ToInt32(liczba_a.Text);
                b = Convert.ToInt32(liczba_b.Text);
                w = a + b;

                wynik.Text = w.ToString();

            }

            else
            {
                wynik.Text = "BŁĄD";

            }

           

        }
    }

}
