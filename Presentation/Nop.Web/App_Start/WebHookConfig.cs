




using System.Web.Http;

namespace Nop.Web
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveGitHubWebHooks();

        }
    }
}
