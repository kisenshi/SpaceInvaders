using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization

	public float speed;
	public float firedelay;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown( KeyCode.Space ) ){

			GameObject gun = transform.Find ("ShotSpawn").gameObject;
		
			if (gun != null) {
				GameObject shot = (GameObject)Resources.Load (@"Shot");
				Instantiate (shot, gun.transform.position, gun.transform.rotation);
			}


		}
			
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
