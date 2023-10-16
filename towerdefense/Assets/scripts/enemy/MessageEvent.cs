using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Knockback.oncollision2 += Message;
    }
    private void Message()
    {

        Debug.Log("knockback boem");

    }
}
