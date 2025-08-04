using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 10.0f;

    public GameObject bulletPrefab;
    public GameObject firingPosition;
    
    //Enemy���������ꂽ��e�𔭎˂���悤�ɂ���
    private void Start()
    {
        Shot();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //Bullet�����ɓ�����
    private void Move()
    {
        transform.position += new Vector3(0, 0, -moveSpeed) * Time.deltaTime;
    }

    private void Shot()
    {
        Instantiate(bulletPrefab,firingPosition.transform.transform.position,transform.rotation)
    }
}
