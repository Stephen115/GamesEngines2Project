using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : SteeringBehaviour
{
    public float forwardSpeed = 40f, strafeSpeed = 40f, hoverSpeed = 40f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    public Rigidbody rb;
    //public Boid boid;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boid = GetComponent<Boid>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        activeHoverSpeed = Input.GetAxisRaw("Hover") * hoverSpeed;

        //transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        //transform.position += transform.right * activeStrafeSpeed * Time.deltaTime;
        //transform.position += transform.up * activeHoverSpeed * Time.deltaTime;
        //rb.AddForce(((transform.forward * activeForwardSpeed)+(transform.right * activeStrafeSpeed)+(transform.up * activeHoverSpeed)) * Time.deltaTime);
        //boid.SeekDirection(((transform.forward * activeForwardSpeed) + (transform.right * activeStrafeSpeed) + (transform.up * activeHoverSpeed)) * Time.deltaTime);
    }

    public override Vector3 Calculate()
    {
        return boid.SeekDirection(((transform.forward * activeForwardSpeed) + (transform.right * activeStrafeSpeed) + (transform.up * activeHoverSpeed)) * Time.deltaTime);
        //Vector3 direction = new Vector3(activeStrafeSpeed, activeHoverSpeed, activeForwardSpeed);
        //return boid.SeekDirection((direction) * Time.deltaTime);

    }
}
