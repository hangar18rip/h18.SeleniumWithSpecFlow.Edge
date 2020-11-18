using Microsoft.Edge.SeleniumTools;
using TechTalk.SpecFlow;

namespace h18.SeleniumWithSpecFlow.Edge
{
    public class EdgeHook : HookBase<EdgeDriver, EdgeOptions>
    {
        public EdgeHook(ScenarioContext context) : base(context)
        {
        }

        protected override EdgeDriver GetDriver(EdgeOptions options)
        {
            options.UseChromium = true;
            return new EdgeDriver(options);
        }

        protected override HookConfigurationBase<EdgeOptions> GetDefaultConfiguration()
        {
            return new EdgeHookConfiguration();
        }
    }
}
