using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingShootingTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "ShootingEnd")
        {
            GetComponent<Shoot>().enabled = false;
        }
        else if (other.gameObject.tag == "ShootingTrigger")
        {
            GetComponent<Shoot>().enabled = true;
        }
    }
}
