using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public void LoadGame(){
		Application.LoadLevel("MainView");
	}

    public void ExitGame()
    {
        Application.Quit();
    }


}
