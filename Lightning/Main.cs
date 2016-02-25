using System.Threading;
using MiNET;
using MiNET.Net;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Utils;

namespace Lightning {
	[Plugin(Author = "sepi", Description = "번개좀 맞아봐라 지지직", PluginName = "Lightning", PluginVersion = "1.0-Alpha")]
	public class Lightinig
	{
		[PacketHandler, Receive]
		public void MessageHandler(McpeText message, Player player) {
			string text = message.message;
			if(text == "번개 맞고 싶다") {
				for(int i = 0; i < 6; i++) {
					player.StrikeLightning();
					player.SendMessage(ChatColors.Yellow + "아하하하하 번개맛이 어떠냥!", type: MessageType.Raw);
					Thread.Sleep(1000);
				}
			}	
		}
	}
}
