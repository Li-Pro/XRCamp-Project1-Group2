using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
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

    void OnTriggerEnter(Collider other){
        // I would migrate this to controller later :)
        // mother_control(other,check);
        
        // Debug.Log("hi " + other);
        // if (other == mainController.playerLeftHandObj || other == mainController.playerRightHandObj)
        
        // TODO: call controller for mother & phone, remember to 判斷故事線
        if (other.tag == "mother") {
            // Debug.Log("hi " + other);
            // Debug.Log("Me: " + this.tag + " " + other);
            mainController.onMotherTriggered(other);
        }

        if(other.tag == "phone")
        {
            // Debug.Log("hi phone");
            mainController.onPhoneTriggered(other);
        }

        // if (other.tag == "dog")
        // {
        //     // Debug.Log("hi dog");
        //     mainController.onDogTriggered();
        // }

        if(other.tag == "father")
        {
            // Debug.Log("hi father");
            mainController.onFatherTriggered();
        }
        
    }
    void OnTriggerExit(Collider other){
        if(other.tag=="mother"){
            mainController.motherObj.GetComponent<mother_control>().UiObject.SetActive(false);
        }
        if (other.tag == "dog")
        {
            //mainController.motherObj.GetComponent<feeddog>().food.SetActive(false);
        }
    }
}
