using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{
    [SerializeField] private int maxDistance;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private float speed;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    
    void DetectPlayer()
    {

        if (Physics2D.Raycast(transform.position - offset , Vector2.left, maxDistance, layerMask))
        {
            transform.Translate((player.transform.position - transform.position).normalized * speed);
          

        }
    }

    private void Update()
    {
        DetectPlayer();
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position , transform.position + Vector3.left);
    }
}

