using Microsoft.Maui.Controls;

namespace MauiBMICalc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        // Zkontrolujte, zda jsou vstupy validní a lze je převést na čísla
        if (double.TryParse(weightEntry.Text, out double weight) && weight > 0 &&
            double.TryParse(heightEntry.Text, out double height) && height > 0)
        {
            // Převeďte výšku na metry a spočítejte BMI
            double bmi = weight / Math.Pow(height / 100, 2);  // výška je v cm, takže ji převedeme na metry dělením 100

            // Zobrazte výsledek BMI
            bmiLabel.Text = $"BMI: {bmi:F2}";

            // Určete kategorii BMI a odpovídající obrázek
            string bmiCategory;
            string imageSource;

            if (bmi < 18.5)
            {
                bmiCategory = "Podváha";
                imageSource = "underweight.png";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                bmiCategory = "Normální váha";
                imageSource = "normal.png";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                bmiCategory = "Nadváha";
                imageSource = "overweight.png";
            }   
            else if (bmi >= 30 && bmi < 35)
            {
                bmiCategory = "Obezita I. stupně";
                imageSource = "obesity.png";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                bmiCategory = "Obezita II. stupně";
                imageSource = "morbid.png";
            }
            else
            {
                bmiCategory = "Neznámé";
                imageSource = "unknown.png";
            }

            // Zobrazení kategorie
            bmiCategoryLabel.Text = $"Kategorie: {bmiCategory}";

            // Nastavení obrázku na základě kategorie BMI
            bmiImage.Source = ImageSource.FromFile(imageSource);
        }
        else
        {
            // Pokud jsou vstupy neplatné, zobrazí se chybová zpráva
            bmiLabel.Text = "BMI: Neplatný vstup";
            bmiCategoryLabel.Text = "Kategorie: Neplatný vstup";
            bmiImage.Source = null;

            // Zobrazí dialog s chybovou zprávou
            DisplayAlert("Chyba", "Zadejte prosím platné hodnoty pro váhu a výšku.", "OK");
        }
    }
}
