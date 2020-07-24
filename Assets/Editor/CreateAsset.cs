using UnityEditor;

public class CreateAsset
{
    [MenuItem("Assets/Build AssetBundle")]
    static void BildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/Asset", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
