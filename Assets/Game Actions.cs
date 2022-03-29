// GENERATED AUTOMATICALLY FROM 'Assets/Game Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game Actions"",
    ""maps"": [
        {
            ""name"": ""XR HMD"",
            ""id"": ""09ff3ccc-21b4-4346-a3a2-7c978b5af892"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""1a9029f8-7a46-46b9-9eff-e9ae8365f611"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""aed87fe6-2b01-4dd2-a8fa-195578fd8158"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cff1f981-6e1f-4e2c-a90c-715a0ea2e80e"",
                    ""path"": ""<XRHMD>/centerEyePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2017383-a3f6-4c46-acb1-012b8eece9cc"",
                    ""path"": ""<XRHMD>/centerEyeRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XR LeftHand"",
            ""id"": ""5fe596f9-1b7b-49b7-80a7-3b5195caf74d"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""83a7af0b-87e3-42c3-a909-95fbf8091e4f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""cb6b7130-2bac-4ef7-abe4-6991ae7d419d"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""33754c03-48ec-46ef-9bc6-22ed6bfdd8e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""0c0991c5-d329-4afc-8892-1076b440477c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""664a62b0-e178-421d-b3f8-014eec01591d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9693e25f-8a4f-4aed-842f-3961243c69a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9164e093-ebd4-4923-af32-1b52f31c2d66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Start"",
                    ""type"": ""Button"",
                    ""id"": ""cbeaf823-3b69-4004-8ec8-13ea2ca3fc31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a21db72c-4843-4839-b4d0-3ce8d287cb86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""89ce8348-6001-41a3-85b9-f8f2e2dcad7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Teleport Destination"",
                    ""type"": ""Value"",
                    ""id"": ""21b75b25-12ad-410f-b4f8-a7745b7aca27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Locomotion Mode Toggle"",
                    ""type"": ""Button"",
                    ""id"": ""ecd077af-c63a-41bb-891d-196a89166399"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""dae94c47-3da5-40be-9db6-36a9239b3603"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""5655e5d6-b3bf-4d77-92af-ac9f96f41f7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slow Time"",
                    ""type"": ""Button"",
                    ""id"": ""0a79676f-8968-4656-bfd8-e1605ca62d6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""c2dedd64-ee19-4581-bed1-8180a29cf847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79634234-07c9-488b-98bd-7d83eb6895c5"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bf4fccb-bf42-4ec5-b215-c967f1d71642"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71a4d23f-3e9a-4513-923b-ba388c5e84bf"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""487f4f2e-9e9b-49aa-b0f2-4037a24624f5"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de8136fd-5b07-4794-bb96-63c6027cf1b6"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""529c0dda-d254-4a71-8aa8-7dbdeabbe45d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dad37c56-3fcd-4890-98bf-e06f80ba76ff"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0dd3431-14bb-4817-ac71-ed700d5af1ca"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0064f189-a00e-4cf8-9f53-be76a30cb97f"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8e383b1a-270f-4c20-819b-89a59cffb498"",
                    ""path"": ""<XRController>{LeftHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Continuous Move"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector Keyboard"",
                    ""id"": ""baecc7a7-e573-4ff4-8745-6f72151ba809"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5af8ae08-9e32-4a4a-91fe-3334c96dd7e1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4dcf3efe-8076-4f67-b361-5bfcf3f18ba1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b30c41f-d344-44cc-a40e-10f087164281"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c9589cb8-e972-4b65-b264-7d129a4088c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""acdf9550-5529-4ff7-8558-73ecdf0d75bd"",
                    ""path"": ""<XRController>{LeftHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e870334b-3dcf-4446-80da-692913c748ee"",
                    ""path"": ""<XRController>{LeftHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Locomotion Mode Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73a6d359-40f8-4581-9827-91d1d6b66a4e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89b24cb8-9e2a-42a2-bbf3-c106fea6e24e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow Time"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""583bd4fd-754c-4e71-972b-60d1e120215b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""863d5818-8537-46f8-8861-0a81bf75c8b7"",
                    ""path"": ""<XRController>{LeftHand}/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector Keyboard"",
                    ""id"": ""146a3d26-d500-465d-b918-3d044f109140"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport Start"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e85266c4-b52f-4046-bebd-87c1a98f5af0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""XR RightHand"",
            ""id"": ""7960f8ef-2bf3-4281-aecc-4c03809d6c8c"",
            ""actions"": [
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""c4990d70-7b8a-4ce1-b03c-da86716b8352"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""ee6bf5bf-bb0a-4a50-8327-cb654b19e298"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""ac96c10b-c955-4a46-8e67-bf16bc069b53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""41976d89-60de-4deb-bff9-16b4af96b290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI Press"",
                    ""type"": ""Button"",
                    ""id"": ""65174b45-c2ee-4f90-93bb-fb4084eaaab3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptic Device"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57b2a1b4-3290-46d6-ac07-4854ee8f91b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""00a4dc9f-1ee6-4349-b0e9-72d5dccaadd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""9fb2eb2b-2fb6-4328-8167-10a1bf11b424"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Select"",
                    ""type"": ""Button"",
                    ""id"": ""02e43582-8973-4940-af06-dff6158e3df2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Activate"",
                    ""type"": ""Button"",
                    ""id"": ""a6c7231d-c55d-4dd4-9e87-877bb5522ef5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""d587b60c-39a0-4365-8075-477ce484ba0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Teleport Destination"",
                    ""type"": ""Value"",
                    ""id"": ""9b5d8312-f609-4895-b70f-81a722b2ae11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa59aed1-ae0b-4074-a58c-294b85f46228"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d2a5710-51f9-4e4b-a592-021821e5caa7"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62690862-4688-4010-975b-b3d9c6062157"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90efd65e-3290-4798-af15-21ab4d7848b5"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de466e6e-12bf-46a1-b0fd-ffbc343f3399"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919c4a6c-22ed-4083-8e14-f30e91ff59fe"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e6d19f-8306-47c9-8ca9-d3b6137565dc"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Teleport Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""274078b0-62e5-4730-bcc2-6896b9ad9f0c"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ce80054-410d-4112-a332-50faa7fb4f23"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92bb5b8f-bf48-4dab-af05-50a865773895"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""UI Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6011e1e6-b2dd-4cb1-8da5-29b03868f2c5"",
                    ""path"": ""<XRController>{RightHand}/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Haptic Device"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""61502e80-1b21-4116-890c-c0bc31c9dffd"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2b466c01-134f-40f2-b376-f7e9684e423b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79757cb3-5b81-4a3d-bc3c-d2582f85d5db"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""76425f70-54b8-4f8e-ad52-94debc75962c"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1),Invert"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8df952de-cf29-4b5e-9a90-a6b4eee7f52c"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Rotate Teleport Destination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d6c08c3d-3d41-4695-994d-1ac9016a5a9e"",
                    ""path"": ""<XRController>{RightHand}/Primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7468b27d-4e22-4067-8456-add9bbbd63b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0060665c-f8a5-4464-b261-7378bd170441"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2d1f53df-152b-4add-bfd2-9da347a193e3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4e3d42ed-385f-4839-9281-6e56f0ff4777"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b812a05-917e-41b4-95c8-77e15f476b10"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""61a974cf-a984-4aa6-bb4f-c479e02ed8b1"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""b313bf22-cfa1-4bf3-bec1-360bbe62e540"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""29841cad-8ff7-49a7-b85a-d6f7d6192a87"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9be57c84-b560-4424-909a-e6809801304b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""428da702-2737-449b-985a-ad2e11de4ebb"",
                    ""path"": ""<XRController>/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a8e82d1-3811-4c2b-bcaf-02622d6df432"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f74f16cb-737c-48d5-97fe-0d85ddb656f9"",
                    ""path"": ""<XRController>/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38cf2cbe-0532-4a91-9dbc-3733ebd5b788"",
                    ""path"": ""<XRController>/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generic XR Controller"",
                    ""action"": ""PointerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generic XR Controller"",
            ""bindingGroup"": ""Generic XR Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<WMRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Continuous Move"",
            ""bindingGroup"": ""Continuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Noncontinuous Move"",
            ""bindingGroup"": ""Noncontinuous Move"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // XR HMD
        m_XRHMD = asset.FindActionMap("XR HMD", throwIfNotFound: true);
        m_XRHMD_Position = m_XRHMD.FindAction("Position", throwIfNotFound: true);
        m_XRHMD_Rotation = m_XRHMD.FindAction("Rotation", throwIfNotFound: true);
        // XR LeftHand
        m_XRLeftHand = asset.FindActionMap("XR LeftHand", throwIfNotFound: true);
        m_XRLeftHand_Position = m_XRLeftHand.FindAction("Position", throwIfNotFound: true);
        m_XRLeftHand_Rotation = m_XRLeftHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRLeftHand_Grab = m_XRLeftHand.FindAction("Grab", throwIfNotFound: true);
        m_XRLeftHand_Activate = m_XRLeftHand.FindAction("Activate", throwIfNotFound: true);
        m_XRLeftHand_HapticDevice = m_XRLeftHand.FindAction("Haptic Device", throwIfNotFound: true);
        m_XRLeftHand_Move = m_XRLeftHand.FindAction("Move", throwIfNotFound: true);
        m_XRLeftHand_Turn = m_XRLeftHand.FindAction("Turn", throwIfNotFound: true);
        m_XRLeftHand_TeleportStart = m_XRLeftHand.FindAction("Teleport Start", throwIfNotFound: true);
        m_XRLeftHand_TeleportActivate = m_XRLeftHand.FindAction("Teleport Activate", throwIfNotFound: true);
        m_XRLeftHand_TeleportCancel = m_XRLeftHand.FindAction("Teleport Cancel", throwIfNotFound: true);
        m_XRLeftHand_RotateTeleportDestination = m_XRLeftHand.FindAction("Rotate Teleport Destination", throwIfNotFound: true);
        m_XRLeftHand_LocomotionModeToggle = m_XRLeftHand.FindAction("Locomotion Mode Toggle", throwIfNotFound: true);
        m_XRLeftHand_Jump = m_XRLeftHand.FindAction("Jump", throwIfNotFound: true);
        m_XRLeftHand_Sprint = m_XRLeftHand.FindAction("Sprint", throwIfNotFound: true);
        m_XRLeftHand_SlowTime = m_XRLeftHand.FindAction("Slow Time", throwIfNotFound: true);
        m_XRLeftHand_Menu = m_XRLeftHand.FindAction("Menu", throwIfNotFound: true);
        // XR RightHand
        m_XRRightHand = asset.FindActionMap("XR RightHand", throwIfNotFound: true);
        m_XRRightHand_Position = m_XRRightHand.FindAction("Position", throwIfNotFound: true);
        m_XRRightHand_Rotation = m_XRRightHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRRightHand_Grab = m_XRRightHand.FindAction("Grab", throwIfNotFound: true);
        m_XRRightHand_Activate = m_XRRightHand.FindAction("Activate", throwIfNotFound: true);
        m_XRRightHand_UIPress = m_XRRightHand.FindAction("UI Press", throwIfNotFound: true);
        m_XRRightHand_HapticDevice = m_XRRightHand.FindAction("Haptic Device", throwIfNotFound: true);
        m_XRRightHand_Move = m_XRRightHand.FindAction("Move", throwIfNotFound: true);
        m_XRRightHand_Turn = m_XRRightHand.FindAction("Turn", throwIfNotFound: true);
        m_XRRightHand_TeleportSelect = m_XRRightHand.FindAction("Teleport Select", throwIfNotFound: true);
        m_XRRightHand_TeleportActivate = m_XRRightHand.FindAction("Teleport Activate", throwIfNotFound: true);
        m_XRRightHand_TeleportCancel = m_XRRightHand.FindAction("Teleport Cancel", throwIfNotFound: true);
        m_XRRightHand_RotateTeleportDestination = m_XRRightHand.FindAction("Rotate Teleport Destination", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_PointerPosition = m_UI.FindAction("PointerPosition", throwIfNotFound: true);
        m_UI_PointerRotation = m_UI.FindAction("PointerRotation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // XR HMD
    private readonly InputActionMap m_XRHMD;
    private IXRHMDActions m_XRHMDActionsCallbackInterface;
    private readonly InputAction m_XRHMD_Position;
    private readonly InputAction m_XRHMD_Rotation;
    public struct XRHMDActions
    {
        private @GameActions m_Wrapper;
        public XRHMDActions(@GameActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRHMD_Position;
        public InputAction @Rotation => m_Wrapper.m_XRHMD_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_XRHMD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRHMDActions set) { return set.Get(); }
        public void SetCallbacks(IXRHMDActions instance)
        {
            if (m_Wrapper.m_XRHMDActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRHMDActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_XRHMDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public XRHMDActions @XRHMD => new XRHMDActions(this);

    // XR LeftHand
    private readonly InputActionMap m_XRLeftHand;
    private IXRLeftHandActions m_XRLeftHandActionsCallbackInterface;
    private readonly InputAction m_XRLeftHand_Position;
    private readonly InputAction m_XRLeftHand_Rotation;
    private readonly InputAction m_XRLeftHand_Grab;
    private readonly InputAction m_XRLeftHand_Activate;
    private readonly InputAction m_XRLeftHand_HapticDevice;
    private readonly InputAction m_XRLeftHand_Move;
    private readonly InputAction m_XRLeftHand_Turn;
    private readonly InputAction m_XRLeftHand_TeleportStart;
    private readonly InputAction m_XRLeftHand_TeleportActivate;
    private readonly InputAction m_XRLeftHand_TeleportCancel;
    private readonly InputAction m_XRLeftHand_RotateTeleportDestination;
    private readonly InputAction m_XRLeftHand_LocomotionModeToggle;
    private readonly InputAction m_XRLeftHand_Jump;
    private readonly InputAction m_XRLeftHand_Sprint;
    private readonly InputAction m_XRLeftHand_SlowTime;
    private readonly InputAction m_XRLeftHand_Menu;
    public struct XRLeftHandActions
    {
        private @GameActions m_Wrapper;
        public XRLeftHandActions(@GameActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRLeftHand_Position;
        public InputAction @Rotation => m_Wrapper.m_XRLeftHand_Rotation;
        public InputAction @Grab => m_Wrapper.m_XRLeftHand_Grab;
        public InputAction @Activate => m_Wrapper.m_XRLeftHand_Activate;
        public InputAction @HapticDevice => m_Wrapper.m_XRLeftHand_HapticDevice;
        public InputAction @Move => m_Wrapper.m_XRLeftHand_Move;
        public InputAction @Turn => m_Wrapper.m_XRLeftHand_Turn;
        public InputAction @TeleportStart => m_Wrapper.m_XRLeftHand_TeleportStart;
        public InputAction @TeleportActivate => m_Wrapper.m_XRLeftHand_TeleportActivate;
        public InputAction @TeleportCancel => m_Wrapper.m_XRLeftHand_TeleportCancel;
        public InputAction @RotateTeleportDestination => m_Wrapper.m_XRLeftHand_RotateTeleportDestination;
        public InputAction @LocomotionModeToggle => m_Wrapper.m_XRLeftHand_LocomotionModeToggle;
        public InputAction @Jump => m_Wrapper.m_XRLeftHand_Jump;
        public InputAction @Sprint => m_Wrapper.m_XRLeftHand_Sprint;
        public InputAction @SlowTime => m_Wrapper.m_XRLeftHand_SlowTime;
        public InputAction @Menu => m_Wrapper.m_XRLeftHand_Menu;
        public InputActionMap Get() { return m_Wrapper.m_XRLeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRLeftHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRLeftHandActions instance)
        {
            if (m_Wrapper.m_XRLeftHandActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Grab.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnGrab;
                @Activate.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivate;
                @Activate.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivate;
                @Activate.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivate;
                @HapticDevice.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnHapticDevice;
                @Move.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Turn.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTurn;
                @TeleportStart.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportStart;
                @TeleportStart.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportStart;
                @TeleportStart.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportStart;
                @TeleportActivate.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportActivate.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportActivate.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportCancel.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportCancel;
                @TeleportCancel.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportCancel;
                @TeleportCancel.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnTeleportCancel;
                @RotateTeleportDestination.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotateTeleportDestination;
                @RotateTeleportDestination.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotateTeleportDestination;
                @RotateTeleportDestination.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotateTeleportDestination;
                @LocomotionModeToggle.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnLocomotionModeToggle;
                @LocomotionModeToggle.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnLocomotionModeToggle;
                @LocomotionModeToggle.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnLocomotionModeToggle;
                @Jump.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSprint;
                @SlowTime.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSlowTime;
                @SlowTime.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSlowTime;
                @SlowTime.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnSlowTime;
                @Menu.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_XRLeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Activate.started += instance.OnActivate;
                @Activate.performed += instance.OnActivate;
                @Activate.canceled += instance.OnActivate;
                @HapticDevice.started += instance.OnHapticDevice;
                @HapticDevice.performed += instance.OnHapticDevice;
                @HapticDevice.canceled += instance.OnHapticDevice;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @TeleportStart.started += instance.OnTeleportStart;
                @TeleportStart.performed += instance.OnTeleportStart;
                @TeleportStart.canceled += instance.OnTeleportStart;
                @TeleportActivate.started += instance.OnTeleportActivate;
                @TeleportActivate.performed += instance.OnTeleportActivate;
                @TeleportActivate.canceled += instance.OnTeleportActivate;
                @TeleportCancel.started += instance.OnTeleportCancel;
                @TeleportCancel.performed += instance.OnTeleportCancel;
                @TeleportCancel.canceled += instance.OnTeleportCancel;
                @RotateTeleportDestination.started += instance.OnRotateTeleportDestination;
                @RotateTeleportDestination.performed += instance.OnRotateTeleportDestination;
                @RotateTeleportDestination.canceled += instance.OnRotateTeleportDestination;
                @LocomotionModeToggle.started += instance.OnLocomotionModeToggle;
                @LocomotionModeToggle.performed += instance.OnLocomotionModeToggle;
                @LocomotionModeToggle.canceled += instance.OnLocomotionModeToggle;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @SlowTime.started += instance.OnSlowTime;
                @SlowTime.performed += instance.OnSlowTime;
                @SlowTime.canceled += instance.OnSlowTime;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public XRLeftHandActions @XRLeftHand => new XRLeftHandActions(this);

    // XR RightHand
    private readonly InputActionMap m_XRRightHand;
    private IXRRightHandActions m_XRRightHandActionsCallbackInterface;
    private readonly InputAction m_XRRightHand_Position;
    private readonly InputAction m_XRRightHand_Rotation;
    private readonly InputAction m_XRRightHand_Grab;
    private readonly InputAction m_XRRightHand_Activate;
    private readonly InputAction m_XRRightHand_UIPress;
    private readonly InputAction m_XRRightHand_HapticDevice;
    private readonly InputAction m_XRRightHand_Move;
    private readonly InputAction m_XRRightHand_Turn;
    private readonly InputAction m_XRRightHand_TeleportSelect;
    private readonly InputAction m_XRRightHand_TeleportActivate;
    private readonly InputAction m_XRRightHand_TeleportCancel;
    private readonly InputAction m_XRRightHand_RotateTeleportDestination;
    public struct XRRightHandActions
    {
        private @GameActions m_Wrapper;
        public XRRightHandActions(@GameActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Position => m_Wrapper.m_XRRightHand_Position;
        public InputAction @Rotation => m_Wrapper.m_XRRightHand_Rotation;
        public InputAction @Grab => m_Wrapper.m_XRRightHand_Grab;
        public InputAction @Activate => m_Wrapper.m_XRRightHand_Activate;
        public InputAction @UIPress => m_Wrapper.m_XRRightHand_UIPress;
        public InputAction @HapticDevice => m_Wrapper.m_XRRightHand_HapticDevice;
        public InputAction @Move => m_Wrapper.m_XRRightHand_Move;
        public InputAction @Turn => m_Wrapper.m_XRRightHand_Turn;
        public InputAction @TeleportSelect => m_Wrapper.m_XRRightHand_TeleportSelect;
        public InputAction @TeleportActivate => m_Wrapper.m_XRRightHand_TeleportActivate;
        public InputAction @TeleportCancel => m_Wrapper.m_XRRightHand_TeleportCancel;
        public InputAction @RotateTeleportDestination => m_Wrapper.m_XRRightHand_RotateTeleportDestination;
        public InputActionMap Get() { return m_Wrapper.m_XRRightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRRightHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRRightHandActions instance)
        {
            if (m_Wrapper.m_XRRightHandActionsCallbackInterface != null)
            {
                @Position.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Grab.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnGrab;
                @Activate.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivate;
                @Activate.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivate;
                @Activate.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivate;
                @UIPress.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @HapticDevice.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnHapticDevice;
                @HapticDevice.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnHapticDevice;
                @Move.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Turn.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTurn;
                @TeleportSelect.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportSelect.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportSelect;
                @TeleportActivate.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportActivate.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportActivate.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportActivate;
                @TeleportCancel.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportCancel;
                @TeleportCancel.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportCancel;
                @TeleportCancel.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnTeleportCancel;
                @RotateTeleportDestination.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotateTeleportDestination;
                @RotateTeleportDestination.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotateTeleportDestination;
                @RotateTeleportDestination.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotateTeleportDestination;
            }
            m_Wrapper.m_XRRightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @Activate.started += instance.OnActivate;
                @Activate.performed += instance.OnActivate;
                @Activate.canceled += instance.OnActivate;
                @UIPress.started += instance.OnUIPress;
                @UIPress.performed += instance.OnUIPress;
                @UIPress.canceled += instance.OnUIPress;
                @HapticDevice.started += instance.OnHapticDevice;
                @HapticDevice.performed += instance.OnHapticDevice;
                @HapticDevice.canceled += instance.OnHapticDevice;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @TeleportSelect.started += instance.OnTeleportSelect;
                @TeleportSelect.performed += instance.OnTeleportSelect;
                @TeleportSelect.canceled += instance.OnTeleportSelect;
                @TeleportActivate.started += instance.OnTeleportActivate;
                @TeleportActivate.performed += instance.OnTeleportActivate;
                @TeleportActivate.canceled += instance.OnTeleportActivate;
                @TeleportCancel.started += instance.OnTeleportCancel;
                @TeleportCancel.performed += instance.OnTeleportCancel;
                @TeleportCancel.canceled += instance.OnTeleportCancel;
                @RotateTeleportDestination.started += instance.OnRotateTeleportDestination;
                @RotateTeleportDestination.performed += instance.OnRotateTeleportDestination;
                @RotateTeleportDestination.canceled += instance.OnRotateTeleportDestination;
            }
        }
    }
    public XRRightHandActions @XRRightHand => new XRRightHandActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_PointerPosition;
    private readonly InputAction m_UI_PointerRotation;
    public struct UIActions
    {
        private @GameActions m_Wrapper;
        public UIActions(@GameActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @PointerPosition => m_Wrapper.m_UI_PointerPosition;
        public InputAction @PointerRotation => m_Wrapper.m_UI_PointerRotation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @PointerPosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @PointerPosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @PointerPosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @PointerRotation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
                @PointerRotation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
                @PointerRotation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @PointerPosition.started += instance.OnPointerPosition;
                @PointerPosition.performed += instance.OnPointerPosition;
                @PointerPosition.canceled += instance.OnPointerPosition;
                @PointerRotation.started += instance.OnPointerRotation;
                @PointerRotation.performed += instance.OnPointerRotation;
                @PointerRotation.canceled += instance.OnPointerRotation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_GenericXRControllerSchemeIndex = -1;
    public InputControlScheme GenericXRControllerScheme
    {
        get
        {
            if (m_GenericXRControllerSchemeIndex == -1) m_GenericXRControllerSchemeIndex = asset.FindControlSchemeIndex("Generic XR Controller");
            return asset.controlSchemes[m_GenericXRControllerSchemeIndex];
        }
    }
    private int m_ContinuousMoveSchemeIndex = -1;
    public InputControlScheme ContinuousMoveScheme
    {
        get
        {
            if (m_ContinuousMoveSchemeIndex == -1) m_ContinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Continuous Move");
            return asset.controlSchemes[m_ContinuousMoveSchemeIndex];
        }
    }
    private int m_NoncontinuousMoveSchemeIndex = -1;
    public InputControlScheme NoncontinuousMoveScheme
    {
        get
        {
            if (m_NoncontinuousMoveSchemeIndex == -1) m_NoncontinuousMoveSchemeIndex = asset.FindControlSchemeIndex("Noncontinuous Move");
            return asset.controlSchemes[m_NoncontinuousMoveSchemeIndex];
        }
    }
    public interface IXRHMDActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IXRLeftHandActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
        void OnHapticDevice(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnTeleportStart(InputAction.CallbackContext context);
        void OnTeleportActivate(InputAction.CallbackContext context);
        void OnTeleportCancel(InputAction.CallbackContext context);
        void OnRotateTeleportDestination(InputAction.CallbackContext context);
        void OnLocomotionModeToggle(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSlowTime(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IXRRightHandActions
    {
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnActivate(InputAction.CallbackContext context);
        void OnUIPress(InputAction.CallbackContext context);
        void OnHapticDevice(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnTeleportSelect(InputAction.CallbackContext context);
        void OnTeleportActivate(InputAction.CallbackContext context);
        void OnTeleportCancel(InputAction.CallbackContext context);
        void OnRotateTeleportDestination(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPointerPosition(InputAction.CallbackContext context);
        void OnPointerRotation(InputAction.CallbackContext context);
    }
}
