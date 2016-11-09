




using System.Web.Http;

namespace Nop.Admin
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveGitHubWebHooks();

        }
    }
}
