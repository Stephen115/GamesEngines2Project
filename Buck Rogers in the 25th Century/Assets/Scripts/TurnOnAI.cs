using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnAI : MonoBehaviour
{
    public float WaitTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Launch", WaitTime);
    }

    void Launch() 
    {
        this.GetComponent<ThunderManager>().enabled = true;
    }

}
