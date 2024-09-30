namespace fontAttributes
{
    public partial class MainPage : ContentPage
    {
        string[] helloTexts = { "Dzień Dobry", "Good Morning", "Buenos Dias" };
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*
            Nazwa Funkcji:          onNextClicked
            Parametry Wejściowe:    sender - kliknięty objekt
            Wartość Zwracana:       brak
            Informacje:             Funkcja po kliknięciu przycisku podnosi
                                    zmienną "count" o jeden, następnie sprawdza
                                    czy nie jest ona wieksza od 2 - jezeli tak
                                    ustawia zmienna na 0. Ostatecznie ustawia ona
                                    tekst w objekcie label "lblCytat" na jeden z tekstów
                                    w tabeli "helloTexts" o index'ie rownego zmiennej "count"
            Autor:                  12363412316
         */
        private void onNextClicked(object sender, EventArgs e)
        {
            count++;
            if (count > 2)
                count = 0;
            lblCytat.Text = helloTexts[count];
        }

        /*
            Nazwa Funkcji:          onSldrSlid
            Parametry Wejściowe:    sender - kliknięty objekt
            Wartość Zwracana:       brak
            Informacje:             Funkcja ustawia rozmiar objektu label "lblCytat"
                                    na wartość ustawioną przy użyciu suwaka, zamienioną
                                    na liczbę całkowitą oraz zmienia na równą jej wartość
                                    tekst w label'u "lblRozmiar"
            Autor:                  12363412316
         */
        private void onSldrSlid(object sender, EventArgs e)
        {
            lblCytat.FontSize = int.Parse(Math.Round(sldrSize.Value).ToString());
            lblRozmiar.Text = $"Rozmiar: {sldrSize.Value.ToString("0")}";
        }

        
    }

}
