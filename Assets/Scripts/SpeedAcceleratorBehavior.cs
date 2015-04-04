using UnityEngine;
using System.Collections;

public class SpeedAcceleratorBehavior : MonoBehaviour {

	void OnTriggerEnter2D() {
		CameraBehavior camera = Camera.main.GetComponent<CameraBehavior>();
		camera.returnToStandardVelocity();
	}
}
