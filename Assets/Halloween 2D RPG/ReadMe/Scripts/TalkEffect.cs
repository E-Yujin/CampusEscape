using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkEffect : MonoBehaviour
{
    public int CharPerSec;
    public GameObject EndCursor;
    public bool isAnim;

    string targetmsg;
    Text msgText;
    AudioSource audioSource;
    int index;
    float interval;

    private void Awake()
    {
        msgText = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }
    public void SetMsg(string msg)
    {
        if (isAnim)
        {
            msgText.text = targetmsg;
            CancelInvoke();
            EffectEnd();
        }
        else
        {
            targetmsg = msg;
            EffectStart();
        }
    }

    void EffectStart()
    {
        msgText.text = "";
        index = 0;
        EndCursor.SetActive(false);

        //Start Animation
        interval = 1.0f / CharPerSec;

        isAnim = true;

        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        //End Animation
        if(msgText.text == targetmsg)
        {
            EffectEnd();
            return;
        }
        msgText.text += targetmsg[index];

        //Sound
        if (targetmsg[index] != ' ' || targetmsg[index] != '.')
            audioSource.Play();

        index++;

        //Recursive
        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        isAnim = false;
        EndCursor.SetActive(true);
    }
}
