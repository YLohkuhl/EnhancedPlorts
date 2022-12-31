using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Cotton
    {
        public static void ModifyPlort()
        {
            GameObject cottonPlort = Get<GameObject>("plortCotton");

            Material tailMat = UnityEngine.Object.Instantiate(Get<IdentifiableType>("CottonPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial);
            tailMat.SetColor("_TopColor", Color.white);
            tailMat.SetColor("_MiddleColor", Color.white);
            tailMat.SetColor("_BottomColor", Color.white);

            GameObject plortEars = new GameObject("plortCottonEars");

            plortEars.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortCottonEars");
            plortEars.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("CottonPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortEars.transform.parent = cottonPlort.transform;
            plortEars.transform.localScale *= 0.4f;

            GameObject plortTail = new GameObject("plortCottonTail");

            plortTail.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortCottonTail");
            plortTail.AddComponent<MeshRenderer>().sharedMaterial = tailMat;
            plortTail.transform.parent = cottonPlort.transform;
            plortTail.transform.localScale *= 0.4f;
        }
    }
}
