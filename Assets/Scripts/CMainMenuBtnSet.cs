using UnityEngine;
using System.Collections;

public class CMainMenuBtnSet : MonoBehaviour {
	float ScrWidthRatio;
	float ScrHeightRatio;
	GameObject DungeonBtnSet;
	GameObject CardBtnSet;
	GameObject ShopBtnSet;
	GameObject FriendBtnSet;
	GameObject AchivementBtnSet;
	GameObject OptionBtnSet;
	Texture DungeonBtn;
	Texture CardBtn;
	Texture ShopBtn;
	Texture FriendBtn;
	Texture AchivementBtn;
	Texture OptionBtn;

	// Use this for initialization
	void Start () {
		this.ScrWidthRatio = Screen.width/1280.0f;
		this.ScrHeightRatio = Screen.height/720.0f;
		
		this.DungeonBtnSet = transform.FindChild("DungeonBtnSet").gameObject;
		this.DungeonBtnSet.SetActive (false);
		this.CardBtnSet = transform.FindChild("CardBtnSet").gameObject;
		this.CardBtnSet.SetActive (false);
		this.ShopBtnSet = transform.FindChild("ShopBtnSet").gameObject;
		this.ShopBtnSet.SetActive (false);
		this.FriendBtnSet = transform.FindChild("FriendBtnSet").gameObject;
		this.FriendBtnSet.SetActive (false);
		this.AchivementBtnSet = transform.FindChild("AchivementBtnSet").gameObject;
		this.AchivementBtnSet.SetActive (false);
		this.OptionBtnSet = transform.FindChild("OptionBtnSet").gameObject;
        this.OptionBtnSet.SetActive (false); 
		
		this.DungeonBtn = Resources.Load ("MainMenuUI/DungeonBtn") as Texture;
		this.CardBtn = Resources.Load ("MainMenuUI/CardBtn") as Texture;
		this.ShopBtn = Resources.Load ("MainMenuUI/ShopBtn") as Texture;
		this.FriendBtn = Resources.Load ("MainMenuUI/FriendBtn") as Texture;
		this.AchivementBtn = Resources.Load ("MainMenuUI/AchivementBtn") as Texture;
		this.OptionBtn = Resources.Load ("MainMenuUI/OptionBtn") as Texture;
		//한줄게시판 영역추가
	}
 	
	// Update is called once per frame
	void Update () {
		//던전버튼클릭 시 동작
		//카드버튼클릭 시 동작
		//상점버튼클릭 시 동작
		//친구버튼클릭 시 동작
		//업적버튼클릭 시 동작
		//설정버튼클릭 시 동작

	}

	void OnGUI() 
	{
		//버튼애니메이션
		//width = 20+40+240(btn)+40+240(btn)+40
		//height = 10+144+56+144+
		GUI.DrawTexture (new Rect (60 * ScrWidthRatio, 200 * ScrHeightRatio, this.DungeonBtn.width * ScrWidthRatio, this.DungeonBtn.height * ScrHeightRatio), this.DungeonBtn);
		GUI.DrawTexture (new Rect (60 * ScrWidthRatio, 370 * ScrHeightRatio, this.CardBtn.width * ScrWidthRatio, this.CardBtn.height * ScrHeightRatio), this.CardBtn);
		GUI.DrawTexture (new Rect (60 * ScrWidthRatio, 540 * ScrHeightRatio, this.ShopBtn.width * ScrWidthRatio, this.ShopBtn.height * ScrHeightRatio), this.ShopBtn);
		GUI.DrawTexture (new Rect (340 * ScrWidthRatio, 200 * ScrHeightRatio, this.FriendBtn.width * ScrWidthRatio, this.FriendBtn.height * ScrHeightRatio), this.FriendBtn);
		GUI.DrawTexture (new Rect (340 * ScrWidthRatio, 370 * ScrHeightRatio, this.AchivementBtn.width * ScrWidthRatio, this.AchivementBtn.height * ScrHeightRatio), this.AchivementBtn);
		GUI.DrawTexture (new Rect (340 * ScrWidthRatio, 540 * ScrHeightRatio, this.OptionBtn.width * ScrWidthRatio, this.OptionBtn.height * ScrHeightRatio), this.OptionBtn);
	}
}
 