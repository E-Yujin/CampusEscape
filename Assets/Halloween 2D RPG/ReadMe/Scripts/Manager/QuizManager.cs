using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public QuestManager QM;
    public TalkManager TM;
    public Sprite [] QuizPage;
    public GameObject Answer;
    public InputField A_IF;
    public int isCorrect = 2;

    public string ans;

    public Sprite GetQuizImage(int questID)
    {
        switch (questID)
        {
            case 30:
                return QuizPage[0];
            case 50:
                return QuizPage[1];
            case 80:
                return QuizPage[2];
            case 100:
                return QuizPage[3];
            case 140:
                return QuizPage[4];
            case 170:
                return QuizPage[5];
            case 180:
                return QuizPage[6];
            case 190:
                return QuizPage[7];
        }
        return null;
    }
    public Sprite GetQuizImage()
    {
        switch (QM.questId)
        {
            case 30:
                return QuizPage[0];
            case 50:
                return QuizPage[1];
            case 80:
                return QuizPage[2];
            case 100:
                return QuizPage[3];
            case 140:
                return QuizPage[4];
            case 170:
                return QuizPage[5];
            case 180:
                return QuizPage[6];
            case 190:
                return QuizPage[7];
        }
        return null;
    }
    public void Judgement()
    {
        ans = A_IF.text.Replace(" ", "");
        switch (QM.questId)
        {
            case 30:
                if(ans == "257" && isCorrect != 1)
                {
                    isCorrect = 1;//Á¤´ä
                }
                else if(isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;

            case 50:
                if (ans == "È£¹Ú" && isCorrect != 1)
                {
                    isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;

            case 80:
                if (ans == "6250" && isCorrect != 1)
                {
                    isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;

            case 100:
                if (ans == "CITIZEN" || ans == "citizen" || ans == "½ÃÆ¼Áð" || ans == "Citizen")
                {
                    if(isCorrect != 1)
                    isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;
            case 140:
                if (ans == "3974" && isCorrect != 1)
                {
                    isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;
            case 170:
                if (ans == "UFO" || ans == "ufo" || ans == "À¯¿¡ÇÁ¿À" || ans == "À¯žƒÇÁ¿À")
                {
                    if (isCorrect != 1)
                        isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;
            case 180:
                if (ans == "µîÀÜ¹ØÀÌ¾îµÓ´Ù" || ans == "µîÀÜ¹ØÀÌ¾îµÓ´Ù.")
                {
                    if (isCorrect != 1)
                        isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;
            case 190:
                if (ans == "OFF" || ans == "off" || ans == "Off" || ans == "¿ÀÇÁ")
                {
                    if (isCorrect != 1)
                        isCorrect = 1;//Á¤´ä
                }
                else if (isCorrect == 1 || isCorrect == 0)
                {
                    isCorrect = 2;
                }
                else
                {
                    Debug.Log("½ÃÆÈ");
                    isCorrect = 0;//¿À´ä
                }
                break;
        }
        A_IF.text = "";
        ans = "";
    }
}
