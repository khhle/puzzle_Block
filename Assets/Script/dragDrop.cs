using System.Collections;
using UnityEngine;

class dragDrop : MonoBehaviour {

	private Color mouseOverColor = Color.blue;
	private Color originalColor ;
	
	public bool dragging = false;
	
	private float distance;
	private blockObject block;

	
	void Start()
	{
		block = this.transform.parent.GetComponent<blockObject> ();

	}
	
	void OnMouseEnter()
	{
		originalColor = gameObject.transform.parent.renderer.material.GetColor ("_Color");
		gameObject.transform.parent.renderer.material.color = mouseOverColor;
		block.isRollOver = true;

	}
	
	void OnMouseExit()
	{
		gameObject.transform.parent.renderer.material.color = originalColor;
		block.isRollOver = false;
	}

	void OnMouseDown()
	{
		//resize the block when dragging from UI bar to workspace 
		gameObject.transform.parent.transform.localScale = new Vector3(1F, 01F, 0);
		distance = Vector3.Distance (transform.position, Camera.main.transform.position);
		dragging = true;
		if(block != null)
		{
			if(block.isSelected == false)
				block.isSelected = true;
			else
				block.isSelected = false;
			block.isUse = true;
		}

	}

	void OnMouseUp()
	{

		Vector3 currentPos = transform.position;
		gameObject.transform.parent.transform.position = new Vector3(currentPos.x,
		                                                             currentPos.y,
		                                                             0);
		gameObject.transform.position = new Vector3(currentPos.x ,
                                             currentPos.y ,
                                             -1);
		dragging = false;

	}
	
	
	
	void Update()
	{
		if (dragging)	
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			Vector3 rayPoint = ray.GetPoint(distance);
			
			transform.parent.position = rayPoint;
			transform.position = rayPoint;
		}
	}
}