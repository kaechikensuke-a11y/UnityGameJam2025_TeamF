using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject Gameclear;
    private float speed = 60.0f;//�ړ����x
    public AudioClip bulletSound;//���˂����Ƃ��̌��ʉ�
    private AudioSource audioSource;//�����Đ����邽�߂̃I�[�f�B�I�\�[�X


    public GameObject bulletPrefab;
    public GameObject firingPosition;
    public GameObject[]lifeArray=new GameObject[3];
    private int lifePoint = 3;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        for (int i = 0; i < lifeArray.Length; i++)
        {
            lifeArray[i].SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Shot();
        //�ړ������邱�[��
        if (Input.GetKey("w"))
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }





    }
    private void Shot()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(bulletPrefab,//�����������I�u�W�F�N�g
                firingPosition.transform.position,//�ʒu
                firingPosition.transform.rotation);
              
            audioSource.PlayOneShot(bulletSound);//�T�E���h���Đ�
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            Gameclear.SetActive(true);
        }
    }

    public void DecreaseLife()
    {
        if (lifePoint > 0)
        {
            lifePoint--;
            lifeArray[lifePoint].SetActive(false);
        }
        if(lifePoint <= 0)
        {
            Debug.Log("�Q�[���I�[�o�[");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            DecreaseLife();
        }
    }
}
