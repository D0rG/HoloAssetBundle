using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAsset : MonoBehaviour
{
    string assetBundleURL = "https://my-files.su/Save/wp43vk/model.unity3d";
    int version = 0;


    public void OnClick()
    {
        StartCoroutine(Download());
    }
    IEnumerator Download()
    {
        while (!Caching.ready)
            yield return null;

        var www = WWW.LoadFromCacheOrDownload(assetBundleURL, version);

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.LogError(www.error);
            yield break;
        }
        Debug.Log("Бандл загружен");

        var modelRequest = www.assetBundle.LoadAssetAsync("car", typeof(GameObject));
        yield return modelRequest;
        Debug.Log("Модель распакована");

        GameObject model = modelRequest.asset as GameObject;
        Instantiate(model);
        Debug.Log("Модель поставлена");
    }
}
