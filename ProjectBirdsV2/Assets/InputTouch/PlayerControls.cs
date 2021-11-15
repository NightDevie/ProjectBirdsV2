// GENERATED AUTOMATICALLY FROM 'Assets/InputTouch/PlayerControls.inputactions'

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
            ""name"": ""Bird"",
            ""id"": ""09256591-e401-4f6a-b573-1aac3c7ac9fe"",
            ""actions"": [
                {
                    ""name"": ""Flap"",
                    ""type"": ""Button"",
                    ""id"": ""d7ec68dc-d870-4110-bfa4-ad89b35a496e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe83a6d0-2dbf-4501-9f20-5cf179270623"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press(pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b825566-5779-4097-9f91-a00eb78c6651"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""911aa497-94ac-44da-9ade-ecdd415e5b86"",
            ""actions"": [
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""88c04bf0-dfe8-465d-b54d-e6791f36110e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwipePrimaryContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""34be2c63-b0fd-45a9-bd88-29ebb8fda0de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwipePrimaryPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""309ed252-6d97-4bd1-b0f4-bfae93c32488"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3a083e1-662a-4bc5-b474-d50b447c88b9"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99d8fd53-c0d6-4b11-b465-e3d7df987670"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df948ce0-ab6d-4d83-a8c6-5d7389f9795e"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwipePrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35c59e41-a3f7-46b7-8636-98e08830ced3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwipePrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34125edf-6f27-494a-8f33-103dc4a8d3cf"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwipePrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc910a02-7868-4468-9fda-dfd6469b4dd8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwipePrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_Flap = m_Bird.FindAction("Flap", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Hold = m_Menu.FindAction("Hold", throwIfNotFound: true);
        m_Menu_SwipePrimaryContact = m_Menu.FindAction("SwipePrimaryContact", throwIfNotFound: true);
        m_Menu_SwipePrimaryPosition = m_Menu.FindAction("SwipePrimaryPosition", throwIfNotFound: true);
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

    // Bird
    private readonly InputActionMap m_Bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_Bird_Flap;
    public struct BirdActions
    {
        private @PlayerControls m_Wrapper;
        public BirdActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Flap => m_Wrapper.m_Bird_Flap;
        public InputActionMap Get() { return m_Wrapper.m_Bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @Flap.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Flap.started += instance.OnFlap;
                @Flap.performed += instance.OnFlap;
                @Flap.canceled += instance.OnFlap;
            }
        }
    }
    public BirdActions @Bird => new BirdActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Hold;
    private readonly InputAction m_Menu_SwipePrimaryContact;
    private readonly InputAction m_Menu_SwipePrimaryPosition;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hold => m_Wrapper.m_Menu_Hold;
        public InputAction @SwipePrimaryContact => m_Wrapper.m_Menu_SwipePrimaryContact;
        public InputAction @SwipePrimaryPosition => m_Wrapper.m_Menu_SwipePrimaryPosition;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Hold.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnHold;
                @SwipePrimaryContact.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryContact;
                @SwipePrimaryContact.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryContact;
                @SwipePrimaryContact.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryContact;
                @SwipePrimaryPosition.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryPosition;
                @SwipePrimaryPosition.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryPosition;
                @SwipePrimaryPosition.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSwipePrimaryPosition;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @SwipePrimaryContact.started += instance.OnSwipePrimaryContact;
                @SwipePrimaryContact.performed += instance.OnSwipePrimaryContact;
                @SwipePrimaryContact.canceled += instance.OnSwipePrimaryContact;
                @SwipePrimaryPosition.started += instance.OnSwipePrimaryPosition;
                @SwipePrimaryPosition.performed += instance.OnSwipePrimaryPosition;
                @SwipePrimaryPosition.canceled += instance.OnSwipePrimaryPosition;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IBirdActions
    {
        void OnFlap(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnHold(InputAction.CallbackContext context);
        void OnSwipePrimaryContact(InputAction.CallbackContext context);
        void OnSwipePrimaryPosition(InputAction.CallbackContext context);
    }
}