using System.Collections;
using UnityEngine;

public class LoadAsset : MonoBehaviour
{
    [SerializeField] private string assetBundleURL;
    [SerializeField] private int version = 0;
    [SerializeField] private string nameObj;
    [SerializeField] private Vector3 spawnPosition;

    public void Awake()
    {
        version = PlayerPrefs.GetInt("countDownload");
    }

    public void OnClick()
    {
        PlayerPrefs.SetInt("countDownload", ++version);
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        while (!Caching.ready)
            yield return null;

        var www = WWW.LoadFromCacheOrDownload(assetBundleURL, version);
            yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.LogError(www.error);
            yield break;
        }
        Debug.Log("Бандл загружен");

        var modelRequest = www.assetBundle.LoadAssetAsync(nameObj, typeof(GameObject));
        yield return modelRequest;
        Debug.Log("Модель распакована");

        Instantiate(modelRequest.asset as GameObject, spawnPosition, Quaternion.identity);
        Debug.Log("Модель поставлена");
    }
}
