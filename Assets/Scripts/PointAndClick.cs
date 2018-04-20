using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

    public AudioClip[] sfx;
    AudioSource fxSource;
    public GameObject SoundManager;
    GameObject prev;

    private void Start()
    {
        fxSource = SoundManager.GetComponent<AudioSource>();
    }

    void Update()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		// Check hovered tile
		if (Physics.Raycast(ray, out hit, 100f))
		{
            
			GameObject hitGO = hit.transform.gameObject;
			TileScript hitTile = hitGO.GetComponent<TileScript>();
            if (prev == hitGO)
            {
                hitTile.TileIsHovered();
                
            }
            else {
                fxSource.clip = sfx[0];
                fxSource.Play();
            }
            
            
			// Grow the tile on click
			if (Input.GetMouseButtonDown(0))
			{
				hitTile.Grow();
                fxSource.clip = sfx[1];
                fxSource.Play();

            }
            prev = hitGO;
        }
		
		
	}
}