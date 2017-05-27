using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Exporter : MonoBehaviour {

    [MenuItem("Unity3DRIder/ExportBundles")]
    static void ExportAsset() {
        //BuildPipeline.BuildAssetBundles("Assets/ABs", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        AssetDatabase.ExportPackage("Assets/Plugins/Editor/JetBrains", "Assets/Rider.unitypackage", ExportPackageOptions.Recurse);
    }

    static Exporter() { ExportAsset(); }

}
