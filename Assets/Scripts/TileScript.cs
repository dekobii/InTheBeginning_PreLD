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
        Vector3 r = transform.localScale;

        transform.localScale = new Vector3(r.x,r.y * 1.1f,r.z);
	}

    public void Shrink()
    {
        Vector3 r = transform.localScale;

        transform.localScale = new Vector3(r.x, r.y * 1/1.1f, r.z);
    }

    // Called to indicate this tile is being hovered
    public void TileIsHovered()
	{
		hovered = true;
	}
}