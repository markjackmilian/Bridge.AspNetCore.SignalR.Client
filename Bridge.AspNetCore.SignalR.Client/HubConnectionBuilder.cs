namespace Bridge.AspNetCore.SignalR.Client
{
    [External]
    [Namespace("signalR")]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.CamelCase)]
    public class HubConnectionBuilder
    {

        public string Url { get; private set; }
        
        public HubConnectionBuilder()
        {
            
        }

        
        public HubConnectionBuilder WithUrl(string url)
        {
            this.Url = url;
            return this;
        }

        public HubConnection Build()
        {
            return new HubConnection(this.Url);
        }
    }
}