using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // self instance
    public static MainController theController { get; private set; } = null;

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
    public GameObject fatherObj;
    public GameObject phoneObj;
    public GameObject foodObj;
    public GameObject dogObj;
    public GameObject bowlObj;
    public GameObject blackObj;

    // TODO: set this
    public int currentStoryNode = -1;
    public int currentScene = -1;

    private UnityEngine.InputSystem.InputActionAsset defaultPlayerAction;

    /// <summary>
    /// Initializes the scene (if needed)
    /// </summary>
    /// <param name="id">Id of scene to load</param>
    /// <returns>The parent GameObject of the scene</returns>
    public GameObject LoadScene(int id)
    {
        currentScene = id;
        switch (id)
        {
            case 0:
                {
                    // TODO: return the parent object of the scene
                    //motherObj = GameObject.FindWithTag("mother");
                    
                    // GetSceneBGM(0).Play();
                    return GameObject.Find("scene0-controller");
                }
            case 1:
                {
                    //foodObj = GameObject.FindWithTag("food");
                    //return GameObject.Find("scene0-controller");//check
                    
                    // GetSceneBGM(1).Play();
                    return GameObject.Find("scene1-controller");
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
        // Debug.Log("02193092813098");

        // TODO: open dialogues mainModel.CreateDialog
        switch (id)
        {
            // case "story.start.0":
            //     mainModel.CreateDialogue("很久很久以前，有個溫馨的小屋，住著你和爸爸媽媽一家三口，還有你最喜歡的小狗大白", () => TriggerDialogue("story.start.1"));
            //     break;
            // case "story.start.1":
            //     mainModel.CreateDialogue("你的名字叫xxx，是個好吃懶做的米蟲，媽媽", () => TriggerDialogue("story.start.2"));
            //     break;
            // case "story.start.2":
            //     mainModel.CreateDialogue("一個平凡的午後，你剛剛看電視看到睡著，從沙發上醒來", () => StartGameplay());
            //     break;
            case "story.guide.0":
                mainModel.CreateDialogue("　　　　　命中 機遇\n　　　　 開始遊戲(Y)", () => TriggerDialogue("story.guide.1"));
                break;
            case "story.guide.1":
                mainModel.CreateDialogue("　教學\n　Y：確認\n　觸碰物件：互動\n　食指抓取物件：抓取", () => StartPrologue());
                break;
            case "story.start.0":
                mainModel.CreateDialogueOverlay("OOO 原本是個想像力豐富的女孩，總是以畫圖來發揮想像力，也喜歡和小狗 大白 玩遊戲。", () => TriggerDialogue("story.start.1"));
                break;
            case "story.start.1":
                mainModel.CreateDialogueOverlay("但是自從去年生日獲得第一支手機後，OOO 就開始沉迷網路，不再畫畫，也漸漸忽略大白了...", () => StartGameplay());
                break;
            case "mom.talk":
                mainModel.CreateDialogue("媽媽 : OOO，別一直看電視，記得要去餵大白:)", () => LoadStoryNode(2), motherObj.GetComponent<mother_control>());
                break;
            case "phone.talk":
                mainModel.CreateDialogue("訊息：2022春徵線上說明會好康報報！參加線上說明會每人每場次可獲一點，7點可兌換7-11百元商品卡，14點可兌換7-11千元商品卡！", () => /*SetDialogueActiveFalse(2)*/ {});
                break;
            case "phone.battery.low":
                mainModel.CreateDialogue("手機沒電了...", () => LoadStoryNode(2));
                break;
            case "father":
                mainModel.CreateDialogue("爸爸：這禮拜是不是還沒帶大白去散步，趁天氣好去遛一下大白吧！", () => LoadStoryNode(5), fatherObj.GetComponent<father_control>());
                break;
            case "missing.dog":
                mainModel.CreateDialogue("：咦？大白怎麼不見了...", () => TriggerDialogue("missing.dog.2"));
                break;
            case "missing.dog.2":
                mainModel.CreateDialogue("：剛剛不是還好好的待在客廳裡嗎?", () => LoadStoryNode(4));//結尾(?
                break;
            case "white.ending":
                mainModel.CreateDialogue("：大白?", () => EndWhiteEnding());
                break;
            case "feed.dog":
                mainModel.CreateDialogue("媽媽：餵小白一點好吃的東西!關心狗狗是很重要的", () => SetDialogueActiveFalse(3), motherObj.GetComponent<mother_control>());
                break;
            default:
                Debug.LogError("ID does not exist: " + id);
                break;
        }

        // no callback: `mainModel.CreateDialogue("Some dialogue", () => {})`
        // open series of dialogue: `mainModel.CreateDialogue("The first message", () => TriggerDialogue("The second message"))`
    }

    //private class phone_control : MonoBehaviour { public bool message_check=false; }

    public AudioSource GetSceneBGM(int scene)
    {
        // switch (scene)
        // {
        //     case 0:
        //         return GameObject.Find("BGM0").GetComponent<AudioSource>();
        // }
        
        string bgmNodeName = string.Format("BGM{0}", scene);
        return GameObject.Find(bgmNodeName).GetComponent<AudioSource>();
    }

    public void onMotherTriggered(Collider other) {
        bool check = GameObject.Find("phone").GetComponent<phone_control>().message_check;
        // Debug.Log("hi " + this + " " + other);
        if (check)
        {
            // motherObj.GetComponent<mother_control>().toteddy(other);

            if (currentStoryNode == 1)
            {
                // LoadStoryNode(2);
                // currentStoryNode = 3;
                
                motherObj.GetComponent<mother_control>().toteddy(other);
                LoadStoryNode(3);
            }
        }
        else if (currentStoryNode == 1)
        {
            TriggerDialogue("mom.talk");
            motherObj.GetComponent<mother_control>().check_mom_first=true;
        }
    }

    public void onPhoneTriggered(Collider other) {
        // set message.message_check to true
        bool check2 = GameObject.FindWithTag("mother").GetComponent<mother_control>().check_mom_first;
        if (!check2 && currentStoryNode == 1)
        {
            phoneObj.GetComponent<phone_control>().onTrigger(other, check2);
        }
        else
        {
            phoneObj.GetComponent<phone_control>().onTrigger(other, check2);
        }

    }

    public void onDogTriggered()
    {
        // if (currentStoryNode == 2 && GameObject.FindWithTag("mother").GetComponent<mother_control>().check_mom_first)
        // {
        //     TriggerDialogue("feed.dog");
        //     GetSceneBGM(1).volume = 0.3f;
        //     bowlObj.GetComponent<feeddog>().food_disappear();
        // }
        // else
        // {
        //     Debug.Log("not 2");
        // }

        if (currentStoryNode <= 1)
        {
            return;
        }

        if (currentStoryNode == 2)
        {
            TriggerDialogue("feed.dog");
        }

        GetSceneBGM(1).volume = 0.3f;
        bowlObj.GetComponent<feeddog>().food_disappear();

        // if (currentStoryNode == 2)
        // {
        //     LoadStoryNode(3);
        // }
    }

    public void onFatherTriggered()
    {
        if (currentStoryNode != 3)
        {
            Debug.Log("not 3");
            return;
        }

        bool check3 = GameObject.Find("Dog bowl").GetComponent<feeddog>().isfed;

        if(currentStoryNode == 3)
        {
            if (check3)
            {
                //happy ending
                // bool check = GameObject.Find("phone").GetComponent<phone_control>().message_check;
                // if (check)
                // {
                //     // reset the pitch
                // }

                // reset the pitch
                // GameObject.Find("BGM").GetComponent<AudioSource>().pitch = 1.0f;
                // GetSceneBGM(1).volume = 0.3f;

                TriggerDialogue("father");
                dogObj.transform.position = GameObject.Find("dog_position").transform.position;
            }
            else
            {
                //bad ending
                blackObj.SetActive(true);
                mainModel.SetEmptyScene();
                TriggerDialogue("missing.dog");
                // blackObj.SetActive(true);
            }
        }
        else
        {
            Debug.Log("not 3");
        }
    }
    
    void SetDialogueActiveFalse(int storynode)
    {
        dialogueObj.SetActive(false);
        LoadStoryNode(storynode);
    }

    public void SetPlayerMovable(bool enabled)
    {
        //mainController.playerObj.SetActive(enabled);

        //mainController.playerObj.GetComponent<BNG.VREmulator>().EmulatorEnabled = enabled;


        playerObj.transform.Find("PlayerController").GetComponent<BNG.SmoothLocomotion>().UpdateMovement = enabled;

        //playerObj.GetComponent<BNG.VREmulator>().EmulatorActionSet = (enabled ? defaultPlayerAction : null);
    }

    //////////////////////////////////////////////////////////////////

    void StartPrologue()
    {
        LoadStoryNode(0);
        // mainModel.SwitchScene(0, 0);

        blackObj.SetActive(false);
        dialogueObj.SetActive(true);
        TriggerDialogue("story.start.0");

        // StartGameplay();
    }

    /// <summary>
    /// Load a node of the story line
    /// </summary>
    /// <param name="id">the story node to load</param>
    void LoadStoryNode(int id)
    {
        Debug.Log("Loading story node " + id);
        switch (id)
        {
            case 0:
                {
                    // TODO: setup interactive objects (mom & phone)
                    // TODO: setup
                    currentStoryNode = 0;
                    mainModel.SwitchScene(0, 0);
                    // mainModel.SwitchScene(1, 0);
                    break;
                }
            case 1:
                {
                    currentStoryNode = 1;
                    //room1
                    mainModel.SwitchScene(1, 0);
                    break;
                }
            case 2:
                {
                    //feed dog
                    currentStoryNode = 2;
                    break;
                }
            case 3:
                {
                    //room2
                    currentStoryNode = 3;
                    break;
                }
            case 4:
                {
                    currentStoryNode = 4;
                    StartWhiteEnding();
                    break;
                }
            case 5:
                {
                    currentStoryNode = 5;
                    motherObj.GetComponent<mother_control>().backFromTeddy();
                    // GetSceneBGM(currentScene).pitch += 0.2f;
                    break;
                }
        }
    }

    void StartWhiteEnding()
    {
        blackObj.SetActive(true);
        mainModel.SetEmptyScene();

        playerLeftHandObj.SetActive(false);
        playerRightHandObj.SetActive(false);

        dogObj.GetComponent<Doggy>().Woof();
        
        // AudioSource carStop = playerObj.transform.Find("CarStopSound").GetComponent<AudioSource>();
        // AudioSource carStopWoof = playerObj.transform.Find("CarStopWoofSound").GetComponent<AudioSource>();

        AudioSource carStop = GameObject.Find("CarStopSound").GetComponent<AudioSource>();
        AudioSource carStopWoof = GameObject.Find("CarStopWoofSound").GetComponent<AudioSource>();
        
        GetSceneBGM(currentScene).Stop();

        carStop.Play();
        carStop.time = 26.0f;

        carStopWoof.Play();

        // const float duration = 5;
        // const int stepCount = 50;

        // const float step = duration / stepCount;

        // for (int i = 0; i < stepCount; i++)
        // {
        //     mainModel.CallbackInSecond(() => {
        //         carStop.volume -= 0.7f * step;
        //         carStopWoof.volume -= 0.5f * step;
        //     }, step);
        // }

        mainModel.CallbackInSecond(() => {
            carStop.Stop();
            // carStopWoof.Stop();
        }, 5.0f);

        mainModel.CallbackInSecond(() => {
            // carStop.Stop();
            carStopWoof.Stop();
            TriggerDialogue("white.ending");
        }, 8.0f);
    }

    void EndWhiteEnding()
    {
        dialogueObj.SetActive(true);
        dialogueObj.transform.Find("Panel").gameObject.SetActive(false);
        dialogueObj.transform.Find("Text").gameObject.SetActive(false);

        UnityEngine.UI.Image image = blackObj.GetComponent<UnityEngine.UI.Image>();
        float brightness = 0;

        void brighten() {
            image.color = new Color(brightness, brightness, 0.8f*brightness, 1.0f);
            brightness += 0.01f;
            
            if (brightness < 1.0f)
            {
                mainModel.CallbackInSecond(brighten, 0.1f);
            }
        }

        // playerLeftHandObj.SetActive(false);
        // playerRightHandObj.SetActive(false);

        mainModel.CallbackInSecond(brighten, 0.0f);
        mainModel.CallbackInSecond(() => {
            GetSceneBGM(0).Play();
        }, 5.0f);
    }

    void StartGameplay()
    {
        // LoadScene(0);
        
        dialogueObj.SetActive(false);
        // foodObj.SetActive(true);

        LoadStoryNode(1);
    }

    void StartMenu()
    {
        mainModel.SetEmptyScene();
        TriggerDialogue("story.guide.0");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(theController == null, "There should be only one MainController.");
        theController = this;

        mainModel = GameObject.Find("MainModel").GetComponent<MainModel>();

        // allow cross-scene reference
        UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = false;

        // TODO: setup the object refs with Find or FindWithTag
        dialogueObj = GameObject.Find("textbubble");
        playerObj = GameObject.FindWithTag("Player");
        playerLeftHandObj = GameObject.FindWithTag("hands_l_gloves_mat06");
        playerRightHandObj = GameObject.FindWithTag("hands_r_gloves_mat06");
        // foodObj = GameObject.FindWithTag("food");
        bowlObj = GameObject.Find("Dog bowl");
        dogObj = GameObject.FindWithTag("dog");
        motherObj = GameObject.FindWithTag("mother");
        fatherObj = GameObject.FindWithTag("father");
        blackObj = GameObject.Find("blackarea");
        phoneObj = GameObject.Find("phone");

        defaultPlayerAction = playerObj.GetComponent<BNG.VREmulator>().EmulatorActionSet;

        // checks on connected objects
        Debug.Assert(dialogueObj != null, "Dialogue Obj should be initialized.");
        Debug.Assert(playerObj != null, "Player Obj should be initialized.");

        // playerObj.transform.Find("PlayerController").GetComponent<BNG.PlayerTeleport>().HandSide = BNG.ControllerHand.None;

        //Debug.Log("someTHING");
        //StartCoroutine(Lates)
        
        StartMenu();
        // StartPrologue();
        // StartGameplay();
    }

    // Update is called once per frame
    void Update()
    {
        playerObj.transform.Find("PlayerController").GetComponent<BNG.PlayerTeleport>().enabled = false;
    }

    void OnDestroy()
    {
        // reset cross-scene reference settings to prevent edits in editor (it would not be saved)
        UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = true;
    }
}
