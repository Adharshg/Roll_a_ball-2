using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {

	private Rigidbody rb;
	public float speed=100f;
	private int count;
	public Text countText;
	public Text wintext;

	void Start(){
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		wintext.text="";
	}

	void FixedUpdate(){
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

		rb.AddForce(movement * speed);
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("pick up")){
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();
		}
	}

	void SetCountText(){
		countText.text = count.ToString() + " COINS";
		if(count>=32){
			wintext.text = "YOU WIN !!";
			countText.text="";
		}
	}
}
