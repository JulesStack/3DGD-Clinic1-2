using System;
using UnityEngine;
using UnityEngine.AI;

namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }


        void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}
