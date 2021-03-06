﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubis : MonoBehaviour {

	public int valeur = 1;
	private bool ramasssable = true; // pour eviter plusieurs ramassages dans la même frame

	void OnTriggerEnter2D(Collider2D coll)
	{
		// les rubis ne sont ramassables que par les triggers du joueur
		if (ramasssable && coll.isTrigger && coll.gameObject.layer == LayerMask.NameToLayer("Player"))
		{
			BourseARubis r = coll.gameObject.GetComponentInParent(typeof(BourseARubis)) as BourseARubis;
			if (r != null)
			{
				r.rubisCollectés += valeur;
				Destroy(gameObject);
			}
		}
	}
}
