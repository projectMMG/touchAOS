using UnityEngine;
using System.Collections;

public class CMainMenu : MonoBehaviour {
	Texture bg;
	float ScrWidth;
	float ScrHeight;

	// Use this for initialization
	void Start () {
		this.bg = Resources.Load ("MainMenuUI/background") as Texture;

		this.ScrWidth = Screen.width/1280.0f;
		this.ScrHeight = Screen.height/720.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.bg);
	}

}
