using UnityEngine;
using System.Collections;

public class blockObject : MonoBehaviour {
	public bool isSelected = false;
	private Color isSelectedColor = Color.black;
	private Color originalColor ;
	public bool isRollOver = false;
	public bool isUse = false;
	// Use this for initialization
	void Start () {
		originalColor = this.transform.renderer.material.GetColor ("_Color");
	}
	
	// Update is called once per frame
	void Update () {
		if(isSelected == true)
		{
			this.transform.renderer.material.color = isSelectedColor;
		}
		else if(isRollOver == false)
			this.transform.renderer.material.color = originalColor;
	
	}
}
