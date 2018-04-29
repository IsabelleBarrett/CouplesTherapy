using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject man;
    public GameObject unicorn;

    private long timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        timer += 1;

        if(timer > 100)
        {
            var spawn = Instantiate(man);
            var num = Random.Range(-1000f, 1000f);

            if(num > 0)
            {
                spawn = Instantiate(unicorn);
            }
            
            
            spawn.GetComponent<Zombie>().go = true;
            spawn.SetActive(true);


            timer = 0;
        }
    }
}
