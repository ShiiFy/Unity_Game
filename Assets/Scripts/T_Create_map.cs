using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Create_map : MonoBehaviour
{
    public GameObject tileHex;
    public Vector3 positionHex = new Vector3(0, 0, 0);
    Vector2[] myArray = new Vector2[100];

    private void Start()
    {   
        for(int i = 0; i < 100; i++)
        {   
            GameObject createHex = Instantiate(tileHex, positionHex, Quaternion.identity);            
            Vector2 next_Hex = new Vector2((int)positionHex.x, (int)positionHex.y);
            myArray[i] = next_Hex;
            positionHex.x += 0.743f;
            positionHex.y += 0.43f;

        }       
    }
}
