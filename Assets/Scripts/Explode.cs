using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {



    public float countTillExplode = 3f;
//    public GameObject explosionAnim;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        countTillExplode -= Time.deltaTime;
		
        if(countTillExplode <= 0f){
            

//            Instantiate(explosionAnim, transform.position, Quaternion.identity);
            FindObjectOfType<DestroyStuff>().BombExplode(transform.position);
            Destroy(gameObject);
        }
	}
}
