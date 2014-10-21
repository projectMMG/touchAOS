using UnityEngine;
using System.Collections;

public class CUIObject : MonoBehaviour {
	
	Rect[] rCharacterSelectUI;
	Texture[] tCharacterSelectUI;
	int selectedCharacter;
	Texture tSelectedCharacter;
	// Use this for initialization
	
	public void SetCharacterSelectUI(){
		rCharacterSelectUI=new Rect[6];
		tCharacterSelectUI=new Texture[6];
		float ratioX=Screen.width/1280.0f;
		float ratioY=Screen.height/780.0f;
		for(int i=1; i<=5; i++){
			rCharacterSelectUI[i]=new Rect((-250+256*i)*ratioX,538.0f*ratioY,250.0f*ratioX,250.0f*ratioY);
			tCharacterSelectUI[i]=new Texture();
			tCharacterSelectUI[i]= (Texture) Resources.Load ("character"+i);
		}
		tSelectedCharacter=new Texture();
		tSelectedCharacter=(Texture)Resources.Load("characterSelected");
		selectedCharacter=0;
	}
	public void DrawCharacterSelectUI(){
		for(int i=1; i<=5; i++){
			GUI.DrawTexture(rCharacterSelectUI[i],tCharacterSelectUI[i]);
		}
		if(selectedCharacter!=0)
			GUI.DrawTexture(rCharacterSelectUI[selectedCharacter],tSelectedCharacter);
	}
	
	void Start () {
		SetCharacterSelectUI();
	}
	void Awake(){
		SetCharacterSelectUI();
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 mousePosition=new Vector3();
			mousePosition=Input.mousePosition;
			mousePosition.y=Screen.height-mousePosition.y;
			//Debug.Log ("mouse clicked!! "+mousePosition.x+","+mousePosition.y);
			for(int i=1; i<=5; i++)
			{
				if(rCharacterSelectUI[i].Contains(mousePosition)){
					if(i==selectedCharacter)selectedCharacter=0;
					else selectedCharacter=i;
				}
			}
		}
	}
	void OnGUI(){
		//Debug.Log ("CUIObject - OnGUI();");
		DrawCharacterSelectUI();
	}
}
