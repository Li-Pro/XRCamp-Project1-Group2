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
    public GameObject playerLeftHandObj;
    public GameObject playerRightHandObj;
    public GameObject motherObj;

    // TODO: set this
    public int currentStoryNode;

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
                    motherObj = GameObject.FindWithTag("mother");
                    return GameObject.Find("scene0-controller");
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
            case "story.start.0":
                mainModel.CreateDialogue("Long time ago,", () => TriggerDialogue("story.start.1"));
                break;
            case "story.start.1":
                mainModel.CreateDialogue("this is the second line.", () => StartGameplay());
                break;
            case "mom.talk":
                mainModel.CreateDialogue("媽媽 : please feed dog:)", () => LoadStoryNode(1));
                break;
            case "phone.talk":
                break;
        }

        // no callback: `mainModel.CreateDialogue("Some dialogue", () => {})`
        // open series of dialogue: `mainModel.CreateDialogue("The first message", () => TriggerDialogue("The second message"))`
    }

    public void onMotherTriggered(Collider other) {
        bool check = GameObject.Find("phone").GetComponent<message>().message_check;
        // Debug.Log("hi " + this + " " + other);
        motherObj.GetComponent<mother_control>().mother_controller(other,check);

    }

    public void onPhoneTriggered(Collider other) {
        // set message.message_check to true
    }

    //////////////////////////////////////////////////////////////////

    void StartPrologue()
    {
        TriggerDialogue("story.start.0");

        // StartGameplay();
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
                    mainModel.SwitchScene(0, 0);
                    break;
                }
            case 1:
                {
                    
                    break;
                }
        }
    }

    void StartGameplay()
    {
        // LoadScene(0);
        
        dialogueObj.SetActive(false);
        LoadStoryNode(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainModel = GameObject.Find("MainModel").GetComponent<MainModel>();

        // allow cross-scene reference
        UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = false;

        // TODO: setup the object refs with Find or FindWithTag
        dialogueObj = GameObject.Find("textbubble");
        playerObj = GameObject.FindWithTag("Player");
        playerLeftHandObj = GameObject.FindWithTag("hands_l_gloves_mat06");
        playerRightHandObj = GameObject.FindWithTag("hands_r_gloves_mat06");

        // checks on connected objects
        Debug.Assert(dialogueObj != null, "Dialogue Obj should be initialized.");
        Debug.Assert(playerObj != null, "Player Obj should be initialized.");


        StartPrologue();
        // StartGameplay();
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
