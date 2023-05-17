using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMeshController : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
       agent  = GetComponent<NavMeshAgent>();
        StartCoroutine(NextRound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator NextRound()
    {
        yield return new WaitForSeconds(5f);

        agent.destination = target.position;
    }
}
