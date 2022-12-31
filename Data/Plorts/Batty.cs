using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Batty
    {
        public static void ModifyPlort()
        {
            GameObject battyPlort = Get<GameObject>("plortBatty");

            GameObject plortEars = new GameObject("plortBattyEars");

            plortEars.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortBattyEars");
            plortEars.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("BattyPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortEars.transform.parent = battyPlort.transform;
            plortEars.transform.localScale *= 0.4f;

            GameObject plortWings = new GameObject("plortBattyWings");

            plortWings.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortBattyWings");
            plortWings.AddComponent<MeshRenderer>().sharedMaterial = Get<SlimeAppearance>("BattyDefault").Structures[1].DefaultMaterials[0];
            plortWings.transform.parent = battyPlort.transform;
            plortWings.transform.localScale *= 0.4f;
        }
    }
}
