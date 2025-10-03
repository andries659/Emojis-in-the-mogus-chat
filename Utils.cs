namespace Emojis
{
    public static class Utils
    {
        public static string ReformatForEmojis(string text)
        {
            string final = text; 
            //Emojis
            if (final.Contains($":angery:")) final = final.Replace($":angery:", $"<sprite name=angery>");
            if (final.Contains($":bonk:")) final = final.Replace($":bonk:", $"<sprite name=bonk>");
            if (final.Contains($":brainrot:")) final = final.Replace($":brainrot:", $"<sprite name=brainrot>");
            if (final.Contains($":coming4u:")) final = final.Replace($":coming4u:", $"<sprite name=coming4u>");
            if (final.Contains($":lmao:")) final = final.Replace($":lmao:", $"<sprite name=lmao>");
            if (final.Contains($":ded:")) final = final.Replace($":ded:", $"<sprite name=ded>");
            if (final.Contains($":what:")) final = final.Replace($":what:", $"<sprite name=what>");
            if (final.Contains($":etto:")) final = final.Replace($":etto:", $"<sprite name=etto>");
            if (final.Contains($":family:")) final = final.Replace($":family:", $"<sprite name=family>");
            if (final.Contains($":flushed:")) final = final.Replace($":flushed:", $"<sprite name=flushed>");
            if (final.Contains($":gamer:")) final = final.Replace($":gamer:", $"<sprite name=gamer>");
            if (final.Contains($":ghost:")) final = final.Replace($":ghost:", $"<sprite name=ghost>");
            if (final.Contains($":going:")) final = final.Replace($":going:", $"<sprite name=going>");
            if (final.Contains($":running:")) final = final.Replace($":running:", $"<sprite name=running>");
            if (final.Contains($":impostor:")) final = final.Replace($":impostor:", $"<sprite name=impostor>");
            if (final.Contains($":owo:")) final = final.Replace($":owo:", $"<sprite name=owo>");
            if (final.Contains($":lol:")) final = final.Replace($":lol", $"<sprite name=lol>");
            if (final.Contains($":like:")) final = final.Replace($":like:", $"<sprite name=like>");
            if (final.Contains($":love:")) final = final.Replace($":love:", $"<sprite name=love>");
            if (final.Contains($":monster:")) final = final.Replace($":moster:", $"<sprite name=monster>");
            if (final.Contains($":sad:")) final = final.Replace($":sad:", $"<sprite name=sad>");
            if (final.Contains($":scared:")) final = final.Replace($":scraed:", $"<sprite name=scared>");
            if (final.Contains($":stillgoing:")) final = final.Replace($":stillgoing:", $"<sprite name=stillgoing>");
            if (final.Contains($":sus:")) final = final.Replace($":sus:", $"<sprite name=sus>");
            if (final.Contains($":sweat:")) final = final.Replace($":sweat:", $"<sprite name=sweat>");
            if (final.Contains($":smol:")) final = final.Replace($":smol:", $"<sprite name=smol>");
            if (final.Contains($":thinking:")) final = final.Replace($":thinking:", $"<sprite name=thinking>");
            if (final.Contains($":toocool:")) final = final.Replace($":toocool:", $"<sprite name=toocool>");

            //Role Icons
            if (final.Contains($":bait:")) final = final.Replace($":bait:", $"<sprite name=bait>");
            if (final.Contains($":burrower:")) final = final.Replace($":burrower:", $"<sprite name=burrower>");
            if (final.Contains($":burst:")) final = final.Replace($":burst:", $"<sprite name=burst>");
            if (final.Contains($":captain:")) final = final.Replace($":captain:", $"<sprite name=captain>");
            if (final.Contains($":hitman:")) final = final.Replace($":hitman:", $"<sprite name=hitman>");
            if (final.Contains($":surgeon:")) final = final.Replace($":surgeon:", $"<sprite name=surgeon>");
            if (final.Contains($":janitor:")) final = final.Replace($":janitor:", $"<sprite name=janitor>");
            if (final.Contains($":exe:")) final = final.Replace($":exe:", $"<sprite name=exe>");
            if (final.Contains($":flash:")) final = final.Replace($":flash:", $"<sprite name=flash>");
            if (final.Contains($":coroner:")) final = final.Replace($":coroner:", $"<sprite name=coroner>");
            if (final.Contains($":gambler:")) final = final.Replace($":gambler:", $"<sprite name=gambler>");
            if (final.Contains($":giant:")) final = final.Replace($":giant:", $"<sprite name=giant>");
            if (final.Contains($":gravityfield:")) final = final.Replace($":gravityfield:", $"<sprite name=gravityfield>");
            if (final.Contains($":hacker:")) final = final.Replace($":hacker:", $"<sprite name=hacker>");
            if (final.Contains($":jester:")) final = final.Replace($":jester:", $"<sprite name=jester>");
            if (final.Contains($":nk:")) final = final.Replace($":nk:", $"<sprite name=nk>");
            if (final.Contains($":mayor:")) final = final.Replace($":mayor:", $"<sprite name=mayor>");
            if (final.Contains($":mini:")) final = final.Replace($":mini:", $"<sprite name=mini>");
            if (final.Contains($":medic:")) final = final.Replace($":medic:", $"<sprite name=medic>");
            if (final.Contains($":rb:")) final = final.Replace($":rb:", $"<sprite name=rb>");
            if (final.Contains($":sealer:")) final = final.Replace($":sealer:", $"<sprite name=sealer>");
            if (final.Contains($":sheriff:")) final = final.Replace($":sheriff:", $"<sprite name=sheriff>");
            if (final.Contains($":reaper:")) final = final.Replace($":reaper:", $"<sprite name=reaper>");
            if (final.Contains($":swapper:")) final = final.Replace($":swapper:", $"<sprite name=swapper>");
            if (final.Contains($":teleporter:")) final = final.Replace($":teleporter:", $"<sprite name=teleporter>");
            if (final.Contains($":torch:")) final = final.Replace($":torch:", $"<sprite name=torch>");
            if (final.Contains($":traitor:")) final = final.Replace($":traitor:", $"<sprite name=traitor>");
            if (final.Contains($":vip:")) final = final.Replace($":vip:", $"<sprite name=vip>");

            return final;
        }
    }
}