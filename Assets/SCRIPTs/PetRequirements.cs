using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PetRequirements : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField input;

    public static float idealTemp;
    public static float idealMoisture;
    public static float idealLight;

    public void TempSubmit()
    {
        output.text = "Ideal Temperature: " + input.text + "°C";
        idealTemp = float.Parse(input.text);
    }

    public void MoistureSubmit()
    {
        output.text = "Ideal Moisture: " + input.text + "%";
        idealMoisture = float.Parse(input.text);
    }

    public void LightSubmit()
    {
        output.text = "Ideal Light: " + input.text + "%";
        idealLight = float.Parse(input.text);
    }
}