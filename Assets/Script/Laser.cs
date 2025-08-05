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
    }
    //ƒoƒŒƒbƒg‚ð”ò‚Î‚·
    private void Move()
    {
        transform.position += new Vector3(bulletSpeed, 0,0) * Time.deltaTime;
    }
}
