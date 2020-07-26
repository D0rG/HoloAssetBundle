using UnityEditor;

public class CreateAsset
{
    [MenuItem("Assets Bundle/Build AssetBundle Windows64")]
    static void BildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/Asset", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }

    [MenuItem("Assets Bundle/Build AssetBundle Windows32")]
    static void BildAssetBundles32()
    {
        BuildPipeline.BuildAssetBundles("Assets/Asset", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
    
    [MenuItem("Assets Bundle/Build AssetBundle WebGL")]
    static void BildAssetBundlesWeb()
    {
        BuildPipeline.BuildAssetBundles("Assets/Asset", BuildAssetBundleOptions.None, BuildTarget.WebGL);
    }

    [MenuItem("Assets Bundle/Build AssetBundle WSA (Hololens)")]
    static void BildAssetBundlesWsa()
    {
        BuildPipeline.BuildAssetBundles("Assets/Asset", BuildAssetBundleOptions.None, BuildTarget.WSAPlayer);
    }
}
