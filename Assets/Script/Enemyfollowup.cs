using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollowup : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
