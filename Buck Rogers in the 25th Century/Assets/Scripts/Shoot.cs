using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AudioSource laser;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public GameObject bulletPrefab;

    public float fireRate = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Shooting()
    {
        if (laser)
            laser.Play();

        GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
        GameObject bullet2 = GameObject.Instantiate<GameObject>(bulletPrefab);
        bullet.transform.position = spawnPoint.position;
        bullet.transform.rotation = this.transform.rotation;
        bullet2.transform.position = spawnPoint2.position;
        bullet2.transform.rotation = this.transform.rotation;
    }

    void OnEnable()
    {
        StartCoroutine(ShootingCoroutine());
    }

    bool shooting = true;

    System.Collections.IEnumerator ShootingCoroutine()
    {
        while (true)
        {
            if (shooting == true)
            {
                Shooting();
                yield return new WaitForSeconds(1.0f / fireRate);
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}