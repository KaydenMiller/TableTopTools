using System.CommandLine;
using TableTop.Economy.Application;

var root = new RootCommand("");
var audioOption = new Option<string>(
    name: "--config",
    description: "a configured json blob that describes the audio to be played");
var audio = new Command("audio", "audio configuration");
audio.SetHandler((config) =>
{
    var app = new Application();
}, audioOption);
