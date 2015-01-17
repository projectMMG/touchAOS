using UnityEngine;
using System.Collections;

public class CMainMenu : MonoBehaviour {
	float ScrWidthRatio;
	float ScrHeightRatio;
	GameObject MainMenuBtnSet;
	Texture StatusUI;

	// Use this for initialization
	void Start () {
		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;

		this.MainMenuBtnSet = transform.FindChild("MainMenuBtnSet").gameObject;
		this.MainMenuBtnSet.SetActive (true);
		
		this.StatusUI = Resources.Load ("MainMenuUI/StatusUI") as Texture;
	}
	
	// Update is called once per frame
	void Update () {
		//스테이터스 바 데이터 계산
	
	}
	
	void OnGUI() 
	{
		//스테이터스 바 애니메이션
		GUI.DrawTexture (new Rect (20 * ScrWidthRatio, 10 * ScrHeightRatio, this.StatusUI.width * ScrWidthRatio, this.StatusUI.height * ScrHeightRatio), this.StatusUI);
	}
}
