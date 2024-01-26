using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;



[System.Serializable]
public class GoogleData
{
	public string order, result, msg, x, y, questid, QAI;
}


public class LoginSystem : MonoBehaviour
{
	const string URL = "https://script.google.com/macros/s/AKfycbyBO5EECPoTmyi61LiwNrsttDnqZJcGr9M-XtHPijH--O7vR-r1Jgws1lrkG-6LALi84Q/exec";
	public GoogleData GD;
	public SoundManager SM;
	public InputField IDInput, PassInput;

	public Text Idinfo;
	public GameObject Login_Wan;
	public GameObject Login_fail;
	public GameObject Player;
	public GameObject Player_in_pumkin;
	public GameObject MenuSet;
	public GameObject LoadingT;
	public GameObject Warn;
	public Text Warn_M;
	public QuestManager quest;
	public GameManager GM;
	public Text log_fail;
	public string id, pass;
	public string S_x, S_y;
	public string S_q_id, S_QAI;


	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();

		if (PlayerPrefs.HasKey("PlayerPass")  && PlayerPrefs.GetString("PlayerId") != "")
		{
			id = PlayerPrefs.GetString("PlayerId");
			pass = PlayerPrefs.GetString("PlayerPass");
			Login();
		}
	}

	bool SetIDPass()
	{
		id = IDInput.text.Trim();
		pass = PassInput.text.Trim();

		if (id == "" || pass == "")return false;
		else return true;
	}



	public void Login()
	{
		if (PlayerPrefs.HasKey("PlayerPass") && PlayerPrefs.GetString("PlayerId") != "")
			{
				id = PlayerPrefs.GetString("PlayerId");
				pass = PlayerPrefs.GetString("PlayerPass");
			}
			else if (!SetIDPass())
			{
				//log_fail.color = new Color(1, 0, 0, 1);
				log_fail.text = "<color=#e61919>" + "이름 또는 학번이 비어있습니다" + "</color>";
				print("이름 또는 학번이 비어있습니다");
				return;
			}

			WWWForm form = new WWWForm();
			form.AddField("order", "login");
			form.AddField("id", id);
			form.AddField("pass", pass);

			StartCoroutine(Post(form));

	}


	public void LogOut()
	{
		WWWForm form = new WWWForm();
		form.AddField("order", "logout");
		form.AddField("id", id);

		StartCoroutine(Post(form));
		LoadingT.SetActive(false);
	}


	public void SetValue()
	{

		WWWForm form = new WWWForm();
		form.AddField("order", "setValue");
		form.AddField("id", id);
		form.AddField("pass", pass);

		StartCoroutine(Post(form));
		LoadingT.SetActive(false);
	}

	public void Save()
	{
		if (!GM.isAction && !quest.isEnding && quest.questId + quest.questActionIndex != 220)
		{
			if (quest.questId + quest.questActionIndex >= 71 && quest.questId + quest.questActionIndex < 160)
		{
			S_x = Player_in_pumkin.transform.position.x.ToString();
			S_y = Player_in_pumkin.transform.position.y.ToString();
			S_q_id = quest.questId.ToString();
			S_QAI = quest.questActionIndex.ToString();
		}
        else
        {
			S_x = Player.transform.position.x.ToString();
			S_y = Player.transform.position.y.ToString();
			S_q_id = quest.questId.ToString();
			S_QAI = quest.questActionIndex.ToString();
		}


		WWWForm form = new WWWForm();
		form.AddField("order", "save");
		form.AddField("id", id);
		form.AddField("x", S_x);
		form.AddField("y", S_y);
		form.AddField("questid", S_q_id);
		form.AddField("QAI", S_QAI);

		StartCoroutine(Post(form));

		MenuSet.SetActive(false);
		LoadingT.SetActive(false);
		}
		else if(GM.isAction)
		{
			Warn_M.text = "대화 중에는 저장할 수 없습니다.";
			Warn.SetActive(true);
			Invoke("off_warn", 2);
		}
		else if (quest.isEnding || quest.questId + quest.questActionIndex == 220)
		{
			Warn_M.text = "오프닝과 엔딩에선 저장할 수 없습니다.";
			Warn.SetActive(true);
			Invoke("off_warn", 2);
		}
	}

	public void Load()
	{
		LoadingT.SetActive(true);
		WWWForm form = new WWWForm();
		form.AddField("order", "load");
		form.AddField("id", id);

		StartCoroutine(Post(form));
		//LoadingT.SetActive(false);
	}



	IEnumerator Post(WWWForm form)
	{
		LoadingT.SetActive(true);
		using (UnityWebRequest www = UnityWebRequest.Post(URL, form)) // 반드시 using을 써야한다
		{
			yield return www.SendWebRequest();

			if (www.isDone){
				Response(www.downloadHandler.text);
			}
			else print("웹의 응답이 없습니다.");
		}
	}


	void Response(string json)
	{
		if (string.IsNullOrEmpty(json)) return;

		GD = JsonUtility.FromJson<GoogleData>(json);

		if (GD.result == "ERROR")
		{
			print(GD.order + "을 실행할 수 없습니다. 에러 메시지 : " + GD.msg);
			if (GD.msg == "로그인 실패")
			{
				//log_fail.color = new Color(1, 0, 0, 1);
				log_fail.text = "<color=#e61919>" + "잘못 입력되었거나 존재하지 않습니다." + "</color>";
			}
			if (GD.msg == "저장된 데이터 없음.")
            {
				Warn_M.text = "저장된 게임 데이터가 없습니다.";
				Warn.SetActive(true);
				Invoke("off_warn", 2);
				Debug.Log("유흐");
			}
			LoadingT.SetActive(false);
			return;
		}
        else
        {
			print(GD.order + "을 실행했습니다. 메시지 : " + GD.msg);

			if (GD.msg == "로그인 완료")
			{
				PlayerPrefs.SetString("PlayerId", id);
				PlayerPrefs.SetString("PlayerPass", pass);
				PlayerPrefs.Save();
				Idinfo.text = pass + " " + id + "님이 접속중입니다.";
				anim.SetTrigger("notActive");
				Invoke("LoginComplete", 1.3f);
			}

			if (GD.order == "logout")
			{
				PlayerPrefs.SetString("PlayerId", "");
				PlayerPrefs.SetString("PlayerPass", "");
				PlayerPrefs.Save();
				Idinfo.text = "";
				anim.SetTrigger("Active");
				Invoke("LogOutComplete", 1.3f);
				id = null;
				pass = null;
				//log_fail.color = new Color(0.20f, 0.20f, 0.20f, 1);
				log_fail.text = "<color=#ffffff>" + "게임 시작 전 이름 및 학번으로 로그인 해주세요!" + "</color>";
			}

			if (GD.order == "load")
			{
				S_x = GD.x;
				S_y = GD.y;
				S_q_id = GD.questid;
				S_QAI = GD.QAI;
				GM.GameLoad(S_x, S_y, S_q_id, S_QAI);
				SM.StopBGM(0);
				LoadingT.SetActive(false);
			}
		}
	}
	void LoginComplete()
	{
		Login_Wan.SetActive(false);
		LoadingT.SetActive(false);
	}
	void LogOutComplete()
	{
		Login_Wan.SetActive(true);
		LoadingT.SetActive(false);
	}
	void off_warn()
	{
		Warn.SetActive(false);
	}
}
