using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetRank : MonoBehaviour
{
    public Text[] RankId;
    public Text[] Rankpass;
    public GameObject LoadingT;
    int j = 0;
    const string URL = "https://docs.google.com/spreadsheets/d/1kPwdVfzrjiEWeehWrRzpgAppaBbVclgmtS6eX4L_nJ8/export?format=tsv&gid=651088418&range=A2:B";

    private void Start()
    {
        StartCoroutine(Getrank());
    }
    public IEnumerator Getrank()
    {
        LoadingT.SetActive(true);
        UnityWebRequest www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        //Debug.Log(data);
        if(data != "")
        {
            string[] result = data.Split('\n', '\t');

            for (int i = 0; i < result.Length && j < 10; i++)
            {
                //Debug.Log(result.Length);
               // Debug.Log(result[i] + " " + result[i + 1]);
                RankId[j].text = result[i];
                Rankpass[j].text = result[i + 1];
                i++;
                j++;
            }
            j = 0;
        }

        LoadingT.SetActive(false);
    }

    public void SetRank()
    {
        StartCoroutine(Getrank());
    }
}
