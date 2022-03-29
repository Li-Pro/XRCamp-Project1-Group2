using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feeddog : MonoBehaviour
{
    public GameObject food;
    public bool isfed = false;
    // Start is called before the first frame update
    void Start()
    {
        food.SetActive(false);
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dog_food_pouch" && !food.activeSelf)
        {
            // food.transform.Find("PouringSound").GetComponent<AudioSource>().Play();
            GameObject pourSoundObj = GameObject.Find("PouringSound");
            if (pourSoundObj != null)
            {
                pourSoundObj.GetComponent<AudioSource>().Play();
            }

            food.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void food_disappear()
    {
        if (!food.activeSelf)
        {
            return;
        }

        Debug.Log("feed");
        food.SetActive(false);
        isfed = true;
    }
}
