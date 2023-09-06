using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace PoopTheParty {
    public class ItemAttributes : MonoBehaviour {
        public string itemName;

        public int itemPoints;
        }

    public class ItemTypes {
        public string destructibleItem = "Destructible";
        public string treasureItem = "Treasure";
        public string currencyItem = "Currency";
        public string toolItem = "Tool";
    }
        
}