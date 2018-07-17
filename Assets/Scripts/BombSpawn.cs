using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

//This was just made for testing

public class BombSpawn : MonoBehaviour {

    public Tilemap tilemap;
    public GameObject bomb;
    Vector3 worldPos;
    Vector3Int cell;
    Vector3 cellCenter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //        if(Input.GetMouseButtonDown(0)){
        //
        //            worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //            cell = tilemap.WorldToCell(worldPos);
        //            cellCenter = tilemap.GetCellCenterWorld(cell);

        //           Instantiate(bomb, cellCenter, Quaternion.identity);
        //        }
		
	}


}
