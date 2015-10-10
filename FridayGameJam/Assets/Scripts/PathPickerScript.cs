using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PathPickerScript : MonoBehaviour {

    public List<GameObject> Paths;

    public KeyCode NextWave = KeyCode.KeypadEnter;

    public float respawnCooldown = 0.5f;
    public GameObject enemy;

    public int numberOfWaves;
    public int numberOfEnemies;

    //int vawesCounter;
    int enemiesCounter;

    private static GameObject pickedPath;
    private float respawnTimer;

    // Use this for initialization
	void Start () {
        respawnTimer = respawnCooldown;

        
        pickPath();
        createEnemy();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (numberOfWaves > 0)
        {
            if (enemiesCounter > 0)
            {
                if (respawnTimer <= 0)
                {
                    respawnTimer = respawnCooldown;
                    createEnemy();
                }

                respawnTimer -= Time.deltaTime;
            }
            else if (enemiesCounter <= 0)
            {
                if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
                {
                    pickPath();
                    numberOfWaves--;
                }
                //pickPath();
            }
        }

        
	}

    public static GameObject GetPath()
    {
        
        return pickedPath;
    }

    void createEnemy()
    {
        GameObject start = GetPath().transform.Find("start").gameObject;
        Instantiate(enemy,start.transform.position,Quaternion.identity);
        enemiesCounter--;
    }

    void pickPath()
    {
        foreach (GameObject o in Paths)
        {
            o.active = true;
        }

        enemiesCounter = numberOfEnemies;
        pickedPath = Paths[Random.Range(0, Paths.Count)];

        foreach (GameObject o in Paths)
        {
            o.active = false;
            pickedPath.active = true;
        }
    }
}
