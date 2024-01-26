using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    public float Speed;
    public GameManager manager;
    public QuestManager QM;

    float h;
    float v;
    public bool isHorizonMove;
    Vector3 dirVec;
    public GameObject scanObject;
    public GameObject DonTouch;

    bool hDown, vDown, hUp, vUp;

    //Mobile Key Var
    int up_Value;
    int Down_Value;
    int Left_Value;
    int Right_Value;
    bool up_Down;
    bool down_Down;
    bool left_Down;
    bool right_Down;
    bool up_Up;
    bool down_Up;
    bool left_Up;
    bool right_Up;

    Rigidbody2D rigid;
    Animator anim;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!manager.isAction && !QM.isHide)
        {//자유롭게 움직이기
            DonTouch.SetActive(false);
            //Move Value
            h = Input.GetAxisRaw("Horizontal") + Right_Value + Left_Value;
            v = Input.GetAxisRaw("Vertical") + up_Value + Down_Value;

            //Check Button Down & Up
            hDown = Input.GetButtonDown("Horizontal") || right_Down || left_Down;
            vDown = Input.GetButtonDown("Vertical") || up_Down || down_Down;
            hUp = Input.GetButtonUp("Horizontal") || right_Up || left_Up;
            vUp = Input.GetButtonUp("Vertical") || up_Up || down_Up;
        }
        else if (QM.isOpening){//방향키는 안먹지만 움직일 수 있음
            DonTouch.SetActive(true);
            //Move Value
            h = Right_Value + Left_Value;
            v = up_Value + Down_Value;

            //Check Button Down & Up
            hDown = right_Down || left_Down;
            vDown = up_Down || down_Down;
            hUp = right_Up || left_Up;
            vUp = up_Up || down_Up;
        }
        else if (QM.isHide)
        {//아예 움직일 수 없음
            //Move Value
            h = 0;
            v = 0;

            //Check Button Down & Up
            hDown = false;
            vDown = false;
            hUp = false;
            vUp = false;
        }
        else
        {
            //Move Value
            h = 0;
            v = 0;

            //Check Button Down & Up
            hDown = false;
            vDown = false;
            hUp = false;
            vUp = false;
        }


        //Check Horizontal Move
        if (hDown)
            isHorizonMove = true;
        else if (vDown)
            isHorizonMove = false;
        else if (hUp || vUp)
            isHorizonMove = h != 0;

        //Animation

            anim.SetInteger("hAxisRaw", (int)h);
            anim.SetInteger("vAxisRaw", (int)v);

        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        //Scan Object & Action
        if (Input.GetButtonDown("Jump"))
        {
            if (QM.questId == 10) QM.Opening();
            if (scanObject != null && !QM.gyojublah) manager.Action(scanObject);
            if (QM.gyojublah && !QM.getblah) QM.soliloquy(2000);
            if (scanObject == null && !QM.gyojublah && QM.getblah) QM.soliloquy(8000);
        }
        //Moblie Var Init
        up_Down = false;
        down_Down = false;
        left_Down = false;
        right_Down = false;
        up_Up = false;
        down_Up = false;
        left_Up = false;
        right_Up = false;
    }
    void FixedUpdate()
    {
        if (QM.questId == 10)
        {
            if (QM.questActionIndex == 3 && manager.talkIndex == 0) Speed = 4;
            else Speed = 1;
        }
        else if(QM.questId+QM.questActionIndex == 211)
        {
            Speed = 1;
        }
        else Speed = 4;

        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec * Speed;

        //Ray
        Debug.DrawRay(rigid.position, dirVec * 0.7f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Object"));

        if (rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
        }
        else
            scanObject = null;
    }

    public void ButtonDown(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 1;
                up_Down = true;
                break;
            case "D":
                Down_Value = -1;
                down_Down = true;
                break;
            case "L":
                Left_Value = -1;
                left_Down = true;
                break;
            case "R":
                Right_Value = 1;
                right_Down = true;
                break;
            case "A":
                if (QM.questId == 10) QM.Opening();
                if (scanObject != null && !QM.gyojublah) manager.Action(scanObject);
                if (QM.gyojublah && !QM.getblah) QM.soliloquy(2000);
                if (scanObject == null && !QM.gyojublah && QM.getblah) QM.soliloquy(8000);
                break;
            case "C":
                manager.SubMenuActive();
                break;
        }
    }
    public void ButtonUp(string type)
    {
        switch (type)
        {
            case "U":
                up_Value = 0;
                up_Up = true;
                break;
            case "D":
                Down_Value = 0;
                down_Up = true;
                break;
            case "L":
                Left_Value = 0;
                left_Up = true;
                break;
            case "R":
                Right_Value = 0;
                right_Up = true;
                break;
            case "A":
                if (QM.questId == 10) QM.Opening();
                if (scanObject != null && !QM.gyojublah) manager.Action(scanObject);
                if (QM.gyojublah && !QM.getblah) QM.soliloquy(2000);
                if (scanObject == null && !QM.gyojublah && QM.getblah) QM.soliloquy(8000);
                break;
        }
    }
}
