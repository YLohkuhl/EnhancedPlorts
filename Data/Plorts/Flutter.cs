using Il2Cpp;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Flutter
    {
        public static void ModifyPlort()
        {
            GameObject flutterPlort = Get<GameObject>("plortFlutter");

            Material wingMat = UnityEngine.Object.Instantiate(Get<IdentifiableType>("FlutterPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial);
            wingMat.SetColor("_TopColor", new Color32(255, 20, 147, 255));
            wingMat.SetColor("_MiddleColor", new Color32(255, 127, 80, 255));
            wingMat.SetColor("_BottomColor", Color.yellow);

            GameObject plortAntennae = new GameObject("plortFlutterAntennae");

            plortAntennae.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortFlutterAntennae");
            plortAntennae.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("FlutterPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortAntennae.transform.parent = flutterPlort.transform;
            plortAntennae.transform.localScale *= 0.3f;

            GameObject plortWings = new GameObject("plortFlutterWings");

            plortWings.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortFlutterWings");
            plortWings.AddComponent<MeshRenderer>().sharedMaterial = wingMat;
            plortWings.transform.parent = flutterPlort.transform;
            plortWings.transform.localScale *= 0.4f;
        }
    }
}
