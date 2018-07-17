using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestroyStuff : MonoBehaviour {
    
    public Tilemap tilemap;
    public Tile indestructible;
    public Tile destructible;
    public GameObject explosionAnim;

    public AudioClip explode;
    AudioSource audioSource;

    private Tile tile;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BombExplode(Vector2 worldPos){

        Vector3Int originalCell = tilemap.WorldToCell(worldPos);

        ExplodeCell(originalCell);
        ExplodeCell(originalCell + new Vector3Int(1,0,0));
        ExplodeCell(originalCell + new Vector3Int(0, 1, 0));

        ExplodeCell(originalCell + new Vector3Int(-1, 0, 0));
        ExplodeCell(originalCell + new Vector3Int(0, -1, 0));

    }

    void ExplodeCell(Vector3Int cellPos){
        
       tile =  tilemap.GetTile<Tile>(cellPos);


        if(tile == indestructible){
            return;
            
        }

        if (tile == destructible)
        {
            tilemap.SetTile(cellPos, null);
        }

        audioSource.PlayOneShot(explode, 0.7F);
        Vector3 position = tilemap.GetCellCenterWorld(cellPos);
        Instantiate(explosionAnim, position, Quaternion.identity);
    }
}
