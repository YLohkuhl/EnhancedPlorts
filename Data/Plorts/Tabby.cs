using Il2Cpp;
using Il2CppSystem;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Tabby
    {
        public static void ModifyPlort()
        {
            GameObject tabbyPlort = Get<GameObject>("plortTabby");

            GameObject plortEars = new GameObject("plortTabbyEars");

            plortEars.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortTabbyEars");
            plortEars.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("TabbyPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortEars.transform.parent = tabbyPlort.transform;
            plortEars.transform.localScale *= 0.3f;

            GameObject plortTail = new GameObject("plortTabbyTail");

            plortTail.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortTabbyTail");
            plortTail.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("TabbyPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortTail.transform.parent = tabbyPlort.transform;
            plortTail.transform.localScale *= 0.4f;
        }
    }
}
