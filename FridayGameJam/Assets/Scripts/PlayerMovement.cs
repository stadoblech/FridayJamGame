using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public KeyCode UpMovement = KeyCode.UpArrow;
    public KeyCode downMovement = KeyCode.DownArrow;
    public KeyCode LeftMovement = KeyCode.LeftArrow;
    public KeyCode RighMovement = KeyCode.RightArrow;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        playerMovement();
	}

    private void playerMovement()
    {
        Vector2 vel = GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKey(UpMovement))
        {
            vel.y += speed;
        }
        if (Input.GetKey(downMovement))
        {
            vel.y -= speed;
        }
        if (Input.GetKey(RighMovement))
        {
            vel.x += speed;
        }
        if (Input.GetKey(LeftMovement))
        {
            vel.x -= speed;
        }

        GetComponent<Rigidbody2D>().velocity = vel;
    }

    
}
