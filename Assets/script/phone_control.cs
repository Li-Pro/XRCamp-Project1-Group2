using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone_control : MonoBehaviour
{
    public bool message_check = false;

    private float screen_brightness = 1.0f;
    private bool faded = false;

    public void onTrigger(Collider collider, bool isMomTriggered)
    {
        message_check = true;

        if (!isMomTriggered)
        {
            MainController.theController.TriggerDialogue("phone.talk");
            this.transform.Find("VibrateSound").GetComponent<AudioSource>().Play();
        }
        else
        {
            fadeScreen();
            MainController.theController.TriggerDialogue("phone.battery.low");
            this.transform.Find("VibrateSound").GetComponent<AudioSource>().Play();
        }

        //public static MainController theController { get; private set; } = null;

        //Debug.Assert(theController == null, "There should be only one MainController.");
        //theController = this;
    }

    private void fadeScreen()
    {
        const int steps = 10;
        const float duration = 2.0f;

        IEnumerator fadeFunc()
        {
            for (int i = 0; i < steps; i++)
            {
                Debug.Log("the alpha: " + screen_brightness);

                screen_brightness -= 1.0f / steps;
                yield return new WaitForSeconds(duration / steps);
            }
        };

        if (!faded)
        {
            faded = true;
            StartCoroutine(fadeFunc());
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("colliding with: " + other);
    //     if (other.name.StartsWith("hand"))
    //     {
    //         Debug.Log("colliding with2: " + other);
    //         //fadeScreen();

    //         MainController.theController.onPhoneTriggered(this.GetComponent<Collider>());
    //     }
    // }

    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Material material = this.GetComponent<MeshRenderer>().materials[1];
        //material.color = new Color(material.color.r, material.color.g, material.color.b, screen_alpha);
        material.color = new Color(screen_brightness * material.color.r, screen_brightness * material.color.g, screen_brightness * material.color.b, 1.0f);
    }
}
