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
    //�o���b�g���΂�
    private void Move()
    {
        transform.position += new Vector3(bulletSpeed, 0.0f,0.0f) * Time.deltaTime;
    }
    //�e����ʊO�ɏo�����������
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
            Destroy(other.gameObject); // �G������
            Destroy(gameObject);       // �e������
        }
    }
}
