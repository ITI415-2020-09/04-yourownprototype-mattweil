using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [Header("Set in Inspector")]

  
	public GameObject cannon;
	public GameObject prefabProjectile;
	public float velocityMult = 8f;
	public GameObject launchPoint;
	
    [Header("Set Dynamically")]
    // public GameObject launchPoint;
    public Vector3 launchPos; 
	
	private Rigidbody projectileRigidbody;  	
    public GameObject projectile;
    // Start is called before the first frame update\
	
	void Awake(){
	   // Transform launchPointTrans = transform.FindChild("LaunchPoint");
        //launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive( false );
        launchPos = launchPoint.transform.position;  
	}
	
    void Start()
    {
        
    }
	
	private void FireCannon(){
		
	
	}


	
	
    // Update is called once per frame
    void Update()
    {
		

        if (Input.GetKey ("space")) {
			
			projectile = Instantiate( prefabProjectile ) as GameObject;
			projectile.transform.position = launchPos;
			projectileRigidbody = projectile.GetComponent<Rigidbody>();
            projectileRigidbody.velocity = launchPos * velocityMult;
            projectile = null;
		}
        if (Input.GetKey ("up")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z < 0){
				transform.Rotate(0, 0, 1);
				launchPos = launchPoint.transform.position;  
			}
		}
		if (Input.GetKey ("down")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z > -0.7){
				transform.Rotate(0, 0, -1);
				launchPos = launchPoint.transform.position;  
			}
			
		}
    }
}
