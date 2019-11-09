﻿// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace DoubleCross.Addin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC2fc9430a444a0d907de801c25c9ad554";
            const string authToken = "your_auth_token";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+14155551212");
            var from = new PhoneNumber("+15017122661");
            var call = CallResource.Create(to, from,
                url: new Uri("http://demo.twilio.com/docs/voice.xml"));

            Console.WriteLine(call.Sid);
        }
    }
}
