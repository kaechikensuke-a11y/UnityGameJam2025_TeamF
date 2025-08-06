using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{

    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //Spwan‚ğˆê•bŠÔŠu‚Å¶¬‚³‚¹‚é
        InvokeRepeating("Spawn",1.0f,1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ƒ‰ƒ“ƒ_ƒ€‚É“G‚ğ¶¬‚³‚¹‚é
    private void Spawn()
    {
        // X²‚ğƒ‰ƒ“ƒ_ƒ€‚ÉAx²‚ÍŒÅ’è
        float randomY = Random.Range(-60.0f, 55.0f);
        float fixedX = 135.0f;
        float fixedZ = 110.0f;
        Vector3 spawnPos = new Vector3(fixedX, randomY, fixedZ);

      //  Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        Quaternion enemyRotation = Quaternion.LookRotation(Vector3.left);

        Instantiate(enemyPrefab, spawnPos, enemyRotation);



    }
}
