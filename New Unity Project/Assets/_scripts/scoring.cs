using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour
{


    public int purple;
    public int pink;
    private UImanager uiMan;


    private void Start()
    {
        uiMan = GetComponent<UImanager>();
    }

    public void PurpleScore()
    {
        purple += 1;
        uiMan.UpdateScore(pink, purple);
    }

    public void PinkScore()
    {
        pink++;
        uiMan.UpdateScore(pink, purple);
    }
}
