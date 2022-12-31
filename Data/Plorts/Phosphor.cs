using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;

namespace EnhancedPlorts.Data.Plorts
{
    internal class Phosphor
    {
        public static void ModifyPlort()
        {
            GameObject phosphorPlort = Get<GameObject>("plortPhosphor");

            GameObject plortAntennae = new GameObject("plortPhosphorAntennae");

            plortAntennae.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortPhosphorAntennae");
            plortAntennae.AddComponent<MeshRenderer>().sharedMaterial = Get<IdentifiableType>("PhosphorPlort").prefab.GetComponent<MeshRenderer>().sharedMaterial;
            plortAntennae.transform.parent = phosphorPlort.transform;
            plortAntennae.transform.localScale *= 0.3f;

            GameObject plortWings = new GameObject("plortPhosphorWings");

            plortWings.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortPhosphorWings");
            plortWings.AddComponent<MeshRenderer>().sharedMaterial = Get<SlimeAppearance>("PhosphorDefault").Structures[2].DefaultMaterials[0];
            plortWings.transform.parent = phosphorPlort.transform;
            plortWings.transform.localScale *= 0.4f;
        }
    }
}
