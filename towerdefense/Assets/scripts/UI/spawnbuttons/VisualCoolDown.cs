using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VisualCoolDown : MonoBehaviour
{
    public Image image;
    private float currentTime = 0f;
    private bool isCoolingDown = false;
    private GameObject spawnerobject;
    public Spawner spawner;

    void Start()
    {
        image= GetComponent<Image>();
        spawner = GetComponent<Spawner>();
        
    }

    void Update()
    {
        if (isCoolingDown)
        {
            currentTime += Time.deltaTime;
            float fillValue = Mathf.Clamp01(currentTime / spawner.cooldownvalue);
            image.fillAmount = 1 - fillValue; 
            if (currentTime >= spawner.cooldownvalue)
            {

                isCoolingDown = false;
                currentTime = 0f;
            }
        }
        // je kunt deze functie startcooldown roepen wanneer er is word getriggered
    }

    public void StartCoolDown()
    {
        isCoolingDown = true;
    }
}
