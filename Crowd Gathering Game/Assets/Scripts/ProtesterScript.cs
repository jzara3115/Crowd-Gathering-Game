using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Renderer))]
public class ProtesterScript : MonoBehaviour
{
    private bool follow = false;
    public float followSpeed;

    public Transform target;
    NavMeshAgent nav;

    void Awake()
    {
        nav = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //Overlap Sphere positioning and setting
        Collider[] check = Physics.OverlapSphere(transform.position, 3f);

        //When player tag in sphere, follow is true
        foreach (var checks in check)
        {
            if (checks.tag == "player") {
                follow = true;
            }
        }

        //follow player
        if (follow == true)
        {
            nav.SetDestination(target.position);
        }
    }
}
