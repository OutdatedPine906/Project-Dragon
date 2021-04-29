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
            ""name"": ""movement"",
            ""id"": ""13c5329b-61c9-40b1-bdf1-5094d63a9a36"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""c11b68ea-bf3b-4c11-9db3-167c151a170e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""bafe402f-ad3b-4609-ac55-fdae4ab42e75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""fly"",
                    ""type"": ""Value"",
                    ""id"": ""55378919-ad81-4f60-9550-7580e98d20d7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d8fefb66-aa65-493e-8cfd-827c845ab727"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02019dca-4ba3-47a0-ae19-de728cc04b95"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1e09001-30b6-4ca8-b7fc-2aa122ecab11"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3148f8c4-ffef-422b-aefc-320cf1d55283"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""01af0339-d4df-4e5e-80b1-b55b83bad2fd"",
            ""actions"": [
                {
                    ""name"": ""viewer"",
                    ""type"": ""Button"",
                    ""id"": ""500583e0-220c-4639-a6e8-72ca1607947a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""0dd1e00e-e3ed-481b-83b6-4216d75a11f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cheat_menu"",
                    ""type"": ""Button"",
                    ""id"": ""b05c2439-2971-44fa-af72-ebbfb7729807"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3dab573-fbed-423d-8776-d0911a47f33e"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""viewer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7d6b623-5224-4167-beb9-c5819f2235c3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""viewer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95cff2ef-a10f-417e-b12e-b6ddec4f1335"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d38ae27-fb53-425e-bf9e-ab136bced6f7"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14aab4b6-a1b4-4174-93e8-ecc00462bb34"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cheat_menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d677f55-5c2f-411e-85c4-c4bc6d7cd7c2"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cheat_menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""attack"",
            ""id"": ""fe562822-2778-45ef-abeb-5b092583c9de"",
            ""actions"": [
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""30c889c9-c632-4bef-85ac-2c06e50eb9a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""charge_attack"",
                    ""type"": ""Button"",
                    ""id"": ""ae729301-60ff-4986-b0ea-08c575546306"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""81aa8c0a-5241-4cdb-9c80-399fa4c3ef2c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""917dbe4a-f305-4171-b430-fb144c3673c1"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ddcd8c4-6ede-41c0-a696-20d3ca289181"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""charge_attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bea09f79-b698-4efa-866b-e4ce629208e4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""charge_attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""test"",
            ""id"": ""415a0279-ac48-4b0a-b9de-3009ac7506a0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""PassThrough"",
                    ""id"": ""107fb383-8f21-4df1-ba37-aca3aad7db73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9384e162-9e76-4df0-b3c4-6f4899fbc08a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // movement
        m_movement = asset.FindActionMap("movement", throwIfNotFound: true);
        m_movement_move = m_movement.FindAction("move", throwIfNotFound: true);
        m_movement_jump = m_movement.FindAction("jump", throwIfNotFound: true);
        m_movement_fly = m_movement.FindAction("fly", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_viewer = m_UI.FindAction("viewer", throwIfNotFound: true);
        m_UI_Exit = m_UI.FindAction("Exit", throwIfNotFound: true);
        m_UI_cheat_menu = m_UI.FindAction("cheat_menu", throwIfNotFound: true);
        // attack
        m_attack = asset.FindActionMap("attack", throwIfNotFound: true);
        m_attack_attack = m_attack.FindAction("attack", throwIfNotFound: true);
        m_attack_charge_attack = m_attack.FindAction("charge_attack", throwIfNotFound: true);
        // test
        m_test = asset.FindActionMap("test", throwIfNotFound: true);
        m_test_Newaction = m_test.FindAction("New action", throwIfNotFound: true);
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

    // movement
    private readonly InputActionMap m_movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_movement_move;
    private readonly InputAction m_movement_jump;
    private readonly InputAction m_movement_fly;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_movement_move;
        public InputAction @jump => m_Wrapper.m_movement_jump;
        public InputAction @fly => m_Wrapper.m_movement_fly;
        public InputActionMap Get() { return m_Wrapper.m_movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @fly.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnFly;
                @fly.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnFly;
                @fly.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnFly;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @fly.started += instance.OnFly;
                @fly.performed += instance.OnFly;
                @fly.canceled += instance.OnFly;
            }
        }
    }
    public MovementActions @movement => new MovementActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_viewer;
    private readonly InputAction m_UI_Exit;
    private readonly InputAction m_UI_cheat_menu;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @viewer => m_Wrapper.m_UI_viewer;
        public InputAction @Exit => m_Wrapper.m_UI_Exit;
        public InputAction @cheat_menu => m_Wrapper.m_UI_cheat_menu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @viewer.started -= m_Wrapper.m_UIActionsCallbackInterface.OnViewer;
                @viewer.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnViewer;
                @viewer.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnViewer;
                @Exit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @cheat_menu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCheat_menu;
                @cheat_menu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCheat_menu;
                @cheat_menu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCheat_menu;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @viewer.started += instance.OnViewer;
                @viewer.performed += instance.OnViewer;
                @viewer.canceled += instance.OnViewer;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @cheat_menu.started += instance.OnCheat_menu;
                @cheat_menu.performed += instance.OnCheat_menu;
                @cheat_menu.canceled += instance.OnCheat_menu;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // attack
    private readonly InputActionMap m_attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_attack_attack;
    private readonly InputAction m_attack_charge_attack;
    public struct AttackActions
    {
        private @PlayerControls m_Wrapper;
        public AttackActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @attack => m_Wrapper.m_attack_attack;
        public InputAction @charge_attack => m_Wrapper.m_attack_charge_attack;
        public InputActionMap Get() { return m_Wrapper.m_attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @attack.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
                @attack.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
                @attack.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
                @charge_attack.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnCharge_attack;
                @charge_attack.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnCharge_attack;
                @charge_attack.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnCharge_attack;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @attack.started += instance.OnAttack;
                @attack.performed += instance.OnAttack;
                @attack.canceled += instance.OnAttack;
                @charge_attack.started += instance.OnCharge_attack;
                @charge_attack.performed += instance.OnCharge_attack;
                @charge_attack.canceled += instance.OnCharge_attack;
            }
        }
    }
    public AttackActions @attack => new AttackActions(this);

    // test
    private readonly InputActionMap m_test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_test_Newaction;
    public struct TestActions
    {
        private @PlayerControls m_Wrapper;
        public TestActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_test_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public TestActions @test => new TestActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFly(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnViewer(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnCheat_menu(InputAction.CallbackContext context);
    }
    public interface IAttackActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnCharge_attack(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
