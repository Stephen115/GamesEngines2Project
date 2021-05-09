using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : State
{
    public bool changeState;
    
    public override void Enter()
    {
        changeState = owner.GetComponent<ChangeState>().changeState;
        owner.GetComponent<FollowPath>().enabled = true;
        owner.GetComponent<Boid>().maxSpeed = 10;
        owner.GetComponent<Boid>().maxForce = 5;

    }

    public override void Think()
    {
        //changeState = owner.GetComponent<ChangeState>().changeState;
        //if (owner.GetComponent<ChangeState>().changeState == true) 
        //{
        //    owner.ChangeState(new boost()); 
        //}
    }

    public override void Exit()
    {
        owner.GetComponent<ChangeState>().changeState = false;
        changeState = false;
    }

}
public class followPath : State
{

    public override void Enter()
    {
        owner.GetComponent<FollowPath>().enabled = true;
        owner.GetComponent<Boid>().maxSpeed = 20;
        owner.GetComponent<Boid>().maxForce = 10;
    }

    public override void Think()
    {

        //owner.ChangeState(new boost());
    }

    public override void Exit()
    {

    }

}
public class shoot : State
{

    public override void Enter()
    {


    }

    public override void Think()
    {

    }

    public override void Exit()
    {

    }

}
public class boost : State
{
    public bool changeState;

    public override void Enter()
    {
        owner.GetComponent<Boid>().maxSpeed = 80;
        owner.GetComponent<Boid>().maxForce = 40;

    }

    public override void Think()
    {
        //changeState = owner.GetComponent<ChangeState>().changeState;
        //if (changeState == true)
        //{
          //  owner.ChangeState(new followPath());
        //}
    }

    public override void Exit()
    {
        owner.GetComponent<ChangeState>().changeState = false;
        changeState = false;

    }

}

public class ThunderStates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
