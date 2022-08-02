using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //[SerializeField] Vector3[] waypoints;
    //[SerializeField] int index;
    [SerializeField] bool isAbleToWalk;
    [SerializeField] int Health;

    private void Update()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    /*
        private void OnDrawGizmos()
        {
            Gizmos.DrawSphere(waypoints[index],1);
        }
    */
}
