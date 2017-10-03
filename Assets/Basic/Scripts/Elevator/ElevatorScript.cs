using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {


	private Animator elevatorAnimator;
	private bool isDoorsOpen = false;
	public float heightTransportation;
	public float speedElevator;
	private bool readyToStart = false;

	private Vector3 startPosition;
	public Vector3 endPosition;
    //private Rigidbody rigidbodyElevator;
    //


    void OnEnable()
	{
		ButtonElevatorScript.OnPush += ElevatorDoorsOpen;
	}

	void OnDisable()
	{
		ButtonElevatorScript.OnPush -= ElevatorDoorsOpen;

	}


	void Start () 
	{

		elevatorAnimator = GetComponent<Animator> ();
		startPosition = this.transform.position;

        //rigidbodyElevator = GetComponent<Rigidbody>();
    }


	
	void FixedUpdate ()
	{
		if(readyToStart)
		{
			if (transform.position.y <= endPosition.y) 
			{
                //Add pause for some seconds
                this.transform.Translate(new Vector3(0,0, speedElevator * Time.deltaTime));
            } 
			else 
			{
				readyToStart = false;
				ElevatorDoorsOpen ();
			}
		}
		
	}

	public void ElevatorDoorsOpen()
	{
		if (!isDoorsOpen) 
		{
			elevatorAnimator.SetTrigger ("DoorOpen");
			isDoorsOpen = true;
			readyToStart = false;
		} 

	}

	public void ElevatorDoorsClose()
	{
		if(isDoorsOpen) 
		{
			elevatorAnimator.SetTrigger ("DoorClose");
			isDoorsOpen = false;
            readyToStart = true;
        }
    }

	public void Close()
	{
		elevatorAnimator.SetTrigger ("DoorClose");
	}

	public void OnAnimationEnd()
	{
		readyToStart = true;
		Debug.Log ("animation event end");
	}
		
}
