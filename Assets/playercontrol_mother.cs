using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol_mother : MonoBehaviour
{
    private static MainController mainController;

    public GameObject mom;
    //public GameObject teddy;
    //public float dist=10;
    //RaycastHit hit;

    
    void Start()
    {

        mainController = GameObject.Find("MainController").GetComponent<MainController>();
    }
    void change_material(GameObject gameObject,Material mat){
        // gameObject.GetComponent(typeof(gameObject)).material = mat;
    }
    void OnTriggerEnter(Collider other){
        // I would migrate this to controller later :)
        // mother_control(other,check);
       // Debug.Log("hi " + other);
        // if (other == mainController.playerLeftHandObj || other == mainController.playerRightHandObj)
        
        // TODO: call controller for mother & phone, remember to 判斷故事線
        if (other.tag == "mother") {
            // Debug.Log("hi " + other);
            Debug.Log("Me: " + this.tag + " " + other);
            mainController.onMotherTriggered(other);
        }
        
    }
    void OnTriggerExit(Collider other){
        if(other.tag=="mother"){
            mainController.motherObj.GetComponent<mother_control>().UiObject.SetActive(false);
        }
    }
}
