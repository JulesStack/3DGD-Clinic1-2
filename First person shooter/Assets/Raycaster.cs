using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour {
    public bool canSeePlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Raycaster ray = new Raycaster(transform.position - Player.position);
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, 100);
        if (hit.collider)
        {
            if (hit.collider.tag == "character")
                canSeePlayer = true;
            else if (hit.collider.tag != "character")
                canSeePlayer = false;
        
        }

        if (canSeePlayer == true)
        {
            print("Enemy can see the player");
        }
        else if (canSeePlayer == false)
        {
            print("Enemy can't see the player");
        }

    }
}
