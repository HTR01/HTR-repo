using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    //public float translateAmount = 0.025f;

    public float speed;
    public float clampValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    gameObject.transform.Translate(0, 0, translateAmount);
        // }

        //  if (Input.GetKey(KeyCode.S))
        // {
        //      gameObject.transform.Translate(0, 0, -translateAmount);
        //  }
        //gameObject.transform.position += new Vector3(0, 0, Input.GetAxis("Horizontal"));
        MovePaddle(Input.GetAxis("Vertical"));
        //Debug.Log(Input.GetAxis("Vertical"));
    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedAmount = gameObject.transform.position + new Vector3(0, 0, inputAxisInfo * speed);
        clampedAmount.z = Mathf.Clamp(clampedAmount.z, -clampValue, clampValue);

        gameObject.transform.position = clampedAmount;

      //  gameObject.transform.position += new Vector3(0, 0, inputAxisInfo * speed);
    }
}
