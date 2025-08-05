using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    private int bulletSpeed = 80;

    private void Update()
    {
        Move();
        Offscreen();
    }

    // Update is called once per frame
    private void Move()
    {
        transform.position += new Vector3(-bulletSpeed, 0,0) * Time.deltaTime;
    }

    private void Offscreen()
    {
        if(this.transform.position.x < -180.0f )
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
