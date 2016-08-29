using UnityEngine;
using UnityEngine.UI;
using System;
using BaseClasses;

public class Tower : MonoBehaviour {
    [SerializeField]
    Sprite[] towerSprites;
    Image image;

    public BasePlayer parent;
    public int slots = 2;
    private BaseGem[] gems;

    // Use this for initialization
    void Start () {
        this.gems = new BaseGem[slots];
        image = GetComponent<Image>();

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

    public void UpdateTowerSprite(float life) {
        if(life > 75)
            image.sprite = towerSprites[0];
        else if(life > 50)
            image.sprite = towerSprites[1];
        else if(life > 25)
            image.sprite = towerSprites[2];
        else if(life > 0)
            image.sprite = towerSprites[3];
        else
            image.sprite = towerSprites[4];
    }
}
