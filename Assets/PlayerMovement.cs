using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization

	public float speed;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if( Input.GetKeyDown( KeyCode.Space ) )
			
		/* Movement */
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 position = this.transform.position;
			position.x += speed;
			this.transform.position = position;

		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 position = this.transform.position;
			position.x -= speed;
			this.transform.position = position;
		}
	}
}
