using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExplosion : MonoBehaviour
{
    public GameObject explosion;
    public Transform CurrentLocation;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(explosion, CurrentLocation.position, Quaternion.identity);
        Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
