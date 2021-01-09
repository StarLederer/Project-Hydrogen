﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Editor fields
	public GameObject largeFilterPrefab;
	public GameObject smallFilterPrefab;
	public GameObject gunModulePrefab;
	public GameObject screwdriverPrefab;

	public Transform spawnTransform;

	//public static GameManager Instance;

	private void Awake()
	{
		//Instance = this;
	}

	private void Start()
	{

	}

	public void Win()
	{
		// Add success indication
	}

	public void SpawnNewHydrogenInteractable()
	{
		/*switch (type)
		{
			case HydrogenInteractableType.LargeFilter:
				interactable = Instantiate(largeFilterPrefab, spawnTransform.position, spawnTransform.rotation).GetComponent<HydrogenInteractable>();
				break;
			case HydrogenInteractableType.SmallFilter:
				interactable = Instantiate(smallFilterPrefab, spawnTransform.position, spawnTransform.rotation).GetComponent<HydrogenInteractable>();
				break;
			case HydrogenInteractableType.GunModule:
				interactable = Instantiate(gunModulePrefab, spawnTransform.position, spawnTransform.rotation).GetComponent<HydrogenInteractable>();
				break;
			default: // HydrogenInteractableType.Screwdriver
				interactable = Instantiate(screwdriverPrefab, spawnTransform.position, spawnTransform.rotation).GetComponent<HydrogenInteractable>();
				break;
		}*/

		StartCoroutine(WaitForFrameAndInstanciateHydrogenInteractable());
	}

	IEnumerator WaitForFrameAndInstanciateHydrogenInteractable()
	{
		yield return new WaitForEndOfFrame();
		Instantiate(gunModulePrefab, Vector3.zero, Quaternion.identity).GetComponent<HydrogenInteractable>().OnHydrogenInteractableDestroyed += OnInteractableDestroyed;
	}

	public void OnInteractableDestroyed(HydrogenInteractable interactable)
	{
		Debug.Log("interactable " + interactable.name + " destroyed");
	}
}
