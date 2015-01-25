using UnityEngine;
using System.Collections;

public class CGameController : MonoBehaviour {
	public GameObject character;
	GameObject[] characterList;
	public Vector3[] startPositions;
	// Use this for initialization
	void Start () {
		startPositions = new Vector3[6];
		startPositions [1].Set (-11, 5,-20);
		startPositions [2].Set(-9, 5,-20);
		startPositions [3].Set(-7, 5,-20);
		startPositions [4].Set (-10, 3,-20);
		startPositions [5].Set (-8, 3,-20);

	}
	// Update is called once per frame
	void Update () {

		if (characterList == null) {
			characterList= new GameObject[6];
			for(int i=1; i<=5; i++)
			{
				characterList[i]=(GameObject)Instantiate(character,startPositions[i],Quaternion.identity);
			}
		}
	}
}
