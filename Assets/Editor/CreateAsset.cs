using System.Diagnostics;
using System.IO;
using UnityEditor;

public class CreateAsset
{
    private static string mainPath = "Assets/Asset/";

    [MenuItem("Assets Bundle/Build AssetBundle Windows64")]
    static void BildAssetBundles()
    {
        string directory = mainPath + "Windows64";
        checkDir(directory);
        BuildPipeline.BuildAssetBundles(mainPath + "Windows64", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }

    [MenuItem("Assets Bundle/Build AssetBundle Windows32")]
    static void BildAssetBundles32()
    {
        string directory = mainPath + "Windows32";
        checkDir(directory);
        BuildPipeline.BuildAssetBundles(mainPath + "Windows32", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
    
    [MenuItem("Assets Bundle/Build AssetBundle WebGL")]
    static void BildAssetBundlesWeb()
    {
        string directory = mainPath + "WebGL";
        checkDir(directory);
        BuildPipeline.BuildAssetBundles(mainPath + "WebGL", BuildAssetBundleOptions.None, BuildTarget.WebGL);
    }

    [MenuItem("Assets Bundle/Build AssetBundle WSA (Hololens)")]
    static void BildAssetBundlesWsa()
    {
        string directory = mainPath + "Hololens_(WSA)";
        checkDir(directory);
        BuildPipeline.BuildAssetBundles(mainPath + "Hololens_(WSA)", BuildAssetBundleOptions.None, BuildTarget.WSAPlayer);
    }

    private static void checkDir(string dir)
    {
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
    }
}
