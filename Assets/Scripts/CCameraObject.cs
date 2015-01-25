using UnityEngine;
using System.Collections;

public class CCameraObject : MonoBehaviour {
	public GameObject selectedCharacter;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}

	void MoveCamera ()
	{
		Vector3 nextPos;
		nextPos=new Vector3(selectedCharacter.transform.position.x-transform.position.x,selectedCharacter.transform.position.y-transform.position.y,0);
		nextPos.Normalize();
		transform.Translate(nextPos*speed);
	}
	
	// Update is called once per frame
	

	// Update is called once per frame
	void Update () {
		if (Vector2.Distance (selectedCharacter.transform.position, transform.position) > 1.0) {
			
			//Debug.Log ("Camera distance " + Vector2.Distance ( selectedCharacter.transform.position, transform.position));
			MoveCamera ();
		}
	}
}

