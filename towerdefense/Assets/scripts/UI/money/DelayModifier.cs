
using System.Collections;
using UnityEngine;

public class DelayModifier : MonoBehaviour
{
    public float delay; // Current delay between spawns

    public float InitialDelay = 1.0f; // The initial delay between spawns
    public float delayprecentage;
    private float MinDelay = 0.3f;

    private void Start()
    {
        delay = InitialDelay; // Set the initial delay
        StartCoroutine(ModifyDelay());
    }

    IEnumerator ModifyDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(10); // Wait for 10 seconds before modifying the delay
            ModifyDelayByPercentage(delayprecentage); // Reduce the delay by 5%
        }
    }

    public void ModifyDelayByPercentage(float percentage)
    {
        if (delay > MinDelay)
        {
            float reductionAmount = delay * (percentage / 100.0f); // Calculate the reduction based on the given percentage
            delay -= reductionAmount; // Reduce the delay by the calculated amount
        }
        

    }

    public float GetCurrentDelay()
    {
        return delay;
    }
}
