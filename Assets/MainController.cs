using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    private static MainModel mainModel;

    // TODO: set the dialogue object in Start() (那ㄍ對話框)
    public GameObject dialogueObj;

    /// <summary>
    /// Initialize the scene (if needed)
    /// </summary>
    /// <param name="id">Id of scene to load</param>
    /// <returns>The parent GameObject of the scene</returns>
    public GameObject LoadScene(int id)
    {
        switch (id)
        {
            case 0:
                {
                    
                    return null;
                }

        }

        return null;
    }

    public void SwitchScene(int id, int from)
    {
        GameObject obj = LoadScene(from);

        // find the GameObject location-from-<from>
        string locationNode = string.Format("location-from-{0}", from);
        Vector3 location = obj.transform.Find(locationNode).position;

        // TODO: set player location
    }

    /// <summary>
    /// Creates a series of dialogues
    /// </summary>
    /// <param name="id"></param>
    public void TriggerDialogue(string id)
    {
        // TODO: open dialogues mainModel.CreateDialog
        switch (id)
        {
            case "mom.talk":
                break;
            case "phone.talk":
                break;
        }

        // no callback: `mainModel.CreateDialogue("Some dialogue", () => {})`
        // open series of dialogue: `mainModel.CreateDialogue("The first message", () => TriggerDialogue("The second message"))`
    }

    //////////////////////////////////////////////////////////////////

    void StartStory()
    {

    }

    void StartGameplay()
    {
        // LoadScene(0);
        SwitchScene(0, 0);

        // TODO: setup interactive objects

        // TODO: setup 
    }

    // Start is called before the first frame update
    void Start()
    {
        //StartStory();
        StartGameplay();

        mainModel = GameObject.Find("MainModel").GetComponent<MainModel>();

        // TODO: set the dialogue object (那ㄍ對話框)
        dialogueObj = null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
