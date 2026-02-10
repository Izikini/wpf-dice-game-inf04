using System;
using Microsoft.Maui.Controls;

namespace Kosci {
    public partial class MainPage : ContentPage
    {
        int sumaGry = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Losowanie_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            int kosc1 = random.Next(1, 7);
            int kosc2 = random.Next(1, 7);
            int kosc3 = random.Next(1, 7);
            int kosc4 = random.Next(1, 7);
            int kosc5 = random.Next(1, 7);

            kostka_img1.Source = $"k{kosc1}.jpg";
            kostka_img2.Source = $"k{kosc2}.jpg";
            kostka_img3.Source = $"k{kosc3}.jpg";
            kostka_img4.Source = $"k{kosc4}.jpg";
            kostka_img5.Source = $"k{kosc5}.jpg";

            int suma = kosc1 + kosc2 + kosc3 + kosc4 + kosc5;

            wynik.Text = "Wynik tego losowania: " + suma;
            sumaGry = sumaGry + suma;
            wynik_gry.Text = "Wynik gry: " + sumaGry;
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            sumaGry = 0;
            kostka_img1.Source = "question.jpg";
            kostka_img2.Source = "question.jpg";
            kostka_img3.Source = "question.jpg";
            kostka_img4.Source = "question.jpg";
            kostka_img5.Source = "question.jpg";
            wynik_gry.Text = "Wynik gry: 0";
            wynik.Text = "Wynik tego losowania: ";
        }
    }
}