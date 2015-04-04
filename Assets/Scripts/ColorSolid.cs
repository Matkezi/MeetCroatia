using UnityEngine;
using System.Collections;



public class ColorSolid : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}