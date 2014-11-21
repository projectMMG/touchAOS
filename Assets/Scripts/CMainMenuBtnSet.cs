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
	}
}
 