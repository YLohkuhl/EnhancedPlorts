using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Hunter
    {
        public static void ModifyPlort()
        {
            GameObject hunterPlort = Get<GameObject>("plortHunter");

            GameObject plortEars = new GameObject("plortHunterEars");

            plortEars.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortHunterEars");
            plortEars.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("HunterPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortEars.transform.parent = hunterPlort.transform;
            plortEars.transform.localScale *= 0.3f;

            GameObject plortTail = new GameObject("plortHunterTail");

            plortTail.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortHunterTail");
            plortTail.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("HunterPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortTail.transform.parent = hunterPlort.transform;
            plortTail.transform.localScale *= 0.4f;
        }
    }
}
