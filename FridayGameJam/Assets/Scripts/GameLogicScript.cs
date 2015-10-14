using UnityEngine;
using System.Collections;

/// <summary>
/// zatim prazdne
/// </summary>
public class GameLogicScript : MonoBehaviour {

    public int Lives = 20; 

	void Start () {
        BaseLife.lives = Lives;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public static void restartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
