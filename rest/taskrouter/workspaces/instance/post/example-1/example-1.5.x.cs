// Download the twilio-csharp library from
// https://www.twilio.com/docs/libraries/csharp#installation
using System;
using Twilio;
using Twilio.Rest.Taskrouter.V1;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string workspaceSid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        TwilioClient.Init(accountSid, authToken);

        var workspace = WorkspaceResource.Update(
            workspaceSid, friendlyName: "NewFriendlyName",
            eventCallbackUrl: new Uri("http://requestb.in/vh9reovh"));

        Console.WriteLine(workspace.FriendlyName);
        Console.WriteLine(workspace.EventCallbackUrl);
    }
}
