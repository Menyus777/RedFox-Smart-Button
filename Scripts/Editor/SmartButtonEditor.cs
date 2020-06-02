// Copyright 2020 by RedFox Interactive - All Rights Reserved
// MIT License

using RedFox.InputManagement.ExtendedUI;
using UnityEditor;
using UnityEditor.UI;

namespace RedFox.EditorExtensions.InputManagement.ExtendedUI
{
    /// <summary>
    /// The editor script for <see cref="SmartButton"/>.
    /// <list type="table">Supported Events:
    /// <item><term>On Press</term><description> Called when the button is pressed.</description></item>
    /// <item><term>On Hold</term><description> Called when the button is being held down.</description></item>
    /// <item><term>On Release</term><description> Called when the button is released. (The pointer was over the button)</description></item>
    /// <item><term>On Exit</term><description> Called when the pointer was released or left the button border.</description></item>
    /// </list>
    /// </summary>
    [CanEditMultipleObjects]
    [CustomEditor(typeof(SmartButton), true)]
    public class SmartButtonEditor : ButtonEditor
    { 
        SerializedProperty onPressProperty;
        SerializedProperty onHoldProperty;
        SerializedProperty onReleaseProperty;
        SerializedProperty onExitProperty;

        protected override void OnEnable()
        {
            base.OnEnable();
            onPressProperty = serializedObject.FindProperty("onPress");
            onHoldProperty = serializedObject.FindProperty("onHold");
            onReleaseProperty = serializedObject.FindProperty("onRelease");
            onExitProperty = serializedObject.FindProperty("onExit");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.Space();
            serializedObject.Update();
            EditorGUILayout.PropertyField(onPressProperty);
            EditorGUILayout.PropertyField(onHoldProperty);
            EditorGUILayout.PropertyField(onReleaseProperty);
            EditorGUILayout.PropertyField(onExitProperty);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
