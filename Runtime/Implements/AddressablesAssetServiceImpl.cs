using System.Threading.Tasks;
using HoweFramework.Asset;
using UnityEngine;

namespace HoweFramework.Addressables
{
    /// <summary>
    /// 基于Unity-Addressables实现的资产服务
    /// </summary>
    public class AddressablesAssetServiceImpl : IAssetService
    {
        public async Task<T> LoadAsync<T>(string resKey)
        {
            return await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<T>(resKey).Task;
        }

        public async Task<GameObject> InstantiateAsync(string resKey)
        {
            return await UnityEngine.AddressableAssets.Addressables.InstantiateAsync(resKey).Task;
        }

        public T LoadSync<T>(string resKey)
        {
            return UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<T>(resKey).WaitForCompletion();
        }

        public GameObject InstantiateSync(string resKey)
        {
            return UnityEngine.AddressableAssets.Addressables.InstantiateAsync(resKey).WaitForCompletion();
        }

        public void Release<T>(T asset)
        {
            UnityEngine.AddressableAssets.Addressables.Release(asset);
        }

        public void ReleaseInstance(GameObject gameObject)
        {
            UnityEngine.AddressableAssets.Addressables.ReleaseInstance(gameObject);
        }
    }
}