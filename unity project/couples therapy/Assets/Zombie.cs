using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    public GameObject player;

    private float speed = 3f;
    public bool go = false;

	// Use this for initialization
	void Start () {

        var rotation = Quaternion.Euler(player.transform.position - transform.position);

        var x = 0f;
        var y = 0f;
        var z = 0f;

        var angle = Random.Range(0f, 10000f);


        var distance = Random.Range(100f, 200f);

        x = distance * Mathf.Sin(angle);
        z = distance * Mathf.Cos(angle);


        y = Random.Range(-10, 10);



        //transform.SetPositionAndRotation(new Vector3(x, y, z), rotation);
        transform.position = new Vector3(x, y, z);
        transform.Rotate(new Vector3(Random.Range(0f,360f), Random.Range(0f, 360f), Random.Range(0f, 360f)));
    
        

        

    }

    // Update is called once per frame
    void Update () {


        if (go)
        {
            if ((transform.position - player.transform.position).magnitude > 0)
            {
                transform.position = (Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime));

            }
        }
      



    }
}
