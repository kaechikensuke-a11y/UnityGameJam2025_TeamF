using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //EnemyÇç∂Ç…ìÆÇ©Ç∑
    private void Move()
    {
        transform.position += new Vector3(0, 0, -moveSpeed) * Time.deltaTime;
    }
}
