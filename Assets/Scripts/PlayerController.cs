using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		// float moveHorizontal = Input.GetAxis ("Horizontal");
		rigidbody.AddForce(new Vector3(moveHorizontal,0.0f,moveVertical)*3);
	}
}
