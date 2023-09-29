using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    bool stopwatchActief = false; 
    public float huidigeTijd; 
    public Text huidigeTijdTekst; 
    
    void Start()
    {
        huidigeTijd = 0; 
        StartStopwatch(); 
    }

    void Update()
    {
        if (stopwatchActief)
        {
            huidigeTijd = huidigeTijd + Time.deltaTime; // We voegen steeds 1 seconde toe aan de tijd als de stopwatch actief is
        }

        // We formatteren de tijd met voorloopnullen op basis van het aantal cijfers
        string geformatteerdeTijd = FormatteerTijd(huidigeTijd);
        huidigeTijdTekst.text = geformatteerdeTijd; // We tonen de geformatteerde tijd in de UI Tekst component
    }

    public void StartStopwatch()
    {
        stopwatchActief = true; 
    }

    
    private string FormatteerTijd(float tijdInSeconden)
    {
        int seconden = Mathf.FloorToInt(tijdInSeconden); // We ronden de tijd naar beneden af naar de dichtstbijzijnde gehele seconde

        int minDigits = Mathf.Max(2, Mathf.FloorToInt(Mathf.Log10(seconden) + 1)); // We berekenen het minimum aantal cijfers dat nodig is om seconden weer te geven (note to me probeer niet Logaritme  te begrijpen hz is de uitleg zo ingewikkeld voor no reason )
        return seconden.ToString($"D{minDigits}");  
    }
}
