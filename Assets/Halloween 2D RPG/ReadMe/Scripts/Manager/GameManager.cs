using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questmanager;
    public QuizManager quizmanager;
    public MapManager mapmanager;
    public SoundManager soundmanager;
    public PlayerAction playerControll;

    public Animator talkPanel;
    public Image portraitImg;
    public Animator portraitAnim;
    public TalkEffect talk;
    public Text ObjName;
    public Text questText;
    public GameObject scanObject;
    public GameObject menuSet;
    public GameObject player;
    public int talkIndex;
    public bool isAction;
    public Sprite prePortrait;
    public GameObject MainPage;

    public GameObject QuizManager;
    public Image quizImg;
    public GameObject QuizIMG;
    public GameObject NPC1;
    public GameObject[] subNPC;
    public AudioSource ringing;
    public GameObject player_in_pumkin;
    public GameObject[] ActionButton;
    public GameObject samulham;
    public bool isim;
    public bool isgyo;
    public GameObject Warn;
    public Text Warn_M;
    public GameObject[] Gomain;
    public bool is11000;

    public GameObject BlackOut;

    float x, y;
    int i;
    string talkData;



    void Start()
    {
        questText.text = questmanager.CheckQuest();
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            SubMenuActive();
        }
    }
    public void SubMenuActive()
    {
        if (menuSet.activeSelf)
            menuSet.SetActive(false);
        else
            menuSet.SetActive(true);
    }
    public void Action(GameObject scanObj)
    {
       
        //Get Current Object
        scanObject = scanObj;

        //MapData mapD = scanObject.GetComponent<MapData>();
        ObjData objData = scanObject.GetComponent<ObjData>();
        ObjName.text = objData.name;

        if (objData.id == 6000)
        {
            mapmanager.MapMove(objData.name);
            soundmanager.StartES(1);
            if (questmanager.questId + questmanager.questActionIndex == 123 || questmanager.questId + questmanager.questActionIndex == 13) questmanager.CheckQuest(6000);
            if (questmanager.questId + questmanager.questActionIndex == 124)
            {
                Talk(objData.id, objData.isNpc);
                talkPanel.SetBool("isShow", isAction);
            }
            return;
        }
        if (objData.id == 11000)
        {
            is11000 = true;
        }
        else is11000 = false;

        if (questmanager.questList[questmanager.questId].questName.Split(':')[1] == "1" //퀴즈가 있는 퀘스트이고
            && objData.id == questmanager.questList[questmanager.questId].npcId[0] //퀴즈가 있는 오브젝트를 선택했다면
            )
        {
            if(talkIndex != 4)
            Quiz();
        }

        Talk(objData.id, objData.isNpc);

        //Visible Talk for Action
        talkPanel.SetBool("isShow", isAction);
    }

    public void Quiz()
    {
        quizImg.sprite = quizmanager.GetQuizImage();
        QuizManager.SetActive(true);
        QuizIMG.SetActive(true);

        if (talkIndex != 0 && talkIndex != 4 && !talk.isAnim)//첫대사 이후로 실행, 끝에 다다르면 실행하지 않음
        {
            quizmanager.Judgement();
            switch (quizmanager.isCorrect)
            {
                case 0://오답
                    talkIndex = 1;
                    break;
                case 1://정답
                    talkIndex = 3;
                    QuizManager.SetActive(false);
                    QuizIMG.SetActive(false);
                    quizmanager.isCorrect = 2;
                    break;
                case 2:
                    break;
            }
        }
    }

    public void Talk(int id, bool isNpc)
    {
        //Set Talk Data
        int questTalkIndex = 0;
        talkData = "";



        if (talk.isAnim)
        {
            soundmanager.StopES(4);
            if (isim) ObjName.text = "나";
            if (isgyo) ObjName.text = "교주";
            talk.SetMsg("");
            return;
        }
        else
        {
            questTalkIndex = questmanager.GetQuestTalkIndex(id);
            talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        }

        //End Talk
        if (talkData == null)
        {
            talkIndex = 0;
            questmanager.gyojublah = false;
            questmanager.getblah = false;
            isAction = false;
            questText.text = questmanager.CheckQuest(id);
            QuizManager.SetActive(false);
            QuizIMG.SetActive(false);
            questmanager.Story();
            questmanager.Object_Controll();
            if(questmanager.questId + questmanager.questActionIndex == 15)
            {
                questmanager.Opening();
            }

            if (questmanager.questId + questmanager.questActionIndex == 130 && is11000 == true)
            {
                BlackOut.SetActive(true);
                player_in_pumkin.SetActive(false);
                player.SetActive(true);
                Invoke("GoMain", 4);
            }
            return;
        }

        //Continue Talk
        if (talkData.Contains(":"))
        {
            talk.SetMsg(talkData.Split(':')[0]);
            if(int.Parse(talkData.Split(':')[1]) >= 1000 && int.Parse(talkData.Split(':')[1]) < 2000)
            {
                ObjName.text = "나";
                isim = true;
                isgyo = false;
                i = int.Parse(talkData.Split(':')[1]);
                id = i - i % 10;
                i = i - id;
                portraitImg.sprite = talkManager.GetPortrait(id, i);
            }
            else if(int.Parse(talkData.Split(':')[1]) >= 2000)
            {
                ObjName.text = "교주";
                isgyo = true;
                isim = false;
                i = int.Parse(talkData.Split(':')[1]);
                id = i - i % 10;
                i = i - id;
                portraitImg.sprite = talkManager.GetPortrait(id, i);
            }
            else
            {
                if(questmanager.questId == 10 ) ObjName.text = "???";
                isim = false;
                isgyo = false;
                portraitImg.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split(':')[1]));
            }

            portraitImg.color = new Color(1, 1, 1, 1);

            if (prePortrait != portraitImg.sprite)
            {
                portraitAnim.SetTrigger("doEffect");
                prePortrait = portraitImg.sprite;
            }

        }
        else
        {
            talk.SetMsg(talkData);
            if (questmanager.gyojublah || questmanager.questId+questmanager.questActionIndex == 124) ObjName.text = "신자들";
            isim = false;
            isgyo = false;
            portraitImg.color = new Color(1, 1, 1, 0);
        }
        isAction = true;

        questmanager.Object_Controll();

        questmanager.Story();

        if (questmanager.questList[questmanager.questId].questName.Split(':')[1] == "1" && QuizManager.activeSelf == true && talkIndex == 2)
        {
            Debug.Log("왜 이래");
            talkIndex = 3;
            quizmanager.isCorrect = 0;
        }


        talkIndex++;

    }

    public void GameLoad(string x, string y, string questId, string QAI)
    {
        Gomain[5].SetActive(false);
        questmanager.questId = int.Parse(questId);
        questmanager.questActionIndex = int.Parse(QAI);

        subNPC[4].SetActive(true);
        subNPC[4].transform.position = new Vector3(22.08186f, -61.20826f, 0);
        if (questmanager.questId + questmanager.questActionIndex >= 71 && questmanager.questId + questmanager.questActionIndex < 160)
        {
            if (questmanager.questId + questmanager.questActionIndex >= 72) subNPC[4].SetActive(false);
            player.SetActive(false);
            player_in_pumkin.SetActive(true);
            player_in_pumkin.transform.position = new Vector3(float.Parse(x), float.Parse(y), 0);
            ActionButton[0].SetActive(false);
            ActionButton[1].SetActive(true);
        }
        else 
        {
            player.SetActive(true);
            player_in_pumkin.SetActive(false);
            player.transform.position = new Vector3(float.Parse(x), float.Parse(y), 0);
            ActionButton[0].SetActive(true);
            ActionButton[1].SetActive(false);
        }



        if (questmanager.questId == 10)
        {
            questmanager.isOpening = true;
            if(questmanager.questActionIndex == 4)
            questmanager.Final();
        }
        questmanager.Story();
        questmanager.Object_Controll();
        questText.text = questmanager.CheckQuest();
        MainPage.SetActive(false);
        GameBGM();
    }
    public void NewGame()
    {
        player.SetActive(true);
        ActionButton[0].SetActive(true);
        ActionButton[1].SetActive(false);
        NPC1.SetActive(true);
        subNPC[0].SetActive(true);
        subNPC[1].SetActive(true);
        subNPC[2].SetActive(true);
        subNPC[3].SetActive(true);
        subNPC[4].SetActive(true);
        subNPC[5].SetActive(true);
        NPC1.transform.position = new Vector2(5.541854f, -25.49826f);
        talkIndex = 0;
        player.transform.position = new Vector3(3.541f, -28.227f, 0);
        questmanager.questId = 10;
        questmanager.questActionIndex = 0;
        questText.text = questmanager.CheckQuest();
    }
    public void GoMain()
    {
        if (!isAction)
        {
            BlackOut.SetActive(false);
            soundmanager.StartBGM(0);
            Gomain[0].SetActive(true);
            Gomain[1].SetActive(true);
            Gomain[2].SetActive(false);
            Gomain[3].SetActive(false);
            Gomain[4].SetActive(false);
            Gomain[5].SetActive(true);
            Gomain[6].SetActive(false);
            Gomain[7].SetActive(false);
            ringing.Stop();
            player.SetActive(false);
            player_in_pumkin.SetActive(false);
            talkData = null;
            talkIndex = 0;
            isAction = false;
            talkPanel.SetBool("isShow", isAction);
            QuizManager.SetActive(false);
            QuizIMG.SetActive(false);
            questmanager.Object_reset();
            soundmanager.StopBGM(1);
            soundmanager.StopBGM(2);
            soundmanager.StopBGM(3);
            soundmanager.StopBGM(4);
            NPC1.SetActive(true);
        }
        else
        {
            Warn_M.text = "대화를 중단하고 메인으로 갈 수 없습니다.";
            Warn.SetActive(true);
            Invoke("off_warn", 2);
        }
       
    }
    public void GameExit()
    {
        Application.Quit();
    }
    void off_warn()
    {
        Warn.SetActive(false);
    }
    void GameBGM()
    {
        if (questmanager.questActionIndex + questmanager.questId >= 12 && questmanager.questActionIndex + questmanager.questId < 160)
        {
            soundmanager.StopBGM(0);
            soundmanager.StopBGM(1);
            soundmanager.StartBGM(2);
            soundmanager.StopBGM(3);
            soundmanager.StopBGM(4);
        }
        if (questmanager.questActionIndex + questmanager.questId >= 160 && questmanager.questActionIndex + questmanager.questId < 201)
        {
            soundmanager.StopBGM(0);
            soundmanager.StopBGM(1);
            soundmanager.StopBGM(2);
            soundmanager.StartBGM(3);
            soundmanager.StopBGM(4);
        }
        if (questmanager.questActionIndex + questmanager.questId >= 201 && questmanager.questActionIndex + questmanager.questId < 210)
        {
            soundmanager.StopBGM(0);
            soundmanager.StartBGM(1);
            soundmanager.StartBGM(2);
            soundmanager.StopBGM(3);
            soundmanager.StopBGM(4);
        }
        if (questmanager.questActionIndex + questmanager.questId == 220)
        {
            soundmanager.StopBGM(0);
            soundmanager.StopBGM(1);
            soundmanager.StopBGM(2);
            soundmanager.StopBGM(3);
            soundmanager.StartBGM(4);
        }
    }
}



