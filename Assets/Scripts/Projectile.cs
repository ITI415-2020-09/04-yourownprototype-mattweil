using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public CannonController cannon;
    // public Text cubesCollected;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){

        // cubesCollected.text = "Cubes Collected: " + shotsLeft.ToString();   



        if(other.gameObject.CompareTag("TargetCube")){

            other.gameObject.SetActive(false);
            cannon = GameObject.Find("Cylinder").GetComponent<CannonController>();
            // cannon.collected = cannon.collected + 1;
            cannon.collected = cannon.collected + 1;
           print(cannon.collected);
        }

    }



}
