using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject[] friendly;
    public GameObject[] enemy;

    // Start is called before the first frame update
    void Start()
    {
        friendly = GameObject.FindGameObjectsWithTag("Friendly");
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
