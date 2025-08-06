using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GoalTrigger : MonoBehaviour
{
    public AudioClip endingBGM; // �G���f�B���OBGM
    public Text goalText; // �u�S�[���I�v�ƕ\�����邽�߂�UI Text

    private AudioSource audioSource;
    // �ړI�n�̍��W
    public Vector3 targetPosition = new Vector3(0, 0, 0);
    // �ړ����x
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        goalText.enabled = false; // ���߂͔�\��
    }

    // Update is called once per frame
    void Update()
    {
        // Cube���ړI�n�ɓ�������܂ňړ�
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // �ړI�n�ɓ��������ꍇ�̃`�F�b�N
        if (transform.position == targetPosition)
        {
            Debug.Log("�ړI�n�ɓ������܂����I");
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
        // �u�S�[���I�v�ƕ\��
        goalText.enabled = true;
        goalText.text = "CLEAR!";

        //�G���f�B���OBGM���Đ�
        //audioSource.clip = endingBGM;
        //audioSource.Play();

        // 5�b�҂�
        yield return new WaitForSeconds(1f);

        // �V�[�����ēǂݍ��݂��čŏ������蒼��
        SceneManager.LoadScene("GameClear");
    }
}

