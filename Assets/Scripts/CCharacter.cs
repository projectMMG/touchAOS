using UnityEngine;
using System.Collections;

public class CCharacter : MonoBehaviour {
	
	public float speed;
	Vector3 destination;
	
	// Use this for initialization
	void Start () {
		destination = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ScreentoWorld ();
		}
		if (Vector2.Distance (destination, transform.position) > 1.0) {
			
			//Debug.Log (Vector2.Distance ( destination, transform.position));
			MoveCharacter ();
		}
	}
	public void ScreentoWorld(){
		Vector3 worldPos = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane) );
		destination=worldPos;
	}
	public void MoveCharacter(){
		Vector3 nextPos;
		nextPos=new Vector3(destination.x-transform.position.x,destination.y-transform.position.y,0);
		nextPos.Normalize();
		transform.Translate(nextPos*speed);
	}
}
