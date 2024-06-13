using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingleton<GameManager>
{
    public Dictionary<string, Effect> EffectList;
    private Save currentSave;
    public Save CurrentSave
    {
        get {return currentSave;}
        private set
        {
            if (value is Save)
            {
                CurrentSave =  value;
            }
            else 
            {
                Debug.Log("the objec is not Save type");
            }

        }
    }
    public void Load()
    {
        
    }
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
