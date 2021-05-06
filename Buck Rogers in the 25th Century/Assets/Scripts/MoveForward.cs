using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public GameObject sceneChange;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
