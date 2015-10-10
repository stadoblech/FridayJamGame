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
        if (GetComponent<Rigidbody2D>().isKinematic)
        {
            speed *= 10;
        }
	}
	
	// Update is called once per frame
	void Update () {
        playerMovement();
	}

    private void playerMovement()
    {
        if (!GetComponent<Rigidbody2D>().isKinematic)
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
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        }
    }

    
}
