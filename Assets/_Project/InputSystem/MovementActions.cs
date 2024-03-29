//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Project/InputSystem/MovementActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MovementActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MovementActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MovementActions"",
    ""maps"": [
        {
            ""name"": ""MovementMap"",
            ""id"": ""4c5279b2-1f3c-4c25-b3c7-7282bfe7c653"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""1e448e88-d244-44a2-ab3b-782fd851695e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""5e58bd33-310a-4d36-a3cf-1fbd00d7b168"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dc6e83c1-50dd-44d9-ae16-fd8a25c3cf0d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5c691908-43f1-4c07-9a99-625606f37bcb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02f77ea0-e0e6-4bc3-a4cd-91bee4d74493"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a30d22a-fc11-4efd-a8f7-570c8f6514ed"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArroKeys"",
                    ""id"": ""bee29218-bb45-4c74-80bc-7bdd9624caa3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""906fa1d0-4065-4d5d-a676-deef3db8e988"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6178f375-b24c-4cfd-8b44-6cd7ac0f34cb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b880edcc-76fa-4e97-a24b-d601d66503c8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e8c5744f-6d1a-4657-b5ba-21b0570ac1e8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MovementMap
        m_MovementMap = asset.FindActionMap("MovementMap", throwIfNotFound: true);
        m_MovementMap_PlayerMovement = m_MovementMap.FindAction("PlayerMovement", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MovementMap
    private readonly InputActionMap m_MovementMap;
    private List<IMovementMapActions> m_MovementMapActionsCallbackInterfaces = new List<IMovementMapActions>();
    private readonly InputAction m_MovementMap_PlayerMovement;
    public struct MovementMapActions
    {
        private @MovementActions m_Wrapper;
        public MovementMapActions(@MovementActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovement => m_Wrapper.m_MovementMap_PlayerMovement;
        public InputActionMap Get() { return m_Wrapper.m_MovementMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementMapActions set) { return set.Get(); }
        public void AddCallbacks(IMovementMapActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementMapActionsCallbackInterfaces.Add(instance);
            @PlayerMovement.started += instance.OnPlayerMovement;
            @PlayerMovement.performed += instance.OnPlayerMovement;
            @PlayerMovement.canceled += instance.OnPlayerMovement;
        }

        private void UnregisterCallbacks(IMovementMapActions instance)
        {
            @PlayerMovement.started -= instance.OnPlayerMovement;
            @PlayerMovement.performed -= instance.OnPlayerMovement;
            @PlayerMovement.canceled -= instance.OnPlayerMovement;
        }

        public void RemoveCallbacks(IMovementMapActions instance)
        {
            if (m_Wrapper.m_MovementMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementMapActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementMapActions @MovementMap => new MovementMapActions(this);
    public interface IMovementMapActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
    }
}
