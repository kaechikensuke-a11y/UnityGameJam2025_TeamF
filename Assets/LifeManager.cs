using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[5];//ハートUI
    private int lifePoint = 5;//現在のライフ数
    // Start is called before the first frame update
    void Start()
    {
        // 最初に全ハートを表示
        for (int i = 0; i < lifeArray.Length; i++)
        {
            lifeArray[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックでハートが増える。
        if (Input.GetMouseButtonDown(0) && lifePoint <lifeArray.Length)
        {
            lifePoint++;
            lifeArray[lifePoint - 1].SetActive(true);
        }
        //右クリックでハートが減る。
        else if (Input.GetMouseButtonDown(1) && lifePoint > 0)
        {
            lifeArray[lifePoint - 1].SetActive(false);
            lifePoint--;
        }
    }
 
}
