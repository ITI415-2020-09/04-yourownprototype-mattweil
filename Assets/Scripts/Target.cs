using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public GameObject targetCube;

    public int numSpheresMin = 6;

    public int numSpheresMax = 10;

    public Vector3 sphereOffsetScale = new Vector3(5,2,1);

    public Vector2 sphereScaleRangeX = new Vector2(4,8);

    public Vector2 sphereScaleRangeY = new Vector2(3,4);

    
    public Vector2 sphereScaleRangeZ = new Vector2(2,4);

    public float scaleYMin = 2f;

    private List<GameObject> cubes;     

    
    // Start is called before the first frame update
    void Start()
    {

        cubes = new List<GameObject>();

        int num = Random.Range(numSpheresMin, numSpheresMax);                          // c

        for (int i=0; i<num; i++) {

            GameObject cb = Instantiate<GameObject>( targetCube );                    // d

            cubes.Add( cb );

            Transform spTrans = cb.transform;

            spTrans.SetParent( this.transform );



            // Randomly assign a position

            Vector3 offset = Random.insideUnitSphere;                                  // e

            offset.x = 1;

            offset.y = 1;

            offset.z = 1;

            spTrans.localPosition = offset;                                            // f



            // Randomly assign scale

            Vector3 scale = Vector3.one;                                              // g

            scale.x = 2;

            scale.y = 2;

            scale.z = 2;



            // Adjust y scale by x distance from core

            // scale.y *= 1 - (Mathf.Abs(offset.x) / sphereOffsetScale.x);                // h

            // scale.y = Mathf.Max( scale.y, scaleYMin );



            spTrans.localScale = scale;                          





        
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    }

}
