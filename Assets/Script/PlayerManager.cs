using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject Gameclear;
    private float speed = 60.0f;//移動速度
    public AudioClip bulletSound;//発射したときの効果音
    private AudioSource audioSource;//音を再生するためのオーディオソース


    public GameObject bulletPrefab;
    public GameObject firingPosition;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
        //移動させるこーど
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
            Instantiate(bulletPrefab,//生成したいオブジェクト
                firingPosition.transform.position,//位置
                firingPosition.transform.rotation);
              
            audioSource.PlayOneShot(bulletSound);//サウンドを再生
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            Gameclear.SetActive(true);
        }
    }
}
