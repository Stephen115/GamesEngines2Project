using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFindTarget : MonoBehaviour
{
    public GameObject DodgeTarget;
    public GameObject target;
    public BigBoid boid;
    public float dodgeDist = 25f;
    public float shootDist = 65f;
    public float dodgingArea = 100;

    public String tag;
    // Start is called before the first frame update
    void Start()
    {
        boid = GetComponent<BigBoid>();
        DodgeTarget = new GameObject("DodgeTarget" + transform.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target && target.activeInHierarchy)
        {
            if (Vector3.Distance(this.transform.position, target.transform.position) < dodgeDist)
            {
                //boid.seekTarget(target.transform.position + (target.transform.right * dodgeDist * 2));
                target = GetTarget();

            }
            else
            {
                boid.seekTargetTransform = target.transform;
            }
            if (Vector3.Angle(transform.forward, target.transform.position - transform.position) < 20 && target.transform.CompareTag(tag))
            {
                //boid.seekTarget(target.transform.position + (target.transform.right * dodgeDist * 2));
                this.GetComponent<Shoot>().enabled = true;

            }
            else
            {
                this.GetComponent<Shoot>().enabled = false;
            }
        }
        else 
        {
            target = GetTarget();
        }
        
    }

    public GameObject GetTarget() 
    {

        GameObject[] ships = GameObject.FindGameObjectsWithTag(tag);
        GameObject ship = ships[Random.Range(0, ships.Length - 1)];

        if (Vector3.Distance(this.transform.position, ship.transform.position) > dodgeDist)
        {
            return ship;
        }
        else {
            DodgeTarget.transform.position = (Random.insideUnitSphere * dodgingArea) + this.transform.position;
            return DodgeTarget;
        }

        //return ships[Random.Range(0, ships.Length - 1)];

    }
}
