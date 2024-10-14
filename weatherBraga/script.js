window.addEventListener('load', () => {
    const apiKey = 'd2560ddc9c1e59ab1bc05635e308f9de';
    const city = 'Braga'; // You can change the city here
  
    const apiUrl = `https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=${apiKey}`;
  
    fetch(apiUrl)
      .then(response => response.json())
      .then(data => {
        const weatherInfo = document.querySelector('.weather-card .weather-info');
        const location = document.querySelector('.weather-card .location');
        const temperature = document.querySelector('.weather-card .temperature');
        const weatherIcon = document.getElementById('weather-icon');
  
        const temperatureCelsius = Math.round(data.main.temp - 273.15); // Convert temperature to Celsius
  
        location.textContent = `${city}`;
        temperature.textContent = `${temperatureCelsius}°C`;
        weatherIcon.src = `https://openweathermap.org/img/w/${data.weather[0].icon}.png`;
        weatherIcon.alt = data.weather[0].description;
  
        weatherInfo.style.display = 'block'; // Show weather information
      })
      .catch(error => {
        console.log('Error:', error);
        const weatherInfo = document.querySelector('.weather-card .weather-info');
        weatherInfo.textContent = 'An error occurred while fetching weather data.';
      });
  });
  