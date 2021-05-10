using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    public GameObject CameraManager;

    public GameObject CameraPathPan;
    public GameObject BarrelRollCam;

    public GameObject Thunder1;
    public GameObject Thunder2;
    public GameObject Thunder3;
    public GameObject Thunder4;
    public GameObject Thunder5;
    public GameObject Thunder6;


    public GameObject Marauder1;
    public GameObject Marauder2;
    public GameObject Marauder3;
    public GameObject Marauder4;
    public GameObject Marauder5;
    public GameObject Marauder6;
    public GameObject Marauder7;
    public GameObject Marauder8;
    public GameObject MarauderGun;

    public GameObject DracoExplosion;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        CameraManager = GameObject.Find("CameraManager");

        CameraPathPan = GameObject.Find("DracoCamera");
        BarrelRollCam = GameObject.Find("BarrelRollCam");

        Thunder1 = GameObject.Find("ThunderFighter player");
        Thunder2 = GameObject.Find("ThunderFighter2 (1)");
        Thunder3 = GameObject.Find("ThunderFighter2 (2)");
        Thunder4 = GameObject.Find("ThunderFighter2 (3)");
        Thunder5 = GameObject.Find("ThunderFighter2 (5)");
        Thunder6 = GameObject.Find("ThunderFighter2 (6)");

        Marauder1 = GameObject.Find("Marauder 12 (4)");
        Marauder2 = GameObject.Find("Marauder 12 (5)");
        Marauder3 = GameObject.Find("Marauder 12 (6)");
        Marauder4 = GameObject.Find("Marauder 12 (7)");
        Marauder5 = GameObject.Find("Marauder 12 (8)");
        Marauder6 = GameObject.Find("Marauder 12 (9)");
        Marauder7 = GameObject.Find("Marauder 12 (10)");
        Marauder8 = GameObject.Find("Marauder 12 (11)");
        MarauderGun = GameObject.FindWithTag("GunFire");

        DracoExplosion = GameObject.FindWithTag("DracoExplosion");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Time.deltaTime * speed;

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "SceneChange") {
            SceneManager.LoadScene("SampleScene");
        } else if (collision.gameObject.tag == "Pan")
        {
            MarauderGun.gameObject.SetActive(false);
            DracoExplosion.gameObject.SetActive(false);
            CameraPathPan.GetComponent<FollowPath>().enabled = true;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 1;
        }
        else if (collision.gameObject.tag == "FlyBy")
        {
            Marauder1.GetComponent<FollowPath>().enabled = true;
            Marauder2.GetComponent<FollowPath>().enabled = true;
            Marauder3.GetComponent<FollowPath>().enabled = true;
            Marauder4.GetComponent<FollowPath>().enabled = true;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 2;
        }
        else if (collision.gameObject.tag == "FlyTo")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 7;

        }
        else if (collision.gameObject.tag == "Talk")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 0;

        }
        else if (collision.gameObject.tag == "SideFly")
        {

        }
        else if (collision.gameObject.tag == "GunCam")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 6;
        }
        else if (collision.gameObject.tag == "DracoExplosion")
        {

        }
        else if (collision.gameObject.tag == "LiftOff")
        {
            //Thunder1.GetComponent<TurnOnAI>().enabled = true;
            //Thunder2.GetComponent<TurnOnAI>().enabled = true;
            //Thunder3.GetComponent<TurnOnAI>().enabled = true;
            //Thunder4.GetComponent<TurnOnAI>().enabled = true;
            //Thunder5.GetComponent<TurnOnAI>().enabled = true;

            CameraManager.GetComponent<CameraSwitching>().camNumber = 0;

        }
        else if (collision.gameObject.tag == "BarrelRoll")
        {
            Thunder1.GetComponent<TurnOnAI>().enabled = true;
            Thunder2.GetComponent<TurnOnAI>().enabled = true;
            Thunder3.GetComponent<TurnOnAI>().enabled = true;
            Thunder4.GetComponent<TurnOnAI>().enabled = true;
            Thunder5.GetComponent<TurnOnAI>().enabled = true;
            DracoExplosion.gameObject.SetActive(false);
            Marauder5.GetComponent<FollowPath>().enabled = true;
            Marauder6.GetComponent<FollowPath>().enabled = true;
            Marauder5.GetComponent<Shoot>().enabled = true;
            Marauder6.GetComponent<Shoot>().enabled = true;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 13;
        }
        else if (collision.gameObject.tag == "ShootOverFront")
        {

        }
        else if (collision.gameObject.tag == "Cockpit")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 4;

        }
        else if (collision.gameObject.tag == "Tunnel")
        {

        }
        else if (collision.gameObject.tag == "OutsideTunnel")
        {

        }
        else if (collision.gameObject.tag == "FlyOverFront")
        {
            BarrelRollCam.GetComponent<CameraTarget>().target = Thunder1.transform;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 13;

        }
        else if (collision.gameObject.tag == "FlyUp")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 14;

        }
        else if (collision.gameObject.tag == "MarauderFormation")
        {

        }
        else if (collision.gameObject.tag == "MarauderChase")
        {

        }
        else if (collision.gameObject.tag == "SideTCam")
        {
            CameraManager.GetComponent<CameraSwitching>().camNumber = 10;

        }
        else if (collision.gameObject.tag == "2")
        {

        }
        else if (collision.gameObject.tag == "3")
        {

        }
        else if (collision.gameObject.tag == "4")
        {

        }
        else if (collision.gameObject.tag == "5")
        {

        }
        else if (collision.gameObject.tag == "6")
        {

        }
        else if (collision.gameObject.tag == "7")
        {

        }
        else if (collision.gameObject.tag == "8")
        {

        }
        else if (collision.gameObject.tag == "9")
        {

        }
        else if (collision.gameObject.tag == "10")
        {

        }
        else if (collision.gameObject.tag == "ShootingFlyby")
        {
            MarauderGun.gameObject.SetActive(true);
            CameraManager.GetComponent<CameraSwitching>().camNumber = 11;

        }
        else if (collision.gameObject.tag == "DracoExplosions")
        {
            MarauderGun.gameObject.SetActive(false);
            DracoExplosion.gameObject.SetActive(true);
            CameraManager.GetComponent<CameraSwitching>().camNumber = 12;

        }
        else if (collision.gameObject.tag == "ForwardShoot")
        {
            Marauder8.GetComponent<Shoot>().enabled = true;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 15;

        }
        else if (collision.gameObject.tag == "ChaseFirst")
        {

            Thunder6.GetComponent<ChaseManager>().enabled = true;
            Marauder7.GetComponent<BigBoid>().enabled = true;
            CameraManager.GetComponent<CameraSwitching>().camNumber = 16;

        }
        else if (collision.gameObject.tag == "BendExplode")
        {

            CameraManager.GetComponent<CameraSwitching>().camNumber = 17;

        }
    }
}
