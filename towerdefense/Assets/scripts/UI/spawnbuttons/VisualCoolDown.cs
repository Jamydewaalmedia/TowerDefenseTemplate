using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VisualCoolDown : MonoBehaviour
{
    public Image image;
    public float cooldownTime = 3.8f;
    private float currentTime = 0f;
    private bool isCoolingDown = false;

    void Start()
    {
        image.fillAmount = 0;
    }

    void Update()
    {
        if (isCoolingDown)
        {
            currentTime += Time.deltaTime;
            float fillValue = Mathf.Clamp01(currentTime / cooldownTime);
            image.fillAmount = 1 - fillValue; // Reverse fill direction
            if (currentTime >= cooldownTime)
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
