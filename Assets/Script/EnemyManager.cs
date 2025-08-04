using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 40.0f;
    public AudioClip enemySound;

    private AudioSource audioSource;

    public GameObject bulletPrefab;
    public GameObject firingPosition;
    
    //EnemyÇ™ê∂ê¨Ç≥ÇÍÇΩÇÁíeÇî≠éÀÇ∑ÇÈÇÊÇ§Ç…Ç∑ÇÈ
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Shot();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //BulletÇç∂Ç…ìÆÇ©Ç∑
    private void Move()
    {
        transform.position += new Vector3(0, 0, -moveSpeed) * Time.deltaTime;
    }

    private void Shot()
    {
        Instantiate(bulletPrefab, firingPosition.transform.transform.position,Quaternion.Euler(90.0f, 0.0f, 0.0f));//âÒì]
        audioSource.PlayOneShot(enemySound);
    }
}
