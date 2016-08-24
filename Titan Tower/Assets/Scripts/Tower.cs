using UnityEngine;
using System.Collections;
using GemsCollection;
using System;
using SpellsCollection;
using BaseClasses;

public class Tower : MonoBehaviour {
    
    public BasePlayer parent;
    public int slots = 2;
    private BaseGem[] gems;

    // Use this for initialization
    void Start () {
        this.gems = new BaseGem[slots];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void PutGemAt(int slot, BaseGem gem)
    {
        if (slot > slots)
            throw new IndexOutOfRangeException("Este slot não existe");

        this.gems[slot] = gem;
    }

    public int CalculateDamage(BaseSpell spell)
    {
        var values = Enum.GetValues(typeof(Element));
        int totalDamage = 0;

        foreach(Element e in values)
        {
            int partialDamage = spell.Damage[e];
            if (partialDamage > 0)
            {
                for(int i = 0; i < this.slots; i++)
                {
                    int gemDefense = gems[i].Damage[e];
                    if (gemDefense > 0)
                    {
                        partialDamage = Mathf.Clamp(partialDamage - gemDefense, 0, partialDamage);
                        gems[i] = null;
                    }
                }

                totalDamage += partialDamage;
            }
        }

        return totalDamage;
    }
}
