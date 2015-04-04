using UnityEngine;
using System.Collections;

public class CarBehavior : MonoBehaviour {

	public float velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x += velocity * Time.deltaTime;
		transform.position = position;
	}
}
