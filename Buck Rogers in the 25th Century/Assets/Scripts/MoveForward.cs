using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    public GameObject CameraManager;

    public GameObject CameraPathPan;

    public GameObject Thunder1;
    public GameObject Thunder2;
    public GameObject Thunder3;
    public GameObject Thunder4;
    public GameObject Thunder5;


    public GameObject Marauder1;
    public GameObject Marauder2;
    public GameObject Marauder3;
    public GameObject Marauder4;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        CameraManager = GameObject.Find("CameraManager");

        CameraPathPan = GameObject.Find("DracoCamera");

        Thunder1 = GameObject.Find("ThunderFighter player");
        Thunder2 = GameObject.Find("ThunderFighter2 (1)");
        Thunder3 = GameObject.Find("ThunderFighter2 (2)");
        Thunder4 = GameObject.Find("ThunderFighter2 (3)");
        Thunder5 = GameObject.Find("ThunderFighter2 (5)");

        Marauder1 = GameObject.Find("Marauder 12 (4)");
        Marauder2 = GameObject.Find("Marauder 12 (5)");
        Marauder3 = GameObject.Find("Marauder 12 (6)");
        Marauder4 = GameObject.Find("Marauder 12 (7)");
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

        }
        else if (collision.gameObject.tag == "DracoExplosion")
        {

        }
        else if (collision.gameObject.tag == "LiftOff")
        {

        }
        else if (collision.gameObject.tag == "BarrelRoll")
        {

        }
        else if (collision.gameObject.tag == "ShootOverFront")
        {

        }
        else if (collision.gameObject.tag == "Cockpit")
        {

        }
        else if (collision.gameObject.tag == "Tunnel")
        {

        }
        else if (collision.gameObject.tag == "OutsideTunnel")
        {

        }
        else if (collision.gameObject.tag == "FlyOverFront")
        {

        }
        else if (collision.gameObject.tag == "FlyUp")
        {

        }
        else if (collision.gameObject.tag == "MarauderFormation")
        {

        }
        else if (collision.gameObject.tag == "MarauderChase")
        {

        }
        else if (collision.gameObject.tag == "1")
        {

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
    }
}
