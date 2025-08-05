using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int bulletSpeed = 80;

    private void Update()
    {
        Move();
    }

    // Update is called once per frame
    private void Move()
    {
        transform.position += new Vector3(-bulletSpeed, 0,0) * Time.deltaTime; 
    }
}
