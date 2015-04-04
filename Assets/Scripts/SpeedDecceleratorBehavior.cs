using UnityEngine;
using System.Collections;

public class SpeedDecceleratorBehavior : MonoBehaviour {

	void OnTriggerEnter2D() {
		Debug.Log("ovdje");
		CameraBehavior camera = Camera.main.GetComponent<CameraBehavior>();
		camera.Velocity = 6;
	}
}
