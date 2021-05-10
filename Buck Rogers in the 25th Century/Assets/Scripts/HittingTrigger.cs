using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingTrigger : MonoBehaviour
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
        if (other.gameObject.tag == "TriggerBoost")
        {
            GetComponent<StateMachine>().ChangeState(new boost());
        } else if (other.gameObject.tag == "Bullet")
        {
            GetComponent<StateMachine>().ChangeState(new destroyed());
        }
    }
}
