using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject oceanTile;
    public GameObject missTile;
    public GameObject hitTile;
    public int size;
    private Tile[,] map;

	// Use this for initialization
	void Start () {
        createMap();
        dsiplayMap();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void createMap()
    {
        map = new Tile[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                Tile t = new Tile();
                if (Random.Range(0, 100) > 60)
                {
                    t.typeOfTile = tileType.Hit;
                }
                else
                {
                    t.typeOfTile = tileType.Ocean;
                }
                map[x, z] = t;
            }
        }
    }

    void dsiplayMap()
    {
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                switch (map[x, z].typeOfTile)
                {
                    case tileType.Ocean:
                        Instantiate(oceanTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case tileType.Miss:
                        Instantiate(missTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case tileType.Hit:
                        Instantiate(hitTile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                }
            }
        }
    }
}
