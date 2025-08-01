using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject GoalText;
    private float speed = 5.0f;
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
        GoalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GoalText.SetActive(true);
        }

    }
}
