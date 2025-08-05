using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
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
        transform.position += new Vector3(bulletSpeed, 0,0) * Time.deltaTime;
    }
    //�e����ʊO�ɏo�����������
    private void Offscreen()
    {
        if(this.transform.position.x > 165.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
