using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[5];
    private int lifePoint = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lifeArray.Length; i++)
        {
            lifeArray[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && lifePoint < lifeArray.Length)
        {
            lifeArray[lifePoint].SetActive(true);
            lifePoint++;
        }
        else if (Input.GetMouseButtonDown(1) && lifePoint > 0)
        {
            lifePoint--;
            lifeArray[lifePoint].SetActive(false);
        }
    }

    public void DecreaseLife()
    {
        if (lifePoint > 0)
        {
            lifePoint--;
            lifeArray[lifePoint].SetActive(false);
        }

        if (lifePoint <= 0)
        {
            Debug.Log("ゲームオーバー！");
        }
    }

    // トリガー接触時にライフ減少
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            DecreaseLife();
        }
    }
}
