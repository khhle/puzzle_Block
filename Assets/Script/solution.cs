using UnityEngine;
using System.Collections;

public class solution : MonoBehaviour {
	private Color mouseOverColor = Color.cyan;
	private Color originalColor ;
	public Sprite spritesSolutionShow;
	public Sprite spritesSolutionHide;

	private SpriteRenderer spriteRenderer;
	private bool isShow = false;



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
		if(isShow == false)
		{
			spriteRenderer.sprite = spritesSolutionShow;
			isShow = true;
		}
		else
		{
			spriteRenderer.sprite = spritesSolutionHide;
			isShow = false;
		}
		
	}
	

	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
