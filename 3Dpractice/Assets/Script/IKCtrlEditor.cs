using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IKCtrl))]
public class IKCtrlEditor : Editor {

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		IKCtrl ctrl = (IKCtrl)target;

		ctrl.rightHandIKWeight = EditorGUILayout.Slider("RightHandIKWeight",ctrl.rightHandIKWeight, 0f, 1f);
	}
}
