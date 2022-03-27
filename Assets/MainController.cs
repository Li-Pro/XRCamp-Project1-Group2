using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // main model
    private static MainModel mainModel;

    // sub controllers
    // ...

    // TODO: set the dialogue object & player object in Start()
    public GameObject dialogueObj;
    public GameObject playerObj;

    /// <summary>
    /// Initializes the scene (if needed)
    /// </summary>
    /// <param name="id">Id of scene to load</param>
    /// <returns>The parent GameObject of the scene</returns>
    public GameObject LoadScene(int id)
    {
        switch (id)
        {
            case 0:
                {
                    // TODO: return the parent object of the scene
                    return null;
                }

        }

        return null;
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

    void StartPrologue()
    {

    }

    /// <summary>
    /// Load a node of the story line
    /// </summary>
    /// <param name="id">the story node to load</param>
    void LoadStoryNode(int id)
    {
        switch (id)
        {
            case 0:
                {
                    // TODO: setup interactive objects (mom & phone)
                    // TODO: setup
                    break;
                }
        }
    }

    void StartGameplay()
    {
        // LoadScene(0);
        mainModel.SwitchScene(0, 0);
        LoadStoryNode(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainModel = GameObject.Find("MainModel").GetComponent<MainModel>();

        // allow cross-scene reference
        UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = false;

        // TODO: setup the object refs with Find or FindWithTag
        //dialogueObj = GameObject.Find("<name of dialogue>");
        //playerObj = GameObject.Find("<name of player>");

        // checks on connected objects
        Debug.Assert(dialogueObj != null, "Dialogue Obj should be initialized.");
        Debug.Assert(playerObj != null, "Player Obj should be initialized.");


        //StartPrologue();
        StartGameplay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        // reset cross-scene reference settings to prevent edits in editor (it would not be saved)
        UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = true;
    }
}
