using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {


	private Animator elevatorAnimator;
	private bool isDoorsOpen = false;
	public float speedElevator;
	private bool readyToStart = false;

	private float startPosition;
	public float heightTransportation = 0;
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
		startPosition = this.transform.position.y;
    }


	
	void FixedUpdate ()
	{
		if(readyToStart)
		{
			if (transform.position.y <= startPosition + heightTransportation) 
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
		//if (!isDoorsOpen) 
		//{
            StartCoroutine("OpenDoors");
			//isDoorsOpen = true;
			readyToStart = false;
		//} 

	}

	public void ElevatorDoorsClose()
	{
		//if(isDoorsOpen) 
		//{
			elevatorAnimator.SetTrigger ("DoorClose");
        //isDoorsOpen = false;
        readyToStart = true;
        //     }
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
    IEnumerator OpenDoors()
    {
        elevatorAnimator.SetTrigger("DoorOpen");
        
        yield return new WaitForSeconds(5f);
    }
}
