using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[5];//�n�[�gUI
    private int lifePoint = 5;//���݂̃��C�t��
    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��ɑS�n�[�g��\��
        for (int i = 0; i < lifeArray.Length; i++)
        {
            lifeArray[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //���N���b�N�Ńn�[�g��������B
        if (Input.GetMouseButtonDown(0) && lifePoint <lifeArray.Length)
        {
            lifePoint++;
            lifeArray[lifePoint - 1].SetActive(true);
        }
        //�E�N���b�N�Ńn�[�g������B
        else if (Input.GetMouseButtonDown(1) && lifePoint > 0)
        {
            lifeArray[lifePoint - 1].SetActive(false);
            lifePoint--;
        }
    }
 
}
