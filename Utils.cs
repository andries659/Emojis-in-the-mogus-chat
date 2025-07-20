namespace Emojis
{
    public static class Utils
    {
        public static string ReformatForEmojis(string text)
        {
            string final = text; 
            
            if (final.Contains($":angery:")) final = final.Replace($":angery:", $"<sprite name=angery>");
            if (final.Contains($":bonk:")) final = final.Replace($":bonk:", $"<sprite name=Bonk>");
            if (final.Contains($":brainrot:")) final = final.Replace($":brainrot:", $"<sprite name=Brainrot>");
            if (final.Contains($":comingforyou:")) final = final.Replace($":comingforyou:", $"<sprite name=ComingForYou>");
            if (final.Contains($":crylaugh:")) final = final.Replace($":crylaugh:", $"<sprite name=Crylaugh>");
            if (final.Contains($":deadrn:")) final = final.Replace($":deadrn:", $"<sprite name=DeadRN>");
            if (final.Contains($":donttrustyou:")) final = final.Replace($":donttrustyou:", $"<sprite name=DontTrustYou>");
            if (final.Contains($":etto:")) final = final.Replace($":etto:", $"<sprite name=Etto>");
            if (final.Contains($":family:")) final = final.Replace($":family:", $"<sprite name=Family>");
            if (final.Contains($":flushed:")) final = final.Replace($":flushed:", $"<sprite name=Flushed>");
            if (final.Contains($":gamermode:")) final = final.Replace($":gamermode:", $"<sprite name=GamerMode>");
            if (final.Contains($":ghost:")) final = final.Replace($":ghost:", $"<sprite name=Ghost>");
            if (final.Contains($":going:")) final = final.Replace($":going:", $"<sprite name=Going>");
            if (final.Contains($":gonnakillyou:")) final = final.Replace($":gonnakillyou:", $"<sprite name=GonnaKillYou>");
            if (final.Contains($":impostor:")) final = final.Replace($":impostor:", $"<sprite name=Impostor>");
            if (final.Contains($":laugh:")) final = final.Replace($":laugh:", $"<sprite name=Laugh>");
            if (final.Contains($":like:")) final = final.Replace($":like:", $"<sprite name=Like>");
            if (final.Contains($":love:")) final = final.Replace($":love:", $"<sprite name=Love>");
            if (final.Contains($":monster:")) final = final.Replace($":monster:", $"<sprite name=Monster>");
            if (final.Contains($":owo:")) final = final.Replace($":owo:", $"<sprite name=owo>");
            if (final.Contains($":sad:")) final = final.Replace($":sad:", $"<sprite name=Sad>");
            if (final.Contains($":scared:")) final = final.Replace($":scared:", $"<sprite name=Scared>");
            if (final.Contains($":stillgoing:")) final = final.Replace($":stillgoing:", $"<sprite name=StillGoing>");
            if (final.Contains($":sus:")) final = final.Replace($":sus:", $"<sprite name=sus>");
            if (final.Contains($":sweat:")) final = final.Replace($":sweat:", $"<sprite name=sweat>");
            if (final.Contains($":thinking:")) final = final.Replace($":thinking:", $"<sprite name=Thinking>");
            if (final.Contains($":toocool:")) final = final.Replace($":toocool:", $"<sprite name=TooCool>");
            if (final.Contains($":verysmol:")) final = final.Replace($":verysmol:", $"<sprite name=VerySmall>");
            
            return final;
        }
    }
}