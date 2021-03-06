namespace AbpDz.Messaging
{
    public class AbpDzMessagingerviceConfig : Volo.Abp.DependencyInjection.ISingletonDependency
    {
        // register only permission that need to listned for signalr 
        public System.Collections.Concurrent.ConcurrentDictionary<string, int> NotifyPermissions { get; set; } = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();

        // register permission for Messaging 
        public void RegisterPermission(string key)
        {
            this.NotifyPermissions.TryAdd(key, 1);
        }
    }
}