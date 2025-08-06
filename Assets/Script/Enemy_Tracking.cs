using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tracking : MonoBehaviour
{
    private float moveSpeed = 40.0f;
   

    //Enemy‚ª¶¬‚³‚ê‚½‚ç’e‚ğ”­Ë‚·‚é‚æ‚¤‚É‚·‚é
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //Bullet‚ğ¶‚É“®‚©‚·
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }

   
}
