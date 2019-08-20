using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManage : MonoBehaviour
{
    public static ballManage instance;
    private List<int> potentialAngles = new List<int> { 45, 135, 225, 270 };

    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    public void SpawnBall()
    {
        int angleIndex = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(0, potentialAngles[angleIndex], 0));
    }


    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
