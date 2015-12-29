using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
[AddComponentMenu("NGUI/NData/Renderer Visibility Binding")]
public class NguiRendererVisibilityBinding : NguiBooleanBinding
{

	protected Renderer[] _renderers;

	public override void Awake()
	{
		base.Awake();
		_renderers = GetComponentsInChildren<Renderer> (true);
	}

	protected override void ApplyNewValue(bool newValue)
	{
		foreach (var r in _renderers) {
			Debug.LogError ("NguiRendererVisibilityBinding, r = " + r.name + ", newValue = " + newValue);
//			r.enabled = newValue;
		}
	}
}
