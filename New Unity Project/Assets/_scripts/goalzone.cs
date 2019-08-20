using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalzone : MonoBehaviour
{
    public string teamname;
    public scoring sm;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        ballManage.instance.SpawnBall();

        if (teamname == "Pink")
        {
            sm.PinkScore();
        }

        if (teamname == "Purple")
        {
            sm.PurpleScore();
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
