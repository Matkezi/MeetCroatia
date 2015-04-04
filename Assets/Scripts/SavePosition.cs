using UnityEngine;
using System.Collections;

public class SavePosition : MonoBehaviour {

    GameObject player = GameObject.Find("Main Camera");
    void PlayerIsSwitchingScene (){
        PlayerPrefs.SetFloat("X", player.transform.position.x);
        PlayerPrefs.SetFloat("Y", player.transform.position.y);
        PlayerPrefs.SetFloat("Z", player.transform.position.z);
        // Player Switches Scene
    }

    void PlayerIsComingBack (){
        // Player comes back
        //player.transform.position.x = PlayerPrefs.GetFloat("X");
        //player.transform.position.y = PlayerPrefs.GetFloat("Y");
        //player.transform.position.z = PlayerPrefs.GetFloat("Z");
    }
}