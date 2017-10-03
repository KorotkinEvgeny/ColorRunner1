using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private CharacterController charController;
	private const float beginningSpeed = 10f;
	public float speedIncreasingValue = 1.5f;
	public float speed = 2.0f;
	public float gravity = -9.8f;
	public float jumpHeight = 2f;
	private float verticalSpeed = 0;
	private Vector3 movement;


	public float maxSpeedIncrease = 20f;

	// Use this for initialization
	void Start () {

		charController = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxisRaw ("Horizontal") * speed;
		float z = Input.GetAxisRaw ("Vertical") * speed;

		movement = new Vector3 (x,0,z);

		movement = Vector3.ClampMagnitude (movement,speed);

		if (charController.isGrounded) {
			
			verticalSpeed = 0;
			if (Input.GetButtonDown ("Jump")) {
				verticalSpeed = jumpHeight;
			}
		}

		if (Input.GetKey(KeyCode.LeftShift)) {
			while(speed<=maxSpeedIncrease){
				speed += speedIncreasingValue;
			}
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			speed = beginningSpeed;
		}



		verticalSpeed -= gravity * Time.deltaTime;

		movement.y = verticalSpeed;

		movement *= Time.deltaTime;

		movement = transform.TransformDirection (movement);

		charController.Move (movement); 

	}





	private void OnControllerColliderHit(ControllerColliderHit hit){

		if (charController.isGrounded) {
			GameObject go = hit.gameObject;

			//Change color of object example
			//GameObject whateverGameObject = whatever;
//			Color whateverColor = new Color(whateverRValue,whateverGValue,whateverBValue,1);
//
//			MeshRenderer gameObjectRenderer = whateverGameObject.GetComponent<MeshRenderer>();
//
//			Material newMaterial = new Material(Shader.Find("Whatever name of the shader you want to use"));
//
//			newMaterial.color = whateverColor;
//			gameObjectRenderer.material = newMaterial ;


		}

		if (!charController.isGrounded && hit.normal.y < 0.1f) {
			if(Input.GetButtonDown("Jump")){
				verticalSpeed = jumpHeight;
//				movement = (-hit.moveDirection) * speed;
				Debug.DrawRay(hit.point,hit.normal,Color.red,10f);
				movement = (hit.normal) * speed;
				Debug.DrawRay(hit.point,hit.moveDirection ,Color.black,10f);
			}
		}

	}
}
