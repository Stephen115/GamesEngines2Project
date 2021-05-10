using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public AudioSource explosionNoise;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        GameObject fx = Instantiate(explosionPrefab.gameObject, transform.position, transform.rotation);
        GameObject noise = Instantiate(explosionNoise.gameObject, transform.position, transform.rotation);

        Destroy(fx, 2);
        Destroy(noise, 2);

        Destroy(this.gameObject);

    }
}
