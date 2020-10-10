using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CannonController : MonoBehaviour
{
    [Header("Set in Inspector")]

	public Text shotsText;
	public Text collectedText;
	public GameObject cannon;
	public GameObject prefabProjectile;
	public float velocityMult = 19000f;
	public GameObject launchPoint;
	public float fireRate = 0.9F;
	public int collected = 0;
	private int shotsLeft = 5;


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
     shotsText.text = "Shots Left: " + shotsLeft.ToString();
	 collectedText.text = "Cubes Collected: " + collected.ToString();   
    }
	



	
	
    // Update is called once per frame
    void Update()
    {
		 collectedText.text = "Cubes Collected: " + collected.ToString();

        if (Input.GetKey ("space") && Time.time > nextFire && shotsLeft > 0 ) {
			nextFire = Time.time + fireRate;
			projectile = Instantiate( prefabProjectile ) as GameObject;
			projectile.transform.position = launchPos;
			projectileRigidbody = projectile.GetComponent<Rigidbody>();
			projectileRigidbody.velocity = launchPoint.transform.up * velocityMult;
			projectile = null;
			shotsLeft = shotsLeft - 1;
			shotsText.text = "Shots Left: " + shotsLeft.ToString();   

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
