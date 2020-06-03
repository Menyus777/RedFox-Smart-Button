// Copyright 2020 by RedFox Interactive - All Rights Reserved
// MIT License

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RedFox.InputManagement.ExtendedUI
{
    /// <summary>
    /// A button with extended input event functionality.
    /// <list type="table">
    /// <item><term>On Press</term><description> Called when the button is pressed.</description></item>
    /// <item><term>On Hold</term><description> Called when the button is being held down.</description></item>
    /// <item><term>On Release</term><description> Called when the button is released. (The pointer was over the button)</description></item>
    /// <item><term>On Exit</term><description> Called when the pointer leaves the button area.</description></item>
    /// <item><term>On Enter</term><description> Called when the pointer enters the button area.</description></item>
    /// </list>
    /// </summary>
    /// <remarks>This component depends on <see cref="TouchInputHandler"/> remove code dependecies to make it work without it.</remarks>
    [AddComponentMenu("RedFox UI/Smart Button", 0)]
    public class SmartButton : Button
    {
        /// <summary>
        /// UnityEvent to be fired when the buttons is pressed(first touch).
        /// </summary>
        public ButtonPressEvent OnPress { get { return onPress; } set { onPress = value; } }
        [SerializeField]
        private ButtonPressEvent onPress = new ButtonPressEvent();

        /// <summary>
        /// UnityEvent to be fired when the buttons is held down.
        /// </summary>
        public ButtonHoldEvent OnHold { get { return onHold; } set { onHold = value; } }
        [SerializeField]
        private ButtonHoldEvent onHold = new ButtonHoldEvent();
        private bool holding;

        /// <summary>
        /// UnityEvent to be fired when the buttons is released.
        /// </summary>
        public ButtonReleaseEvent OnRelease { get { return onRelease; } set { onRelease = value; } }
        [SerializeField]
        private ButtonReleaseEvent onRelease = new ButtonReleaseEvent();

        /// <summary>
        /// UnityEvent to be fired when the pointer leaves the button area.
        /// </summary>
        public ButtonExitEvent OnExit { get { return onExit; } set { onExit = value; } }
        [SerializeField]
        private ButtonExitEvent onExit = new ButtonExitEvent();

        /// <summary>
        /// UnityEvent to be fired when the pointer enters the button area.
        /// </summary>
        public ButtonExitEvent OnEnter { get { return onEnter; } set { onEnter = value; } }
        [SerializeField]
        private ButtonExitEvent onEnter = new ButtonExitEvent();

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            if (eventData.button != PointerEventData.InputButton.Left)
                return;
            else if (!IsActive() || !IsInteractable())
                return;
            else
            {
                onPress.Invoke();
                onHold.Invoke();
                holding = true;
            }
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            holding = false;
            onRelease.Invoke();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            holding = false;
            onExit.Invoke();

            InstantClearState();
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            onEnter.Invoke();
        }

        /// <summary>
        /// Method definition for a button press event.</para>
        /// </summary>
        [Serializable]
        public class ButtonPressEvent : UnityEvent
        {

        }

        /// <summary>
        /// Method definition for a button hold event.</para>
        /// </summary>
        [Serializable]
        public class ButtonHoldEvent : UnityEvent
        {

        }

        /// <summary>
        /// Method definition for a button release event.</para>
        /// </summary>
        [Serializable]
        public class ButtonReleaseEvent : UnityEvent
        {

        }

        /// <summary>
        /// Method definition for a button exit event.</para>
        /// </summary>
        [Serializable]
        public class ButtonExitEvent : UnityEvent
        {

        }

        /// <summary>
        /// Method definition for a button enter event.</para>
        /// </summary>
        [Serializable]
        public class ButtonEnterEvent : UnityEvent
        {

        }

        void Update()
        {
            if (holding)
            {
                onHold.Invoke();
            }
        }
    }
}
