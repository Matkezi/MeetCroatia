using UnityEngine;
using System.Collections;



public class CameraBehavior : MonoBehaviour {

	private const float standardVelocity = 0;

	private Vector3 velocity = Vector3.zero;

	public float Velocity {
		get { return velocity.x; }
		set { velocity.x = value; }
	}

	public void returnToStandardVelocity() {
		Velocity = standardVelocity;
	}

	// Use this for initialization
	void Start () {
		Velocity = standardVelocity;
 	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x += Velocity * Time.deltaTime;
		transform.position = position;
	}


}
