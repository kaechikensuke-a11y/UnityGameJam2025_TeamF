using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float bulletSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
        Offscreen();
    }
    //バレットを飛ばす
    private void Move()
    {
        transform.position += new Vector3(bulletSpeed, 0.0f,0.0f) * Time.deltaTime;
    }
    //弾が画面外に出たら消すたま
    private void Offscreen()
    {
        if(this.transform.position.x > 165.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            Destroy(other.gameObject); // 敵を消す
            Destroy(gameObject);       // 弾も消す
        }
    }
}
