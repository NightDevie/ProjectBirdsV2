// GENERATED AUTOMATICALLY FROM 'Assets/InputTouch/TouchControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControls"",
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
        }
    ],
    ""controlSchemes"": []
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_Flap = m_Bird.FindAction("Flap", throwIfNotFound: true);
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
        private @TouchControls m_Wrapper;
        public BirdActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
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
    public interface IBirdActions
    {
        void OnFlap(InputAction.CallbackContext context);
    }
}
