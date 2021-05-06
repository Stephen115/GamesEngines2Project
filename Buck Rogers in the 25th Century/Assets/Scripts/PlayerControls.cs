// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerFlight"",
            ""id"": ""112fec57-0a46-426f-8a68-29bdd18b693a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""cb5d3bec-a3c8-4e62-ab9f-8e84bfb93453"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""5d7ba5ba-070a-4e0c-b700-5f640d2b6357"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""d7493b9b-1f72-4da6-9dd8-364252ec12ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Missile"",
                    ""type"": ""Button"",
                    ""id"": ""088f517a-0136-4d54-9b04-91371d53a95e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""66c976be-9a69-4347-9729-eccd352bac77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Button"",
                    ""id"": ""67d747cc-113b-4e07-89fa-cc8b97426fb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockTarget"",
                    ""type"": ""Button"",
                    ""id"": ""7fa0d1a2-ceeb-4e20-8c74-85f285d4c9ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomCamera"",
                    ""type"": ""Button"",
                    ""id"": ""2c963b3f-3cee-49b4-8d3f-cb5364758054"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""3ae95eb0-0655-4e07-af57-6ba6a56a2d35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""d27e1bea-6bb5-498a-b7ea-63167bdab150"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5853a693-8695-471d-95a3-0983b5d389cc"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a09c4ba8-5248-4bb3-8480-8b3d54a8af00"",
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
                    ""id"": ""62a976a6-7ff9-4fdd-a9c2-61451bb18778"",
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
                    ""id"": ""9ef5aacb-6981-4487-b032-b72cf5fb4fbb"",
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
                    ""id"": ""bb91e5e6-1180-422b-815b-a0814eae098e"",
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
                    ""id"": ""08287b2e-5254-4450-9a43-a00c055b4be8"",
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
                    ""id"": ""6a732bda-3d9f-4f7b-b68a-61588eb72255"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a7d2d7b-e826-4beb-a51a-7dc957e96333"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbf2383d-411b-427a-bdf1-c6b847229b7c"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85b88357-215a-4c69-9459-689fc23d25a4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87a28366-7c85-48c5-8dc8-f8e626bd107e"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Missile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a34ea44-2826-45e7-bb9c-9902addd2ede"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Missile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""610aca64-a6c1-4c4d-b074-92cbc13151f5"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6af1d7ee-d484-4d22-833a-ca657a06873d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""118e9f0f-2899-43f0-8fe5-46c1e1905a2c"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7202131a-b981-4741-a2e8-56fb763cfbd3"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82d2dded-c66e-415f-ab51-ef612d694dd3"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30bfa120-b224-4dcd-92a0-b9f11b5815a4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeb06ca7-5f79-428c-895f-fb01c3187cd5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccf63f47-e4b2-4ef7-a5a2-a2c44248d5a9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a37a958-ad71-4cae-aad2-a79dbc3f8f01"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba9dc795-d7bf-4368-b596-fe8ddd543cf3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""783bda67-e485-4cdf-abe7-e844ec43418a"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cd5dc3e-1975-4a4d-9c6f-0fb9b83b15b4"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerFlight
        m_PlayerFlight = asset.FindActionMap("PlayerFlight", throwIfNotFound: true);
        m_PlayerFlight_Move = m_PlayerFlight.FindAction("Move", throwIfNotFound: true);
        m_PlayerFlight_Rotate = m_PlayerFlight.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerFlight_Shoot = m_PlayerFlight.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerFlight_Missile = m_PlayerFlight.FindAction("Missile", throwIfNotFound: true);
        m_PlayerFlight_Boost = m_PlayerFlight.FindAction("Boost", throwIfNotFound: true);
        m_PlayerFlight_ChangeCamera = m_PlayerFlight.FindAction("ChangeCamera", throwIfNotFound: true);
        m_PlayerFlight_LockTarget = m_PlayerFlight.FindAction("LockTarget", throwIfNotFound: true);
        m_PlayerFlight_ZoomCamera = m_PlayerFlight.FindAction("ZoomCamera", throwIfNotFound: true);
        m_PlayerFlight_Menu = m_PlayerFlight.FindAction("Menu", throwIfNotFound: true);
        m_PlayerFlight_Special = m_PlayerFlight.FindAction("Special", throwIfNotFound: true);
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

    // PlayerFlight
    private readonly InputActionMap m_PlayerFlight;
    private IPlayerFlightActions m_PlayerFlightActionsCallbackInterface;
    private readonly InputAction m_PlayerFlight_Move;
    private readonly InputAction m_PlayerFlight_Rotate;
    private readonly InputAction m_PlayerFlight_Shoot;
    private readonly InputAction m_PlayerFlight_Missile;
    private readonly InputAction m_PlayerFlight_Boost;
    private readonly InputAction m_PlayerFlight_ChangeCamera;
    private readonly InputAction m_PlayerFlight_LockTarget;
    private readonly InputAction m_PlayerFlight_ZoomCamera;
    private readonly InputAction m_PlayerFlight_Menu;
    private readonly InputAction m_PlayerFlight_Special;
    public struct PlayerFlightActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerFlightActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerFlight_Move;
        public InputAction @Rotate => m_Wrapper.m_PlayerFlight_Rotate;
        public InputAction @Shoot => m_Wrapper.m_PlayerFlight_Shoot;
        public InputAction @Missile => m_Wrapper.m_PlayerFlight_Missile;
        public InputAction @Boost => m_Wrapper.m_PlayerFlight_Boost;
        public InputAction @ChangeCamera => m_Wrapper.m_PlayerFlight_ChangeCamera;
        public InputAction @LockTarget => m_Wrapper.m_PlayerFlight_LockTarget;
        public InputAction @ZoomCamera => m_Wrapper.m_PlayerFlight_ZoomCamera;
        public InputAction @Menu => m_Wrapper.m_PlayerFlight_Menu;
        public InputAction @Special => m_Wrapper.m_PlayerFlight_Special;
        public InputActionMap Get() { return m_Wrapper.m_PlayerFlight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerFlightActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerFlightActions instance)
        {
            if (m_Wrapper.m_PlayerFlightActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnRotate;
                @Shoot.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnShoot;
                @Missile.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMissile;
                @Missile.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMissile;
                @Missile.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMissile;
                @Boost.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnBoost;
                @ChangeCamera.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnChangeCamera;
                @LockTarget.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLockTarget;
                @LockTarget.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLockTarget;
                @LockTarget.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLockTarget;
                @ZoomCamera.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnZoomCamera;
                @Menu.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMenu;
                @Special.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnSpecial;
            }
            m_Wrapper.m_PlayerFlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Missile.started += instance.OnMissile;
                @Missile.performed += instance.OnMissile;
                @Missile.canceled += instance.OnMissile;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @ChangeCamera.started += instance.OnChangeCamera;
                @ChangeCamera.performed += instance.OnChangeCamera;
                @ChangeCamera.canceled += instance.OnChangeCamera;
                @LockTarget.started += instance.OnLockTarget;
                @LockTarget.performed += instance.OnLockTarget;
                @LockTarget.canceled += instance.OnLockTarget;
                @ZoomCamera.started += instance.OnZoomCamera;
                @ZoomCamera.performed += instance.OnZoomCamera;
                @ZoomCamera.canceled += instance.OnZoomCamera;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
            }
        }
    }
    public PlayerFlightActions @PlayerFlight => new PlayerFlightActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerFlightActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMissile(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
        void OnLockTarget(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
    }
}
