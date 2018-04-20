using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {
	private bool hovered;
    Material outlineMat;

	void Start()
	{
		hovered = false;
        outlineMat = GetComponent<Renderer>().material;

    }

	void Update()
	{
		// Check if tile is being hovered this frame
		if (hovered)
		{
            outlineMat.SetFloat("_Outline", 0.08f);
		}
		else
		{
            outlineMat.SetFloat("_Outline", 0f);
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