using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tracking : MonoBehaviour
{
    private float moveSpeed = 40.0f;
   

    //Enemy���������ꂽ��e�𔭎˂���悤�ɂ���
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //Bullet�����ɓ�����
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }

   
}
