using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingleton<GameManager>
{
    public Dictionary<string, Effect> EffectList;
    private void Start()
    {
        CreateEffectList();
    }
    //initialize EffectList 
    void CreateEffectList()
    {
        EffectList = new Dictionary<string, Effect>();
        Effect strengthEnhancementEffect = new Effect("StrengthEnhancement");
        strengthEnhancementEffect.EffectsOnAttribute.Add(new EffectOnAttribute("Strength", EffectType.Addition, 10));
        EffectList.Add(strengthEnhancementEffect.Name, strengthEnhancementEffect);
    }


}
