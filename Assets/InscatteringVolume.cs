﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class InscatteringVolume : MonoBehaviour
{
	[ColorUsage(true, true)]
	public Color m_InscatteringColor;

	//public Material m_InscatteringMaterial;

	private void OnEnable()
	{
		InscatteringVolumeManager.InscatteringVolumes.Add(this);
	}

	private void OnDisable()
	{
		InscatteringVolumeManager.InscatteringVolumes.Remove(this);
	}

	private void Update()
	{
		transform.localScale = new Vector3(transform.localScale.x, transform.localScale.x, transform.localScale.x);
	}
}