using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour {
    public int width;
    public int height;
    public GameObject gridHex;

    // Use this for initialization
    void Start () {
        //gridHex = (GameObject)Resources.Load("Prefabs/hex", typeof(GameObject));
        for (int i = 0; i < height; i++)
        {
            //Instantiate(gridHex, new Vector3(0, 0, 0), Quaternion.identity);
            for (int j = 0; j < width; j++)
            {
                if (j % 2 == 0)
                {
                    Instantiate(gridHex, new Vector3(1.5f * j, 0, (1.74f * i)), Quaternion.identity);
                }
                else
                {
                    Instantiate(gridHex, new Vector3( (1.5f * j), 0, -0.87f + (1.74f * i)), Quaternion.identity);
                }

            }
        }
        

        //1.5, 0.87
        //1.74

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
