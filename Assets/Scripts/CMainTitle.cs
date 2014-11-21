using UnityEngine;
using System.Collections;

public class CMainTitle : MonoBehaviour {
	Texture bg;
	Texture TouchImg;
	GameObject MainMenu;
	float Alpa4Fade;
	float AlpaDir;
	float Time4Fade;
	float ScrWidthRatio;
	float ScrHeightRatio;

	// Use this for initialization
	void Start () {
		this.bg = Resources.Load ("MainMenuUI/background") as Texture;
		this.TouchImg = Resources.Load ("MainMenuUI/TouchImg") as Texture;

		this.MainMenu = GameObject.Find ("MainMenu");
		this.MainMenu.SetActive (false);

		this.Alpa4Fade = 1.0f;
		this.AlpaDir = 0.1f;
		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			this.MainMenu.SetActive(true);
			gameObject.SetActive(false);
		}
	}

	void OnGUI()
	{
		//터치 이미지 점멸
		Time4Fade += Time.deltaTime;
		if(Time4Fade >= 0.1f)
		{
			if (Alpa4Fade <= 0) 
			{
				AlpaDir = 0.05f;
			} 
			else if (Alpa4Fade >= 1) 
			{
				AlpaDir = -0.05f;
			}
			Alpa4Fade += AlpaDir;
			Time4Fade = 0;
		}

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.bg);
		GUI.color = new Color (0, 0, 0, Alpa4Fade); 
		GUI.DrawTexture (new Rect (384*ScrWidthRatio, 260*ScrHeightRatio, this.TouchImg.width*ScrWidthRatio, this.TouchImg.height*ScrHeightRatio), this.TouchImg);
	}
}
