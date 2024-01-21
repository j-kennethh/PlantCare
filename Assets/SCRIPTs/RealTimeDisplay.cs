using TMPro;
using UnityEngine;

public class RealTimeDisplay : MonoBehaviour
{
    public TMP_Text temperatureText;
    public TMP_Text humidityText;
    public TMP_Text lightText;

    public PetHealthbar tempBar;
    public PetHealthbar humidityBar;
    public PetHealthbar lightBar;

    float idealTemp = PetRequirements.idealTemp;
    float idealHumidity = PetRequirements.idealMoisture;
    float idealLight = PetRequirements.idealLight;

    void Update()
    {
        // Assuming that ArduinoDataReceiver script has static variables for temperature, humidity, and lightLevel
        float temperature = ArduinoDataReceiver.temperature;
        float humidity = ArduinoDataReceiver.humidity;
        float lightLevel = ArduinoDataReceiver.lightLevel;

        // Update UI TextMeshPro with real-time sensor values
        temperatureText.text = temperature.ToString("F2") + " C";
        humidityText.text = humidity.ToString("F2") + "%";
        lightText.text = lightLevel.ToString("F2");

        // Update Healthbars
        tempBar.UpdateHealthBar(temperature, idealTemp);
        humidityBar.UpdateHealthBar(humidity, idealHumidity);
        lightBar.UpdateHealthBar(lightLevel, idealLight);
    }
}



