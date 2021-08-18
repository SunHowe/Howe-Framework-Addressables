using System.Threading.Tasks;
using HoweFramework.Asset;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace HoweFramework.Addressables
{
    public class AddressablesSceneInstance : ISceneInstance
    {
        public Scene scene => _sceneInstance.Scene;

        private SceneInstance _sceneInstance;

        public AddressablesSceneInstance(SceneInstance sceneInstance)
        {
            _sceneInstance = sceneInstance;
        }

        public async Task ActivateAsync()
        {
            var completed = false;
            _sceneInstance.ActivateAsync().completed += operation =>
            {
                completed = true;
            };

            await Task.Run(() =>
            {
                while (!completed)
                {
                }
            });
        }

        public void Activate()
        {
            ActivateAsync().Wait();
        }
    }
}