using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public Slider volumeslider;
    public AudioSource background;
    // Start is called before the first frame update
    void Start()
    {
        volumeslider = GetComponent<Slider>();
        volumeslider.value = background.volume;
    }
    public void slider(float value)
    {
        background.volume = value;
    }
}
