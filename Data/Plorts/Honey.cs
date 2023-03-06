using Il2Cpp;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Honey
    {
        public static void ModifyPlort()
        {
            GameObject honeyPlort = Get<GameObject>("plortHoney");

            GameObject plortPlate = new GameObject("plortHoneyPlate");

            plortPlate.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortHoneyPlate");
            plortPlate.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("HoneyPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortPlate.transform.parent = honeyPlort.transform;
            plortPlate.transform.localScale *= 0.4f;
        }
    }
}
