using System.Collections.Generic;
public class Save 
{
    public const int IdSuffixLength = 6;
    public const int IdPrefixLength = 4;
    public static readonly string[] IdPrefixList = {"char", "item", "stor"};
    public List<Dictionary<string, IIdentifiable>> IdDict;
    public Save()
    {
        IdDict = new List<Dictionary<string, IIdentifiable>>();
        for (int i = 0; i < IdPrefixList.Length; i++)
        {
            IdDict.Add(new Dictionary<string,IIdentifiable>());

        }
    }
    public string CreateId(IIdentifiable identifiableObject, int prefixNum)
    {
        if (!(identifiableObject is IIdentifiable))
        {
            return "error: object is not identifiable";
        }
        if (prefixNum >= IdPrefixList.Length || prefixNum < 0)
        {
            return "error: prefix number out of range";
        }
        string id = IdPrefixList[prefixNum] + Helper.Instance.GenerateID(IdSuffixLength);
        IdDict[prefixNum][id] = identifiableObject;
        return id;
        
    }
}