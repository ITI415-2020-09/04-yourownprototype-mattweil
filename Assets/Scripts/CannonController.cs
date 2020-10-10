using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    [Header("Set in Inspector")]

  
	public GameObject cannon;
	public GameObject prefabProjectile;
	public float velocityMult = 19000f;
	public GameObject launchPoint;
	public float fireRate = 0.5F;
	
    [Header("Set Dynamically")]
    // public GameObject launchPoint;
	public bool didFire = false;
    public Vector3 launchPos; 
	private Rigidbody projectileRigidbody;  	
    public GameObject projectile;

	
  
  private float nextFire = 0.0F;
	
	void Awake(){
	   // Transform launchPointTrans = transform.FindChild("LaunchPoint");
        //launchPoint = launchPointTrans.gameObject;
        // launchPoint.SetActive( false );
        launchPos = launchPoint.transform.position;  
	}
	
    void Start()
    {
        
    }
	



	
	
    // Update is called once per frame
    void Update()
    {
		

        if (Input.GetKey ("space") && Time.time > nextFire ) {
			nextFire = Time.time + fireRate;
			projectile = Instantiate( prefabProjectile ) as GameObject;
			projectile.transform.position = launchPos;
			projectileRigidbody = projectile.GetComponent<Rigidbody>();
			projectileRigidbody.velocity = launchPoint.transform.up * velocityMult;
			projectile = null;

		}
        if (Input.GetKey ("left")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z < 0.7){
				transform.Rotate(0, 0, 1);
				launchPos = launchPoint.transform.position;  
			}
		}
		if (Input.GetKey ("right")) {
			print(cannon.transform.rotation.z);
			if(cannon.transform.localRotation.z > -0.7){
				transform.Rotate(0, 0, -1);
				launchPos = launchPoint.transform.position;  
			}
			
		}
    }
}
