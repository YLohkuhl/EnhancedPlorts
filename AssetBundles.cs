using System.IO;
using System.Reflection;
using UnityEngine;

namespace EnhancedPlorts
{
    internal class AB
    {
        public static byte[] GetAsset(string path)
        {
            Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name + "." + path);
            byte[] array = new byte[manifestResourceStream.Length];
            manifestResourceStream.Read(array, 0, array.Length);
            return array;
        }

        internal static Il2CppAssetBundle models_attach = Il2CppAssetBundleManager.LoadFromMemory(GetAsset("Files.AB.models_attach"));
    }
}