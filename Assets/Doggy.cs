using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Woof()
    {
        AudioSource source = this.transform.Find("WoofSound").GetComponent<AudioSource>();
        // source.time = 0.0f;
        if (source.time == 0.0f)
        {
            source.time = 0.3f;
            source.Play();
        }
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        Woof();
        if (GameObject.Find("Dog bowl").GetComponent<feeddog>().food.activeSelf)
        {
            MainController.theController.onDogTriggered();
        }
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource source = this.transform.Find("WoofSound").GetComponent<AudioSource>();
        if (source.time > 2.0f)
        {
            source.time = 0.0f;
            source.Stop();
        }
    }
}
