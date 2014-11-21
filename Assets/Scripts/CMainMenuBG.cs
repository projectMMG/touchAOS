using UnityEngine;
using System.Collections;

public class CMainMenuBG : MonoBehaviour {
	Texture bg;
	float ScrWidthRatio;
	float ScrHeightRatio;

	// Use this for initialization
	void Start () {
		this.bg = Resources.Load ("MainMenuUI/background") as Texture;

		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		//배경그리기
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.bg);
	}
}
