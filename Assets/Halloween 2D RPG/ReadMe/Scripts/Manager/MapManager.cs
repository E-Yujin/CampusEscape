using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public QuestManager QM;
    public GameObject player;
    public GameObject player_in_Pumkin;

    public void MapMove(string name)
    {
        switch (name)
        {
            case "인문대 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector3(29.58f, -24.04f, 0);
                else player.transform.position = new Vector3(29.58f, -24.04f, 0);
                break;

            case "인문대 지하 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector3(22.01185f, -45.12826f, 0);
                else player.transform.position = new Vector3(22.01185f, -45.12826f, 0);
                break;

            case "2층 우측 강의실 출구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(35.52008f, -58.71499f);
                else player.transform.position = new Vector2(35.52008f, -58.71499f);
                break;

            case "2층 우측 강의실 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(5.36f, -53.06f);
                else player.transform.position = new Vector2(5.36f, -53.06f);
                break;

            case "2층 좌측 강의실 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(5.74f, -70.79f);
                else player.transform.position = new Vector2(5.74f, -70.79f);
                break;

            case "2층 좌측 강의실 출구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(29.55f, -59.07f);
                else player.transform.position = new Vector2(29.55f, -59.07f);
                break;

            case "지하로 내려가기":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector3(8.141854f, -39.16826f, 0);
                else player.transform.position = new Vector3(8.141854f, -39.16826f, 0);
                break;

            case "1층으로 내려가기":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(20.42f, -85.83f);
                else player.transform.position = new Vector2(20.42f, -85.83f);
                break;

            case "2층으로 올라가기":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(20.54f, -66.96f);
                else player.transform.position = new Vector2(20.54f, -66.96f);
                break;

            case "1층으로 올라가기":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(20.54f, -87.75f);
                else player.transform.position = new Vector2(20.54f, -87.75f);
                break;

            case "1층 좌측 강의실 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(47.01f, -83.03f);
                else player.transform.position = new Vector2(47.01f, -83.03f);
                break;

            case "1층 우측 강의실 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(48.007f, -69.956f);
                else player.transform.position = new Vector2(48.007f, -69.956f);
                break;

            case "1층 좌측 강의실 출구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(23.28f, -85.98f);
                else player.transform.position = new Vector2(23.28f, -85.98f);
                break;

            case "1층 우측 강의실 출구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(29.54f, -80.03f);
                else player.transform.position = new Vector2(29.54f, -80.03f);
                break;

            case "전기실 입구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(29, -118.19f);
                else player.transform.position = new Vector2(29f, -118.19f);
                break;

            case "전기실 출구":
                if (QM.questId + QM.questActionIndex >= 71)
                    player_in_Pumkin.transform.position = new Vector2(35.48f, -80.03f);
                else player.transform.position = new Vector2(35.48f, -80.03f);
                break;
        }
    }
}
