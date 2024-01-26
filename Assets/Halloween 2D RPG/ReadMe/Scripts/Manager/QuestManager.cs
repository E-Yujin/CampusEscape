using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public GameManager GM;
    public SoundManager SM;
    public int questId;
    public int questActionIndex;
    public GameObject[] questObject;
    public GameObject[] darkeffect;
    public GameObject GameClear;
    public GameObject ClearText;
    public GameObject Rank;
    public GameObject Cradit;
    public GetRank getRank;
    public LoginSystem setRank;
    string Clear = "����Ʈ �� Ŭ����!:0";
    public QuizManager quizmanager;
    public Image quizIMG;

    public Dictionary<int, QuestData> questList;

    public bool isOpening;
    public Animator talkPanel;
    public GameObject player;
    public GameObject player_in_pumkin;
    public GameObject NPC1;
    public Animator NPC1_Ani;

    public GameObject[] subNPC;
    public PlayerAction playerControll;
    public PlayerAction player_pumkin_Controll;
    public GameObject BlackOut;
    public Animator NewMap;
    public Animator NewMap_pumkin;
    public Animator BlackFadeIn;
    public Animator jack;
    public Animator[] cameramove;
    public Animator laugh;
    public GameObject BlackFadeOut;
    public GameObject QuizImg;
    public bool getblah;
    public bool gyojublah;

    public GameObject[] ActionButton;
    public GameObject MoveButton;
    public GameObject samulham;
    public GameObject samulham_button;
    public bool isEnding;
    public bool isHide;

    AudioSource audioSource;


    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        audioSource = GetComponent<AudioSource>();
        GenerateData();
    }
    private void Update()
    {
        if (questId == 10 || questId == 210)
            isEnding = true;
        else isEnding = false;
    }
    private void FixedUpdate()
    {
        if (questId + questActionIndex == 10 && GM.talkIndex == 3)
        {
            NPC1.transform.position = Vector3.MoveTowards(NPC1.transform.position, new Vector2(player.transform.position.x + 0.8f, player.transform.position.y + 0.5f), 0.1f);
        }
        if (questId + questActionIndex == 11 && GM.talkIndex == 0)
        {
            NPC1.transform.position = Vector2.MoveTowards(NPC1.transform.position, new Vector2(5.541854f, -25.49826f), 0.07f);
        }
        if (questId + questActionIndex == 14 && GM.talkIndex == 3)
        {
            NPC1.transform.position = Vector2.MoveTowards(NPC1.transform.position, new Vector2(22.06186f, -41.74826f), 0.07f);
        }
        if (questId + questActionIndex == 14 && GM.talkIndex == 11)
        {
            subNPC[0].transform.position = Vector2.MoveTowards(subNPC[0].transform.position, new Vector2(21.12185f, -42.49826f), 0.5f);
            subNPC[1].transform.position = Vector2.MoveTowards(subNPC[1].transform.position, new Vector2(22.85f, -42.49826f), 0.51f);
            subNPC[2].transform.position = Vector2.MoveTowards(subNPC[2].transform.position, new Vector2(22.842f, -43.87f), 0.52f);
            subNPC[3].transform.position = Vector2.MoveTowards(subNPC[3].transform.position, new Vector2(21.12526f, -43.87f), 0.53f);
        }
        if (questId + questActionIndex == 72 && GM.talkIndex == 0)
        {
            subNPC[4].transform.position = Vector2.MoveTowards(subNPC[4].transform.position, new Vector2(21.53185f, -66.28826f), 0.15f);
        }
        if (questId + questActionIndex == 91 && GM.talkIndex == 0)
        {
            subNPC[0].transform.position = Vector2.MoveTowards(subNPC[0].transform.position, new Vector2(18.44f, -84.42f), 0.08f);
            subNPC[1].transform.position = Vector2.MoveTowards(subNPC[1].transform.position, new Vector2(18.44f, -84.62f), 0.07f);
            subNPC[2].transform.position = Vector2.MoveTowards(subNPC[2].transform.position, new Vector2(18.44f, -84.32f), 0.08f);
            subNPC[3].transform.position = Vector2.MoveTowards(subNPC[3].transform.position, new Vector2(18.44f, -84.92f), 0.04f);
        }
        if (questId + questActionIndex == 92 && GM.talkIndex == 0)
        {
            NPC1.transform.position = Vector2.MoveTowards(NPC1.transform.position, new Vector2(18.72f, -88.53085f), 0.17f);
        }
        if (questId + questActionIndex == 125 && GM.talkIndex == 0)
        {
            subNPC[0].transform.position = Vector2.MoveTowards(subNPC[0].transform.position, new Vector2(35.46f, -79.65f), 0.13f);
            subNPC[1].transform.position = Vector2.MoveTowards(subNPC[1].transform.position, new Vector2(35.46f, -79.65f), 0.1f);
            subNPC[2].transform.position = Vector2.MoveTowards(subNPC[2].transform.position, new Vector2(35.46f, -79.65f), 0.075f);
            subNPC[3].transform.position = Vector2.MoveTowards(subNPC[3].transform.position, new Vector2(35.46f, -79.65f), 0.053f);
            NPC1.transform.position = Vector2.MoveTowards(NPC1.transform.position, new Vector2(35.46f, -79.65f), 0.022f);
        }
        if (questId + questActionIndex == 151 && GM.talkIndex == 2)
        {
            NPC1.transform.position = Vector2.MoveTowards(NPC1.transform.position, new Vector2(21.52686f, -42.34f), 0.18f);
        }
        if (questId + questActionIndex == 151 && GM.talkIndex == 5)
        {
            subNPC[0].transform.position = Vector2.MoveTowards(subNPC[0].transform.position, new Vector2(20.24f, -40.39f), 0.2f);
            subNPC[1].transform.position = Vector2.MoveTowards(subNPC[1].transform.position, new Vector2(20.24f, -41.79501f), 0.2f);
            subNPC[2].transform.position = Vector2.MoveTowards(subNPC[2].transform.position, new Vector2(22.82f, -40.39f), 0.2f);
            subNPC[3].transform.position = Vector2.MoveTowards(subNPC[3].transform.position, new Vector2(22.82f, -41.79501f), 0.2f);
        }
        if (questId + questActionIndex == 211 && GM.talkIndex == 3)
        {
            NPC1.transform.position = Vector3.MoveTowards(NPC1.transform.position, new Vector2(player.transform.position.x + 0.8f, player.transform.position.y + 0.5f), 0.1f);
        }
        if(questId+questActionIndex >= 200 && GM.talkIndex >= 6) SM.StopES(9);
        if (questId + questActionIndex >= 201 && GM.talkIndex >= 1) SM.StopES(9);
    }

    //����Ʈ ����
    void GenerateData()
    {
        questList.Add(10, new QuestData("������:0"
                                         , new int[] { 2000, 2000, 2000, 6000, 2000, 2000 }));
        questList.Add(20, new QuestData("���ǽǿ��� ���� ����.:0"
                                         , new int[] { 5000, 4000 }));
        questList.Add(30, new QuestData("ù ��° ����:1"
                                         , new int[] { 7000 }));
        questList.Add(40, new QuestData("2�� ����:0"
                                         , new int[] { 8000, 4000 }));
        questList.Add(50, new QuestData("�� ��° ����:1"
                                         , new int[] { 3000 }));
        questList.Add(60, new QuestData("ȣ��Ż ����:0"
                                         , new int[] { 5000 }));
        questList.Add(70, new QuestData("�������⸦ �ӿ�����:0"
                                         , new int[] { 9000, 15000, 4000, 3000 }));
        questList.Add(80, new QuestData("�� ��° ����:1"
                                         , new int[] { 3000 }));
        questList.Add(90, new QuestData("Ż��!:0"
                                         , new int[] { 13000, 2000, 3000, 4000 }));
        questList.Add(100, new QuestData("�� ��° ����:1"
                                         , new int[] { 3000 }));
        questList.Add(110, new QuestData("�������Ѱ� ��ȭ:0"
                                         , new int[] { 5000, 1000 }));
        questList.Add(120, new QuestData("��������:0"
                                         , new int[] { 13000, 8000, 2000, 6000, 8000, 0, 8000}));
        questList.Add(130, new QuestData("���ϽǷ�:0"
                                         , new int[] { 3000 }));
        questList.Add(140, new QuestData("�ټ� ��° ����:1"
                                         , new int[] { 3000 }));
        questList.Add(150, new QuestData("�� �ɷ���:0"
                                        , new int[] { 5000, 2000 }));
        questList.Add(160, new QuestData("�ϴó���:0"
                                        , new int[] { 8000, 8000, 5000 }));
        questList.Add(170, new QuestData("���� ��° ����:1"
                                , new int[] { 5000 }));
        questList.Add(180, new QuestData("�ϰ� ��° ����:1"
                                  , new int[] { 5000 }));
        questList.Add(190, new QuestData("���� ��° ����:1"
                                , new int[] { 5000 }));
        questList.Add(200, new QuestData("������:0"
                                 , new int[] { 5000, 8000}));
        questList.Add(210, new QuestData("����:0"
                         , new int[] { 8000, 2000 }));
        questList.Add(220, new QuestData("����Ʈ �� Ŭ����!:0"
         , new int[] { }));
    }
    public int GetQuestTalkIndex(int id)
    {
        return questId + questActionIndex;
    }
    public string CheckQuest(int id)
    {
        //Next Talk Target
        if (quizmanager.isCorrect != 0)
        {
            if (id == questList[questId].npcId[questActionIndex])
                questActionIndex++;
            if (questId + questActionIndex == 11 && GM.talkIndex == 0) Opening();
            if (questId + questActionIndex == 12 && GM.talkIndex == 0) Opening();
            if (questId + questActionIndex == 13 && GM.talkIndex == 0) Opening();
            if (questId + questActionIndex == 14 && GM.talkIndex == 0) Opening();
        }


        //Control Quest Object
        Object_Controll();

        //Talk Complete & Next Quest
        if(quizmanager.isCorrect != 0)
        {
            if (questActionIndex == questList[questId].npcId.Length)
                NextQuest();
        }

        //Quest Name
        return questList[questId].questName.Split(':')[0];
    }
    public string CheckQuest()
    {
        //Quest Name
        return questList[questId].questName.Split(':')[0];
    }
    void NextQuest()
    {
        questId += 10;
        questActionIndex = 0;

        //���� �������� Ȯ��
        if (questList[questId].questName == Clear)
        {
            SM.StopBGM(0);
            SM.StopBGM(1);
            SM.StopBGM(2);
            SM.StopBGM(3);
            SM.StartBGM(4);
            Cradit.SetActive(true);
            GameClear.SetActive(true);
            setRank.SetValue();
            Invoke("ShowRank", 31);
        }

    }

    //����Ʈ ������Ʈ ����

    public void Object_reset()
    {
        questObject[0].SetActive(false);//�ʰ��

        questObject[1].SetActive(true);//����

        questObject[2].SetActive(true);//��¥��(����)
        questObject[3].SetActive(false);//��¥��

        questObject[4].SetActive(true);//ù ��° ��Ʈ Ź��

        questObject[5].SetActive(false);//ȣ���ǻ�
        questObject[6].SetActive(false);//ȣ������

        questObject[7].SetActive(true);//����� ��¥��
        questObject[8].SetActive(true);//1�� ���� ���ǽ� ��¥��
        questObject[9].SetActive(true);//���Ͻ� ��¥��

        questObject[10].SetActive(false);//����� ��¥��
        questObject[11].SetActive(false);//1�� ���� ���ǽ� ��¥��
        questObject[12].SetActive(false);//���Ͻ� ��¥��

        questObject[13].SetActive(false);//2�� ��¥��
        questObject[14].SetActive(true);//2�� ��¥��

        questObject[15].SetActive(false);//���� ��¥��
        questObject[16].SetActive(true);//���� ��¥��

        questObject[19].SetActive(false);//����
        questObject[20].SetActive(true);//�ⱸ
        questObject[21].SetActive(false);//1������ �ö󰡱�
        questObject[22].SetActive(false);//����2

        questObject[23].SetActive(true);//2�� ���� ���ǽ� ��¥
        questObject[24].SetActive(false);//2�� ���� ���ǽ� ��¥

        subNPC[4].SetActive(true);
        subNPC[4].transform.position = new Vector3(22.08186f, -61.20826f, 0);

        darkeffect[0].SetActive(false);
        darkeffect[1].SetActive(false);

    }
    public void Object_Controll()
    {
        if (questId == 10)
        {
            Object_reset();
        }
        switch (questId)
        {
            case 10:
                questObject[0].SetActive(true);//�ʰ��
                break;
            case 20:
                if (questActionIndex == 0)
                    questObject[0].SetActive(true);//�ʰ��
                if (questActionIndex == 1)
                    questObject[0].SetActive(false);//�ʰ��
                questObject[2].SetActive(true);//��¥��(����)
                questObject[3].SetActive(false);//��¥��

                break;
            case 30:
                questObject[2].SetActive(true);//��¥��(����)
                questObject[3].SetActive(false);//��¥��
                break;
            case 40:
                questObject[1].SetActive(true);//�ʰ��
                questObject[2].SetActive(false);//��¥��(����)
                questObject[3].SetActive(true);//��¥��
                questObject[4].SetActive(false);//ù ��° ��Ʈ Ź��
                break;
            case 60:
                if (questActionIndex == 0)
                    questObject[5].SetActive(true);//ȣ���ǻ�
                if (questActionIndex == 1)
                    questObject[5].SetActive(false);//ȣ���ǻ�
                break;
            case 70:
                if (questActionIndex >= 1)
                    questObject[1].SetActive(false);//�ʰ��
                if (questActionIndex >= 2)
                    Invoke("npc4_move", 1);
                break;
            case 110:
                questObject[6].SetActive(true);//ȣ������
                if (questActionIndex >= 1)
                {
                    questObject[6].SetActive(false);//ȣ������
                }
                break;
            case 150:
                if (questActionIndex == 0)
                    questObject[19].SetActive(true);//����
                if (questActionIndex == 1)
                    questObject[19].SetActive(false);//����
                break;
        }
        if (questId + questActionIndex >= 72)
        {
            questObject[23].SetActive(false);//2�� ���� ���ǽ� ��¥
            questObject[24].SetActive(true);//2�� ���� ���ǽ� ��¥
        }
        else
        {
            questObject[23].SetActive(true);//2�� ���� ���ǽ� ��¥
            questObject[24].SetActive(false);//2�� ���� ���ǽ� ��¥
        }

        if (questId >= 40)
        {
            questObject[2].SetActive(false);//��¥��(����)
            questObject[3].SetActive(true);//��¥��
            questObject[4].SetActive(false);//ù ��° ��Ʈ Ź��
        }
        else
        {
            questObject[2].SetActive(true);//��¥��(����)
            questObject[3].SetActive(false);//��¥��
            questObject[4].SetActive(true);//ù ��° ��Ʈ Ź��
        }

        if (questId + questActionIndex >= 71)
        {
            questObject[1].SetActive(false);//����
        }
        else questObject[1].SetActive(true);//����

        if (questId + questActionIndex >= 72)
        {
            Invoke("npc4_move", 1);
        }

        if (questId >= 90)
        {
            if (questId == 90 && questActionIndex == 0)
            {
                questObject[13].SetActive(false);//2�� ��¥��
                questObject[14].SetActive(true);//2�� ��¥��
            }
            else if (questId == 90 && questActionIndex == 1)
            {
                questObject[13].SetActive(true);//2�� ��¥��
                questObject[14].SetActive(false);//2�� ��¥��
            }
            else if (questId == 90 && questActionIndex >= 2)
            {
                questObject[13].SetActive(true);//2�� ��¥��
                questObject[14].SetActive(false);//2�� ��¥��
                questObject[8].SetActive(false);//1�� �������ǽ� ��¥��
                questObject[11].SetActive(true);//1�� �������ǽ� ��¥��
                questObject[20].SetActive(false);//�ⱸ
            }
            else
            {
                questObject[13].SetActive(true);//2�� ��¥��
                questObject[14].SetActive(false);//2�� ��¥��
                questObject[8].SetActive(false);//1�� �������ǽ� ��¥��
                questObject[11].SetActive(true);//1�� �������ǽ� ��¥��
                questObject[20].SetActive(false);//�ⱸ
            }
        }

        if (questId >= 120)
        {
            questObject[9].SetActive(false);//���Ͻ� ��¥��
            questObject[12].SetActive(true);//���Ͻ� ��¥��

            questObject[15].SetActive(true);//���� ��¥��
            questObject[16].SetActive(false);//���� ��¥��

            if (questId == 120 && questActionIndex == 0)
            {
                questObject[7].SetActive(true);//����� ��¥��
                questObject[10].SetActive(false);//����� ��¥��
            }
            else if (questId == 120 && questActionIndex >= 1)
            {
                questObject[7].SetActive(false);//����� ��¥��
                questObject[10].SetActive(true);//����� ��¥��
            }
            else
            {
                questObject[7].SetActive(false);//����� ��¥��
                questObject[10].SetActive(true);//����� ��¥��
            }

        }
        if (questId + questActionIndex >= 130)
        {
            questObject[7].SetActive(true);//����� ��¥��
            questObject[10].SetActive(false);//����� ��¥��
        }

        if (questId >= 130)
        {
            questObject[15].SetActive(false);//���� ��¥��
            questObject[16].SetActive(true);//���� ��¥��
            questObject[8].SetActive(true);//1�� �������ǽ� ��¥��
            questObject[11].SetActive(false);//1�� �������ǽ� ��¥��
        }
        else if(questId == 10)
        {
            questObject[15].SetActive(false);//���� ��¥��
            questObject[16].SetActive(true);//���� ��¥��
        }
        else
        {
            questObject[15].SetActive(true);//���� ��¥��
            questObject[16].SetActive(false);//���� ��¥��
        }
        
        if (questId + questActionIndex > 15 && questId + questActionIndex <= 90)
        {
            NPC1.transform.position = new Vector2(6.231854f, -25.94826f);
            subNPC[0].transform.position = new Vector2(19.10185f, -39.16826f);
            subNPC[1].transform.position = new Vector2(24.68185f, -39.00826f);
            subNPC[2].transform.position = new Vector2(24.02185f, -43.59826f);
            subNPC[3].transform.position = new Vector2(18.82185f, -44.01826f);
        }
        if (questId + questActionIndex >= 92 && questId + questActionIndex <= 121)//��������� 2������ �̵�
        {
            if(questId + questActionIndex == 92)//���ְ� �̵� ��
            {
                NPC1.SetActive(true);
                subNPC[0].SetActive(false);
                subNPC[1].SetActive(false);
                subNPC[2].SetActive(false);
                subNPC[3].SetActive(false);
            }
            else//�̵� ��
            {
                NPC1.SetActive(false);
                subNPC[0].SetActive(false);
                subNPC[1].SetActive(false);
                subNPC[2].SetActive(false);
                subNPC[3].SetActive(false);
            }

        }
        else if (questId + questActionIndex >= 126 && questId + questActionIndex <= 150)//����� Ȯ��
        {
            if(questId + questActionIndex == 130 && GM.is11000 == true && GM.talkIndex != 0){
                NPC1.transform.position = new Vector2(34.49f, -79.71826f);
                NPC1.SetActive(true);
                subNPC[0].SetActive(false);
                subNPC[1].SetActive(false);
                subNPC[2].SetActive(false);
                subNPC[3].SetActive(false);
            }
            else
            {
                NPC1.SetActive(false);
                subNPC[0].SetActive(false);
                subNPC[1].SetActive(false);
                subNPC[2].SetActive(false);
                subNPC[3].SetActive(false);
            }
        }
        else if (questId + questActionIndex > 150 && GM.talkIndex < 4)
        {
            NPC1.SetActive(true);
            subNPC[0].SetActive(false);
            subNPC[1].SetActive(false);
            subNPC[2].SetActive(false);
            subNPC[3].SetActive(false);
        }
        else
        {
            NPC1.SetActive(true);
            if (questId + questActionIndex != 91)
            {
                subNPC[0].SetActive(true);
                subNPC[1].SetActive(true);
                subNPC[2].SetActive(true);
                subNPC[3].SetActive(true);
            }

        }

        if (questId >= 20)
        {
            questObject[21].SetActive(true);//1������ �ö󰡱�
        }
        else questObject[21].SetActive(false);//1������ �ö󰡱�

        if (questId + questActionIndex >= 122 && questId + questActionIndex <= 150)
        {
            if (questId + questActionIndex >= 124)
            {
                darkeffect[0].SetActive(false);
                darkeffect[1].SetActive(true);
            }
            else
            {
                darkeffect[0].SetActive(true);
                darkeffect[1].SetActive(true);
            }
        }
        else
        {
            darkeffect[0].SetActive(false);
            darkeffect[1].SetActive(false);
        }
    }

    //������ ����Ʈ ����
    public void Opening()
    {
        switch (questId + questActionIndex)
        {
            case 10: // �ι��� �Ա�
                isOpening = true;
                GM.Talk(2000, true);
                //Visible Talk for Action
                talkPanel.SetBool("isShow", GM.isAction);
                switch (GM.talkIndex)
                {
                    case 1:
                        playerControll.ButtonDown("U");
                        break;
                    case 3:
                        playerControll.ButtonUp("U");
                        break;
                    default:
                        break;
                }
                break;

            case 11://�����
                if(GM.talkIndex > 0)
                {
                    isOpening = true;
                    GM.Talk(2000, true);
                    talkPanel.SetBool("isShow", GM.isAction);
                }
                if(questId + questActionIndex != 11) //GM.Talk�� �ϴ� �������� questid�� 10���� 20���� �����. ���� �� �� �ɷ������.
                {
                    isOpening = false;
                    break;
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        M_MoveEffect();
                        break;
                    case 4:
                        audioSource.Stop();
                        break;
                }
                break;
            case 12://�ι��� ���� �Ա�
                isOpening = true;
                if (GM.talkIndex > 0)
                {
                    isOpening = true;
                    GM.Talk(2000, true);
                    talkPanel.SetBool("isShow", GM.isAction);
                }
                if (questId + questActionIndex != 12) //GM.Talk�� �ϴ� �������� questid�� 10���� 20���� �����. ���� �� �� �ɷ������.
                {
                    isOpening = false;
                    break;
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        M_MoveEffect();
                        break;
                    default:
                        break;
                }
                break;
            case 13://�ι��� ����
                if (GM.talkIndex > 0)
                {
                    isOpening = true;
                    GM.Talk(2000, true);
                    talkPanel.SetBool("isShow", GM.isAction);
                }
                if (questId + questActionIndex != 13) //GM.Talk�� �ϴ� �������� questid�� 10���� 20���� �����. ���� �� �� �ɷ������.
                {
                    isOpening = false;
                    break;
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        NPC1.transform.position = new Vector3(22.06186f, -40.66826f, 0);
                        subNPC[0].transform.position = new Vector2(19.10185f, -39.16826f);
                        subNPC[1].transform.position = new Vector2(24.68185f, -39.00826f);
                        subNPC[2].transform.position = new Vector2(24.71185f, -44.01826f);
                        subNPC[3].transform.position = new Vector2(18.82185f, -43.58826f);
                        break;
                    default:
                        break;
                }
                break;
            case 14://2�� ���� ���ǽ�
                if (GM.talkIndex > 0)
                {
                    isOpening = true;
                    GM.Talk(2000, true);
                    talkPanel.SetBool("isShow", GM.isAction);
                }
                if (questId + questActionIndex != 14) //GM.Talk�� �ϴ� �������� questid�� 10���� 20���� �����. ���� �� �� �ɷ������.
                {
                    isOpening = false;
                    break;
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        isOpening = true;
                        GM.Talk(2000, true);
                        talkPanel.SetBool("isShow", GM.isAction);
                        break;
                    case 2:
                        playerControll.ButtonDown("U");
                        Invoke("stop", 2);
                        break;
                    case 12:
                        NewMap.SetTrigger("NewMap");
                        BlackFadeOut.SetActive(true);
                        break;
                    default:
                        break;
                }
                break;
            case 15://2�� ���� ���ǽ�
                player.transform.position = new Vector2(5.441854f, -56.69826f);
                isOpening = true;
                if (GM.talkIndex > 0)
                {
                    isOpening = true;
                    GM.Talk(2000, true);
                    talkPanel.SetBool("isShow", GM.isAction);
                }
                if (questId + questActionIndex != 15) //GM.Talk�� �ϴ� �������� questid�� 10���� 20���� �����. ���� �� �� �ɷ������.
                {
                    isOpening = false;
                    break;
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        BlackFadeIn.SetTrigger("fadein");
                        Invoke("Final", 2);
                        break;
                    default:
                        break;
                }
                break;

            default:
                isOpening = false;
                break;
        }
    }
    void stop()
    {
        playerControll.ButtonUp("U");
    }
    public void Final()
    {
        BlackFadeOut.SetActive(false);
        isOpening = true;
        GM.Talk(2000, true);
        talkPanel.SetBool("isShow", GM.isAction);
    }

    //���� ����
   public void Story()
   {
        switch (questId + questActionIndex)
        {
            case 21://2�� ���� �� ���ǽ�, ù ��Ʈ �߰�
                Get_hint();
                break;
            case 40:
                switch (GM.talkIndex)
                {
                    case 0:
                        if(GM.isAction == false)
                        M_MoveEffect();
                        break;
                }
                break;
            case 41://2�� ���� �� ���ǽ�, �� ��° ��Ʈ �߰�
                getblah = false;
                Get_hint();
                break;
            case 71:
                if (player.activeSelf)//�ڽ�Ƭ �ٲ�, ��Ų�÷��̾� Ȱ��ȭ, ��Ų �׼� ��ư Ȱ��ȭ
                {
                    player_in_pumkin.transform.position = player.transform.position;
                    player.SetActive(false);
                    player_in_pumkin.SetActive(true);
                    ActionButton[0].SetActive(false);
                    ActionButton[1].SetActive(true);
                }
                break;
            case 72:
                Get_hint();//2�� ����(�繰��), �� ��° ��Ʈ �߰�
                break;
            case 80:
                if (samulham.activeSelf)
                {
                    samulham_button.SetActive(true);
                    ActionButton[1].SetActive(false);
                    MoveButton.SetActive(false);
                }
                break;
            case 91:
                subNPC[0].transform.position = new Vector2(23.26f, -85.59f);
                subNPC[1].transform.position = new Vector2(23.26f, -85.59f);
                subNPC[2].transform.position = new Vector2(23.26f, -85.59f);
                subNPC[3].transform.position = new Vector2(23.26f, -85.59f);
                if (subNPC[0].activeSelf)
                {
                    gyojublah = true;
                    getblah = true;
                    Invoke("Gyoju", 1f);
                    Invoke("Gyoju1", 1.5f);
                    Invoke("Gyoju2", 1f);
                    Invoke("Gyoju3", 2.5f);
                }

                break;
            case 92:
                Invoke("Gyoju4", 0.5f);
                break;
            case 93:
                Get_hint();//1�� ���� ���ǽ�, �� ��° ��Ʈ �߰�
                break;

            case 120:
                switch (GM.talkIndex)
                {
                    case 3:
                        
                        isOpening = true;
                        LR();
                        Invoke("RL", 0.1f);
                        Invoke("LR", 0.2f);
                        Invoke("RL", 0.3f);
                        Invoke("LR", 0.4f);
                        Invoke("RLS", 0.5f);

                        break;
                }
                break;
            case 121:
                NPC1.transform.position = new Vector2(21.54f, -41.05f);
                subNPC[0].transform.position = new Vector2(20.50185f, -40.29826f);
                subNPC[1].transform.position = new Vector2(22.6611f, -40.54493f);
                subNPC[2].transform.position = new Vector2(20.66726f, -41.78878f);
                subNPC[3].transform.position = new Vector2(22.36641f, -42.06403f);
                break;
            case 122:
                NPC1.SetActive(true);
                subNPC[0].SetActive(true);
                subNPC[1].SetActive(true);
                subNPC[2].SetActive(true);
                subNPC[3].SetActive(true);
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                            M_MoveEffect();
                        break;
                }
                break;
            case 123:
                gyojublah = false;
                questObject[17].SetActive(false);//����ȭ��
                questObject[18].SetActive(true);//�÷��̾� ȭ��
                break;
            case 124:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                            M_MoveEffect();
                        break;
                }
                break;
            case 125:
                isHide = true;
                player_in_pumkin.transform.position = new Vector2(37.42f, -81.44f);
                NPC1.SetActive(true);
                subNPC[0].SetActive(true);
                subNPC[1].SetActive(true);
                subNPC[2].SetActive(true);
                subNPC[3].SetActive(true);
                NPC1.transform.position = new Vector2(24.89f, -80.66f);
                subNPC[0].transform.position = new Vector2(24.78f, -81.1f);
                subNPC[1].transform.position = new Vector2(24.71f, -80.41f);
                subNPC[2].transform.position = new Vector2(24.71f, -81.38f);
                subNPC[3].transform.position = new Vector2(24.58f, -80.98f);
                Invoke("Gyoju", 2f);
                Invoke("Gyoju1", 2.5f);
                Invoke("Gyoju2", 3f);
                Invoke("Gyoju3", 4.5f);
                Invoke("Gyoju4", 10f);
                break;
            case 127:
                getblah = false;
                break;
            case 150:
                isOpening = false;
                getblah = false;
                gyojublah = false;
                break;
            case 151:

                NPC1.transform.position = new Vector2(21.52686f, -45.48501f);
                subNPC[0].transform.position = new Vector2(20.24f, -45.48501f);
                subNPC[1].transform.position = new Vector2(20.24f, -45.48501f);
                subNPC[2].transform.position = new Vector2(22.82f, -45.48501f);
                subNPC[3].transform.position = new Vector2(22.82f, -45.48501f);
                if(GM.talkIndex >= 2)
                    NPC1.transform.position = new Vector2(21.52686f, -42.34f);
                if (GM.talkIndex > 4)
                {
                    subNPC[0].transform.position = new Vector2(20.24f, -40.39f);
                    subNPC[1].transform.position = new Vector2(20.24f, -41.79501f);
                    subNPC[2].transform.position = new Vector2(22.82f, -40.39f);
                    subNPC[3].transform.position = new Vector2(22.82f, -41.79501f);
                }
                if (GM.talkIndex >= 6)
                {
                    jack.SetTrigger("on");
                    cameramove[0].SetTrigger("camera_move");
                }
                switch (GM.talkIndex)
                {
                    case 0:
                        isOpening = true;
                        player_pumkin_Controll.isHorizonMove = true;
                        player_pumkin_Controll.ButtonDown("L");
                        if (GM.isAction == false)
                        {
                            Invoke("balgak", 0.7f);
                        }
                        break;
                    case 4:
                        subNPC[0].SetActive(true);
                        subNPC[1].SetActive(true);
                        subNPC[2].SetActive(true);
                        subNPC[3].SetActive(true);

                        break;
                }
                break;
            case 160:
                jack.SetTrigger("stop");
                cameramove[0].SetTrigger("stop");
                switch (GM.talkIndex)
                {
                    case 0:
                        isOpening = false;
                        gyojublah = false;
                        if (GM.isAction == false)
                            M_MoveEffect();
                        break;
                }

                break;
            case 161:
                Invoke("BlackOut_off", 5);
                break;
            case 170:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            GM.Quiz();
                            soliloquy(5000);
                        }
                        break;
                }
                break;
            case 180:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            GM.Quiz();
                            soliloquy(5000);
                        }
                        break;
                }
                break;
            case 190:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            GM.Quiz();
                            soliloquy(5000);
                        }
                        break;
                }
                break;
            case 200:
                if (GM.talkIndex < 7)
                {
                    laugh.SetTrigger("laugh");
                    cameramove[1].SetTrigger("camera_move");
                }

                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            soliloquy(5000);

                        }
                        break;
                    case 7:
                        laugh.SetTrigger("stop");
                        cameramove[1].SetTrigger("stop");
                        break;
                }
                break;
            case 201:
                laugh.SetTrigger("stop");
                cameramove[1].SetTrigger("stop");
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            NewMap.SetTrigger("NewMap");
                            M_MoveEffect();
                        }
                        break;
                }
                break;
            case 210:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            isOpening = true;
                            playerControll.isHorizonMove = true;
                            playerControll.ButtonDown("R");
                            Invoke("RS", 0.3f);
                        }
                        break;
                }
                break;
            case 211:
                switch (GM.talkIndex)
                {
                    case 0:
                        if (GM.isAction == false)
                        {
                            NPC1.transform.position = new Vector2(6.231854f, -25.94826f);
                            NewMap.SetTrigger("NewMap");
                            M_MoveEffect();
                            Invoke("Ending", 2);

                        }
                        break;
                    case 3:
                        playerControll.ButtonUp("U");
                        break;
                    default:
                        break;
                }
                break;

        }

    }

    public void M_MoveEffect()
    {
        BlackOut.SetActive(true);
        Invoke("Move", 1);
        Invoke("BlackOut_off", 2);
    }
    void Move()//���� �̵��� ����
    {
        switch (questId + questActionIndex)
        {
            case 11:
                player.transform.position = new Vector3(29.37185f, -27.07826f, 0);
                playerControll.ButtonUp("U");
                break;
            case 12:
                player.transform.position = new Vector3(8.141854f, -39.16826f, 0);
                break;
            case 40:
                player.transform.position = new Vector2(35.456f, -59.936f);
                break;
            case 122:
                NPC1.transform.position = new Vector2(21.54f, -41.05f);
                subNPC[0].transform.position = new Vector2(20.50185f, -40.29826f);
                subNPC[1].transform.position = new Vector2(22.6611f, -40.54493f);
                subNPC[2].transform.position = new Vector2(20.66726f, -41.78878f);
                subNPC[3].transform.position = new Vector2(22.36641f, -42.06403f);
                NPC1.SetActive(true);
                questObject[17].SetActive(true);//���� ȭ��
                questObject[18].SetActive(false);//�÷��̾� ȭ��
                break;
            case 160:
                ActionButton[0].SetActive(true);
                ActionButton[1].SetActive(false);
                player_in_pumkin.SetActive(false);
                player.SetActive(true);

                player.transform.position = new Vector2(88.41f, -87.95998f);
                break;
            case 201:
                player.transform.position = new Vector3(27.868f, -26.284f, 0);
                break;
            case 211:
                player.transform.position = new Vector3(3.541f, -28.227f, 0);
                break;
        }
        if(player.activeSelf) NewMap.SetTrigger("NewMap");
        if (player_in_pumkin.activeSelf) NewMap_pumkin.SetTrigger("NewMap");
    }
    void BlackOut_off()//�̵� �Ŀ� �ٷ� �Ͼ���� �ϴ� ��
    {
        BlackOut.SetActive(false);

        switch (questId + questActionIndex)
        {
            case 11:
                if (GM.talkIndex >= 0 && GM.talkIndex < 4) audioSource.Play();
                GM.Talk(2000, true);
                talkPanel.SetBool("isShow", GM.isAction);
                break;
            case 12:
                GM.Talk(2000, true);
                talkPanel.SetBool("isShow", GM.isAction);
                break;
            case 40:
                getblah = true;
                soliloquy(8000);
                break;
            case 122:
                gyojublah = true;
                soliloquy(2000);
                break;
            case 124:
                getblah = true;
                soliloquy(8000);
                break;
            case 160:
                getblah = true;
                soliloquy(8000);
                break;
            case 161:
                getblah = true;
                soliloquy(8000);
                break;
            case 201:
                getblah = true;
                soliloquy(8000);
                break;
        }
        if (questId + questActionIndex == 130 && GM.is11000 == true && GM.talkIndex >= 1)
        {
            GM.GoMain();
        }
    }
    public void soliloquy(int num)
    {
        GM.Talk(num, true);
        talkPanel.SetBool("isShow", GM.isAction);
    }
    void npc4_move()
    {
        subNPC[4].transform.position = new Vector3(16.67f, -44.85f, 0);
        subNPC[4].SetActive(false);
    }
    public void Get_hint()
    {
        quizIMG.sprite = quizmanager.GetQuizImage(questId+10);
        if (GM.scanObject != null && GM.scanObject.tag == "hint")
        {
            switch (GM.talkIndex)
            {
                case 1:
                    QuizImg.SetActive(true);
                    break;
                case 4:
                    QuizImg.SetActive(false);
                    break;
            }
        }
    }
    void Gyoju()
    {
        subNPC[0].SetActive(false);
    }
    void Gyoju1()
    {
        subNPC[1].SetActive(false);
    }
    void Gyoju2()
    {
        subNPC[2].SetActive(false);
    }
    void Gyoju3()
    {
        subNPC[3].SetActive(false);
        if (questId == 90)
        {
            gyojublah = false;
            getblah = false;
            NPC1.transform.position = new Vector3(23.52f, -86.64f, 0);
        }
    }
    void Gyoju4()
    {
        NPC1.SetActive(false);
        NPC1.transform.position = new Vector2(5.541854f, -25.49826f);
        if (questId == 90)
        {
            subNPC[0].transform.position = new Vector2(19.10185f, -39.16826f);
            subNPC[1].transform.position = new Vector2(24.68185f, -39.00826f);
            subNPC[2].transform.position = new Vector2(24.71185f, -44.01826f);
            subNPC[3].transform.position = new Vector2(18.82185f, -43.58826f);
        }
        if(questId == 120)
        {
            CheckQuest(0);
            isHide = false;
            getblah = true;
            player_pumkin_Controll.ButtonDown("A");
        }
    }

    void balgak()
    {
        isOpening = false;
        NPC1.SetActive(true);
        gyojublah = true;
        soliloquy(2000);
        player_pumkin_Controll.ButtonUp("L");
        NewMap_pumkin.SetTrigger("NewMap");
    }

    void LR()
    {
        player_pumkin_Controll.ButtonUp("L");
        player_pumkin_Controll.ButtonDown("R");
    }
    void RL()
    {
        player_pumkin_Controll.ButtonUp("R");
        player_pumkin_Controll.ButtonDown("L");
    }
    void RLS()
    {
        player_pumkin_Controll.ButtonUp("R");
        NewMap_pumkin.SetTrigger("NewMap");
        isOpening = false;
    }
    void RS()
    {
        playerControll.ButtonUp("R");
        NewMap.SetTrigger("NewMap");
        questObject[22].SetActive(true);//����2
        getblah = true;
        soliloquy(8000);
    }
    void Ending()
    {
        gyojublah = true;
        soliloquy(2000);
        switch (GM.talkIndex)
        {
            case 1:
                playerControll.ButtonDown("U");
                break;
        }
    }

    //����Ʈ ������
    public void ShowRank()
    {
        Rank.SetActive(true);
        Cradit.SetActive(false);
        getRank.SetRank();
    }

}
