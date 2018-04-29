using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject man;

    private long timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        timer += 1;

        if(timer > 100)
        {
            var local_man = Instantiate(man);
            local_man.GetComponent<Zombie>().go = true;
            local_man.SetActive(true);


            timer = 0;
        }
    }
}
