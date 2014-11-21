using UnityEngine;
using System.Collections;

public class generateBlock : MonoBehaviour {

	public Transform newBlock1Prefab;
	public Transform newBlock2Prefab;
	public Transform newBlock3Prefab;
	public Transform newBlock4Prefab;
	public Transform newBlock5Prefab;
	public Transform newBlock6Prefab;
	public Transform newBlock7Prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void generate(){

		int num = Random.Range (1, 8);

		if(num == 1)
		{
			var blockTransform = Instantiate(newBlock1Prefab) as Transform;
			// Assign position

			blockTransform.position = new Vector3 (transform.position.x,
			                                              transform.position.y, 
			                                              -5);
		}
		else if(num == 2)
		{
			var blockTransform = Instantiate(newBlock2Prefab) as Transform;
			// Assign position
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
		else if(num == 3)
		{
			var blockTransform = Instantiate(newBlock3Prefab) as Transform;
			// Assign position
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
		else if(num == 4)
		{
			var blockTransform = Instantiate(newBlock4Prefab) as Transform;
			// Assign position
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
		else if(num == 5)
		{
			var blockTransform = Instantiate(newBlock5Prefab) as Transform;
			// Assign position
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
		else if(num == 6)
		{
			var blockTransform = Instantiate(newBlock6Prefab) as Transform;
			// Assign position
			//blockTransform.localScale -= new Vector3(0.5F, 0.5F, 0);
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
		else if(num == 7)
		{
			var blockTransform = Instantiate(newBlock7Prefab) as Transform;
			// Assign position
			blockTransform.position = new Vector3 (transform.position.x,
			                                       transform.position.y, 
			                                       -5);
		}
	}
}
