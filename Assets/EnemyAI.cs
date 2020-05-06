using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody rb;
    public NavMeshAgent agent;
    public Transform target;
    
    void Start()
    {
        //target = PlayerManager.instance.player.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        faceTarget();
        movement();
    }

    void faceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotaion = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotaion, Time.deltaTime * 5f);
    }

    void movement()
    {
        agent.SetDestination(target.position);
        if (gameObject.tag == "Enemy2")
        {
            agent.baseOffset = Mathf.Sin(Mathf.PI * (target.position.x + Time.deltaTime));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hero")
        {

        }
    }

}
