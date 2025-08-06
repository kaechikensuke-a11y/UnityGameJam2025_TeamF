using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GoalTrigger : MonoBehaviour
{
    public AudioClip endingBGM; // エンディングBGM
    public Text goalText; // 「ゴール！」と表示するためのUI Text

    private AudioSource audioSource;
    // 目的地の座標
    public Vector3 targetPosition = new Vector3(0, 0, 0);
    // 移動速度
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        goalText.enabled = false; // 初めは非表示
    }

    // Update is called once per frame
    void Update()
    {
        // Cubeが目的地に到着するまで移動
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // 目的地に到着した場合のチェック
        if (transform.position == targetPosition)
        {
            Debug.Log("目的地に到着しました！");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(HandleGoal());
        }
    }

    private IEnumerator HandleGoal()
    {
        // 「ゴール！」と表示
        goalText.enabled = true;
        goalText.text = "CLEAR!";

        //エンディングBGMを再生
        //audioSource.clip = endingBGM;
        //audioSource.Play();

        // 5秒待つ
        yield return new WaitForSeconds(1f);

        // シーンを再読み込みして最初からやり直す
        SceneManager.LoadScene("GameClear");
    }
}

