using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace ValorantStreamOverlay
{
    class TwitchIntegration
    {
        private TwitchClient client;

        public TwitchIntegration()
        {
            ConnectionCredentials credentials = new ConnectionCredentials(Properties.Settings.Default.twitchBotUsername, Properties.Settings.Default.twitchBotToken);
            ClientOptions clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 700,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient soccketClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(soccketClient);
            try
            {
                Trace.WriteLine("Client Initalizing");
                client.Initialize(credentials, Properties.Settings.Default.twitchChannel);
            }
            catch (Exception e)
            {
                Properties.Settings.Default.twitchbotEnabled = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Error Connecting to twitch, make sure token and username of bot is correct!");
                Environment.Exit(1);
            }
            client.OnConnected += Client_OnConnected;
            client.OnMessageReceived += Client_OnMessageRecieved;

            //Connect Client to twitch chat.
            client.Connect();
        }

        void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            client.SendMessage(e.AutoJoinChannel, "Valor Stream Overlay has Connected.");
        }

        void Client_OnMessageRecieved(object sender, OnMessageReceivedArgs e)
        {
            switch (e.ChatMessage.Message.ToLower())
            {
                case "!elo":
                    client.SendMessage(e.ChatMessage.Channel, $"{e.ChatMessage.Channel} currently has {LogicHandler.currentMMRorELO} Total Rank Rating");
                    break;
                case "!overlay":
                    client.SendMessage(e.ChatMessage.Channel, $"Overlay and Bot were created by @Rumblemikee, you can find the program here: https://github.com/RumbleMike/ValorantStreamOverlay/releases/latest");
                    break;
                case "!rp":
                    client.SendMessage(e.ChatMessage.Channel, $"{e.ChatMessage.Channel} currently has {LogicHandler.currentRankPoints} Rating in {RankDetection.rankName}");
                    break;
            }

        }

    }
}
