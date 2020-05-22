using System;

namespace Bridge.AspNetCore.SignalR.Client
{
    // public class test
    // {
    //     public test()
    //     {
    //         var hubConnection = new HubConnectionBuilder().WithUrl("/test").Build();
    //         
    //         // Connect to a hub
    //         //var hubConnection = new HubConnection("/test");
    //
    //         // Setup on data received event handler
    //         hubConnection.On("Send", new Action<string>((data) =>
    //         {
    //             // Log the received data to the console
    //             Console.WriteLine(data);
    //         }));
    //
    //         // Setup on connection close handler
    //         hubConnection.OnClose((error) => 
    //         {
    //             // Log the error
    //             Console.WriteLine(error.Message);
    //         });
    //
    //         // Start the connection
    //         hubConnection.Start().Then(
    //             onfulfilled: () =>
    //             {
    //                 // Send a message
    //                 hubConnection.Invoke("send", "Hello");
    //             }, 
    //             onrejected: null);
    //
    //         // Stop the connection
    //         hubConnection.Stop();
    //     }
    // }
}