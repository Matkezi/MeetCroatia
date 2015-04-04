using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	private int numOfBGPanels = 4;

	void OnTriggerEnter2D(Collider2D collider) {

		if (collider is BoxCollider2D) {
			BoxCollider2D boxCollider = (BoxCollider2D)collider;
			Vector3 position = collider.transform.position;
			float widthOfObject = boxCollider.size.x;
			position.x += numOfBGPanels * widthOfObject;
			collider.transform.position = position;

		}
	}
}
