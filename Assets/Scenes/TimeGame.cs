using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartDelayTime=3;
    float roundStartTime;
    int waitTime;
    bool roundStarted;
    // Start is called before the first frame update
    void Start()
    {
        print("Press Spacebar When You Think The Time IS Up!");
        Invoke("SetNewRandomTime",roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&roundStarted)
            InputRecieved();
    }

    void InputRecieved()
    {
        roundStarted=false;
        float playerWaitTime=Time.time-roundStartTime;
        float error=Mathf.Abs(waitTime-playerWaitTime);
        print("You Waited For : "+playerWaitTime+" \nThat's "+error+" seconds off.");
        Invoke("SetNewRandomTime",roundStartDelayTime);
    }

    void SetNewRandomTime()
    {
        waitTime=Random.Range(5,21);
        roundStartTime=Time.time; 
        roundStarted=true;
        print(waitTime+"s.");
        
    }
}
