using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    [SerializeField] Transform telportTarget;
    [SerializeField] GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            player.transform.position = telportTarget.transform.position;
        
    }
}
