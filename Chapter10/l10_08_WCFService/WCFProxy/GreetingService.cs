﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://strangelights.com/FSharp/Foundations/WCFServices", ConfigurationName="IGreetingService")]
public interface IGreetingService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://strangelights.com/FSharp/Foundations/WCFServices/IGreetingService/Greet", ReplyAction="http://strangelights.com/FSharp/Foundations/WCFServices/IGreetingService/GreetRes" +
        "ponse")]
    string Greet(string name);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IGreetingServiceChannel : IGreetingService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class GreetingServiceClient : System.ServiceModel.ClientBase<IGreetingService>, IGreetingService
{
    
    public GreetingServiceClient()
    {
    }
    
    public GreetingServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GreetingServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GreetingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GreetingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string Greet(string name)
    {
        return base.Channel.Greet(name);
    }
}