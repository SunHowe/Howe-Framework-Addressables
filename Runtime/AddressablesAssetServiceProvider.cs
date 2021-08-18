using CatLib;
using CatLib.Container;
using HoweFramework.Asset;

namespace HoweFramework.Addressables
{
    /// <summary>
    /// 资产服务提供者
    /// </summary>
    public class AddressablesAssetServiceProvider : ServiceProvider
    {
        public override void Register()
        {
            App.Singleton<IAssetService, AddressablesAssetServiceImpl>();
        }
    }
}