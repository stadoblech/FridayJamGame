using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public Transform Player;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Player.position.x,Player.position.y, -10);
	}
}
