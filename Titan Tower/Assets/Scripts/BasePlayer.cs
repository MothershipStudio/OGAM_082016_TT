using UnityEngine;
using System.Collections;
using GemsCollection;
using SpellsCollection;
using BaseClasses;

public abstract class BasePlayer : MonoBehaviour   {
    
    [Header("Ritual Settings")]
    public float DoRitual;
    public float IdleRitual;
    public float RitualPerc;

    [Header("Normal settings")]
    public bool isActiveRound;
    public int life = 1000;
    public int energy = 0;
    public int nextRoundAction;

    [HideInInspector]
    public Gems gems;

    [Header("Tower settings")]
    public Tower tower;

    [HideInInspector]
    public GameController gc;
    [HideInInspector]
    public Spells spells;

    public abstract void LaunchSpell(BasePlayer enemy, BaseSpell spell);
    public abstract void ReceiveDamage(BaseSpell spell);
    public abstract void PutGem(BaseGem gem, int slot);
    public abstract void Ritual();
	
}
