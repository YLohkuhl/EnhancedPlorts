using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Utility;
namespace EnhancedPlorts.Data.Plorts
{
    internal class Rad
    {
        public static void ModifyPlort()
        {
            GameObject radPlort = Get<GameObject>("plortRad");

            GameObject plortBubble = new GameObject("plortRadBubble");

            plortBubble.AddComponent<MeshFilter>().mesh = AB.models_attach.LoadAsset<Mesh>("plortRadBubble");
            plortBubble.AddComponent<MeshRenderer>().sharedMaterial = Get<SlimeAppearance>("RadDefault").Structures[0].DefaultMaterials[0];
            plortBubble.transform.parent = radPlort.transform;
            plortBubble.transform.localScale *= 0.4f;
        }
    }
}
