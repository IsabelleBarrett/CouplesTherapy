using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicmove : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((transform.position - player.transform.position).magnitude > 0)
        {
            transform.position = (Vector3.MoveTowards(transform.position, player.transform.position - new Vector3(0,2,0), 3f * Time.deltaTime));

        }
    }
}
