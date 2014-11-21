using UnityEngine;
using System.Collections;

public class rotationButon : MonoBehaviour {
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
				if(block.isSelected == true)
				{
					block.transform.Rotate(0, 0, 45, Space.World);
					
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
