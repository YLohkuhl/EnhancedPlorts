using Il2Cpp;
using Il2CppInterop.Runtime;
using System;
using System.Linq;
using UnityEngine;

internal class Utility
{
    public static class PrefabUtils
    {
        public static Transform DisabledParent;
        static PrefabUtils()
        {
            DisabledParent = new GameObject("DeactivedObject").transform;
            DisabledParent.gameObject.SetActive(false);
            UnityEngine.Object.DontDestroyOnLoad(DisabledParent.gameObject);
            DisabledParent.gameObject.hideFlags |= HideFlags.HideAndDontSave;
        }

        public static GameObject CopyPrefab(GameObject prefab)
        {
            var newG = UnityEngine.Object.Instantiate(prefab, DisabledParent);
            return newG;
        }
    }

    public static class Spawner
    {
        public static void ToSpawn(string name) => SRBehaviour.InstantiateActor(Resources.FindObjectsOfTypeAll<GameObject>().FirstOrDefault(x => x.name == name), SRSingleton<SceneContext>.Instance.RegionRegistry.CurrentSceneGroup, SRSingleton<SceneContext>.Instance.Player.transform.position, Quaternion.identity);
    }

    public static T Get<T>(string name) where T : UnityEngine.Object
    {
        return Resources.FindObjectsOfTypeAll<T>().FirstOrDefault(found => found.name.Equals(name));
    }
}