using UnityEngine;

public class Playermovement : MonoBehaviour {
	public Rigidbody rb;
	public Vector3 jump;
	public float fforce=2000f;
	public float playerJumpHeight = 2.0f;
	public float sforce=500f;
	void Start (){
	}
	// Update is called once per frame
	void FixedUpdate () {

			rb.AddForce(0,0,fforce*Time.deltaTime);
			
		if(Input.GetKey("d")){
			rb.AddForce(sforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		
		if(Input.GetKey("a")){
			rb.AddForce(-sforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKeyDown("w")){
			rb.AddForce(jump * playerJumpHeight, ForceMode.Impulse);
		}
	}
}
