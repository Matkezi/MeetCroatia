using UnityEngine;
using System.Collections;

public class Survive : MonoBehaviour {
    public GameObject FPCamera;
    Vector3 cameraPosition;
    Quaternion cameraRotation;
    public void storeCamera()
    {
        // Save coordinates:
        cameraPosition = FPCamera.gameObject.transform.position;
        cameraRotation = FPCamera.gameObject.transform.rotation;
    }
    public void retrieveCamera()
    {
        // Load coordinates:
        FPCamera.transform.position = cameraPosition;
        FPCamera.transform.rotation = cameraRotation;
    }

}
