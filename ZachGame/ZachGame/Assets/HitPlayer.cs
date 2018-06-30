using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {

    public int AttackDamage;

	// Use this for initialization
	void OnTriggerEnter (Collider other)
    {
        HUD_Manager hudmanager = other.gameObject.GetComponent<HUD_Manager>();
        if(hudmanager != null)
        {
           hudmanager.UpdateHealth(AttackDamage);
        }
	}


}
