using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathPickerScript : MonoBehaviour {

    public List<GameObject> Paths;
    public float respawnCooldown = 0.5f;
    public GameObject enemy;
    
    private static GameObject pickedPath;


    
    private float respawnTimer;

    // Use this for initialization
	void Start () {
        respawnTimer = respawnCooldown;
        pickedPath = Paths[Random.Range(0,Paths.Count)];
        
        foreach (GameObject o in Paths)
        {
            o.active = false;
            pickedPath.active = true;
        }
        createEnemy();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (respawnTimer <= 0)
        {
            respawnTimer = respawnCooldown;
            createEnemy();
        }

        respawnTimer -= Time.deltaTime;
	}

    public static GameObject GetPath()
    {
        
        return pickedPath;
    }

    void createEnemy()
    {
        GameObject start = GetPath().transform.Find("start").gameObject;
        Instantiate(enemy,start.transform.position,Quaternion.identity);
    }
}
