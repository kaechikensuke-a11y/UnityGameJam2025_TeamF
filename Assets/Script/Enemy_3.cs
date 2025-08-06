using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_3 : MonoBehaviour
{
    private float moveSpeed = 120.0f;
    public AudioClip enemySound;

    private AudioSource audioSource;

   

    //Enemy���������ꂽ��e�𔭎˂���悤�ɂ���
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (enemySound != null && audioSource != null)
        {
            audioSource.PlayOneShot(enemySound);
        }



    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Offscreen();
    }
    //Bullet�����ɓ�����
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }

    

    private void Offscreen()
    {
        if (this.transform.position.x < -180.0f)
        {
            Destroy(this.gameObject);
        }
    }
}


