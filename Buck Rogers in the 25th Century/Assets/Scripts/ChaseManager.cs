using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new followPath());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
