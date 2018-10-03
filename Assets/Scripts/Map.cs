using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject oceanTile;
    public float size;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int x = 0;  x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                Instantiate(oceanTile, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
	}
}
