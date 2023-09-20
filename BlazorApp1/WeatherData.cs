namespace BlazorApp1
{
    public class WeatherData
    {
        public List<WeatherInfo> Liveweer { get; set; }
    }

    public class WeatherInfo
    {
        public string Time { get; set; }
        public string Plaats { get; set; }
        public string Temp { get; set; }
        public string Samenv { get; set; }
        public string Winds { get; set; }
        public string luchtd { get; set; }
        public string D1tmin { get; set; }
        public string D1tmax { get; set; }
        public string D2tmin { get; set; }
        public string D2tmax { get; set; }
        public string Verw { get; set; }
        // Voeg andere eigenschappen toe die overeenkomen met de gegevens in de JSON
    }

}
