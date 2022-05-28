namespace WEB
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public void Get()
        {
            throw new NotImplementedException();
            // weatherRepository.Get();
        }
    }
}
