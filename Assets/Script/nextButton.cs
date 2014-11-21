using UnityEngine;
using System.Collections;

public class nextButton : MonoBehaviour {
	private Color mouseOverColor = Color.cyan;
	private Color originalColor ;

	
	void OnMouseEnter()
	{
		originalColor = gameObject.renderer.material.GetColor ("_Color");
		gameObject.renderer.material.color = mouseOverColor;
		
	}
	
	void OnMouseExit()
	{
		gameObject.renderer.material.color = originalColor;
		
	}
	
	void OnMouseDown()
	{

		GameObject[] gos;
		blockObject block;
		gos = GameObject.FindGameObjectsWithTag("blocks");
		foreach (GameObject go in gos) {
			block = go.GetComponent<blockObject> ();
			if(block != null)
				if(block.isUse == false)
				{
					//destroy un-used blocks
					Destroy (go.gameObject);
				}
		}

	}

	void OnMouseUp(){

		GameObject[] gos;
		generateBlock block;
		gos = GameObject.FindGameObjectsWithTag("Respawn");
		foreach (GameObject go in gos) {
			block = go.GetComponent<generateBlock> ();
			if(block != null)
			{
				//generate new block
				block.generate(); 
				
			}
		}


	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
