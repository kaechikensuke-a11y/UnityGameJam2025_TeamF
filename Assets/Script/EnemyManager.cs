using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float moveSpeed = 60.0f;
    public AudioClip enemySound;
    public AudioClip Death;

    private AudioSource audioSource;

    public GameObject bulletPrefab;
    public GameObject firingPosition;
    
    //Enemy���������ꂽ��e�𔭎˂���悤�ɂ���
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Shot();
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

    private void Shot()
    {
        Instantiate(bulletPrefab, firingPosition.transform.transform.position,Quaternion.Euler(0.0f, 0.0f, 90.0f));//��]
        audioSource.PlayOneShot(enemySound);
    }

    private void Offscreen()
    {
        if (this.transform.position.x < -180.0f)
        {
            Destroy(this.gameObject);
            audioSource.PlayOneShot(Death);
        }
    }
}
