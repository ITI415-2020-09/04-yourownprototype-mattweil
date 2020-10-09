using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
	
	public GameObject cannon;
	public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		

		
		
        if (Input.GetKey ("up")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z < 0){
				transform.Rotate(0, 0, 1);
			}
		}
		if (Input.GetKey ("down")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z > -0.7){
				transform.Rotate(0, 0, -1);
			}
			
		}
    }
}
