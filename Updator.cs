using System;
using System.Collections.Generic;
using System.Text;
using AutoUpdaterDotNET;
using Newtonsoft.Json;

namespace ValorantStreamOverlay
{
    class Updator
    {
        public Updator()
        {
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;

            AutoUpdater.Start("https://dl.dropboxusercontent.com/s/2h50ctzn973cx6r/updator.json?dl=0");
        }

        void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json["version"],
                ChangelogURL = json["changelog"],
                DownloadURL = json["url"],
                Mandatory = new Mandatory
                {
                    Value = json["mandatory"]["value"],
                    UpdateMode = json["mandatory"]["UpdateMode"],
                    MinimumVersion = json["mandatory"]["MinimumVersion"]
                }
            };

        }
    }
}
