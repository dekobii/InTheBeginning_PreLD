using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {
	private bool hovered;

	void Start()
	{
		hovered = false;
	}

	void Update()
	{
		// Check if tile is being hovered this frame
		if (hovered)
		{
			GetComponent<Renderer>().material.SetFloat("_Outline", 0.08f);
		}
		else
		{
			GetComponent<Renderer>().material.SetFloat("_Outline", 0f);
		}
		hovered = false;
	}

	public void Grow()
	{
		transform.localScale *= 1.1f;
	}

	// Called to indicate this tile is being hovered
	public void TileIsHovered()
	{
		hovered = true;
	}
}