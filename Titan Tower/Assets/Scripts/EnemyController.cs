﻿using UnityEngine;
using System.Collections;
using System;
using SpellsCollection;
using GemsCollection;
using BaseClasses;

public class EnemyController : BasePlayer {
    
    public void Start()
    {
        base.gems = new Gems();
        base.spells = new Spells();
        base.gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        
    }

    public void Update()
    {
        
    }

    public override void LaunchSpell(BasePlayer enemy, BaseSpell spell)
    {
        gc.ActionsDone++;
        spell.ApplyEffect(enemy, this);
        enemy.ReceiveDamage(spell);
    }

    public override void PutGem(BaseGem gem, int slot)
    {
        gc.ActionsDone++;
        this.tower.PutGemAt(slot, gem);
    }

    public override void Ritual()
    {
        gc.ActionsDone++;
    }

    public override void ReceiveDamage(BaseSpell spell)
    {
        this.life -= this.tower.CalculateDamage(spell);
    }
}
