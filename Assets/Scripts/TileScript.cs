using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public Material normalMaterial;
	public Material highlightedMaterial;

	private bool hovered;

	void Start()
	{
		GetComponent<Renderer>().material = normalMaterial;
		hovered = false;
	}

	void Update()
	{
		// Check if tile is being hovered this frame
		if (hovered)
		{
			GetComponent<Renderer>().material = highlightedMaterial;
		}
		else
		{
			GetComponent<Renderer>().material = normalMaterial;
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