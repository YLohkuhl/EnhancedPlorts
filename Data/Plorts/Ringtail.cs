using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Ringtail
    {
        public static void ModifyPlort()
        {
            GameObject ringtailPlort = Get<GameObject>("plortRingtail");

            GameObject plortEars = new GameObject("plortRingtailEars");

            plortEars.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortRingtailEars");
            plortEars.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("RingtailPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortEars.transform.parent = ringtailPlort.transform;
            plortEars.transform.localScale *= 0.3f;

            GameObject plortTail = new GameObject("plortRingtailTail");

            plortTail.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortRingtailTail");
            plortTail.AddComponent<MeshRenderer>().sharedMaterial = Get<SlimeAppearance>("RingtailDefault").Structures[2].DefaultMaterials[0];
            plortTail.transform.parent = ringtailPlort.transform;
            plortTail.transform.localScale *= 0.4f;
        }
    }
}
