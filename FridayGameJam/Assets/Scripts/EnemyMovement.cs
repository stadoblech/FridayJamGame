using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public float speed = 0.5f;
    private GameObject path;
    private int nextCheckpoint = 1;
    private Transform nextPoint;

    void Start () {
        path = PathPickerScript.GetPath();
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform t in path.transform)
        {
            if (t.name == nextCheckpoint.ToString())
            {
                transform.position = Vector2.MoveTowards(transform.position,t.position,speed * Time.deltaTime);
            }
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "checkpoint")
        {
            nextCheckpoint++;
        }
        
        if (coll.tag == "end")
        {
            Destroy(gameObject);
        }
        
    }
}
