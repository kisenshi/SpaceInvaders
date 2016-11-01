using UnityEngine;
using System.Collections;

public class ShotBehaviour : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		position.y += speed;
		this.transform.position = position;
	}
}
