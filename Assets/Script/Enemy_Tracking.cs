using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tracking: MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int moveSpeed;
 
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,player.transform.position,moveSpeed * Time.deltaTime)
    }
}
