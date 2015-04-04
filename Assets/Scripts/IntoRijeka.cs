using UnityEngine;
using System.Collections;


public class IntoRijeka : MonoBehaviour
{

    // Update is called once per frame void Update () { TapSelect(); }
    void Update()
    {
        TapSelect();
        PlayerPrefs.Save();
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
                if (hit.transform.name == "Cube1")
                {
                    Application.LoadLevel("RijekaInfo");
                }
            }
        }
    }
}

       
	

	

