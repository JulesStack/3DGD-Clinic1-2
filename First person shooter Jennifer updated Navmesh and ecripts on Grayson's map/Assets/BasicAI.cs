using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
    public bool canSeePlayer;

	void Start()
	{

		agent = GetComponent<NavMeshAgent>();

	}


	void Update () {

        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, 100);
        if (hit.collider)
        {
            if (hit.collider.tag == "character")
                canSeePlayer = true;
            else if (hit.collider.tag != "character")
                canSeePlayer = false;

        }
        /*
        if (canSeePlayer == true)
        {
            print("Enemy can see the player");
        }
        else if (canSeePlayer == false)
        {
            print("Enemy can't see the player");
        }
        */

    


        if(canSeePlayer==true)
		agent.SetDestination(target.position);
        else
            transform.LookAt(target);
    }
    
}
