using UnityEngine;
using System.Collections;

public class CCharacter : MonoBehaviour {
	
	public float speed;
	Vector3 direction;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
			ScreentoWorld();
		MoveCharacter ();
	}
	public void ScreentoWorld(){
		Vector3 worldPos = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane) );
		direction=worldPos;
	}
	public void MoveCharacter(){
		Vector3 nextPos;
		nextPos=new Vector3(direction.x-transform.position.x,direction.y-transform.position.y,0);
		nextPos.Normalize();
		transform.Translate(nextPos*speed);
	}
}
