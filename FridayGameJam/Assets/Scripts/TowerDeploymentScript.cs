using UnityEngine;
using System.Collections;

public class TowerDeploymentScript : MonoBehaviour {

    public KeyCode DeployTower = KeyCode.Space;
    public GameObject tower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(DeployTower))
        {
            Instantiate(tower,transform.position,Quaternion.identity);
        }
	}
}
