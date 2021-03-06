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
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
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
    public struct PlayerFlightActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerFlightActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerFlight_Move;
        public InputAction @Rotate => m_Wrapper.m_PlayerFlight_Rotate;
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
    }
}
