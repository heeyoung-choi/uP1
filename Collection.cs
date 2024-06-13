    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Collection<T> where T : class
    {
        protected readonly Dictionary<string, T> listAttributes;
        public Collection()
        {
            listAttributes = new Dictionary<string,T>();
        }
        #nullable enable
        public T? this[string key]
        #nullable disable 
        {
            get 
            {
                if (listAttributes.ContainsKey(key))
                {
                    return listAttributes[key];
                }
                else 
                {
                    Debug.Log("Key doesn't exist!");
                    return null;
                }
            }
        }
    }