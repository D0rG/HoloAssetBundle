using System.Collections;
using UnityEngine;

public class LoadAsset : MonoBehaviour
{
    [SerializeField] private string assetBundleURL;
    [SerializeField] private int version = 0;
    [SerializeField] private string nameObj;
    [SerializeField] private Vector3 spawnPosition;
    private GameObject _currentGameObj;
    private WWW www;

    public void Awake()
    {
        version = PlayerPrefs.GetInt("countDownload");
    }

    public void OnClick()
    {
        if (_currentGameObj != null)
        {
            Destroy(_currentGameObj);
        }

        PlayerPrefs.SetInt("countDownload", ++version);
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        if (www != null && www.assetBundle != null)
        {
            www.assetBundle.Unload(false);
        }

        while (!Caching.ready)
            yield return null;

        www = WWW.LoadFromCacheOrDownload(assetBundleURL, version);
            yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.LogError(www.error);
            yield break;
        }
        Debug.Log("Бандл загружен");

        AssetBundleRequest modelRequest = www.assetBundle.LoadAssetAsync(nameObj, typeof(GameObject));
        yield return modelRequest;
        Debug.Log("Модель распакована");

        _currentGameObj = Instantiate(modelRequest.asset as GameObject, spawnPosition, Quaternion.identity);
        Debug.Log("Модель поставлена");
    }
}
