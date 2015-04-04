using UnityEngine;
using System.Collections;


public class BackToMainTerrain : MonoBehaviour
{

    // Update is called once per frame void Update () { TapSelect(); }
    void Update()
    {
        TapSelect();
    }

    void TapSelect()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Capsule")
                    Application.LoadLevel("BasicScene3");
            }
        }
    }
}

       
	

	



